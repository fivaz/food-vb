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
            columns = new List<string>{ "ACC_LAST_NAME", "ACC_FIRST_NAME", "ACC_EMAIL", "ACC_PASSWORD", "ACC_TYPE" };
            columnId = "ACC_ID";
            deleteColumn = "ACC_IS_DELETED";
        }

        public void EditWithoutPassword(Account account)
        {
            try
            {
                string[] editable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
                string sql = SQLHelper.UpdateQuery(table, editable, columnId);
                //string sql = "UPDATE " + table + " SET ACC_LAST_NAME = :lastName, ACC_FIRST_NAME = :firstName, " +
                //    "ACC_EMAIL = :email, ACC_TYPE = :type WHERE ACC_ID = :id";
                OracleCommand command = connection.SqlPrepare(sql);
                connection.AddString(command, "ACC_lAST_NAME", account.lastName);
                connection.AddString(command, "ACC_FIRST_NAME", account.firstName);
                connection.AddString(command, "ACC_EMAIL", account.email);
                connection.AddString(command, "ACC_TYPE", account.type);
                connection.AddInt(command, "ACC_ID", account.id);
                connection.execute(command);
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
