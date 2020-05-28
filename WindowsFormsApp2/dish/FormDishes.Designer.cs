namespace WindowsFormsApp2
{
    partial class FormDishes
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
            this.dgvDis = new System.Windows.Forms.DataGridView();
            this.btnDisDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisAdd
            // 
            this.btnDisAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisAdd.Location = new System.Drawing.Point(888, 38);
            this.btnDisAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisAdd.Name = "btnDisAdd";
            this.btnDisAdd.Size = new System.Drawing.Size(129, 30);
            this.btnDisAdd.TabIndex = 11;
            this.btnDisAdd.Text = "&Nouveau plat";
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
            this.lblDisSearchName.Text = "&Rechercher";
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
            this.lblDisSearchPrice.Text = "&Prix entre";
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
            this.lblDisSearchQuantity.Text = "&Quantité entre";
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
            this.tbxDisSearchQuantityTo.TabIndex = 10;
            // 
            // lblDisSearchQuantityAnd
            // 
            this.lblDisSearchQuantityAnd.AutoSize = true;
            this.lblDisSearchQuantityAnd.Location = new System.Drawing.Point(555, 51);
            this.lblDisSearchQuantityAnd.Name = "lblDisSearchQuantityAnd";
            this.lblDisSearchQuantityAnd.Size = new System.Drawing.Size(20, 17);
            this.lblDisSearchQuantityAnd.TabIndex = 9;
            this.lblDisSearchQuantityAnd.Text = "et";
            // 
            // dgvDis
            // 
            this.dgvDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDis.Location = new System.Drawing.Point(36, 92);
            this.dgvDis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDis.Name = "dgvDis";
            this.dgvDis.RowHeadersWidth = 51;
            this.dgvDis.RowTemplate.Height = 24;
            this.dgvDis.Size = new System.Drawing.Size(1113, 383);
            this.dgvDis.TabIndex = 13;
            // 
            // btnDisDelAll
            // 
            this.btnDisDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisDelAll.Location = new System.Drawing.Point(1042, 38);
            this.btnDisDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisDelAll.Name = "btnDisDelAll";
            this.btnDisDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnDisDelAll.TabIndex = 12;
            this.btnDisDelAll.Text = "&Supprimer";
            this.btnDisDelAll.UseVisualStyleBackColor = true;
            // 
            // FormDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 498);
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
            this.MinimumSize = new System.Drawing.Size(980, 217);
            this.Name = "FormDishes";
            this.Text = "Plats";
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
        private System.Windows.Forms.DataGridView dgvDis;
        private System.Windows.Forms.Button btnDisDelAll;
    }
}