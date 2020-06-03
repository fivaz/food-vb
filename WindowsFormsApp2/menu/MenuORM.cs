using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2.menu
{
    class MenuORM : ORM<Menu>
    {
        public MenuORM()
        {
            table = "foo_menu";
            view = "vw_menu";
            columns = new List<string> { "MEN_NAME"};
            columnId = "MEN_ID";
            deleteColumn = "MEN_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Menu menu, bool withId)
        {
            connection.AddString(command, columns[0], menu.name);
            if (withId)
                connection.AddInt(command, columnId, menu.id);
            else
                connection.addReturnId(command);
        }

        public void UseMenu(int menuId)
        {
            string deleteAllQuery = "DELETE FROM foo_used_menu";
            connection.ExecuteQuery(deleteAllQuery);

            string insertQuery = "INSERT INTO foo_used_menu (USE_MEN_ID) VALUES (:USE_MEN_ID)";
            OracleCommand command = connection.SqlPrepare(insertQuery);
            connection.AddInt(command, "USE_MEN_ID", menuId);
            connection.Execute(command);
        }

        public int getUsed()
        {
            string query = "SELECT USE_MEN_ID FROM foo_used_menu";
            OracleCommand command = connection.SqlPrepare(query);
            OracleDataReader oracleDataReader = connection.Execute(command);
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            try
            {
                return Convert.ToInt32(dataTable.Rows[0]["USE_MEN_ID"].ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}
