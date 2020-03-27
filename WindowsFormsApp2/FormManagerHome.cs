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
                FormIngredients f2 = new FormIngredients();
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
                FormDishes f2 = new FormDishes();
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
                FormMenus f2 = new FormMenus();
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
                FormAccounts f2 = new FormAccounts();
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
                FormCategories f2 = new FormCategories();
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
                FormTables f2 = new FormTables();
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
                FormStats f2 = new FormStats();
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

        private void fenêtreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alignerVerticalementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
