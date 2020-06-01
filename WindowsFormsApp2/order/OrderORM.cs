using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp2.dish;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.order
{
    class OrderORM : ORM<Order>
    {
        public OrderORM()
        {
            table = "foo_order";
            view = "vw_order";
            columns = new List<string> { "ORD_ACC_ID", "ORD_TAB_ID", "ORD_DATE" };
            columnId = "ORD_ID";
            deleteColumn = "ORD_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Order order, bool withId)
        {
            connection.AddInt(command, "ORD_ACC_ID", order.accountId);
            connection.AddInt(command, "ORD_TAB_ID", order.tableId);
            connection.AddDate(command, "ORD_DATE", order.date);
            if (withId)
                connection.AddInt(command, "ORD_ID", order.id);
            else
                connection.addReturnId(command);
        }

        internal void addRelation(int orderId, Dish dish)
        {
            string query = SQLHelper.InsertQuery("FOO_ORD_DIS_RELATION", new string[] { "ODR_DIS_ID", "ODR_ORD_ID", "ODR_QUANTITY" }, null, false);

            OracleCommand command = connection.SqlPrepare(query);

            connection.AddInt(command, "ODR_DIS_ID", dish.id);
            connection.AddInt(command, "ODR_ORD_ID", orderId);
            connection.AddDouble(command, "ODR_QUANTITY", dish.quantity);

            connection.ExecuteNonQuery(command);
        }

        public void DeleteAllRelations(int id)
        {
            try
            {
                string query = "DELETE FROM FOO_ORD_DIS_RELATION WHERE ODR_ORD_ID = :ODR_ORD_ID";
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
