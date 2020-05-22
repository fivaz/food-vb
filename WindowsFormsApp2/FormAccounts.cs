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
            // TODO: This line of code loads data into the 'dataSet2.FOO_ACCOUNT' table. You can move, or remove it, as needed.
            this.fOO_ACCOUNTTableAdapter.Fill(this.dataSet2.FOO_ACCOUNT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddAccount().Show();
        }

        private void dgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
