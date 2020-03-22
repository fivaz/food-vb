using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmIngredients : Form
    {
        public frmIngredients()
        {
            InitializeComponent();
        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddIngredient().Show();
        }
    }
}
