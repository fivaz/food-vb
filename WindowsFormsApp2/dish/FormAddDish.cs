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
                if(!string.IsNullOrEmpty(row.Cells[6].Value.ToString()))
                    quantity = Convert.ToDouble(row.Cells[6].Value.ToString());

                Console.WriteLine("ingredientId "+ ingredientId);
                Console.WriteLine("dishId " + dishId);
                Console.WriteLine("quantity "+ quantity);

                Ingredient ingredient = new Ingredient(ingredientId, dishId, null, false, null, quantity, 0, 0);
                ingredients.Add(ingredient);
            }
            return ingredients;
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
            IngredientORM ingredientORM = new IngredientORM();

            dgvADiAdded.DataSource = ingredientORM.SearchFromDish(id);
            dgvADiAvailable.DataSource = ingredientORM.SearchExceptFromDish(id);

            formatDgv(dgvADiAdded);
            formatDgv(dgvADiAvailable);

            resizeGrids();
        }

        private void formatDgv(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;
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

        }

        private void tbxADiAddSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvADiAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAvailable.CurrentRow;

            DataTable ingredients = (DataTable)dgvADiAdded.DataSource;

            DataRow dataRow = ingredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells[0].Value;
            dataRow["DIR_DIS_ID"] = id;
            dataRow["ING_NAME"] = currentRow.Cells[2].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells[3].Value;
            dataRow["ING_UNIT"] = currentRow.Cells[4].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells[5].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells[6].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells[7].Value;

            ingredients.Rows.Add(dataRow);

            dgvADiAvailable.Rows.Remove(currentRow);
        }

        private void dgvADiAdded_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvADiAdded.CurrentRow;

            DataTable ingredients = (DataTable)dgvADiAvailable.DataSource;

            DataRow dataRow = ingredients.NewRow();
            dataRow["ING_ID"] = currentRow.Cells[0].Value;
            dataRow["DIR_DIS_ID"] = id;
            dataRow["ING_NAME"] = currentRow.Cells[2].Value;
            dataRow["ING_IS_COUNTABLE"] = currentRow.Cells[3].Value;
            dataRow["ING_UNIT"] = currentRow.Cells[4].Value;
            dataRow["ING_PURCHASE_PRICE"] = currentRow.Cells[5].Value;
            dataRow["ING_QUANTITY"] = currentRow.Cells[6].Value;
            dataRow["ING_MINIMUM_QUANTITY"] = currentRow.Cells[7].Value;

            ingredients.Rows.Add(dataRow);

            dgvADiAdded.Rows.Remove(currentRow);
        }
    }
}
