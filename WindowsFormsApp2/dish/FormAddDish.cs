using System;
using System.Windows.Forms;
using WindowsFormsApp2.dish;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2
{
    public partial class FormAddDish : Form, FormAdd<Dish>
    {
        internal int id;
        internal bool editMode = false;
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
    }
}
