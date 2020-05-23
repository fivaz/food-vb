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
            
            //check1();
            check2();
        }

        static void check2()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSignIn());
            Application.Run(new FormAccounts());
        }
    }
}
