using Oracle.DataAccess.Client;
using System;
using System.Data;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.database;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.category
{
    class CategoryORM : ORM<Category>
    {
        OracleConn connection;
        string table = "foo_category";
        string view = "vw_category";
        string[] columns = { "CAT_NAME" };
        string[] ids = { "CAT_ID" };
        string deleteColumn = "CAT_IS_DELETED";
       
        public CategoryORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(Category category)
        {
            try
            {
                string query = SQLHelper.insertQuery(table, columns, ids);
                //string sql = "INSERT INTO " + table + " (CAT_ID,CAT_NAME) VALUES (NULL,:0)";
                //Console.WriteLine(sql);
                //Console.WriteLine(query);
                OracleCommand command = connection.sqlPrepare(query);
                connection.AddString(command, category.name);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void edit(Category category)
        {
            try
            {
                string query = SQLHelper.updateQuery(table, columns, ids);
                string sql = "UPDATE " + table + " SET CAT_NAME = :name WHERE CAT_ID = :id";
                Console.WriteLine(sql);
                Console.WriteLine(query);
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, category.name);
                connection.AddInt(command, category.id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delete(int id)
        {
            try
            {
                string sql = SQLHelper.deleteQuery(table, deleteColumn, ids);
                //string sql = "UPDATE " + table + " SET CAT_IS_DELETED = 1 WHERE CAT_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddInt(command, id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable search(string text)
        {
            string sql = SQLHelper.searchQuery(view, columns);
            //string sql = "SELECT * FROM " + view + " WHERE CAT_NAME LIKE :query";
            //Console.WriteLine(query);
            Console.WriteLine(sql);
            OracleCommand command = connection.sqlPrepare(sql);
            connection.AddString(command, text + "%");
            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }
    }
}
