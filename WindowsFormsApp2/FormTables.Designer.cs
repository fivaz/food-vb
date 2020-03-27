namespace WindowsFormsApp2
{
    partial class FormTables
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
            this.btnTabAdd = new System.Windows.Forms.Button();
            this.tbxTabSearch = new System.Windows.Forms.TextBox();
            this.lblTabSearch = new System.Windows.Forms.Label();
            this.dgvTab = new System.Windows.Forms.DataGridView();
            this.btnTabDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTabAdd
            // 
            this.btnTabAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabAdd.Location = new System.Drawing.Point(532, 38);
            this.btnTabAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTabAdd.Name = "btnTabAdd";
            this.btnTabAdd.Size = new System.Drawing.Size(129, 30);
            this.btnTabAdd.TabIndex = 3;
            this.btnTabAdd.Text = "&Nouvelle table";
            this.btnTabAdd.UseVisualStyleBackColor = true;
            this.btnTabAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxTabSearch
            // 
            this.tbxTabSearch.Location = new System.Drawing.Point(35, 46);
            this.tbxTabSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTabSearch.Name = "tbxTabSearch";
            this.tbxTabSearch.Size = new System.Drawing.Size(227, 22);
            this.tbxTabSearch.TabIndex = 2;
            // 
            // lblTabSearch
            // 
            this.lblTabSearch.AutoSize = true;
            this.lblTabSearch.Location = new System.Drawing.Point(35, 22);
            this.lblTabSearch.Name = "lblTabSearch";
            this.lblTabSearch.Size = new System.Drawing.Size(82, 17);
            this.lblTabSearch.TabIndex = 1;
            this.lblTabSearch.Text = "&Rechercher";
            // 
            // dgvTab
            // 
            this.dgvTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab.Location = new System.Drawing.Point(35, 92);
            this.dgvTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTab.Name = "dgvTab";
            this.dgvTab.RowHeadersWidth = 51;
            this.dgvTab.RowTemplate.Height = 24;
            this.dgvTab.Size = new System.Drawing.Size(757, 324);
            this.dgvTab.TabIndex = 5;
            // 
            // btnTabDelAll
            // 
            this.btnTabDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabDelAll.Location = new System.Drawing.Point(685, 38);
            this.btnTabDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTabDelAll.Name = "btnTabDelAll";
            this.btnTabDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnTabDelAll.TabIndex = 4;
            this.btnTabDelAll.Text = "&Supprimer";
            this.btnTabDelAll.UseVisualStyleBackColor = true;
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 445);
            this.Controls.Add(this.btnTabAdd);
            this.Controls.Add(this.lblTabSearch);
            this.Controls.Add(this.tbxTabSearch);
            this.Controls.Add(this.dgvTab);
            this.Controls.Add(this.btnTabDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(601, 220);
            this.Name = "FormTables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.FormTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabAdd;
        private System.Windows.Forms.TextBox tbxTabSearch;
        private System.Windows.Forms.Label lblTabSearch;
        private System.Windows.Forms.DataGridView dgvTab;
        private System.Windows.Forms.Button btnTabDelAll;
    }
}