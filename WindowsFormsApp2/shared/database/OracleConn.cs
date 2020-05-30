using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2.shared.database
{
    public class OracleConn
    {
        #region properties

        public string stringConn;
        public OracleConnection connection;

        #endregion

        #region constructor

        public OracleConn(string server, string user, string password)
        {
            stringConn = "DATA SOURCE=" + server + ";USER ID=" + user + ";PASSWORD=" + password;

            connection = new OracleConnection(stringConn);
            connection.Open();
        }

        #endregion

        #region methods

        public void SqlCommand(string sql)
        {
            try
            {
                OracleCommand command = new OracleCommand(sql, connection);
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 0;
                IDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OracleCommand SqlPrepare(string sql)
        {
            try
            {
                OracleCommand command = new OracleCommand(sql, connection);
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 0;
                command.BindByName = true;
                return command;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ExecuteNonQuery(OracleCommand currentCommand)
        {
            try
            {
                return currentCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OracleDataReader execute(OracleCommand currentCommand)
        {
            try
            {
                return currentCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //remove these :

        public void AddString(OracleCommand currentCommand, string column, string value)
        {
            OracleParameter param = new OracleParameter(":" + column, OracleDbType.NVarchar2);
            param.Value = value;
            currentCommand.Parameters.Add(param);
        }

        public void AddInt(OracleCommand currentCommand, string column, int value)
        {
            OracleParameter param = new OracleParameter(":" + column, OracleDbType.Int32);
            param.Value = value;
            currentCommand.Parameters.Add(param);
        }

        public void AddDouble(OracleCommand currentCommand, string column, double value)
        {
            OracleParameter param = new OracleParameter(":" + column, OracleDbType.Double);
            param.Value = value;
            currentCommand.Parameters.Add(param);
        }

        public void addReturnId(OracleCommand command)
        {
            OracleParameter parameter = new OracleParameter("RETURNED_ID", OracleDbType.Int32);
            parameter.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(parameter);
        }

        public void close()
        {
            connection.Close();
        }

        #endregion

    }
}
