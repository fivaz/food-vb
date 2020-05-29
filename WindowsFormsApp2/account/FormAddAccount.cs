using System;
using System.Windows.Forms;
using WindowsFormsApp2.account;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2
{
    public partial class FormAddAccount : Form, FormAdd<Account>
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
                Edit();
            else
                Create();
            ClearForm();
        }

        private void FormAddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAccounts form = FormAccounts.getInstance();
            form.refreshData();
        }

        public Account Build()
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

        public void Edit()
        {
            AccountORM accountORM = new AccountORM();
            Account account = Build();
            if (account.password == "")
                accountORM.EditWithoutPassword(account);
            else
                accountORM.Edit(account);
        }

        public void Create()
        {
            AccountORM accountORM = new AccountORM();
            accountORM.Create(Build());
        }

        public void SetEditMode()
        {
            btnAAcSubmit.Text = "Modifier &compte";
            editMode = true;
        }

        public void ClearForm()
        {
            tbxAAcFirstName.Text = "";
            tbxAAcLastName.Text = "";
            tbxAAcEmail.Text = "";
            tbxAAcPassword1.Text = "";
            tbxAAcPassword2.Text = "";
            rbtAAcManager.Checked = false;
            rbtAAcWaiter.Checked = false;
        }

        //TODO check passwords match
    }
}
