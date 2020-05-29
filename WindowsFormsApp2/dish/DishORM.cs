using Oracle.DataAccess.Client;
using System.Collections.Generic;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2.dish
{
    class DishORM : ORM<Dish>
    {
        public DishORM()
        {
            table = "foo_dish";
            view = "vw_dish";
            columns = new List<string> { "DIS_CAT_ID", "DIS_NAME", "DIS_SELLING_PRICE" };
            ids = new List<string> { "DIS_ID" };
            deleteColumn = "DIS_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Dish dish, bool withId)
        {
            connection.AddInt(command, "DIS_CAT_ID", dish.categoryId);
            connection.AddString(command, "DIS_NAME", dish.name);
            connection.AddDouble(command, "DIS_SELLING_PRICE", dish.sellingPrice);
            if (withId)
                connection.AddInt(command, "DIS_ID", dish.id);
        }
    }
}
