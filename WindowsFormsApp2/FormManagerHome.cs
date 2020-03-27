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

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
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
                frmAccounts f2 = new frmAccounts();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
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
                frmCategories f2 = new frmCategories();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void gérerTablesToolStripMenuItem_Click(object sender, EventArgs e)
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
                frmTables f2 = new frmTables();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void msiStats_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormStats")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStats f2 = new frmStats();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void mstManager_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
