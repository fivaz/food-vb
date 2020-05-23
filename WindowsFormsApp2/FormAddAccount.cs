using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DataSet2TableAdapters;

namespace WindowsFormsApp2
{
    public partial class FormAddAccount : Form
    {
        internal int id;
        internal bool editMode;

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
            Account account = buildAccount();
            TableAdapterManager tam = new TableAdapterManager();
        }

        internal void setEditMode()
        {
            btnAAcSubmit.Text = "Modifier &compte"; 
            editMode = true;
        }
    }
}
