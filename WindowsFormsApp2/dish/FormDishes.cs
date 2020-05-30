using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp2.dish;

namespace WindowsFormsApp2
{
    public partial class FormDishes : Form
    {
        static FormDishes instance;
        public FormDishes()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormDishes getInstance()
        {
            if (instance == null)
                new FormDishes();
            return instance;
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgvDis.Columns[0].Visible = false;
            dgvDis.Columns[1].Visible = false;
            dgvDis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDis.Columns[2].HeaderText = "nom";
            dgvDis.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDis.Columns[3].HeaderText = "categorie";
            dgvDis.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDis.Columns[4].HeaderText = "coût";
        }

        internal void RefreshData()
        {
            dgvDis.DataSource = new DishORM().ListAll();
        }

        private void dgvDis_DoubleClick(object sender, EventArgs e)
        {
            FormAddDish fa = new FormAddDish();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvDis.CurrentRow.Cells[0].Value.ToString());
            fa.cbbADiCategory.SelectedValue = this.dgvDis.CurrentRow.Cells[1].Value.ToString();
            fa.tbxADiName.Text = this.dgvDis.CurrentRow.Cells[2].Value.ToString();

            fa.ShowDialog();
        }

        private void btnDisDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvDis.CurrentRow.Cells[0].Value.ToString());
            new DishORM().Delete(id);
            RefreshData();
        }

        private void tbxDisSearchName_TextChanged(object sender, EventArgs e)
        {

            if (tbxDisSearchName.Text.Equals(""))
                RefreshData();
            else
            {
                DataTable data = new DishORM().Search(tbxDisSearchName.Text);
                dgvDis.DataSource = data;
            }
            /*
            */
        }
        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            new FormAddDish().Show();
        }
    }
}
