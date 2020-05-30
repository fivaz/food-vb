namespace WindowsFormsApp2
{
    partial class FormIngredients
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
            this.tbxIngSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.lblIngSearchPrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblIngSearchPriceAnd = new System.Windows.Forms.Label();
            this.lblIngSearchQuantity = new System.Windows.Forms.Label();
            this.tbxIngSearchQuantityFrom = new System.Windows.Forms.TextBox();
            this.tbxIngSearchQuantityTo = new System.Windows.Forms.TextBox();
            this.lblIngSearchQuantityAnd = new System.Windows.Forms.Label();
            this.dgvIng = new System.Windows.Forms.DataGridView();
            this.btnIngDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngAdd
            // 
            this.btnIngAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngAdd.Location = new System.Drawing.Point(669, 38);
            this.btnIngAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngAdd.Name = "btnIngAdd";
            this.btnIngAdd.Size = new System.Drawing.Size(138, 30);
            this.btnIngAdd.TabIndex = 11;
            this.btnIngAdd.Text = "&Nouvel ingrédient";
            this.btnIngAdd.UseVisualStyleBackColor = true;
            this.btnIngAdd.Click += new System.EventHandler(this.btnIngAdd_Click);
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
            this.lblIngSearchName.Text = "&Rechercher";
            // 
            // tbxIngSearchPriceFrom
            // 
            this.tbxIngSearchPriceFrom.Location = new System.Drawing.Point(291, 46);
            this.tbxIngSearchPriceFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIngSearchPriceFrom.Name = "tbxIngSearchPriceFrom";
            this.tbxIngSearchPriceFrom.Size = new System.Drawing.Size(65, 22);
            this.tbxIngSearchPriceFrom.TabIndex = 4;
            // 
            // lblIngSearchPrice
            // 
            this.lblIngSearchPrice.AutoSize = true;
            this.lblIngSearchPrice.Location = new System.Drawing.Point(287, 22);
            this.lblIngSearchPrice.Name = "lblIngSearchPrice";
            this.lblIngSearchPrice.Size = new System.Drawing.Size(68, 17);
            this.lblIngSearchPrice.TabIndex = 3;
            this.lblIngSearchPrice.Text = "&Prix entre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 46);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 22);
            this.textBox3.TabIndex = 6;
            // 
            // lblIngSearchPriceAnd
            // 
            this.lblIngSearchPriceAnd.AutoSize = true;
            this.lblIngSearchPriceAnd.Location = new System.Drawing.Point(361, 51);
            this.lblIngSearchPriceAnd.Name = "lblIngSearchPriceAnd";
            this.lblIngSearchPriceAnd.Size = new System.Drawing.Size(20, 17);
            this.lblIngSearchPriceAnd.TabIndex = 5;
            this.lblIngSearchPriceAnd.Text = "et";
            // 
            // lblIngSearchQuantity
            // 
            this.lblIngSearchQuantity.AutoSize = true;
            this.lblIngSearchQuantity.Location = new System.Drawing.Point(481, 22);
            this.lblIngSearchQuantity.Name = "lblIngSearchQuantity";
            this.lblIngSearchQuantity.Size = new System.Drawing.Size(99, 17);
            this.lblIngSearchQuantity.TabIndex = 7;
            this.lblIngSearchQuantity.Text = "&Quantité entre";
            // 
            // tbxIngSearchQuantityFrom
            // 
            this.tbxIngSearchQuantityFrom.Location = new System.Drawing.Point(484, 46);
            this.tbxIngSearchQuantityFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIngSearchQuantityFrom.Name = "tbxIngSearchQuantityFrom";
            this.tbxIngSearchQuantityFrom.Size = new System.Drawing.Size(65, 22);
            this.tbxIngSearchQuantityFrom.TabIndex = 8;
            // 
            // tbxIngSearchQuantityTo
            // 
            this.tbxIngSearchQuantityTo.Location = new System.Drawing.Point(580, 46);
            this.tbxIngSearchQuantityTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIngSearchQuantityTo.Name = "tbxIngSearchQuantityTo";
            this.tbxIngSearchQuantityTo.Size = new System.Drawing.Size(65, 22);
            this.tbxIngSearchQuantityTo.TabIndex = 10;
            // 
            // lblIngSearchQuantityAnd
            // 
            this.lblIngSearchQuantityAnd.AutoSize = true;
            this.lblIngSearchQuantityAnd.Location = new System.Drawing.Point(555, 51);
            this.lblIngSearchQuantityAnd.Name = "lblIngSearchQuantityAnd";
            this.lblIngSearchQuantityAnd.Size = new System.Drawing.Size(20, 17);
            this.lblIngSearchQuantityAnd.TabIndex = 9;
            this.lblIngSearchQuantityAnd.Text = "et";
            // 
            // dgvIng
            // 
            this.dgvIng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIng.Location = new System.Drawing.Point(36, 92);
            this.dgvIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIng.Name = "dgvIng";
            this.dgvIng.RowHeadersWidth = 51;
            this.dgvIng.RowTemplate.Height = 24;
            this.dgvIng.Size = new System.Drawing.Size(892, 359);
            this.dgvIng.TabIndex = 13;
            this.dgvIng.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIng_CellDoubleClick);
            // 
            // btnIngDelAll
            // 
            this.btnIngDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngDelAll.Location = new System.Drawing.Point(831, 38);
            this.btnIngDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngDelAll.Name = "btnIngDelAll";
            this.btnIngDelAll.Size = new System.Drawing.Size(96, 30);
            this.btnIngDelAll.TabIndex = 12;
            this.btnIngDelAll.Text = "&Supprimer";
            this.btnIngDelAll.UseVisualStyleBackColor = true;
            this.btnIngDelAll.Click += new System.EventHandler(this.btnIngDelAll_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.btnIngAdd);
            this.Controls.Add(this.lblIngSearchQuantityAnd);
            this.Controls.Add(this.tbxIngSearchQuantityTo);
            this.Controls.Add(this.tbxIngSearchQuantityFrom);
            this.Controls.Add(this.lblIngSearchQuantity);
            this.Controls.Add(this.lblIngSearchPriceAnd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblIngSearchPrice);
            this.Controls.Add(this.tbxIngSearchPriceFrom);
            this.Controls.Add(this.lblIngSearchName);
            this.Controls.Add(this.tbxIngSearchName);
            this.Controls.Add(this.dgvIng);
            this.Controls.Add(this.btnIngDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIngredients";
            this.Text = "Ingrédients";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngAdd;
        private System.Windows.Forms.TextBox tbxIngSearchName;
        private System.Windows.Forms.Label lblIngSearchName;
        private System.Windows.Forms.TextBox tbxIngSearchPriceFrom;
        private System.Windows.Forms.Label lblIngSearchPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblIngSearchPriceAnd;
        private System.Windows.Forms.Label lblIngSearchQuantity;
        private System.Windows.Forms.TextBox tbxIngSearchQuantityFrom;
        private System.Windows.Forms.TextBox tbxIngSearchQuantityTo;
        private System.Windows.Forms.Label lblIngSearchQuantityAnd;
        private System.Windows.Forms.DataGridView dgvIng;
        private System.Windows.Forms.Button btnIngDelAll;
    }
}