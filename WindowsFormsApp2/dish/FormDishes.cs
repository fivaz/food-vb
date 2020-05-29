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
        }
        public static FormDishes getInstance()
        {
            if (instance == null)
                new FormDishes();
            return instance;
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.VW_DISH' table. You can move, or remove it, as needed.
            this.vW_DISHTableAdapter2.Fill(this.dataSet4.VW_DISH);
            this.dgvDis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvDis.Columns[0].HeaderText = "id";
            this.dgvDis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvDis.Columns[1].HeaderText = "id categorie";
            this.dgvDis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDis.Columns[2].HeaderText = "categorie";
            this.dgvDis.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDis.Columns[3].HeaderText = "nom";
        }

        public void RefreshData()
        {
            dgvDis.DataSource = this.dataSet4.VW_DISH;
            this.vW_DISHTableAdapter2.ClearBeforeFill = true;
            this.vW_DISHTableAdapter2.Fill(this.dataSet4.VW_DISH);
        }

        private void dgvDis_DoubleClick(object sender, EventArgs e)
        {
            FormAddDish fa = new FormAddDish();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvDis.CurrentRow.Cells[0].Value.ToString());
            fa.tbxADiName.Text = this.dgvDis.CurrentRow.Cells[1].Value.ToString();
            fa.cbbADiCategory.Text = this.dgvDis.CurrentRow.Cells[2].Value.ToString();

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
        }

        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            new FormAddDish().Show();
        }
    }
}
