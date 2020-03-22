using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormManagerHome : Form
    {
        public FormManagerHome()
        {
            InitializeComponent();
        }

        private void msiIngredients_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormIngredients")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmIngredients f2 = new frmIngredients();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void msiDishes_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormDishes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmDishes f2 = new frmDishes();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void msiMenus_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormDishes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmMenus f2 = new frmMenus();
                f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}
