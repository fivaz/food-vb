using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDishes : Form
    {
        public FormDishes()
        {
            InitializeComponent();
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddDish().Show();
        }
    }
}
