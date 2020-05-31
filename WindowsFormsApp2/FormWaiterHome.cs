using System;
using System.Windows.Forms;
using WindowsFormsApp2.dish;

namespace WindowsFormsApp2
{
    public partial class FormWaiterHome : Form
    {
        public FormWaiterHome()
        {
            InitializeComponent();
        }
        private void FormWaiterHome_Load(object sender, EventArgs e)
        {
            dgvWHoCategory1.DataSource = new DishORM().ListFromMenu("Entrée"); 
            dgvWHoCategory2.DataSource = new DishORM().ListFromMenu("Plat principal");
            //
            dgvWHoCategory4.DataSource = new DishORM().ListFromMenu("Dessert");
            formatDvg(dgvWHoCategory1);
            formatDvg(dgvWHoCategory2);
            formatDvg(dgvWHoCategory4);
        }

        private void formatDvg(DataGridView dvg)
        {
            dvg.Columns["DIS_ID"].Visible= false;
            dvg.Columns["DIS_CAT_ID"].Visible= false;
            dvg.Columns["DIS_NAME"].HeaderText = "nom";
            dvg.Columns["DIS_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dvg.Columns["CAT_NAME"].HeaderText = "catégorie";
            dvg.Columns["CAT_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dvg.Columns["PURCHASE_PRICE"].HeaderText = "prix";
            dvg.Columns["PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dvg.Columns["MDR_DIS_ID"].Visible = false;
            dvg.Columns["MDR_MEN_ID"].Visible = false;
            dvg.Columns["MDR_QUANTITY"].HeaderText = "quantité";
            dvg.Columns["MDR_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dvg.Columns["USE_MEN_ID"].Visible = false;
            dvg.AllowUserToAddRows = false;
        }

        private void btnWHoHistory_Click(object sender, EventArgs e)
        {
            new FormOrdersHistory().Show();
        }

    }
}
