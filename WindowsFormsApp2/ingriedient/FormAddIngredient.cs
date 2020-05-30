using System;
using System.Windows.Forms;
using WindowsFormsApp2.ingredient;

namespace WindowsFormsApp2
{
    public partial class FormAddIngredient : Form
    {
        internal int id;
        internal bool editMode = false;

        public FormAddIngredient()
        {
            InitializeComponent();
        }

        private void btnAInSubmit_Click(object sender, System.EventArgs e)
        {
            if (editMode)
                Edit();
            else
                Create();
            ClearForm();
        }

        public Ingredient Build()
        {
            bool isCountable = rbtAInCountable.Checked;
            string name = tbxAInName.Text.ToString();
            string unity = cbxAInUnity.Text.ToString();
            double price = Convert.ToDouble(tbxAInPrice.Text.ToString());
            double? quantity = Convert.ToDouble(tbxAInQuantity.Text.ToString());
            double miminumQuantity = Convert.ToDouble(tbxAInMQuantity.Text.ToString());

            return new Ingredient(id, 0, name, isCountable, unity, quantity, price, miminumQuantity);
        }
        public void ClearForm()
        {
            rbtAInCountable.Checked = true;
            tbxAInName.Text = "";
            cbxAInUnity.Text = "";
            tbxAInPrice.Text = "";
            tbxAInQuantity.Text = "";
            tbxAInMQuantity.Text = "";
        }
        public void Create()
        {
            IngredientORM ingredientORM = new IngredientORM();
            int id = ingredientORM.Create(Build());
        }

        public void Edit()
        {
            IngredientORM ingredientORM = new IngredientORM();
            Ingredient ingredient = Build();
            ingredientORM.Edit(ingredient);
        }
        
        public void SetEditMode()
        {
            btnAInSubmit.Text = "Modifier &ingredient";
            editMode = true;
        }

        private void FormAddIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIngredients form = FormIngredients.getInstance();
            form.RefreshData();
        }
    }
}
