using System;
using System.Windows.Forms;
using WindowsFormsApp2.ingredient;

namespace WindowsFormsApp2
{
    public partial class FormIngredients : Form
    {
        static FormIngredients instance;
        public FormIngredients()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormIngredients getInstance()
        {
            if (instance == null)
                new FormIngredients();
            return instance;
        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {
            IngredientORM ingredientORM = new IngredientORM();
            dgvIng.DataSource = ingredientORM.ListAll();
            dgvIng.Columns["ING_ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_ID"].HeaderText = "id";
            dgvIng.Columns["ING_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvIng.Columns["ING_NAME"].HeaderText = "nom";
            dgvIng.Columns["ING_IS_COUNTABLE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_IS_COUNTABLE"].HeaderText = "comptable";
            dgvIng.Columns["ING_UNIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_UNIT"].HeaderText = "unité";
            dgvIng.Columns["ING_PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_PURCHASE_PRICE"].HeaderText = "prix";
            dgvIng.Columns["ING_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_QUANTITY"].HeaderText = "quantité";
            dgvIng.Columns["ING_MINIMUM_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIng.Columns["ING_MINIMUM_QUANTITY"].HeaderText = "quantité minimum";
        }

        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            new FormAddIngredient().Show();
        }
    }
}
