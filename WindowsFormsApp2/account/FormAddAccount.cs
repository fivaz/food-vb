using System;
using System.Windows.Forms;
using WindowsFormsApp2.account;

namespace WindowsFormsApp2
{
    public partial class FormAddAccount : Form
    {
        internal int id;
        internal bool editMode = false;

        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void btnAAcSubmit_Click(object sender, EventArgs e)
        {
            if (editMode)
                edit();
            else
                createAccount();
            clearForm();
        }

        private Account build()
        {
            string firstName = tbxAAcFirstName.Text.ToString();
            string lastName = tbxAAcLastName.Text.ToString();
            string email = tbxAAcEmail.Text.ToString();
            string password = tbxAAcPassword1.Text.ToString();
            string type = "Waiter";
            if (rbtAAcManager.Checked)
                type = "Manager";
            return new Account(id, firstName, lastName, email, password, type);
        }

        private void edit()
        {
            AccountORM accountORM = new AccountORM();
            Account account = build();
            if (account.password == "")
                accountORM.EditWithoutPassword(account);
            else
                accountORM.Edit(account);
        }

        private void createAccount()
        {
            AccountORM accountORM = new AccountORM();
            accountORM.Create(build());
        }

        internal void setEditMode()
        {
            btnAAcSubmit.Text = "Modifier &compte";
            editMode = true;
        }

        private void clearForm()
        {
            tbxAAcFirstName.Text = "";
            tbxAAcLastName.Text = "";
            tbxAAcEmail.Text = "";
            tbxAAcPassword1.Text = "";
            tbxAAcPassword2.Text = "";
            rbtAAcManager.Checked = false;
            rbtAAcWaiter.Checked = false;
        }

        private void FormAddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAccounts form = FormAccounts.getInstance();
            form.refreshData();
        }

        //TODO check passwords match
    }
}
