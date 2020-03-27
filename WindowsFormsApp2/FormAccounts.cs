using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAccounts : Form
    {
        public FormAccounts()
        {
            InitializeComponent();
        }

        private void FormAccounts_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddAccount().Show();
        }
    }
}
