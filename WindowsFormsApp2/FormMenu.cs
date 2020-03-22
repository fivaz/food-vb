using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddMenu().Show();
        }
    }
}
