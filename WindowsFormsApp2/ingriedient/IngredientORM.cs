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
            columns = new List<string> { "ING_NAME", "ING_IS_COUNTABLE", "ING_UNIT", "ING_PURCHASE_PRICE", "ING_QUANTITY", "ING_MINIMUM_QUANTITY"};
            ids = new List<string> { "ING_ID" };
            deleteColumn = "ING_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Ingredient ingredient, bool withId)
        {
            connection.AddString(command, "ING_NAME", ingredient.name);
            connection.AddInt(command, "ING_IS_COUNTABLE", Convert.ToInt32(ingredient.isCountable));
            connection.AddString(command, "ING_UNIT", ingredient.unit);
            connection.AddDouble(command, "ING_PURCHASE_PRICE", ingredient.price);
            connection.AddDouble(command, "ING_QUANTITY", ingredient.quantity);
            connection.AddDouble(command, "ING_MINIMUM_QUANTITY", ingredient.minimumQuantity);
            if (withId)
                connection.AddInt(command, "ING_ID", ingredient.id);
        }

        public DataTable Search(string text)
        {
            string[] searchable = { "ING_NAME" };
            return base.Search(text, searchable);
        }

        public DataTable SearchFromDish(int dishId)
        {
            string query = "SELECT * FROM " + view + " WHERE DIR_DIS_ID = :DIR_DIS_ID";

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
            string query = "SELECT * FROM " + view + " WHERE DIR_DIS_ID != :DIR_DIS_ID OR DIR_DIS_ID IS NULL";

            OracleCommand command = connection.SqlPrepare(query);

            OracleParameter param = new OracleParameter(":DIR_DIS_ID", OracleDbType.Int32);
            param.Value = dishId;
            command.Parameters.Add(param);

            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }
    }
}
