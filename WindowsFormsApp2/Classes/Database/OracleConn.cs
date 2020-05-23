using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2.Classes.Database
{
    public class OracleConn
    {
        #region properties

        public String stringConn;
        public OracleConnection connection;

        #endregion

        #region constructor

        public OracleConn(String server, String user, String password)
        {
            //stringConn = 'DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=FOO_DBA;';
            stringConn = "DATA SOURCE=" + server + ";USER ID=" + user + ";PASSWORD=" + password;

            connection = new OracleConnection(stringConn);
            connection.Open();
        }

        #endregion

        
        #region methods

        public String sqlQuery(String sql, DataTable dt)
        {
            try{
                IDbCommand command = new OracleCommand(sql, connection);
                command.CommandTimeout = 0;
                IDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                return "";
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public String sqlCommand(String sql)
        {
            try
            {
                IDbCommand command = new OracleCommand(sql, connection);
                command.CommandTimeout = 0;
                IDataReader reader = command.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void close()
        {
            connection.Close();
        }

        #endregion

    }
}
