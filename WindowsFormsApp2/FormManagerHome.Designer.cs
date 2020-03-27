namespace WindowsFormsApp2
{
    partial class FormManagerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mstManager = new System.Windows.Forms.MenuStrip();
            this.msiMHoDishes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoIngredients = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoTables = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoStats = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMHoHorizontalAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMHoLogout = new System.Windows.Forms.Button();
            this.msiMHoverticalAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mstManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstManager
            // 
            this.mstManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiMHoDishes,
            this.msiMHoIngredients,
            this.msiMHoMenus,
            this.msiMHoOthers,
            this.msiMHoStats,
            this.msiMHoWindows});
            this.mstManager.Location = new System.Drawing.Point(0, 0);
            this.mstManager.MdiWindowListItem = this.msiMHoWindows;
            this.mstManager.Name = "mstManager";
            this.mstManager.Size = new System.Drawing.Size(1277, 28);
            this.mstManager.TabIndex = 4;
            this.mstManager.Text = "menuStrip1";
            this.mstManager.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstManager_ItemClicked);
            // 
            // msiMHoDishes
            // 
            this.msiMHoDishes.Name = "msiMHoDishes";
            this.msiMHoDishes.Size = new System.Drawing.Size(95, 24);
            this.msiMHoDishes.Text = "Gérer &plats";
            this.msiMHoDishes.Click += new System.EventHandler(this.msiDishes_Click);
            // 
            // msiMHoIngredients
            // 
            this.msiMHoIngredients.Name = "msiMHoIngredients";
            this.msiMHoIngredients.Size = new System.Drawing.Size(137, 24);
            this.msiMHoIngredients.Text = "Gérer &ingrédients";
            this.msiMHoIngredients.Click += new System.EventHandler(this.msiIngredients_Click);
            // 
            // msiMHoMenus
            // 
            this.msiMHoMenus.Name = "msiMHoMenus";
            this.msiMHoMenus.Size = new System.Drawing.Size(100, 24);
            this.msiMHoMenus.Text = "Gérer &menu";
            this.msiMHoMenus.Click += new System.EventHandler(this.msiMenus_Click);
            // 
            // msiMHoOthers
            // 
            this.msiMHoOthers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiMHoTables,
            this.msiMHoAccounts,
            this.msiMHoCategory});
            this.msiMHoOthers.Name = "msiMHoOthers";
            this.msiMHoOthers.Size = new System.Drawing.Size(65, 24);
            this.msiMHoOthers.Text = "&Autres";
            // 
            // msiMHoTables
            // 
            this.msiMHoTables.Name = "msiMHoTables";
            this.msiMHoTables.Size = new System.Drawing.Size(224, 26);
            this.msiMHoTables.Text = "Gérer &tables";
            this.msiMHoTables.Click += new System.EventHandler(this.gérerTablesToolStripMenuItem_Click);
            // 
            // msiMHoAccounts
            // 
            this.msiMHoAccounts.Name = "msiMHoAccounts";
            this.msiMHoAccounts.Size = new System.Drawing.Size(224, 26);
            this.msiMHoAccounts.Text = "Gérer &comptes";
            this.msiMHoAccounts.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // msiMHoCategory
            // 
            this.msiMHoCategory.Name = "msiMHoCategory";
            this.msiMHoCategory.Size = new System.Drawing.Size(224, 26);
            this.msiMHoCategory.Text = "&Gérer catégories";
            this.msiMHoCategory.Click += new System.EventHandler(this.gérerToolStripMenuItem1_Click);
            // 
            // msiMHoStats
            // 
            this.msiMHoStats.Name = "msiMHoStats";
            this.msiMHoStats.Size = new System.Drawing.Size(99, 24);
            this.msiMHoStats.Text = "&Statistiques";
            this.msiMHoStats.Click += new System.EventHandler(this.msiStats_Click);
            // 
            // msiMHoWindows
            // 
            this.msiMHoWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiMHoHorizontalAlign,
            this.msiMHoverticalAlign});
            this.msiMHoWindows.Name = "msiMHoWindows";
            this.msiMHoWindows.Size = new System.Drawing.Size(132, 24);
            this.msiMHoWindows.Text = "Gérer les fenêtre";
            this.msiMHoWindows.Click += new System.EventHandler(this.fenêtreToolStripMenuItem_Click);
            // 
            // msiMHoHorizontalAlign
            // 
            this.msiMHoHorizontalAlign.Name = "msiMHoHorizontalAlign";
            this.msiMHoHorizontalAlign.Size = new System.Drawing.Size(253, 26);
            this.msiMHoHorizontalAlign.Text = "Aligner horizontalement";
            this.msiMHoHorizontalAlign.Click += new System.EventHandler(this.alignerToolStripMenuItem_Click);
            // 
            // btnMHoLogout
            // 
            this.btnMHoLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMHoLogout.Location = new System.Drawing.Point(1144, -1);
            this.btnMHoLogout.Name = "btnMHoLogout";
            this.btnMHoLogout.Size = new System.Drawing.Size(127, 30);
            this.btnMHoLogout.TabIndex = 6;
            this.btnMHoLogout.Text = "Se &déconnecter";
            this.btnMHoLogout.UseVisualStyleBackColor = true;
            // 
            // msiMHoverticalAlign
            // 
            this.msiMHoverticalAlign.Name = "msiMHoverticalAlign";
            this.msiMHoverticalAlign.Size = new System.Drawing.Size(253, 26);
            this.msiMHoverticalAlign.Text = "Aligner verticalement";
            this.msiMHoverticalAlign.Click += new System.EventHandler(this.alignerVerticalementToolStripMenuItem_Click);
            // 
            // FormManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 388);
            this.Controls.Add(this.btnMHoLogout);
            this.Controls.Add(this.mstManager);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstManager;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(678, 200);
            this.Name = "FormManagerHome";
            this.ShowIcon = false;
            this.Text = "Page d\'accueil";
            this.mstManager.ResumeLayout(false);
            this.mstManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip mstManager;
        private System.Windows.Forms.ToolStripMenuItem msiMHoDishes;
        private System.Windows.Forms.ToolStripMenuItem msiMHoIngredients;
        private System.Windows.Forms.ToolStripMenuItem msiMHoMenus;
        private System.Windows.Forms.ToolStripMenuItem msiMHoOthers;
        private System.Windows.Forms.ToolStripMenuItem msiMHoTables;
        private System.Windows.Forms.ToolStripMenuItem msiMHoAccounts;
        private System.Windows.Forms.ToolStripMenuItem msiMHoCategory;
        private System.Windows.Forms.ToolStripMenuItem msiMHoStats;
        private System.Windows.Forms.Button btnMHoLogout;
        private System.Windows.Forms.ToolStripMenuItem msiMHoWindows;
        private System.Windows.Forms.ToolStripMenuItem msiMHoHorizontalAlign;
        private System.Windows.Forms.ToolStripMenuItem msiMHoverticalAlign;
    }
}