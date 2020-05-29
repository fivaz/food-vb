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
            ids = new List<string>{ "ACC_ID" };
            deleteColumn = "ACC_IS_DELETED";
        }
        
        /*
        public void create(Account account)
        {
            try
            {
                //string sql = "INSERT INTO " + table + " " +
                //   "(ACC_ID, ACC_LAST_NAME, ACC_FIRST_NAME, ACC_EMAIL, ACC_PASSWORD, ACC_TYPE) " +
                //   "VALUES " +
                //   "(NULL, :lastName, :firstName, :email, :password, :type)";
                
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
        */

        public void EditWithoutPassword(Account account)
        {
            try
            {
                string[] editable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
                string sql = SQLHelper.UpdateQuery(table, editable, ids.ToArray());
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

        /*
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
        */
        /*
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
        */
        
        public DataTable Search(string text)
        {
            string[] searchable = columns.Where(val => !val.Equals("ACC_PASSWORD")).ToArray();
            return base.Search(text, searchable);
            /*
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
            */
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
        }

        //TODO check unique email
    }
}
