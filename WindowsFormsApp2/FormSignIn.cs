using System;
using System.Windows.Forms;
using WindowsFormsApp2.account;

namespace WindowsFormsApp2
{
    public partial class FormSignIn : Form
    {
        static FormSignIn instance;

        public FormSignIn()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormSignIn getInstance()
        {
            if (instance == null)
                new FormSignIn();
            return instance;
        }

        private void btnSInSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Submit()
        {
            string email = txbSInEmail.Text;
            string password = txbSInPassword.Text;
            Account account = new AccountORM().Find(email, password);
            if (account == null)
                MessageBox.Show("email ou mot de passe incorrectes");
            else
            {
                Form mainForm;
                if (account.type == "Manager")
                    mainForm = new FormManagerHome();
                else
                    mainForm = new FormWaiterHome(account.id);
                mainForm.Show();
                ClearForm();
                Hide();
            }
        }

        public void ClearForm()
        {
            txbSInEmail.Text = "";
            txbSInPassword.Text = "";
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
