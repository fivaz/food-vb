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
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMen = new System.Windows.Forms.DataGridView();
            this.btnMenDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenAdd
            // 
            this.btnMenAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenAdd.Location = new System.Drawing.Point(667, 38);
            this.btnMenAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenAdd.Name = "btnMenAdd";
            this.btnMenAdd.Size = new System.Drawing.Size(129, 30);
            this.btnMenAdd.TabIndex = 32;
            this.btnMenAdd.Text = "&nouveau menu";
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
            this.lblMenSearchName.Location = new System.Drawing.Point(34, 22);
            this.lblMenSearchName.Name = "lblMenSearchName";
            this.lblMenSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblMenSearchName.TabIndex = 1;
            this.lblMenSearchName.Text = "Rechercher";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Supprimer";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Modifier";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Price";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantite";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unité";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Width = 125;
            // 
            // clnName
            // 
            this.clnName.HeaderText = "Nom";
            this.clnName.MinimumWidth = 6;
            this.clnName.Name = "clnName";
            this.clnName.Width = 125;
            // 
            // dgvMen
            // 
            this.dgvMen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.Unit,
            this.Quantity,
            this.Prix,
            this.Edit,
            this.Delete});
            this.dgvMen.Location = new System.Drawing.Point(36, 92);
            this.dgvMen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMen.Name = "dgvMen";
            this.dgvMen.RowHeadersWidth = 51;
            this.dgvMen.RowTemplate.Height = 24;
            this.dgvMen.Size = new System.Drawing.Size(892, 368);
            this.dgvMen.TabIndex = 12;
            // 
            // btnMenDelAll
            // 
            this.btnMenDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenDelAll.Location = new System.Drawing.Point(821, 38);
            this.btnMenDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenDelAll.Name = "btnMenDelAll";
            this.btnMenDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnMenDelAll.TabIndex = 11;
            this.btnMenDelAll.Text = "&supprimer";
            this.btnMenDelAll.UseVisualStyleBackColor = true;
            // 
            // frmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.btnMenAdd);
            this.Controls.Add(this.lblMenSearchName);
            this.Controls.Add(this.tbxMenSearchName);
            this.Controls.Add(this.dgvMen);
            this.Controls.Add(this.btnMenDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridView dgvMen;
        private System.Windows.Forms.Button btnMenDelAll;
    }
}