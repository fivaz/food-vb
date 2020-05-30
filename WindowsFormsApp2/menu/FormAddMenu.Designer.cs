namespace WindowsFormsApp2
{
    partial class FormAddMenu
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
            this.gbxAMenuItem = new System.Windows.Forms.GroupBox();
            this.lblAMeAvaSearch = new System.Windows.Forms.Label();
            this.dgvAMeAvailable = new System.Windows.Forms.DataGridView();
            this.lblAMeAvailable = new System.Windows.Forms.Label();
            this.tbxAMeAvaSearch = new System.Windows.Forms.TextBox();
            this.lblAMeAddSearch = new System.Windows.Forms.Label();
            this.dgvAMeAdded = new System.Windows.Forms.DataGridView();
            this.lblAMeAdded = new System.Windows.Forms.Label();
            this.tbxAMeAddSearch = new System.Windows.Forms.TextBox();
            this.lblAMePrice = new System.Windows.Forms.Label();
            this.btnAMeSubmit = new System.Windows.Forms.Button();
            this.lblAMeName = new System.Windows.Forms.Label();
            this.tbxAMeName = new System.Windows.Forms.TextBox();
            this.gbxAMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAMeAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAMeAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAMenuItem
            // 
            this.gbxAMenuItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAMenuItem.Controls.Add(this.lblAMeAvaSearch);
            this.gbxAMenuItem.Controls.Add(this.dgvAMeAvailable);
            this.gbxAMenuItem.Controls.Add(this.lblAMeAvailable);
            this.gbxAMenuItem.Controls.Add(this.tbxAMeAvaSearch);
            this.gbxAMenuItem.Controls.Add(this.lblAMeAddSearch);
            this.gbxAMenuItem.Controls.Add(this.dgvAMeAdded);
            this.gbxAMenuItem.Controls.Add(this.lblAMeAdded);
            this.gbxAMenuItem.Controls.Add(this.tbxAMeAddSearch);
            this.gbxAMenuItem.Location = new System.Drawing.Point(38, 98);
            this.gbxAMenuItem.Name = "gbxAMenuItem";
            this.gbxAMenuItem.Size = new System.Drawing.Size(683, 344);
            this.gbxAMenuItem.TabIndex = 3;
            this.gbxAMenuItem.TabStop = false;
            this.gbxAMenuItem.Text = "Items";
            // 
            // lblAMeAvaSearch
            // 
            this.lblAMeAvaSearch.AutoSize = true;
            this.lblAMeAvaSearch.Location = new System.Drawing.Point(347, 62);
            this.lblAMeAvaSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMeAvaSearch.Name = "lblAMeAvaSearch";
            this.lblAMeAvaSearch.Size = new System.Drawing.Size(82, 17);
            this.lblAMeAvaSearch.TabIndex = 9;
            this.lblAMeAvaSearch.Text = "Rechercher";
            // 
            // dgvAMeAvailable
            // 
            this.dgvAMeAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAMeAvailable.Location = new System.Drawing.Point(350, 113);
            this.dgvAMeAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAMeAvailable.Name = "dgvAMeAvailable";
            this.dgvAMeAvailable.RowHeadersWidth = 51;
            this.dgvAMeAvailable.Size = new System.Drawing.Size(315, 218);
            this.dgvAMeAvailable.TabIndex = 11;
            // 
            // lblAMeAvailable
            // 
            this.lblAMeAvailable.AutoSize = true;
            this.lblAMeAvailable.Location = new System.Drawing.Point(347, 25);
            this.lblAMeAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMeAvailable.Name = "lblAMeAvailable";
            this.lblAMeAvailable.Size = new System.Drawing.Size(81, 17);
            this.lblAMeAvailable.TabIndex = 8;
            this.lblAMeAvailable.Text = "&Disponibles";
            // 
            // tbxAMeAvaSearch
            // 
            this.tbxAMeAvaSearch.Location = new System.Drawing.Point(350, 83);
            this.tbxAMeAvaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAMeAvaSearch.Name = "tbxAMeAvaSearch";
            this.tbxAMeAvaSearch.Size = new System.Drawing.Size(150, 22);
            this.tbxAMeAvaSearch.TabIndex = 10;
            // 
            // lblAMeAddSearch
            // 
            this.lblAMeAddSearch.AutoSize = true;
            this.lblAMeAddSearch.Location = new System.Drawing.Point(15, 62);
            this.lblAMeAddSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMeAddSearch.Name = "lblAMeAddSearch";
            this.lblAMeAddSearch.Size = new System.Drawing.Size(82, 17);
            this.lblAMeAddSearch.TabIndex = 5;
            this.lblAMeAddSearch.Text = "Rechercher";
            // 
            // dgvAMeAdded
            // 
            this.dgvAMeAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAMeAdded.Location = new System.Drawing.Point(18, 113);
            this.dgvAMeAdded.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAMeAdded.Name = "dgvAMeAdded";
            this.dgvAMeAdded.RowHeadersWidth = 51;
            this.dgvAMeAdded.Size = new System.Drawing.Size(315, 218);
            this.dgvAMeAdded.TabIndex = 7;
            // 
            // lblAMeAdded
            // 
            this.lblAMeAdded.AutoSize = true;
            this.lblAMeAdded.Location = new System.Drawing.Point(15, 25);
            this.lblAMeAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMeAdded.Name = "lblAMeAdded";
            this.lblAMeAdded.Size = new System.Drawing.Size(55, 17);
            this.lblAMeAdded.TabIndex = 4;
            this.lblAMeAdded.Text = "&Ajoutés";
            // 
            // tbxAMeAddSearch
            // 
            this.tbxAMeAddSearch.Location = new System.Drawing.Point(18, 83);
            this.tbxAMeAddSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAMeAddSearch.Name = "tbxAMeAddSearch";
            this.tbxAMeAddSearch.Size = new System.Drawing.Size(150, 22);
            this.tbxAMeAddSearch.TabIndex = 6;
            // 
            // lblAMePrice
            // 
            this.lblAMePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAMePrice.AutoSize = true;
            this.lblAMePrice.Location = new System.Drawing.Point(591, 467);
            this.lblAMePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMePrice.Name = "lblAMePrice";
            this.lblAMePrice.Size = new System.Drawing.Size(123, 17);
            this.lblAMePrice.TabIndex = 15;
            this.lblAMePrice.Text = "Prix calculé: 29.43";
            // 
            // btnAMeSubmit
            // 
            this.btnAMeSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAMeSubmit.Location = new System.Drawing.Point(329, 461);
            this.btnAMeSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAMeSubmit.Name = "btnAMeSubmit";
            this.btnAMeSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnAMeSubmit.TabIndex = 13;
            this.btnAMeSubmit.Text = "&Créer";
            this.btnAMeSubmit.UseVisualStyleBackColor = true;
            this.btnAMeSubmit.Click += new System.EventHandler(this.btnAMeSubmit_Click);
            // 
            // lblAMeName
            // 
            this.lblAMeName.AutoSize = true;
            this.lblAMeName.Location = new System.Drawing.Point(35, 35);
            this.lblAMeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMeName.Name = "lblAMeName";
            this.lblAMeName.Size = new System.Drawing.Size(37, 17);
            this.lblAMeName.TabIndex = 1;
            this.lblAMeName.Text = "&Nom";
            // 
            // tbxAMeName
            // 
            this.tbxAMeName.Location = new System.Drawing.Point(38, 56);
            this.tbxAMeName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAMeName.Name = "tbxAMeName";
            this.tbxAMeName.Size = new System.Drawing.Size(132, 22);
            this.tbxAMeName.TabIndex = 2;
            // 
            // FormAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 529);
            this.Controls.Add(this.gbxAMenuItem);
            this.Controls.Add(this.lblAMePrice);
            this.Controls.Add(this.btnAMeSubmit);
            this.Controls.Add(this.lblAMeName);
            this.Controls.Add(this.tbxAMeName);
            this.MaximizeBox = false;
            this.Name = "FormAddMenu";
            this.Text = "Nouveau menu";
            this.Load += new System.EventHandler(this.FormAddMenu_Load);
            this.Resize += new System.EventHandler(this.FormAddMenu_Resize);
            this.gbxAMenuItem.ResumeLayout(false);
            this.gbxAMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAMeAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAMeAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAMenuItem;
        private System.Windows.Forms.Label lblAMeAvaSearch;
        private System.Windows.Forms.DataGridView dgvAMeAvailable;
        private System.Windows.Forms.Label lblAMeAvailable;
        private System.Windows.Forms.TextBox tbxAMeAvaSearch;
        private System.Windows.Forms.Label lblAMeAddSearch;
        private System.Windows.Forms.DataGridView dgvAMeAdded;
        private System.Windows.Forms.Label lblAMeAdded;
        private System.Windows.Forms.TextBox tbxAMeAddSearch;
        private System.Windows.Forms.Label lblAMePrice;
        private System.Windows.Forms.Button btnAMeSubmit;
        private System.Windows.Forms.Label lblAMeName;
        public System.Windows.Forms.TextBox tbxAMeName;
    }
}