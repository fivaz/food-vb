using Oracle.DataAccess.Client;
using System;
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
        protected string[] columns;
        protected string[] ids;
        protected string deleteColumn;

        public ORM()
        {
            connection = OracleConnector.getConnection();
        }

        public void create(T obj)
        {
            try
            {
                string query = SQLHelper.insertQuery(table, columns, ids);
                OracleCommand command = connection.sqlPrepare(query);
                //connection.AddString(command, obj.name);
                bindObject(command, obj, false);
                connection.execute(command);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public abstract void bindObject(OracleCommand command, T obj, Boolean withId);

        public void edit(T obj)
        {
            try
            {
                string sql = SQLHelper.updateQuery(table, columns, ids);
                OracleCommand command = connection.sqlPrepare(sql);
                //connection.AddString(command, obj.name);
                //connection.AddInt(command, obj.id);
                bindObject(command, obj, true);
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
                string sql = SQLHelper.deleteQuery(table, deleteColumn, ids);
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
            string sql = SQLHelper.searchQuery(view, columns);
            Console.WriteLine(sql);
            OracleCommand command = connection.sqlPrepare(sql);
            command.BindByName = true;
            
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
