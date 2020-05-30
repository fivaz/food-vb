using System;
using System.Collections.Generic;
using System.Data;
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
            //dgv.Columns["CAT_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgv.Columns["CAT_NAME"].HeaderText = "catégorie";
            dgv.Columns["CAT_NAME"].Visible = false;
            //dgv.Columns["PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgv.Columns["PURCHASE_PRICE"].HeaderText = "quantité";
            dgv.Columns["PURCHASE_PRICE"].Visible = false;
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

        public void SetEditMode()
        {
            btnAMeSubmit.Text = "Modifier &menu";
            editMode = true;
        }

        private void btnAMeSubmit_Click(object sender, EventArgs e)
        {
            if (editMode)
                Edit();
            else
                Create();
            ClearForm();
        }

        public void Edit()
        {
            MenuORM menuORM = new MenuORM();
            menuORM.Edit(Build());
            DishORM dishORM = new DishORM();
            dishORM.DeleteAllRelations(id);
            List<Dish> addedDishes = getAddedDishes(id);
            foreach (Dish dish in addedDishes)
                dishORM.addRelation(dish);
        }

        public List<Dish> getAddedDishes(int menuId)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (DataGridViewRow row in dgvAMeAdded.Rows)
            {
                int dishId = Convert.ToInt32(row.Cells["DIS_ID"].Value.ToString());
                double quantity = Convert.ToDouble(row.Cells["MDR_QUANTITY"].Value.ToString());

                Dish dish = new Dish(dishId, 0, null, menuId, quantity);
                dishes.Add(dish);
            }
            return dishes;
        }

        public menu.Menu Build()
        {
            string name = tbxAMeName.Text.ToString();
            return new menu.Menu(id, name);
        }

        public void Create()
        {
            MenuORM menuORM = new MenuORM();
            int menuId = menuORM.Create(Build());
            DishORM dishORM = new DishORM();
            List<Dish> addedDishes = getAddedDishes(menuId);
            foreach (Dish dish in addedDishes)
                dishORM.addRelation(dish);
        }

        public void ClearForm()
        {
            tbxAMeName.Text = "";
        }

        private void FormAddMenu_Resize(object sender, EventArgs e)
        {
            resizeGrids();
        }

        private void FormAddMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenus form = FormMenus.getInstance();
            form.RefreshData();
        }

        private void dgvAMeAdded_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvAMeAdded.CurrentRow;

            DataTable ingredients = (DataTable)dgvAMeAvailable.DataSource;

            DataRow dataRow = ingredients.NewRow();
            dataRow["DIS_ID"] = currentRow.Cells["DIS_ID"].Value;
            dataRow["DIS_NAME"] = currentRow.Cells["DIS_NAME"].Value;
            dataRow["DIS_CAT_ID"] = 0;
            dataRow["CAT_NAME"] = "";

            ingredients.Rows.Add(dataRow);

            dgvAMeAdded.Rows.Remove(currentRow);
        }

        private void dgvAMeAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvAMeAvailable.CurrentRow;

            DataTable dishes = (DataTable)dgvAMeAdded.DataSource;

            DataRow dataRow = dishes.NewRow();

            dataRow["DIS_ID"] = currentRow.Cells["DIS_ID"].Value;
            dataRow["DIS_NAME"] = currentRow.Cells["DIS_NAME"].Value;
            dataRow["MDR_MEN_ID"] = 0;
            dataRow["MDR_QUANTITY"] = 0;

            dishes.Rows.Add(dataRow);

            dgvAMeAvailable.Rows.Remove(currentRow);
        }
    }
}
