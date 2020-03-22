using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddIngredient().Show();
        }
    }
}
