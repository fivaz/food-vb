using System;
using System.Windows.Forms;
using WindowsFormsApp2.account;

namespace WindowsFormsApp2
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void btnSInSubmit_Click(object sender, EventArgs e)
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
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                this.Hide();
            }
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
