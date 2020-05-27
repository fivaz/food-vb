namespace WindowsFormsApp2
{
    partial class FormCategories
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
            this.components = new System.ComponentModel.Container();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.tbxCatSearchName = new System.Windows.Forms.TextBox();
            this.lblCatSearchName = new System.Windows.Forms.Label();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.cATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWCATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp2.DataSet();
            this.btnCatDel = new System.Windows.Forms.Button();
            this.vW_CATEGORYTableAdapter = new WindowsFormsApp2.DataSetTableAdapters.VW_CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatAdd.Location = new System.Drawing.Point(286, 38);
            this.btnCatAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(148, 30);
            this.btnCatAdd.TabIndex = 3;
            this.btnCatAdd.Text = "&Nouvelle catégorie";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // tbxCatSearchName
            // 
            this.tbxCatSearchName.Location = new System.Drawing.Point(35, 46);
            this.tbxCatSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCatSearchName.Name = "tbxCatSearchName";
            this.tbxCatSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxCatSearchName.TabIndex = 2;
            this.tbxCatSearchName.TextChanged += new System.EventHandler(this.tbxCatSearchName_TextChanged);
            // 
            // lblCatSearchName
            // 
            this.lblCatSearchName.AutoSize = true;
            this.lblCatSearchName.Location = new System.Drawing.Point(32, 27);
            this.lblCatSearchName.Name = "lblCatSearchName";
            this.lblCatSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblCatSearchName.TabIndex = 1;
            this.lblCatSearchName.Text = "&Rechercher";
            // 
            // dgvCat
            // 
            this.dgvCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCat.AutoGenerateColumns = false;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cATIDDataGridViewTextBoxColumn,
            this.cATNAMEDataGridViewTextBoxColumn});
            this.dgvCat.DataSource = this.vWCATEGORYBindingSource;
            this.dgvCat.Location = new System.Drawing.Point(35, 92);
            this.dgvCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.RowHeadersWidth = 51;
            this.dgvCat.RowTemplate.Height = 24;
            this.dgvCat.Size = new System.Drawing.Size(529, 363);
            this.dgvCat.TabIndex = 5;
            this.dgvCat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellDoubleClick);
            // 
            // cATIDDataGridViewTextBoxColumn
            // 
            this.cATIDDataGridViewTextBoxColumn.DataPropertyName = "CAT_ID";
            this.cATIDDataGridViewTextBoxColumn.HeaderText = "CAT_ID";
            this.cATIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATIDDataGridViewTextBoxColumn.Name = "cATIDDataGridViewTextBoxColumn";
            this.cATIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATNAMEDataGridViewTextBoxColumn
            // 
            this.cATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT_NAME";
            this.cATNAMEDataGridViewTextBoxColumn.HeaderText = "CAT_NAME";
            this.cATNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATNAMEDataGridViewTextBoxColumn.Name = "cATNAMEDataGridViewTextBoxColumn";
            this.cATNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // vWCATEGORYBindingSource
            // 
            this.vWCATEGORYBindingSource.DataMember = "VW_CATEGORY";
            this.vWCATEGORYBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCatDel
            // 
            this.btnCatDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatDel.Location = new System.Drawing.Point(457, 38);
            this.btnCatDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(107, 30);
            this.btnCatDel.TabIndex = 4;
            this.btnCatDel.Text = "&Supprimer";
            this.btnCatDel.UseVisualStyleBackColor = true;
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // vW_CATEGORYTableAdapter
            // 
            this.vW_CATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 483);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.lblCatSearchName);
            this.Controls.Add(this.tbxCatSearchName);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.btnCatDel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(617, 530);
            this.Name = "FormCategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.TextBox tbxCatSearchName;
        private System.Windows.Forms.Label lblCatSearchName;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btnCatDel;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWCATEGORYBindingSource;
        private DataSetTableAdapters.VW_CATEGORYTableAdapter vW_CATEGORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATNAMEDataGridViewTextBoxColumn;
    }
}