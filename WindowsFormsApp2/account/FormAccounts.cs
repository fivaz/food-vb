using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp2.account;

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
                instance = new FormAccounts();
            return instance;
        }

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            dgvAcc.DataSource = new AccountORM().ListAll();
            dgvAcc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAcc.Columns[0].HeaderText = "id";
            dgvAcc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAcc.Columns[1].HeaderText = "nom";
            dgvAcc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAcc.Columns[2].HeaderText = "prénom";
            dgvAcc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAcc.Columns[3].HeaderText = "email";
            dgvAcc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAcc.Columns[4].HeaderText = "type";
        }

        internal void refreshData()
        {
            dgvAcc.DataSource = new AccountORM().ListAll();
        }

        private void dgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddAccount fa = new FormAddAccount();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvAcc.CurrentRow.Cells[0].Value.ToString());
            fa.tbxAAcLastName.Text = this.dgvAcc.CurrentRow.Cells[1].Value.ToString();
            fa.tbxAAcFirstName.Text = this.dgvAcc.CurrentRow.Cells[2].Value.ToString();
            fa.tbxAAcEmail.Text = this.dgvAcc.CurrentRow.Cells[3].Value.ToString();
            String role = this.dgvAcc.CurrentRow.Cells[4].Value.ToString();

            if (role.Equals("Manager"))
                fa.rbtAAcManager.Checked = true;
            else
                fa.rbtAAcWaiter.Checked = true;

            fa.ShowDialog();
        }


        private void btnAccDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvAcc.CurrentRow.Cells[0].Value.ToString());
            new AccountORM().Delete(id);
            refreshData();
        }

        private void tbxAccSearchName_TextChanged(object sender, EventArgs e)
        {
            if (tbxAccSearchName.Text.Equals(""))             
                refreshData();
            else
            {
                DataTable data = new AccountORM().Search(tbxAccSearchName.Text);
                dgvAcc.DataSource = data;
            }
        }

        private void btnAccAdd_Click(object sender, EventArgs e)
        {
            new FormAddAccount().Show();
        }
    }
}
