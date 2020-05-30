using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.ingredient
{
    class IngredientORM : ORM<Ingredient>
    {
        public IngredientORM()
        {
            table = "foo_ingredient";
            view = "vw_ingredient";
            columns = new List<string> { "ING_NAME", "ING_IS_COUNTABLE", "ING_UNIT", "ING_PURCHASE_PRICE", "ING_QUANTITY", "ING_MINIMUM_QUANTITY" };
            columnId = "ING_ID";
            deleteColumn = "ING_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Ingredient ingredient, bool withId)
        {
            connection.AddString(command, "ING_NAME", ingredient.name);
            connection.AddInt(command, "ING_IS_COUNTABLE", Convert.ToInt32(ingredient.isCountable));
            connection.AddString(command, "ING_UNIT", ingredient.unit);
            connection.AddDouble(command, "ING_PURCHASE_PRICE", ingredient.price);
            connection.AddDouble(command, "ING_QUANTITY", ingredient.quantity ?? default);
            connection.AddDouble(command, "ING_MINIMUM_QUANTITY", ingredient.minimumQuantity);
            if (withId)
                connection.AddInt(command, "ING_ID", ingredient.id);
            else
                connection.addReturnId(command);
        }

        internal void addRelation(Ingredient ingredient)
        {
            string query = SQLHelper.InsertQuery("FOO_DIS_ING_RELATION", new string[] { "DIR_QUANTITY", "DIR_ING_ID", "DIR_DIS_ID" }, null, false);
            Console.WriteLine(query);

            OracleCommand command = connection.SqlPrepare(query);

            connection.AddDouble(command, "DIR_QUANTITY", ingredient.quantity ?? default);
            connection.AddInt(command, "DIR_ING_ID", ingredient.id);
            connection.AddInt(command, "DIR_DIS_ID", ingredient.dishId);
            connection.AddInt(command, "DIR_DIS_ID", ingredient.dishId);

            connection.ExecuteNonQuery(command);
        }

        public DataTable Search(string text)
        {
            string[] searchable = { "ING_NAME" };
            return base.Search(text, searchable);
        }

        public DataTable SearchFromDish(int dishId)
        {
            string query = "SELECT * FROM vw_dish_ingredient WHERE DIR_DIS_ID = :DIR_DIS_ID";

            OracleCommand command = connection.SqlPrepare(query);

            OracleParameter param = new OracleParameter(":DIR_DIS_ID", OracleDbType.Int32);
            param.Value = dishId;
            command.Parameters.Add(param);

            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }

        public DataTable SearchExceptFromDish(int dishId)
        {
            DataTable addedIngredients = SearchFromDish(dishId);

            string query = "SELECT * FROM vw_ingredient";

            OracleCommand command = connection.SqlPrepare(query);

            OracleDataReader odr = connection.execute(command);

            DataTable data = new DataTable();
            data.Load(odr);

            foreach (DataRow row in addedIngredients.Rows)
            {
                DataRow[] dataRow = data.Select("ING_ID = " + row["ING_ID"]);
                data.Rows.Remove(dataRow[0]);
            }
            return data;
        }

        public void DeleteAllRelations(int id)
        {
            try
            {
                string query = "DELETE FROM FOO_DIS_ING_RELATION WHERE DIR_DIS_ID = :DIR_DIS_ID";
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
