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
            this.msiDishes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiIngredients = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStats = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnection = new System.Windows.Forms.Button();
            this.mstManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstManager
            // 
            this.mstManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDishes,
            this.msiIngredients,
            this.msiMenus,
            this.msiOthers,
            this.msiStats});
            this.mstManager.Location = new System.Drawing.Point(0, 0);
            this.mstManager.Name = "mstManager";
            this.mstManager.Size = new System.Drawing.Size(660, 28);
            this.mstManager.TabIndex = 4;
            this.mstManager.Text = "menuStrip1";
            this.mstManager.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstManager_ItemClicked);
            // 
            // msiDishes
            // 
            this.msiDishes.Name = "msiDishes";
            this.msiDishes.Size = new System.Drawing.Size(95, 24);
            this.msiDishes.Text = "Gérer &plats";
            this.msiDishes.Click += new System.EventHandler(this.msiDishes_Click);
            // 
            // msiIngredients
            // 
            this.msiIngredients.Name = "msiIngredients";
            this.msiIngredients.Size = new System.Drawing.Size(137, 24);
            this.msiIngredients.Text = "Gérer &ingredients";
            this.msiIngredients.Click += new System.EventHandler(this.msiIngredients_Click);
            // 
            // msiMenus
            // 
            this.msiMenus.Name = "msiMenus";
            this.msiMenus.Size = new System.Drawing.Size(100, 24);
            this.msiMenus.Text = "Gérer &menu";
            this.msiMenus.Click += new System.EventHandler(this.msiMenus_Click);
            // 
            // msiOthers
            // 
            this.msiOthers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerTablesToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.gérerToolStripMenuItem1});
            this.msiOthers.Name = "msiOthers";
            this.msiOthers.Size = new System.Drawing.Size(65, 24);
            this.msiOthers.Text = "&Autres";
            // 
            // gérerTablesToolStripMenuItem
            // 
            this.gérerTablesToolStripMenuItem.Name = "gérerTablesToolStripMenuItem";
            this.gérerTablesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gérerTablesToolStripMenuItem.Text = "Gérer &tables";
            this.gérerTablesToolStripMenuItem.Click += new System.EventHandler(this.gérerTablesToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gérerToolStripMenuItem.Text = "Gérer &comptes";
            this.gérerToolStripMenuItem.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem1
            // 
            this.gérerToolStripMenuItem1.Name = "gérerToolStripMenuItem1";
            this.gérerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.gérerToolStripMenuItem1.Text = "&Gérer catégories";
            this.gérerToolStripMenuItem1.Click += new System.EventHandler(this.gérerToolStripMenuItem1_Click);
            // 
            // msiStats
            // 
            this.msiStats.Name = "msiStats";
            this.msiStats.Size = new System.Drawing.Size(99, 24);
            this.msiStats.Text = "&Statistiques";
            this.msiStats.Click += new System.EventHandler(this.msiStats_Click);
            // 
            // déconnection
            // 
            this.déconnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.déconnection.Location = new System.Drawing.Point(527, -1);
            this.déconnection.Name = "déconnection";
            this.déconnection.Size = new System.Drawing.Size(127, 30);
            this.déconnection.TabIndex = 6;
            this.déconnection.Text = "se &déconnecter";
            this.déconnection.UseVisualStyleBackColor = true;
            // 
            // FormManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 153);
            this.Controls.Add(this.déconnection);
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
        private System.Windows.Forms.ToolStripMenuItem msiDishes;
        private System.Windows.Forms.ToolStripMenuItem msiIngredients;
        private System.Windows.Forms.ToolStripMenuItem msiMenus;
        private System.Windows.Forms.ToolStripMenuItem msiOthers;
        private System.Windows.Forms.ToolStripMenuItem gérerTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msiStats;
        private System.Windows.Forms.Button déconnection;
    }
}