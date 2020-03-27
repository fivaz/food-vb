using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMenus : Form
    {
        public FormMenus()
        {
            InitializeComponent();
        }

        private void FormMenus_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddMenu().Show();
        }
    }
}
