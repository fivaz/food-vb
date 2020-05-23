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

        public DataTable add()
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

        public DataTable edit(Account account)
        {
            return null;
        }

        public DataTable delete(Account account)
        {
            return null;
        }
    }
}
