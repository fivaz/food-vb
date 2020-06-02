using System;
using System.Drawing;
using System.Linq;
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
            dgvIng.DataSource = new IngredientORM().ListAll();

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
            
            dgvIng.Rows
                .OfType<DataGridViewRow>()
                 .Where(x => Convert.ToInt32(x.Cells["ING_QUANTITY"].Value) <= Convert.ToInt32(x.Cells["ING_MINIMUM_QUANTITY"].Value))
                 .ToArray<DataGridViewRow>()[0]
                 .DefaultCellStyle.BackColor = Color.Red;

        }

        internal void RefreshData()
        {
            dgvIng.DataSource = new IngredientORM().ListAll();
        }

        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            new FormAddIngredient().Show();
        }

        private void btnIngDelAll_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvIng.CurrentRow.Cells[0].Value.ToString());
            new IngredientORM().Delete(id);
            RefreshData();
        }

        private void dgvIng_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddIngredient fa = new FormAddIngredient();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvIng.CurrentRow.Cells[0].Value.ToString());

            bool isCountable = dgvIng.CurrentRow.Cells["ING_IS_COUNTABLE"].Value.ToString().Equals("1");
            if (isCountable)
                fa.rbtAInCountable.Checked = true;
            else
                fa.rbtAInUncoutable.Checked = true;
            fa.tbxAInName.Text = dgvIng.CurrentRow.Cells["ING_NAME"].Value.ToString();
            fa.cbxAInUnity.Text = dgvIng.CurrentRow.Cells["ING_UNIT"].Value.ToString();
            fa.tbxAInPrice.Text = dgvIng.CurrentRow.Cells["ING_PURCHASE_PRICE"].Value.ToString();
            fa.tbxAInQuantity.Text = dgvIng.CurrentRow.Cells["ING_QUANTITY"].Value.ToString();
            fa.tbxAInMQuantity.Text = dgvIng.CurrentRow.Cells["ING_MINIMUM_QUANTITY"].Value.ToString();

            fa.ShowDialog();
        }

        //TODO filters
    }
}
