using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp2.shared.database;
using WindowsFormsApp2.shared.helper;

namespace WindowsFormsApp2.shared
{
    public abstract class ORM<T>
    {
        protected OracleConn connection;
        protected string table;
        protected string view;
        protected List<string> columns;
        protected string columnId;
        protected string deleteColumn;

        public ORM()
        {
            connection = OracleConnector.getConnection();
        }

        public DataTable ListAll()
        {
            try
            {
                string query = SQLHelper.SelectQuery(view);
                return connection.SqlCommand(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Create(T obj)
        {
            try
            {
                string query = SQLHelper.InsertQuery(table, columns.ToArray(), columnId);
                Console.WriteLine(query);
                OracleCommand command = connection.SqlPrepare(query);
                BindObject(command, obj, false);
                connection.ExecuteNonQuery(command);
                return Convert.ToInt32(command.Parameters["RETURNED_ID"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public abstract void BindObject(OracleCommand command, T obj, Boolean withId);

        public void Edit(T obj)
        {
            try
            {
                string query = SQLHelper.UpdateQuery(table, columns.ToArray(), columnId);
                Console.WriteLine(query);
                OracleCommand command = connection.SqlPrepare(query);
                BindObject(command, obj, true);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                string query = SQLHelper.DeleteQuery(table, deleteColumn, columnId);
                Console.WriteLine(query);
                OracleCommand command = connection.SqlPrepare(query);
                command.BindByName = false;
                connection.AddInt(command, "", id);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Search(string text, string[] usedColumns = null)
        {
            string query;
            if (usedColumns != null)
                query = SQLHelper.SearchQuery(view, usedColumns);
            else
                query = SQLHelper.SearchQuery(view, columns.ToArray());

            Console.WriteLine(query);
            OracleCommand command = connection.SqlPrepare(query);

            OracleParameter param = new OracleParameter(":query", OracleDbType.NVarchar2);
            param.Value = text + "%";
            command.Parameters.Add(param);

            OracleDataReader odr = connection.execute(command);
            DataTable data = new DataTable();
            data.Load(odr);
            return data;
        }
    }
}

//use close()