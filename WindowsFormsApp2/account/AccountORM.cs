using Oracle.DataAccess.Client;
using System;
using System.Data;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.database;

namespace WindowsFormsApp2.account
{
    class AccountORM : ORM<Account>
    {
        OracleConn connection;
        String table = "foo_account";
        String view = "vw_account";
        public AccountORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(Account account)
        {
            try
            {
                String sql = "INSERT INTO " + table + " " +
                   "(ACC_ID, ACC_LAST_NAME, ACC_FIRST_NAME, ACC_EMAIL, ACC_PASSWORD, ACC_TYPE) " +
                   "VALUES " +
                   "(NULL, :lastName, :firstName, :email, :password, :type)";
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
                String sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                    "ACC_EMAIL = :email, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, account.firstName);
                connection.AddString(command, account.lastName);
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
                String sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                    "ACC_EMAIL = :email, ACC_PASSWORD = :password, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddString(command, account.firstName);
                connection.AddString(command, account.lastName);
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
