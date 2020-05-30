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

        public FormAddDish()
        {
            InitializeComponent();
            this.vW_CATEGORYTableAdapter.Fill(this.dataSet6.VW_CATEGORY);
        }

        private void FormAddDish_Load(object sender, EventArgs e)
        {
            IngredientORM ingredientORM = new IngredientORM();

            dgvADiAdded.DataSource = ingredientORM.SearchFromDish(id);
            dgvADiAvailable.DataSource = ingredientORM.SearchExceptFromDish(id);

            formatAddedDgv(dgvADiAdded);
            formatDgv(dgvADiAvailable);

            resizeGrids();
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
            //int dishId = 999;
            int dishId = dishORM.Create(Build());
            IngredientORM ingredientORM = new IngredientORM();
            List<Ingredient> addedIgredients = getAddedIngredients(dishId);
            foreach (Ingredient ingredient in addedIgredients)
                ingredientORM.addRelation(ingredient);
        }

        public List<Ingredient> getAddedIngredients(int dishId)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (DataGridViewRow row in dgvADiAdded.Rows)
            {
                int ingredientId = Convert.ToInt32(row.Cells[0].Value.ToString());
                double? quantity = null;
                if (!string.IsNullOrEmpty(row.Cells[6].Value.ToString()))
                    quantity = Convert.ToDouble(row.Cells[6].Value.ToString());

                Console.WriteLine("ingredientId " + ingredientId);
                Console.WriteLine("dishId " + dishId);
                Console.WriteLine("quantity " + quantity);

                Ingredient ingredient = new Ingredient(ingredientId, dishId, null, false, null, quantity, 0, 0);
                ingredients.Add(ingredient);
            }
            return ingredients;
        }

        public void Edit()
        {
            DishORM dishORM = new DishORM();
            dishORM.Edit(Build());
            IngredientORM ingredientORM = new IngredientORM();
            ingredientORM.DeleteAllRelations(id);
            List<Ingredient> addedIgredients = getAddedIngredients(id);
            foreach (Ingredient ingredient in addedIgredients)
                ingredientORM.addRelation(ingredient);
        }

        public void SetEditMode()
        {
            btnADiSubmit.Text = "Modifier &plat";
            editMode = true;
        }

        private void formatAddedDgv(DataGridView dgv)
        {
            dgv.Columns["ING_ID"].Visible = false;
            dgv.Columns["DIR_DIS_ID"].Visible = false;
            dgv.Columns["DIR_DIS_ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_NAME"].HeaderText = "nom";
            dgv.Columns["ING_IS_COUNTABLE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_IS_COUNTABLE"].HeaderText = "comptable";
            dgv.Columns["ING_UNIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_UNIT"].HeaderText = "unité";
            dgv.Columns["ING_PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_PURCHASE_PRICE"].HeaderText = "prix";
            dgv.Columns["DIR_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["DIR_QUANTITY"].HeaderText = "quantité";
            dgv.Columns["ING_QUANTITY"].Visible= false;
            dgv.Columns["ING_MINIMUM_QUANTITY"].Visible= false;
            dgv.AllowUserToAddRows = false;
        }

        private void formatDgv(DataGridView dgv)
        {
            dgv.Columns["ING_ID"].Visible = false;
            dgv.Columns["ING_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_NAME"].HeaderText = "nom";
            dgv.Columns["ING_IS_COUNTABLE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_IS_COUNTABLE"].HeaderText = "comptable";
            dgv.Columns["ING_UNIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_UNIT"].HeaderText = "unité";
            dgv.Columns["ING_PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_PURCHASE_PRICE"].HeaderText = "prix";
            dgv.Columns["ING_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_QUANTITY"].HeaderText = "quantité";
            dgv.Columns["ING_MINIMUM_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["ING_MINIMUM_QUANTITY"].HeaderText = "quantité minimum";
            dgv.AllowUserToAddRows = false;
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
            //TODO implementer filtre 
        }

        private void tbxADiAddSearch_TextChanged(object sender, EventArgs e)
        {
            //TODO implementer filtre 
        }


        private void dgvADiAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAvailable.CurrentRow;

            DataTable ingredients = (DataTable)dgvADiAdded.DataSource;

            DataRow dataRow = ingredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells["ING_ID"].Value;
            dataRow["DIR_DIS_ID"] = id;
            dataRow["ING_NAME"] = currentRow.Cells["ING_NAME"].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells["ING_IS_COUNTABLE"].Value;
            dataRow["ING_UNIT"] = currentRow.Cells["ING_UNIT"].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells["ING_PURCHASE_PRICE"].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells["ING_QUANTITY"].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells["ING_MINIMUM_QUANTITY"].Value;

            ingredients.Rows.Add(dataRow);

            dgvADiAvailable.Rows.Remove(currentRow);
        }

        private void dgvADiAdded_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAdded.CurrentRow;

            DataTable ingredients = (DataTable)dgvADiAvailable.DataSource;

            DataRow dataRow = ingredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells["ING_ID"].Value;
            dataRow["ING_NAME"] = currentRow.Cells["ING_NAME"].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells["ING_IS_COUNTABLE"].Value;
            dataRow["ING_UNIT"] = currentRow.Cells["ING_UNIT"].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells["ING_PURCHASE_PRICE"].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells["ING_QUANTITY"].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells["ING_MINIMUM_QUANTITY"].Value;

            ingredients.Rows.Add(dataRow);

            dgvADiAdded.Rows.Remove(currentRow);
        }
    }
}
