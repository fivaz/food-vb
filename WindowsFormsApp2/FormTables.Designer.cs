namespace WindowsFormsApp2
{
    partial class frmTables
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
            this.btnIngAdd = new System.Windows.Forms.Button();
            this.tbxIngSearchName = new System.Windows.Forms.TextBox();
            this.lblIngSearchName = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIng = new System.Windows.Forms.DataGridView();
            this.btnIngDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngAdd
            // 
            this.btnIngAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngAdd.Location = new System.Drawing.Point(667, 38);
            this.btnIngAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngAdd.Name = "btnIngAdd";
            this.btnIngAdd.Size = new System.Drawing.Size(129, 30);
            this.btnIngAdd.TabIndex = 32;
            this.btnIngAdd.Text = "&nouvelle table";
            this.btnIngAdd.UseVisualStyleBackColor = true;
            this.btnIngAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxIngSearchName
            // 
            this.tbxIngSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxIngSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIngSearchName.Name = "tbxIngSearchName";
            this.tbxIngSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxIngSearchName.TabIndex = 2;
            // 
            // lblIngSearchName
            // 
            this.lblIngSearchName.AutoSize = true;
            this.lblIngSearchName.Location = new System.Drawing.Point(34, 22);
            this.lblIngSearchName.Name = "lblIngSearchName";
            this.lblIngSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblIngSearchName.TabIndex = 1;
            this.lblIngSearchName.Text = "Rechercher";
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
            // dgvIng
            // 
            this.dgvIng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.Unit,
            this.Quantity,
            this.Prix,
            this.Edit,
            this.Delete});
            this.dgvIng.Location = new System.Drawing.Point(36, 92);
            this.dgvIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIng.Name = "dgvIng";
            this.dgvIng.RowHeadersWidth = 51;
            this.dgvIng.RowTemplate.Height = 24;
            this.dgvIng.Size = new System.Drawing.Size(892, 368);
            this.dgvIng.TabIndex = 12;
            // 
            // btnIngDelAll
            // 
            this.btnIngDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngDelAll.Location = new System.Drawing.Point(821, 38);
            this.btnIngDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngDelAll.Name = "btnIngDelAll";
            this.btnIngDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnIngDelAll.TabIndex = 11;
            this.btnIngDelAll.Text = "&supprimer";
            this.btnIngDelAll.UseVisualStyleBackColor = true;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.btnIngAdd);
            this.Controls.Add(this.lblIngSearchName);
            this.Controls.Add(this.tbxIngSearchName);
            this.Controls.Add(this.dgvIng);
            this.Controls.Add(this.btnIngDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.FormTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngAdd;
        private System.Windows.Forms.TextBox tbxIngSearchName;
        private System.Windows.Forms.Label lblIngSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridView dgvIng;
        private System.Windows.Forms.Button btnIngDelAll;
    }
}