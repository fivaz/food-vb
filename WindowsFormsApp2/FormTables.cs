using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }

        private void FormTables_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAddTable().Show();
        }
    }
}
