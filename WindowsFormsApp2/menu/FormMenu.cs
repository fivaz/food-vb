using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.menu;

namespace WindowsFormsApp2
{
    public partial class FormMenus : Form
    {
        int menuUsed = 0;
        static FormMenus instance;
        public FormMenus()
        {
            InitializeComponent();
            instance = this;
            menuUsed = new MenuORM().getUsed();
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
            MenuORM orm = new MenuORM();
            orm.UseMenu(menuId);
            menuUsed = menuId;
            RefreshData();
        }

        private void dgvMen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (menuUsed != 0)
            {
                foreach (DataGridViewRow Myrow in dgvMen.Rows)
                {
                    if (Convert.ToInt32(Myrow.Cells["MEN_ID"].Value) == menuUsed)
                        Myrow.DefaultCellStyle.BackColor = Color.Gray;
                    else
                        Myrow.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
