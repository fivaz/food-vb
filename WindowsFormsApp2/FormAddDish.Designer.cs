namespace WindowsFormsApp2
{
    partial class FormAddDish
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
            this.tbxADiName = new System.Windows.Forms.TextBox();
            this.lblADiName = new System.Windows.Forms.Label();
            this.lblADiCategory = new System.Windows.Forms.Label();
            this.cbbADiCategory = new System.Windows.Forms.ComboBox();
            this.btnADiSubmit = new System.Windows.Forms.Button();
            this.lblADiPrice = new System.Windows.Forms.Label();
            this.gpbADiIngredients = new System.Windows.Forms.GroupBox();
            this.lblADiAvaSearch = new System.Windows.Forms.Label();
            this.dgvADiAvailable = new System.Windows.Forms.DataGridView();
            this.lblADiAvailable = new System.Windows.Forms.Label();
            this.tbxADiAvaSearch = new System.Windows.Forms.TextBox();
            this.lblADiAddSearch = new System.Windows.Forms.Label();
            this.dgvADiAdded = new System.Windows.Forms.DataGridView();
            this.lblADiAdded = new System.Windows.Forms.Label();
            this.tbxADiAddSearch = new System.Windows.Forms.TextBox();
            this.gpbADiIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADiAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADiAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxADiName
            // 
            this.tbxADiName.Location = new System.Drawing.Point(35, 62);
            this.tbxADiName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxADiName.Multiline = true;
            this.tbxADiName.Name = "tbxADiName";
            this.tbxADiName.Size = new System.Drawing.Size(132, 22);
            this.tbxADiName.TabIndex = 2;
            // 
            // lblADiName
            // 
            this.lblADiName.AutoSize = true;
            this.lblADiName.Location = new System.Drawing.Point(35, 40);
            this.lblADiName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiName.Name = "lblADiName";
            this.lblADiName.Size = new System.Drawing.Size(37, 17);
            this.lblADiName.TabIndex = 1;
            this.lblADiName.Text = "&Nom";
            // 
            // lblADiCategory
            // 
            this.lblADiCategory.AutoSize = true;
            this.lblADiCategory.Location = new System.Drawing.Point(590, 40);
            this.lblADiCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiCategory.Name = "lblADiCategory";
            this.lblADiCategory.Size = new System.Drawing.Size(69, 17);
            this.lblADiCategory.TabIndex = 3;
            this.lblADiCategory.Text = "&Catégorie";
            // 
            // cbbADiCategory
            // 
            this.cbbADiCategory.FormattingEnabled = true;
            this.cbbADiCategory.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.cbbADiCategory.Location = new System.Drawing.Point(593, 61);
            this.cbbADiCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbADiCategory.Name = "cbbADiCategory";
            this.cbbADiCategory.Size = new System.Drawing.Size(125, 24);
            this.cbbADiCategory.TabIndex = 4;
            // 
            // btnADiSubmit
            // 
            this.btnADiSubmit.Location = new System.Drawing.Point(327, 476);
            this.btnADiSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnADiSubmit.Name = "btnADiSubmit";
            this.btnADiSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnADiSubmit.TabIndex = 14;
            this.btnADiSubmit.Text = "&Créer";
            this.btnADiSubmit.UseVisualStyleBackColor = true;
            this.btnADiSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblADiPrice
            // 
            this.lblADiPrice.AutoSize = true;
            this.lblADiPrice.Location = new System.Drawing.Point(579, 484);
            this.lblADiPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiPrice.Name = "lblADiPrice";
            this.lblADiPrice.Size = new System.Drawing.Size(123, 17);
            this.lblADiPrice.TabIndex = 8;
            this.lblADiPrice.Text = "Prix calculé: 29.43";
            // 
            // gpbADiIngredients
            // 
            this.gpbADiIngredients.Controls.Add(this.lblADiAvaSearch);
            this.gpbADiIngredients.Controls.Add(this.dgvADiAvailable);
            this.gpbADiIngredients.Controls.Add(this.lblADiAvailable);
            this.gpbADiIngredients.Controls.Add(this.tbxADiAvaSearch);
            this.gpbADiIngredients.Controls.Add(this.lblADiAddSearch);
            this.gpbADiIngredients.Controls.Add(this.dgvADiAdded);
            this.gpbADiIngredients.Controls.Add(this.lblADiAdded);
            this.gpbADiIngredients.Controls.Add(this.tbxADiAddSearch);
            this.gpbADiIngredients.Location = new System.Drawing.Point(35, 105);
            this.gpbADiIngredients.Name = "gpbADiIngredients";
            this.gpbADiIngredients.Size = new System.Drawing.Size(683, 344);
            this.gpbADiIngredients.TabIndex = 5;
            this.gpbADiIngredients.TabStop = false;
            this.gpbADiIngredients.Text = "Ingrédients";
            this.gpbADiIngredients.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblADiAvaSearch
            // 
            this.lblADiAvaSearch.AutoSize = true;
            this.lblADiAvaSearch.Location = new System.Drawing.Point(352, 62);
            this.lblADiAvaSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiAvaSearch.Name = "lblADiAvaSearch";
            this.lblADiAvaSearch.Size = new System.Drawing.Size(82, 17);
            this.lblADiAvaSearch.TabIndex = 10;
            this.lblADiAvaSearch.Text = "Rechercher";
            // 
            // dgvADiAvailable
            // 
            this.dgvADiAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvADiAvailable.Location = new System.Drawing.Point(352, 113);
            this.dgvADiAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvADiAvailable.Name = "dgvADiAvailable";
            this.dgvADiAvailable.RowHeadersWidth = 51;
            this.dgvADiAvailable.Size = new System.Drawing.Size(315, 218);
            this.dgvADiAvailable.TabIndex = 13;
            // 
            // lblADiAvailable
            // 
            this.lblADiAvailable.AutoSize = true;
            this.lblADiAvailable.Location = new System.Drawing.Point(352, 25);
            this.lblADiAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiAvailable.Name = "lblADiAvailable";
            this.lblADiAvailable.Size = new System.Drawing.Size(81, 17);
            this.lblADiAvailable.TabIndex = 9;
            this.lblADiAvailable.Text = "&Disponibles";
            // 
            // tbxADiAvaSearch
            // 
            this.tbxADiAvaSearch.Location = new System.Drawing.Point(352, 83);
            this.tbxADiAvaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxADiAvaSearch.Name = "tbxADiAvaSearch";
            this.tbxADiAvaSearch.Size = new System.Drawing.Size(315, 22);
            this.tbxADiAvaSearch.TabIndex = 11;
            // 
            // lblADiAddSearch
            // 
            this.lblADiAddSearch.AutoSize = true;
            this.lblADiAddSearch.Location = new System.Drawing.Point(17, 62);
            this.lblADiAddSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiAddSearch.Name = "lblADiAddSearch";
            this.lblADiAddSearch.Size = new System.Drawing.Size(82, 17);
            this.lblADiAddSearch.TabIndex = 7;
            this.lblADiAddSearch.Text = "Rechercher";
            // 
            // dgvADiAdded
            // 
            this.dgvADiAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvADiAdded.Location = new System.Drawing.Point(17, 113);
            this.dgvADiAdded.Margin = new System.Windows.Forms.Padding(4);
            this.dgvADiAdded.Name = "dgvADiAdded";
            this.dgvADiAdded.RowHeadersWidth = 51;
            this.dgvADiAdded.Size = new System.Drawing.Size(315, 218);
            this.dgvADiAdded.TabIndex = 12;
            this.dgvADiAdded.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblADiAdded
            // 
            this.lblADiAdded.AutoSize = true;
            this.lblADiAdded.Location = new System.Drawing.Point(17, 25);
            this.lblADiAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADiAdded.Name = "lblADiAdded";
            this.lblADiAdded.Size = new System.Drawing.Size(55, 17);
            this.lblADiAdded.TabIndex = 6;
            this.lblADiAdded.Text = "&Ajoutés";
            this.lblADiAdded.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxADiAddSearch
            // 
            this.tbxADiAddSearch.Location = new System.Drawing.Point(17, 83);
            this.tbxADiAddSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxADiAddSearch.Name = "tbxADiAddSearch";
            this.tbxADiAddSearch.Size = new System.Drawing.Size(315, 22);
            this.tbxADiAddSearch.TabIndex = 8;
            this.tbxADiAddSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormAddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 537);
            this.Controls.Add(this.gpbADiIngredients);
            this.Controls.Add(this.lblADiPrice);
            this.Controls.Add(this.btnADiSubmit);
            this.Controls.Add(this.cbbADiCategory);
            this.Controls.Add(this.lblADiCategory);
            this.Controls.Add(this.lblADiName);
            this.Controls.Add(this.tbxADiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddDish";
            this.Text = "Nouveau plat";
            this.Load += new System.EventHandler(this.FormAddDish_Load);
            this.gpbADiIngredients.ResumeLayout(false);
            this.gpbADiIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADiAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADiAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxADiName;
        private System.Windows.Forms.Label lblADiName;
        private System.Windows.Forms.Label lblADiCategory;
        private System.Windows.Forms.ComboBox cbbADiCategory;
        private System.Windows.Forms.Button btnADiSubmit;
        private System.Windows.Forms.Label lblADiPrice;
        private System.Windows.Forms.GroupBox gpbADiIngredients;
        private System.Windows.Forms.DataGridView dgvADiAdded;
        private System.Windows.Forms.Label lblADiAdded;
        private System.Windows.Forms.TextBox tbxADiAddSearch;
        private System.Windows.Forms.Label lblADiAvaSearch;
        private System.Windows.Forms.DataGridView dgvADiAvailable;
        private System.Windows.Forms.Label lblADiAvailable;
        private System.Windows.Forms.TextBox tbxADiAvaSearch;
        private System.Windows.Forms.Label lblADiAddSearch;
    }
}