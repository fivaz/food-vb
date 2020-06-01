using System;
using System.Windows.Forms;
using WindowsFormsApp2.order;

namespace WindowsFormsApp2
{
    public partial class FormOrdersHistory : Form
    {
        public FormOrdersHistory()
        {
            InitializeComponent();
        }

        private void FormOrdersHistory_Load(object sender, EventArgs e)
        {
            dgvHis.DataSource = new OrderORM().listAllWithDishes();
            dgvHis.Columns["ORD_ID"].HeaderText = "id";
            dgvHis.Columns["ORD_ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["ORD_DATE"].HeaderText = "date";
            dgvHis.Columns["ORD_DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["ODR_QUANTITY"].HeaderText = "quantité";
            dgvHis.Columns["ODR_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["DIS_NAME"].HeaderText = "nom";
            dgvHis.Columns["DIS_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["ACC_FIRST_NAME"].HeaderText = "prénom (serveur)";
            dgvHis.Columns["ACC_FIRST_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["ACC_LAST_NAME"].HeaderText = "nom (serveur)";
            dgvHis.Columns["ACC_LAST_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHis.Columns["TAB_NAME"].HeaderText = "table";
            dgvHis.Columns["TAB_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
