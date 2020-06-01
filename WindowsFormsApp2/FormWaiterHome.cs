using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp2.dish;
using WindowsFormsApp2.order;

namespace WindowsFormsApp2
{
    public partial class FormWaiterHome : Form
    {
        public FormWaiterHome()
        {
            InitializeComponent();
        }
        private void FormWaiterHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VW_TABLE' table. You can move, or remove it, as needed.
            this.vW_TABLETableAdapter.Fill(this.dataSet1.VW_TABLE);
            dgvWHoCategory1.DataSource = new DishORM().ListFromMenu("Entrée");
            dgvWHoCategory2.DataSource = new DishORM().ListFromMenu("Plat principal");
            //
            dgvWHoCategory4.DataSource = new DishORM().ListFromMenu("Dessert");
            formatDgv(dgvWHoCategory1);
            formatDgv(dgvWHoCategory2);
            formatDgv(dgvWHoCategory4);
            initializeDgvDishes();
            formatDgv(dgvWHoDish);
        }

        private void formatDgv(DataGridView dgv)
        {
            dgv.Columns["DIS_ID"].Visible = false;
            dgv.Columns["DIS_CAT_ID"].Visible = false;
            dgv.Columns["DIS_NAME"].HeaderText = "nom";
            dgv.Columns["DIS_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["CAT_NAME"].HeaderText = "catégorie";
            dgv.Columns["CAT_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["PURCHASE_PRICE"].HeaderText = "prix";
            dgv.Columns["PURCHASE_PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["MDR_DIS_ID"].Visible = false;
            dgv.Columns["MDR_MEN_ID"].Visible = false;
            dgv.Columns["MDR_QUANTITY"].HeaderText = "quantité";
            dgv.Columns["MDR_QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns["USE_MEN_ID"].Visible = false;
            dgv.AllowUserToAddRows = false;
        }

        private void initializeDgvDishes()
        {
            DataGridViewColumn colId = new DataGridViewTextBoxColumn();
            DataGridViewColumn colCatId = new DataGridViewTextBoxColumn();
            DataGridViewColumn colName = new DataGridViewTextBoxColumn();
            DataGridViewColumn colCatName = new DataGridViewTextBoxColumn();
            DataGridViewColumn colPrice = new DataGridViewTextBoxColumn();
            DataGridViewColumn colQuantity = new DataGridViewTextBoxColumn();
            DataGridViewColumn colId2 = new DataGridViewTextBoxColumn();
            DataGridViewColumn colMenId = new DataGridViewTextBoxColumn();
            DataGridViewColumn colMenId2 = new DataGridViewTextBoxColumn();

            colId.Name = "DIS_ID";
            colCatId.Name = "DIS_CAT_ID";
            colName.Name = "DIS_NAME";
            colCatName.Name = "CAT_NAME";
            colPrice.Name = "PURCHASE_PRICE";
            colId2.Name = "MDR_DIS_ID";
            colMenId.Name = "MDR_MEN_ID";
            colQuantity.Name = "MDR_QUANTITY";
            colMenId2.Name = "USE_MEN_ID";

            DataGridViewColumn[] columns = {
                colId,
                colCatId,
                colName,
                colCatName,
                colPrice,
                colId2,
                colMenId,
                colQuantity,
                colMenId2
            };

            dgvWHoDish.Columns.AddRange(columns);
        }

        private void btnWHoHistory_Click(object sender, EventArgs e)
        {
            new FormOrdersHistory().Show();
        }

        private void dgvWHoCategory1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addDisheToOrder(dgvWHoCategory1);
        }

        private void addDisheToOrder(DataGridView dgv)
        {
            DataGridViewRow currentRow = dgv.CurrentRow;

            int index = dgvWHoDish.Rows.Add();
            DataGridViewRow dataGridViewRow = dgvWHoDish.Rows[index];
            dataGridViewRow.Cells["DIS_ID"].Value = currentRow.Cells["DIS_ID"].Value;
            dataGridViewRow.Cells["DIS_CAT_ID"].Value = currentRow.Cells["DIS_CAT_ID"].Value;
            dataGridViewRow.Cells["DIS_NAME"].Value = currentRow.Cells["DIS_NAME"].Value;
            dataGridViewRow.Cells["CAT_NAME"].Value = currentRow.Cells["CAT_NAME"].Value;
            dataGridViewRow.Cells["PURCHASE_PRICE"].Value = currentRow.Cells["PURCHASE_PRICE"].Value;
            dataGridViewRow.Cells["MDR_DIS_ID"].Value = currentRow.Cells["MDR_DIS_ID"].Value;
            dataGridViewRow.Cells["MDR_MEN_ID"].Value = currentRow.Cells["MDR_MEN_ID"].Value;
            dataGridViewRow.Cells["MDR_QUANTITY"].Value = currentRow.Cells["MDR_QUANTITY"].Value;
            dataGridViewRow.Cells["USE_MEN_ID"].Value = currentRow.Cells["USE_MEN_ID"].Value;

            dgv.Rows.Remove(currentRow);
        }

        private void dgvWHoCategory2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addDisheToOrder(dgvWHoCategory2);
        }

        private void dgvWHoCategory3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvWHoCategory4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addDisheToOrder(dgvWHoCategory4);
        }

        private void dgvWHoDish_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removeDishFromOrder();
        }
        //Category can only have 4 possible values it should be an ENUM
        private void removeDishFromOrder()
        {
            DataGridViewRow currentRow = dgvWHoDish.CurrentRow;

            string categoryName = currentRow.Cells["CAT_NAME"].Value.ToString();
            DataGridView dgv = null;
            switch (categoryName)
            {
                case "Entrée":
                    dgv = this.dgvWHoCategory1;
                    Console.WriteLine("Entrée");
                    break;
                case "Plat principal":
                    dgv = this.dgvWHoCategory2;
                    Console.WriteLine("Plat");
                    break;
                case "Boisson":
                    dgv = this.dgvWHoCategory3;
                    Console.WriteLine("Boisson");
                    break;
                case "Dessert":
                    dgv = this.dgvWHoCategory4;
                    Console.WriteLine("Dessert");
                    break;
            }
            DataTable dataTable = (DataTable) dgv.DataSource;

            DataRow dataRow = dataTable.NewRow();
            dataRow["DIS_ID"] = currentRow.Cells["DIS_ID"].Value;
            dataRow["DIS_CAT_ID"] = currentRow.Cells["DIS_CAT_ID"].Value;
            dataRow["DIS_NAME"] = currentRow.Cells["DIS_NAME"].Value;
            dataRow["CAT_NAME"] = currentRow.Cells["CAT_NAME"].Value;
            dataRow["PURCHASE_PRICE"] = currentRow.Cells["PURCHASE_PRICE"].Value;
            dataRow["MDR_DIS_ID"] = currentRow.Cells["MDR_DIS_ID"].Value;
            dataRow["MDR_MEN_ID"] = currentRow.Cells["MDR_MEN_ID"].Value;
            dataRow["MDR_QUANTITY"] = currentRow.Cells["MDR_QUANTITY"].Value;
            dataRow["USE_MEN_ID"] = currentRow.Cells["USE_MEN_ID"].Value;

            dataTable.Rows.Add(dataRow);

            dgvWHoDish.Rows.Remove(currentRow);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWHoSubmit_Click(object sender, EventArgs e)
        {
            Create();
        }
        public void Create()
        {
            OrderORM orderORM = new OrderORM();
            int orderId = orderORM.Create(Build());
            List<Dish> addedDishes = getAddedDishes();
            Console.WriteLine(addedDishes.Count);
            foreach (Dish dish in addedDishes)
                orderORM.addRelation(orderId, dish);
        }

        public Order Build()
        {
            //TODO
            int accountId = 1;
            int tableId = Convert.ToInt32(cbxWHoTable.SelectedValue.ToString());
            return new Order(0, accountId, tableId, DateTime.Now);
        }

        public List<Dish> getAddedDishes()
        {
            List<Dish> dishes = new List<Dish>();
            foreach (DataGridViewRow row in dgvWHoDish.Rows)
            {
                int dishId = Convert.ToInt32(row.Cells["DIS_ID"].Value.ToString());
                double quantity = Convert.ToDouble(row.Cells["MDR_QUANTITY"].Value.ToString());

                Dish dish = new Dish(dishId, 0, null, 0, quantity);
                dishes.Add(dish);
            }
            return dishes;
        }
    }
}
