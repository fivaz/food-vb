namespace WindowsFormsApp2
{
    partial class FormMenus
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
            this.tbxMenSearch = new System.Windows.Forms.TextBox();
            this.lblMenSearch = new System.Windows.Forms.Label();
            this.dgvMen = new System.Windows.Forms.DataGridView();
            this.btnMenDel = new System.Windows.Forms.Button();
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
            this.btnMenAdd.Click += new System.EventHandler(this.btnMenAdd_Click);
            // 
            // tbxMenSearch
            // 
            this.tbxMenSearch.Location = new System.Drawing.Point(36, 46);
            this.tbxMenSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMenSearch.Name = "tbxMenSearch";
            this.tbxMenSearch.Size = new System.Drawing.Size(227, 22);
            this.tbxMenSearch.TabIndex = 2;
            // 
            // lblMenSearch
            // 
            this.lblMenSearch.AutoSize = true;
            this.lblMenSearch.Location = new System.Drawing.Point(34, 24);
            this.lblMenSearch.Name = "lblMenSearch";
            this.lblMenSearch.Size = new System.Drawing.Size(82, 17);
            this.lblMenSearch.TabIndex = 1;
            this.lblMenSearch.Text = "&Rechercher";
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
            this.dgvMen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMen_CellDoubleClick);
            // 
            // btnMenDel
            // 
            this.btnMenDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenDel.Location = new System.Drawing.Point(716, 39);
            this.btnMenDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenDel.Name = "btnMenDel";
            this.btnMenDel.Size = new System.Drawing.Size(107, 30);
            this.btnMenDel.TabIndex = 4;
            this.btnMenDel.Text = "&Supprimer";
            this.btnMenDel.UseVisualStyleBackColor = true;
            this.btnMenDel.Click += new System.EventHandler(this.btnMenDel_Click);
            // 
            // FormMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 454);
            this.Controls.Add(this.btnMenAdd);
            this.Controls.Add(this.lblMenSearch);
            this.Controls.Add(this.tbxMenSearch);
            this.Controls.Add(this.dgvMen);
            this.Controls.Add(this.btnMenDel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(602, 220);
            this.Name = "FormMenus";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.FormMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenAdd;
        private System.Windows.Forms.TextBox tbxMenSearch;
        private System.Windows.Forms.Label lblMenSearch;
        private System.Windows.Forms.DataGridView dgvMen;
        private System.Windows.Forms.Button btnMenDel;
    }
}