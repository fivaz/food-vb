using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace WindowsFormsApp2.Classes.Database
{
    class AccountORM
    {
        OracleConn connection;
        public AccountORM()
        {
            connection = OracleConnector.getConnection();
        }

        public DataTable show()
        {
            return null;
        }

        public void create(Account account)
        {
            try
            {
                String sql = "INSERT INTO foo_account " +
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

        public void edit(Account account)
        {
            try
            {
                String sql = "UPDATE foo_account SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
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
                String sql = "UPDATE foo_account SET ACC_IS_DELETED = 1 WHERE ACC_ID = :id";
                OracleCommand command = connection.sqlPrepare(sql);
                connection.AddInt(command, id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void search(string text)
        {
            String sql = "SELECT * FROM foo_account WHERE ACC_LAST_NAME = :query OR ACC_FIRST_NAME = :query OR " +
                    "ACC_EMAIL = :query OR ACC_TYPE = :query";
            OracleCommand command = connection.sqlPrepare(sql);
            connection.AddString(command, text);
            connection.AddString(command, text);
            connection.AddString(command, text);
            connection.AddString(command, text);
            connection.execute(command);
        }

        //TODO check unique email
    }
}
