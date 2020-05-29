﻿using Oracle.DataAccess.Client;
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
            columns = new List<string> { "DIS_CAT_ID", "DIS_NAME"};
            ids = new List<string> { "DIS_ID" };
            deleteColumn = "DIS_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Dish dish, bool withId)
        {
            connection.AddInt(command, "DIS_CAT_ID", dish.categoryId);
            connection.AddString(command, "DIS_NAME", dish.name);
            if (withId)
                connection.AddInt(command, "DIS_ID", dish.id);
        }
    }
}
