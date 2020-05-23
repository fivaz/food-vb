using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classes.Database;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSignIn());
            OracleConn oracleConn = new OracleConn("XE", "foo_dba", "foo_dba");
            try
            {

                DataTable dt = new DataTable();
                String sql = "SELECT * FROM foo_account";
                oracleConn.sqlQuery(sql, dt);
                oracleConn.close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Application.Run(new FormAccounts());
        }
    }
}
