using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddCategory().Show();
        }

        private void dgvIng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
