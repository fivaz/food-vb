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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerPlatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerPlatsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerPlatsToolStripMenuItem,
            this.gérerPlatsToolStripMenuItem1,
            this.gérerMenuToolStripMenuItem,
            this.autresToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerPlatsToolStripMenuItem
            // 
            this.gérerPlatsToolStripMenuItem.Name = "gérerPlatsToolStripMenuItem";
            this.gérerPlatsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.gérerPlatsToolStripMenuItem.Text = "Gérer Plats";
            this.gérerPlatsToolStripMenuItem.Click += new System.EventHandler(this.gérerPlatsToolStripMenuItem_Click);
            // 
            // gérerPlatsToolStripMenuItem1
            // 
            this.gérerPlatsToolStripMenuItem1.Name = "gérerPlatsToolStripMenuItem1";
            this.gérerPlatsToolStripMenuItem1.Size = new System.Drawing.Size(109, 20);
            this.gérerPlatsToolStripMenuItem1.Text = "Gérer Ingredients";
            this.gérerPlatsToolStripMenuItem1.Click += new System.EventHandler(this.gérerPlatsToolStripMenuItem1_Click);
            // 
            // gérerMenuToolStripMenuItem
            // 
            this.gérerMenuToolStripMenuItem.Name = "gérerMenuToolStripMenuItem";
            this.gérerMenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.gérerMenuToolStripMenuItem.Text = "Gérer Menu";
            // 
            // autresToolStripMenuItem
            // 
            this.autresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerTablesToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.gérerToolStripMenuItem1});
            this.autresToolStripMenuItem.Name = "autresToolStripMenuItem";
            this.autresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.autresToolStripMenuItem.Text = "Autres";
            // 
            // gérerTablesToolStripMenuItem
            // 
            this.gérerTablesToolStripMenuItem.Name = "gérerTablesToolStripMenuItem";
            this.gérerTablesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.gérerTablesToolStripMenuItem.Text = "Gérer Tables";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.gérerToolStripMenuItem.Text = "Gérer Comptes";
            // 
            // gérerToolStripMenuItem1
            // 
            this.gérerToolStripMenuItem1.Name = "gérerToolStripMenuItem1";
            this.gérerToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.gérerToolStripMenuItem1.Text = "Gérer Catégories";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // FormManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormManagerHome";
            this.ShowIcon = false;
            this.Text = "Page d\'accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerPlatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerPlatsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gérerMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
    }
}