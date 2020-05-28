using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Linq;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.database;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.account
{
    class AccountORM : ORM<Account>
    {
        OracleConn connection;
        string table = "foo_account";
        string view = "vw_account";
        string[] columns = { "ACC_LAST_NAME", "ACC_FIRST_NAME", "ACC_EMAIL", "ACC_PASSWORD", "ACC_TYPE" };
        string[] ids = { "ACC_ID" };
        string deleteColumn = "ACC_IS_DELETED";
        public AccountORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(Account account)
        {
            try
            {
                /*   
                string sql = "INSERT INTO " + table + " " +
                   "(ACC_ID, ACC_LAST_NAME, ACC_FIRST_NAME, ACC_EMAIL, ACC_PASSWORD, ACC_TYPE) " +
                   "VALUES " +
                   "(NULL, :lastName, :firstName, :email, :password, :type)";
                */
                string sql = SQLHelper.insertQuery(table, columns, ids);
                Console.WriteLine(sql);
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, account.firstName);
                connection.AddString(command, account.lastName);
                connection.AddString(command, account.email);
                connection.AddString(command, account.password);
                connection.AddString(command, account.type);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void editWithoutPassword(Account account)
        {
            try
            {
                string[] editable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
                string sql = SQLHelper.updateQuery(table, editable, ids);
                //string sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                //    "ACC_EMAIL = :email, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, account.lastName);
                connection.AddString(command, account.firstName);
                connection.AddString(command, account.email);
                connection.AddString(command, account.type);
                connection.AddInt(command, account.id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void edit(Account account)
        {
            try
            {
                string sql = SQLHelper.updateQuery(table, columns, ids);
                Console.WriteLine(sql);
                //string sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                //    "ACC_EMAIL = :email, ACC_PASSWORD = :password, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, account.lastName);
                connection.AddString(command, account.firstName);
                connection.AddString(command, account.email);
                connection.AddString(command, account.password);
                connection.AddString(command, account.type);
                connection.AddInt(command, account.id);
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
                //string sql = "UPDATE " + table + " SET ACC_IS_DELETED = 1 WHERE ACC_ID = :id";
                string sql = SQLHelper.deleteQuery(table, deleteColumn, ids);
                Console.WriteLine(sql);
                //Console.WriteLine(query);
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
            string[] searchable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
            string sql = SQLHelper.searchQuery(view, searchable);
            //string sql = "SELECT * FROM " + view + " WHERE ACC_LAST_NAME LIKE :query OR ACC_FIRST_NAME LIKE :query OR " +
            //        "ACC_EMAIL LIKE :query OR ACC_TYPE LIKE :query"; 
            //Console.WriteLine(query);
            Console.WriteLine(sql);
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
