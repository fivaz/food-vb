using Oracle.DataAccess.Client;
using System;
using System.Data;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.database;

namespace WindowsFormsApp2.category
{
    class CategoryORM : ORM<Category>
    {
        OracleConn connection;
        String table = "foo_category";
        String view = "vw_category";
        public CategoryORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(Category category)
        {
            try
            {
                String sql = "INSERT INTO " + table + " (CAT_ID, CAT_NAME) VALUES (NULL, :name)";
                OracleCommand command = connection.sqlPrepare(sql);
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
                String sql = "UPDATE " + table + " SET CAT_NAME = :name WHERE CAT_ID = :id";
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
                String sql = "UPDATE " + table + " SET CAT_IS_DELETED = 1 WHERE CAT_ID = :id";
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
            String sql = "SELECT * FROM " + view + " WHERE CAT_NAME LIKE :query";
            OracleCommand command = connection.sqlPrepare(sql);
            connection.AddString(command, text + "%");
            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }
    }
}
