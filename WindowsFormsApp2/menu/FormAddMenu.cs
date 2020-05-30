using System;
using System.Windows.Forms;
using WindowsFormsApp2.dish;
using WindowsFormsApp2.menu;

namespace WindowsFormsApp2
{
    public partial class FormAddMenu : Form
    {
        public int id;
        public bool editMode = false;

        public FormAddMenu()
        {
            InitializeComponent();
        }

        private void FormAddMenu_Load(object sender, EventArgs e)
        {
            DishORM menuORM = new DishORM();

            dgvAMeAdded.DataSource = menuORM.SearchFromMenu(id);
            dgvAMeAvailable.DataSource = menuORM.SearchExceptFromMenu(id);

            formatAddedDgv(dgvAMeAdded);
            formatAvailableDgv(dgvAMeAvailable);
            
            resizeGrids();
        }

        private void formatAddedDgv(DataGridView dgv)
        {
            dgv.Columns["DIS_ID"].Visible = false;
            dgv.Columns["DIS_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["DIS_NAME"].HeaderText = "nom";
            dgv.Columns["MDR_MEN_ID"].Visible = false; 
            dgv.Columns["MDR_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["MDR_QUANTITY"].HeaderText = "quantité";
            dgv.AllowUserToAddRows = false;
        }

        private void formatAvailableDgv(DataGridView dgv)
        {
            dgv.Columns["DIS_ID"].Visible = false;
            dgv.Columns["DIS_CAT_ID"].Visible = false;
            dgv.Columns["DIS_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["DIS_NAME"].HeaderText = "nom";
            dgv.Columns["CAT_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["CAT_NAME"].HeaderText = "catégorie";
            dgv.Columns["PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["PURCHASE_PRICE"].HeaderText = "quantité";
            dgv.AllowUserToAddRows = false;
        }

        private void resizeGrids()
        {
            dgvAMeAdded.Width = gbxAMenuItem.Width / 2 - 2;
            dgvAMeAvailable.Left = gbxAMenuItem.Left + dgvAMeAdded.Width;
            dgvAMeAvailable.Width = gbxAMenuItem.Width / 2 - 36;
            tbxAMeAvaSearch.Left = dgvAMeAvailable.Left;
            lblAMeAvailable.Left = dgvAMeAvailable.Left;
            lblAMeAvaSearch.Left = dgvAMeAvailable.Left;
        }

        public menu.Menu Build()
        {
            string name = tbxAMeName.Text.ToString();
            return new menu.Menu(id, name);
        }
        public void ClearForm()
        {
            tbxAMeName.Text = "";
        }

        public void SetEditMode()
        {
            btnAMeSubmit.Text = "Modifier &menu";
            editMode = true;
        }

        private void btnAMeSubmit_Click(object sender, EventArgs e)
        {

        }

        private void FormAddMenu_Resize(object sender, EventArgs e)
        {
            resizeGrids();
        }
    }
}
