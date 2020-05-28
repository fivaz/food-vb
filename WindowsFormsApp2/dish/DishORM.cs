using Oracle.DataAccess.Client;
using System;
using System.Data;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.database;

namespace WindowsFormsApp2.dish
{
    class DishORM : ORM<Dish>
    {
        OracleConn connection;
        string table = "foo_dish";
        string view = "vw_dish";

        public DishORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(Dish dish)
        {
            try
            {
                string sql = "INSERT INTO " + table + " " +
                   "(DIS_ID, DIS_CAT_ID, DIS_NAME, DIS_SELLING_PRICE) " +
                   "VALUES " +
                   "(NULL, ?, ?, ?, ?, ?)";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddInt(command, dish.categoryId);
                connection.AddString(command, dish.name);
                connection.AddDouble(command, dish.sellingPrice);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void edit(Dish dish)
        {
            try
            {
                String sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                    "ACC_EMAIL = :email, ACC_PASSWORD = :password, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddInt(command, dish.categoryId);
                connection.AddString(command, dish.name);
                connection.AddDouble(command, dish.sellingPrice);
                connection.AddInt(command, dish.id);
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
                String sql = "UPDATE " + table + " SET ACC_IS_DELETED = 1 WHERE ACC_ID = :id";
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
            String sql = "SELECT * FROM " + view + " WHERE ACC_LAST_NAME LIKE :query OR ACC_FIRST_NAME LIKE :query OR " +
                    "ACC_EMAIL LIKE :query OR ACC_TYPE LIKE :query";
            OracleCommand command = connection.sqlPrepare(sql);
            connection.AddString(command, text + "%");
            connection.AddString(command, text + "%");
            connection.AddString(command, text + "%");
            connection.AddString(command, text + "%");
            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }

        //TODO check unique email
    }
}
