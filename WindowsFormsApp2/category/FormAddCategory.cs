using System.Windows.Forms;
using WindowsFormsApp2.category;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2
{
    public partial class FormAddCategory : Form, FormAdd<Category>
    {
        internal int id;
        internal bool editMode = false;

        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void btnACaSubmit_Click(object sender, System.EventArgs e)
        {
            if (editMode)
                Edit();
            else
                Create();
            ClearForm();
        }
        private void FormAddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCategories form = FormCategories.getInstance();
            form.refreshData();
        }

        public Category Build()
        {
            string name = tbxACaName.Text.ToString();
            return new Category(id, name);
        }
        public void ClearForm()
        {
            tbxACaName.Text = "";
        }
        public void Create()
        {
            CategoryORM categoryORM = new CategoryORM();
            categoryORM.Create(Build());
        }

        public void Edit()
        {
            CategoryORM categoryORM = new CategoryORM();
            Category category = Build();
            categoryORM.Edit(category);
        }

        public void SetEditMode()
        {
            btnACaSubmit.Text = "Modifier &category";
            editMode = true;
        }

    }
}
