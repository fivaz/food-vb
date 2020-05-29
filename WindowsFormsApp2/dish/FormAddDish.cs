using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp2.dish;
using WindowsFormsApp2.ingredient;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2
{
    public partial class FormAddDish : Form, FormAdd<Dish>
    {
        public int id;
        public bool editMode = false;
        public List<Ingredient> addedIgredients;

        public FormAddDish()
        {
            InitializeComponent();
            this.vW_CATEGORYTableAdapter.Fill(this.dataSet6.VW_CATEGORY);
        }

        public Dish Build()
        {
            int categoryId = Int32.Parse(cbbADiCategory.SelectedValue.ToString());
            string name = tbxADiName.Text.ToString();
            return new Dish(id, categoryId, name);
        }

        public void ClearForm()
        {
            cbbADiCategory.SelectedIndex = 0;
            tbxADiName.Text = "";
        }

        public void Create()
        {
            DishORM dishORM = new DishORM();
            dishORM.Create(Build());
        }

        public void Edit()
        {
            DishORM dishORM = new DishORM();
            dishORM.Edit(Build());
        }

        public void SetEditMode()
        {
            btnADiSubmit.Text = "Modifier &plat";
            editMode = true;
        }

        private void FormAddDish_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.VW_CATEGORY' table. You can move, or remove it, as needed.
            IngredientORM ingredientORM = new IngredientORM();
            
            dgvADiAdded.DataSource = ingredientORM.SearchFromDish(id);
            dgvADiAvailable.DataSource = ingredientORM.SearchExceptFromDish(id);

            formatDgv(dgvADiAdded);
            formatDgv(dgvADiAvailable);
            
            resizeGrids();
        }

        private void formatDgv(DataGridView dgv)
        {
            //dgv.Columns[0].Visible = false;
            //dgv.Columns[1].Visible = false;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[2].HeaderText = "nom";
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[3].HeaderText = "comptable";
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[4].HeaderText = "unité";
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[5].HeaderText = "prix";
            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[6].HeaderText = "quantité";
            dgv.Columns[7].Visible = false;
        }

        private void btnADiSubmit_Click(object sender, EventArgs e)
        {
            if (editMode)
                Edit();
            else
                Create();
            ClearForm();
        }

        private void FormAddDish_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDishes form = FormDishes.getInstance();
            form.RefreshData();
        }

        private void FormAddDish_Resize(object sender, EventArgs e)
        {
            resizeGrids();
        }

        private void resizeGrids()
        {
            dgvADiAdded.Width = gpbADiIngredients.Width / 2 - 2;
            dgvADiAvailable.Left = gpbADiIngredients.Left + dgvADiAdded.Width;
            dgvADiAvailable.Width = gpbADiIngredients.Width / 2 - 36;
            tbxADiAvaSearch.Left = dgvADiAvailable.Left;
            lblADiAvailable.Left = dgvADiAvailable.Left;
            lblADiAvaSearch.Left = dgvADiAvailable.Left;
        }

        private void tbxADiAvaSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxADiAddSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvADiAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAvailable.CurrentRow;
            Console.WriteLine(Int32.Parse(currentRow.Cells[0].Value.ToString()));

            DataTable addedIngredients  = (DataTable) dgvADiAdded.DataSource;

            DataRow dataRow = addedIngredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells[0].Value;
            dataRow["DIR_DIS_ID"] = id;
            dataRow["ING_NAME"] = currentRow.Cells[2].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells[3].Value;
            dataRow["ING_UNIT"] = currentRow.Cells[4].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells[5].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells[6].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells[7].Value;
            
            addedIngredients.Rows.Add(dataRow);
            
            dgvADiAvailable.Rows.Remove(currentRow);
        }

        private void dgvADiAdded_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAdded.CurrentRow;
            Console.WriteLine(Int32.Parse(currentRow.Cells[0].Value.ToString()));

            DataTable availableIngredients = (DataTable)dgvADiAvailable.DataSource;

            DataRow dataRow = availableIngredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells[0].Value;
            dataRow["DIR_DIS_ID"] = id;
            dataRow["ING_NAME"] = currentRow.Cells[2].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells[3].Value;
            dataRow["ING_UNIT"] = currentRow.Cells[4].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells[5].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells[6].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells[7].Value;

            availableIngredients.Rows.Add(dataRow);

            dgvADiAdded.Rows.Remove(currentRow);
        }
    }
}
