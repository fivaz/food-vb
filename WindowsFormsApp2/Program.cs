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
            /*
            FormFrame formFrame = new FormFrame();
            formFrame.Hide();

            Application.Run();
            */

            //Application.Run(new FormSignIn());
            //Application.Run(new FormManagerHome()); 
            //Application.Run(new FormWaiterHome(1)); 
            //Application.Run(new FormOrdersHistory());
            //Application.Run(new FormAccounts());
            //Application.Run(new FormCategories());
            //Application.Run(new FormDishes());
            //Application.Run(new FormAddDish());
            //Application.Run(new FormIngredients());
            //Application.Run(new FormAddIngredient());
            Application.Run(new FormMenus());
            //Application.Run(new FormAddMenu());
        }
    }
}
