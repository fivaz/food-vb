using System;
using System.Windows.Forms;
using WindowsFormsApp2.Classes.Database;

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

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void tbxAAcLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAAcSubmit_Click(object sender, EventArgs e)
        {
            if (editMode)
                editAccount();
            else
                createAccount();
            clearForm();
        }

        private Account buildAccount()
        {
            String firstName = tbxAAcFirstName.Text.ToString();
            String lastName = tbxAAcLastName.Text.ToString();
            String email = tbxAAcEmail.Text.ToString();
            String password = tbxAAcPassword1.Text.ToString();
            String type = "Waiter";
            if (rbtAAcManager.Checked)
                type = "Manager";
            return new Account(id, firstName, lastName, email, password, type);
        }

        private void editAccount()
        {
        }

        private void createAccount()
        {
            AccountORM accountORM = new AccountORM();
            accountORM.create(buildAccount());
        }

        internal void setEditMode()
        {
            btnAAcSubmit.Text = "Modifier &compte";
            editMode = true;
        }

        private void clearForm(){
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
