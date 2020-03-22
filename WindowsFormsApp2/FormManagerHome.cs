using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormManagerHome : Form
    {
        public FormManagerHome()
        {
            InitializeComponent();
        }

        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerPlatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerPlatsToolStripMenuItem1_Click(object sender, EventArgs e)
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

            if(IsOpen == false)
            {
                frmIngredients f2 = new frmIngredients();
                f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}
