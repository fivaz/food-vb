using System;
using System.Windows.Forms;
using WindowsFormsApp2.Classes.Database;

namespace WindowsFormsApp2
{
    public partial class FormAccounts : Form
    {
        static FormAccounts instance;
        public FormAccounts()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormAccounts getInstance()
        {
            if (instance == null)
            {
                new FormAccounts();
            }
            return instance;
        }

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.VW_ACCOUNT' table. You can move, or remove it, as needed.
            this.vW_ACCOUNTTableAdapter.Fill(this.dataSet3.VW_ACCOUNT);            
            this.dgvAcc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAcc.Columns[0].HeaderText = "id";
            this.dgvAcc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAcc.Columns[1].HeaderText = "nom";
            this.dgvAcc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAcc.Columns[2].HeaderText = "prénom";
            this.dgvAcc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAcc.Columns[3].HeaderText = "email";
            this.dgvAcc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAcc.Columns[4].HeaderText = "type";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddAccount().Show();
        }

        private void dgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddAccount fa = new FormAddAccount();

            fa.setEditMode();
            fa.id = Int32.Parse(dgvAcc.CurrentRow.Cells[0].Value.ToString());
            fa.tbxAAcLastName.Text = this.dgvAcc.CurrentRow.Cells[1].Value.ToString();
            fa.tbxAAcFirstName.Text = this.dgvAcc.CurrentRow.Cells[2].Value.ToString();
            fa.tbxAAcEmail.Text = this.dgvAcc.CurrentRow.Cells[3].Value.ToString();
            String role = this.dgvAcc.CurrentRow.Cells[5].Value.ToString();

            if (role.Equals("Manager"))
                fa.rbtAAcManager.Checked = true;
            else
                fa.rbtAAcWaiter.Checked = true;

            fa.ShowDialog();
        }

        internal void refreshData()
        {
            this.vW_ACCOUNTTableAdapter.ClearBeforeFill = true;
            this.vW_ACCOUNTTableAdapter.Fill(this.dataSet3.VW_ACCOUNT);
        }

        private void btnAccDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvAcc.CurrentRow.Cells[0].Value.ToString());
            new AccountORM().delete(id);
            refreshData();
        }

        private void dgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxAccSearchName_TextChanged(object sender, EventArgs e)
        {
            new AccountORM().search(tbxAccSearchName.Text);
            //this.vW_ACCOUNTTableAdapter.Fill();
        }
    }
}
