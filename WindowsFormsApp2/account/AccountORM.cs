using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp2.shared;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.account
{
    class AccountORM : ORM<Account>
    {
        public AccountORM()
        {
            table = "foo_account";
            view = "vw_account";
            columns = new List<string> { "ACC_LAST_NAME", "ACC_FIRST_NAME", "ACC_EMAIL", "ACC_PASSWORD", "ACC_TYPE" };
            columnId = "ACC_ID";
            deleteColumn = "ACC_IS_DELETED";
        }

        internal Account Find(string email, string password)
        {
            string query = "SELECT * FROM " + table + " WHERE ACC_EMAIL = :ACC_EMAIL AND ACC_PASSWORD = :ACC_PASSWORD";
            OracleCommand command = connection.SqlPrepare(query);
            connection.AddString(command, "ACC_EMAIL", email);
            connection.AddString(command, "ACC_PASSWORD", password);
            OracleDataReader oracleDataReader = connection.Execute(command);
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                int id = Convert.ToInt32(dataRow["ACC_ID"].ToString());
                string firstName = dataRow["ACC_FIRST_NAME"].ToString();
                string lastName = dataRow["ACC_LAST_NAME"].ToString();
                string type = dataRow["ACC_TYPE"].ToString();
                return new Account(id, firstName, lastName, email, null, type);
            }
            else
                return null;
        }
        public void EditWithoutPassword(Account account)
        {
            try
            {
                string[] editable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
                string query = SQLHelper.UpdateQuery(table, editable, columnId);
                OracleCommand command = connection.SqlPrepare(query);
                connection.AddString(command, "ACC_lAST_NAME", account.lastName);
                connection.AddString(command, "ACC_FIRST_NAME", account.firstName);
                connection.AddString(command, "ACC_EMAIL", account.email);
                connection.AddString(command, "ACC_TYPE", account.type);
                connection.AddInt(command, "ACC_ID", account.id);
                connection.Execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Search(string text)
        {
            string[] searchable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
            return base.Search(text, searchable);
        }

        public override void BindObject(OracleCommand command, Account account, bool withId)
        {
            connection.AddString(command, "ACC_LAST_NAME", account.lastName);
            connection.AddString(command, "ACC_FIRST_NAME", account.firstName);
            connection.AddString(command, "ACC_EMAIL", account.email);
            connection.AddString(command, "ACC_PASSWORD", account.password);
            connection.AddString(command, "ACC_TYPE", account.type);
            if (withId)
                connection.AddInt(command, "ACC_ID", account.id);
            else
                connection.addReturnId(command);
        }

        //TODO check unique email
    }
}
