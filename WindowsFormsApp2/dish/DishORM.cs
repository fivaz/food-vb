﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.dish
{
    class DishORM : ORM<Dish>
    {
        public DishORM()
        {
            table = "foo_dish";
            view = "vw_dish";
            columns = new List<string> { "DIS_CAT_ID", "DIS_NAME" };
            columnId = "DIS_ID";
            deleteColumn = "DIS_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Dish dish, bool withId)
        {
            connection.AddInt(command, "DIS_CAT_ID", dish.categoryId);
            connection.AddString(command, "DIS_NAME", dish.name);
            if (withId)
                connection.AddInt(command, "DIS_ID", dish.id);
            else
                connection.addReturnId(command);
        }

        public DataTable Search(string text)
        {
            string[] searchable = columns.Where(val => !val.Equals("DIS_CAT_ID")).ToArray();
            return base.Search(text, searchable);
        }

        public DataTable SearchFromMenu(int menuId)
        {
            string query = "SELECT * FROM vw_menu_dish WHERE MDR_MEN_ID = :MDR_MEN_ID";

            OracleCommand command = connection.SqlPrepare(query);

            OracleParameter param = new OracleParameter(":MDR_MEN_ID", OracleDbType.Int32);
            param.Value = menuId;
            command.Parameters.Add(param);

            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }

        public DataTable SearchExceptFromMenu(int menuId)
        {
            DataTable addedDishes = SearchFromMenu(menuId);

            string query = SQLHelper.SelectQuery(view);

            OracleCommand command = connection.SqlPrepare(query);

            OracleDataReader odr = connection.execute(command);

            DataTable data = new DataTable();
            data.Load(odr);

            foreach (DataRow row in addedDishes.Rows)
            {
                DataRow[] dataRow = data.Select("DIS_ID = " + row["DIS_ID"]);
                data.Rows.Remove(dataRow[0]);
            }
            return data;
        }

        internal void addRelation(Dish dish)
        {
            string query = SQLHelper.InsertQuery("FOO_MEN_DIS_RELATION", new string[] { "MDR_DIS_ID", "MDR_MEN_ID", "MDR_QUANTITY" }, null, false);

            OracleCommand command = connection.SqlPrepare(query);

            connection.AddInt(command, "MDR_DIS_ID", dish.id);
            connection.AddInt(command, "MDR_MEN_ID", dish.menuId);
            connection.AddDouble(command, "MDR_QUANTITY", dish.quantity);

            connection.ExecuteNonQuery(command);
        }

        public void DeleteAllRelations(int id)
        {
            try
            {
                string query = "DELETE FROM FOO_MEN_DIS_RELATION WHERE MDR_MEN_ID = :MDR_MEN_ID";
                OracleCommand command = connection.SqlPrepare(query);
                command.BindByName = false;
                connection.AddInt(command, "", id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
