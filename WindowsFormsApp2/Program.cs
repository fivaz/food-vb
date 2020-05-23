using System;
using System.Windows.Forms;

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
