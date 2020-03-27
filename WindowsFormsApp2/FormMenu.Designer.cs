namespace WindowsFormsApp2
{
    partial class frmMenus
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
            this.btnMenAdd = new System.Windows.Forms.Button();
            this.tbxMenSearchName = new System.Windows.Forms.TextBox();
            this.lblMenSearchName = new System.Windows.Forms.Label();
            this.dgvMen = new System.Windows.Forms.DataGridView();
            this.btnMenDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenAdd
            // 
            this.btnMenAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenAdd.Location = new System.Drawing.Point(562, 39);
            this.btnMenAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenAdd.Name = "btnMenAdd";
            this.btnMenAdd.Size = new System.Drawing.Size(129, 30);
            this.btnMenAdd.TabIndex = 3;
            this.btnMenAdd.Text = "&Nouveau menu";
            this.btnMenAdd.UseVisualStyleBackColor = true;
            this.btnMenAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxMenSearchName
            // 
            this.tbxMenSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxMenSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMenSearchName.Name = "tbxMenSearchName";
            this.tbxMenSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxMenSearchName.TabIndex = 2;
            // 
            // lblMenSearchName
            // 
            this.lblMenSearchName.AutoSize = true;
            this.lblMenSearchName.Location = new System.Drawing.Point(34, 24);
            this.lblMenSearchName.Name = "lblMenSearchName";
            this.lblMenSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblMenSearchName.TabIndex = 1;
            this.lblMenSearchName.Text = "&Rechercher";
            // 
            // dgvMen
            // 
            this.dgvMen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMen.Location = new System.Drawing.Point(36, 92);
            this.dgvMen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMen.Name = "dgvMen";
            this.dgvMen.RowHeadersWidth = 51;
            this.dgvMen.RowTemplate.Height = 24;
            this.dgvMen.Size = new System.Drawing.Size(787, 339);
            this.dgvMen.TabIndex = 5;
            // 
            // btnMenDelAll
            // 
            this.btnMenDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenDelAll.Location = new System.Drawing.Point(716, 39);
            this.btnMenDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenDelAll.Name = "btnMenDelAll";
            this.btnMenDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnMenDelAll.TabIndex = 4;
            this.btnMenDelAll.Text = "&Supprimer";
            this.btnMenDelAll.UseVisualStyleBackColor = true;
            // 
            // frmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 454);
            this.Controls.Add(this.btnMenAdd);
            this.Controls.Add(this.lblMenSearchName);
            this.Controls.Add(this.tbxMenSearchName);
            this.Controls.Add(this.dgvMen);
            this.Controls.Add(this.btnMenDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(602, 220);
            this.Name = "frmMenus";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.FormMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenAdd;
        private System.Windows.Forms.TextBox tbxMenSearchName;
        private System.Windows.Forms.Label lblMenSearchName;
        private System.Windows.Forms.DataGridView dgvMen;
        private System.Windows.Forms.Button btnMenDelAll;
    }
}