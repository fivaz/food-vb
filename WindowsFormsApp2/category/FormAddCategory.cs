using System.Windows.Forms;
using WindowsFormsApp2.category;

namespace WindowsFormsApp2
{
    public partial class FormAddCategory : Form
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
                edit();
            else
                create();
            clearForm();
        }

        private Category build()
        {
            string name = tbxACaName.Text.ToString();
            return new Category(id, name);
        }

        private void edit()
        {
            CategoryORM categoryORM = new CategoryORM();
            Category category = build();
            categoryORM.edit(category);
        }

        private void create()
        {
            CategoryORM categoryORM = new CategoryORM();
            categoryORM.create(build());
        }

        internal void setEditMode()
        {
            btnACaSubmit.Text = "Modifier &category";
            editMode = true;
        }

        private void clearForm()
        {
            tbxACaName.Text = "";
        }

        private void FormAddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCategories form = FormCategories.getInstance();
            form.refreshData();
        }
    }
}
