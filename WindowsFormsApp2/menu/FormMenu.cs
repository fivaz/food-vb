using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.menu;

namespace WindowsFormsApp2
{
    public partial class FormMenus : Form
    {
        static FormMenus instance;
        public FormMenus()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormMenus getInstance()
        {
            if (instance == null)
                new FormMenus();
            return instance;
        }

        private void FormMenus_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        internal void RefreshData()
        {
            dgvMen.DataSource = new MenuORM().ListAll();
            dgvMen.Columns["MEN_ID"].Visible = false;
            dgvMen.Columns["MEN_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMen.Columns["MEN_NAME"].HeaderText = "nom";
            dgvMen.AllowUserToAddRows = false;

            dgvMen.Rows
                .OfType<DataGridViewRow>()
                 .Where(x => Convert.ToInt32(x.Cells["MEN_ID"].Value) == new MenuORM().getUsed())
                 .ToArray<DataGridViewRow>()[0]
                 .DefaultCellStyle.BackColor = Color.Gray;
        }

        private void btnMenAdd_Click(object sender, EventArgs e)
        {
            new FormAddMenu().Show();
        }

        private void btnMenDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvMen.CurrentRow.Cells[0].Value.ToString());
            new MenuORM().Delete(id);
            RefreshData();
        }

        private void dgvMen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddMenu fa = new FormAddMenu();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvMen.CurrentRow.Cells[0].Value.ToString());
            fa.tbxAMeName.Text = dgvMen.CurrentRow.Cells["MEN_NAME"].Value.ToString();
            
            fa.ShowDialog();
        }

        private void btnMenUsed_Click(object sender, EventArgs e)
        {
            int menuId = Convert.ToInt32(dgvMen.CurrentRow.Cells["MEN_ID"].Value.ToString());
            new MenuORM().UseMenu(menuId);
            RefreshData();
        }
    }
}
