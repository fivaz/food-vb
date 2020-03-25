using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSInSubmit_Click(object sender, EventArgs e)
        {
            if(txbSInEmail.Text == "admin")
            {
                new FormManagerHome().Show();
            }
            else
            {
                new FormWaiterHome().Show();
            }
            this.Hide();
        }
    }
}
