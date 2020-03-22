namespace WindowsFormsApp2
{
    partial class frmDishes
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
            this.btnDisAdd = new System.Windows.Forms.Button();
            this.tbxDisSearchName = new System.Windows.Forms.TextBox();
            this.lblDisSearchName = new System.Windows.Forms.Label();
            this.tbxDisSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.lblDisSearchPrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDisSearchPriceAnd = new System.Windows.Forms.Label();
            this.lblDisSearchQuantity = new System.Windows.Forms.Label();
            this.tbxDisSearchQuantityFrom = new System.Windows.Forms.TextBox();
            this.tbxDisSearchQuantityTo = new System.Windows.Forms.TextBox();
            this.lblDisSearchQuantityAnd = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDis = new System.Windows.Forms.DataGridView();
            this.btnDisDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisAdd
            // 
            this.btnDisAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisAdd.Location = new System.Drawing.Point(667, 38);
            this.btnDisAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisAdd.Name = "btnDisAdd";
            this.btnDisAdd.Size = new System.Drawing.Size(129, 30);
            this.btnDisAdd.TabIndex = 32;
            this.btnDisAdd.Text = "&nouvel ingredient";
            this.btnDisAdd.UseVisualStyleBackColor = true;
            this.btnDisAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxDisSearchName
            // 
            this.tbxDisSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxDisSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDisSearchName.Name = "tbxDisSearchName";
            this.tbxDisSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxDisSearchName.TabIndex = 2;
            // 
            // lblDisSearchName
            // 
            this.lblDisSearchName.AutoSize = true;
            this.lblDisSearchName.Location = new System.Drawing.Point(34, 22);
            this.lblDisSearchName.Name = "lblDisSearchName";
            this.lblDisSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblDisSearchName.TabIndex = 1;
            this.lblDisSearchName.Text = "Rechercher";
            // 
            // tbxDisSearchPriceFrom
            // 
            this.tbxDisSearchPriceFrom.Location = new System.Drawing.Point(291, 46);
            this.tbxDisSearchPriceFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDisSearchPriceFrom.Name = "tbxDisSearchPriceFrom";
            this.tbxDisSearchPriceFrom.Size = new System.Drawing.Size(65, 22);
            this.tbxDisSearchPriceFrom.TabIndex = 4;
            // 
            // lblDisSearchPrice
            // 
            this.lblDisSearchPrice.AutoSize = true;
            this.lblDisSearchPrice.Location = new System.Drawing.Point(287, 22);
            this.lblDisSearchPrice.Name = "lblDisSearchPrice";
            this.lblDisSearchPrice.Size = new System.Drawing.Size(68, 17);
            this.lblDisSearchPrice.TabIndex = 3;
            this.lblDisSearchPrice.Text = "Prix entre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 46);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 22);
            this.textBox3.TabIndex = 6;
            // 
            // lblDisSearchPriceAnd
            // 
            this.lblDisSearchPriceAnd.AutoSize = true;
            this.lblDisSearchPriceAnd.Location = new System.Drawing.Point(361, 51);
            this.lblDisSearchPriceAnd.Name = "lblDisSearchPriceAnd";
            this.lblDisSearchPriceAnd.Size = new System.Drawing.Size(20, 17);
            this.lblDisSearchPriceAnd.TabIndex = 5;
            this.lblDisSearchPriceAnd.Text = "et";
            // 
            // lblDisSearchQuantity
            // 
            this.lblDisSearchQuantity.AutoSize = true;
            this.lblDisSearchQuantity.Location = new System.Drawing.Point(481, 22);
            this.lblDisSearchQuantity.Name = "lblDisSearchQuantity";
            this.lblDisSearchQuantity.Size = new System.Drawing.Size(99, 17);
            this.lblDisSearchQuantity.TabIndex = 7;
            this.lblDisSearchQuantity.Text = "Quantité entre";
            // 
            // tbxDisSearchQuantityFrom
            // 
            this.tbxDisSearchQuantityFrom.Location = new System.Drawing.Point(484, 46);
            this.tbxDisSearchQuantityFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDisSearchQuantityFrom.Name = "tbxDisSearchQuantityFrom";
            this.tbxDisSearchQuantityFrom.Size = new System.Drawing.Size(65, 22);
            this.tbxDisSearchQuantityFrom.TabIndex = 8;
            // 
            // tbxDisSearchQuantityTo
            // 
            this.tbxDisSearchQuantityTo.Location = new System.Drawing.Point(580, 46);
            this.tbxDisSearchQuantityTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDisSearchQuantityTo.Name = "tbxDisSearchQuantityTo";
            this.tbxDisSearchQuantityTo.Size = new System.Drawing.Size(65, 22);
            this.tbxDisSearchQuantityTo.TabIndex = 30;
            // 
            // lblDisSearchQuantityAnd
            // 
            this.lblDisSearchQuantityAnd.AutoSize = true;
            this.lblDisSearchQuantityAnd.Location = new System.Drawing.Point(555, 51);
            this.lblDisSearchQuantityAnd.Name = "lblDisSearchQuantityAnd";
            this.lblDisSearchQuantityAnd.Size = new System.Drawing.Size(20, 17);
            this.lblDisSearchQuantityAnd.TabIndex = 31;
            this.lblDisSearchQuantityAnd.Text = "et";
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
            // dgvDis
            // 
            this.dgvDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.Unit,
            this.Quantity,
            this.Prix,
            this.Edit,
            this.Delete});
            this.dgvDis.Location = new System.Drawing.Point(36, 92);
            this.dgvDis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDis.Name = "dgvDis";
            this.dgvDis.RowHeadersWidth = 51;
            this.dgvDis.RowTemplate.Height = 24;
            this.dgvDis.Size = new System.Drawing.Size(892, 368);
            this.dgvDis.TabIndex = 12;
            // 
            // btnDisDelAll
            // 
            this.btnDisDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisDelAll.Location = new System.Drawing.Point(821, 38);
            this.btnDisDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisDelAll.Name = "btnDisDelAll";
            this.btnDisDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnDisDelAll.TabIndex = 11;
            this.btnDisDelAll.Text = "&supprimer";
            this.btnDisDelAll.UseVisualStyleBackColor = true;
            // 
            // frmDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.btnDisAdd);
            this.Controls.Add(this.lblDisSearchQuantityAnd);
            this.Controls.Add(this.tbxDisSearchQuantityTo);
            this.Controls.Add(this.tbxDisSearchQuantityFrom);
            this.Controls.Add(this.lblDisSearchQuantity);
            this.Controls.Add(this.lblDisSearchPriceAnd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblDisSearchPrice);
            this.Controls.Add(this.tbxDisSearchPriceFrom);
            this.Controls.Add(this.lblDisSearchName);
            this.Controls.Add(this.tbxDisSearchName);
            this.Controls.Add(this.dgvDis);
            this.Controls.Add(this.btnDisDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDishes";
            this.Text = "Dishes";
            this.Load += new System.EventHandler(this.FormDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisAdd;
        private System.Windows.Forms.TextBox tbxDisSearchName;
        private System.Windows.Forms.Label lblDisSearchName;
        private System.Windows.Forms.TextBox tbxDisSearchPriceFrom;
        private System.Windows.Forms.Label lblDisSearchPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDisSearchPriceAnd;
        private System.Windows.Forms.Label lblDisSearchQuantity;
        private System.Windows.Forms.TextBox tbxDisSearchQuantityFrom;
        private System.Windows.Forms.TextBox tbxDisSearchQuantityTo;
        private System.Windows.Forms.Label lblDisSearchQuantityAnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridView dgvDis;
        private System.Windows.Forms.Button btnDisDelAll;
    }
}