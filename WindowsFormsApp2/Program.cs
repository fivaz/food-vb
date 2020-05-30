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

            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSignIn());
            //Application.Run(new FormAccounts());
            //Application.Run(new FormCategories());
            //Application.Run(new FormDishes());
            //Application.Run(new FormAddDish());
            Application.Run(new FormIngredients());
            //Application.Run(new FormAddIngredient());
        }
    }
}
