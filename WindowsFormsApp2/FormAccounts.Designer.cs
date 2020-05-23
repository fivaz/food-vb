namespace WindowsFormsApp2
{
    partial class FormAccounts
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
            this.btnAccAdd = new System.Windows.Forms.Button();
            this.tbxAccSearchName = new System.Windows.Forms.TextBox();
            this.lblAccSearchName = new System.Windows.Forms.Label();
            this.btnAccDelAll = new System.Windows.Forms.Button();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.aCCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOOACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp2.DataSet2();
            this.fOO_ACCOUNTTableAdapter = new WindowsFormsApp2.DataSet2TableAdapters.FOO_ACCOUNTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOOACCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccAdd.Location = new System.Drawing.Point(577, 38);
            this.btnAccAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAccAdd.TabIndex = 3;
            this.btnAccAdd.Text = "&Nouveau compte";
            this.btnAccAdd.UseVisualStyleBackColor = true;
            this.btnAccAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxAccSearchName
            // 
            this.tbxAccSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxAccSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAccSearchName.Name = "tbxAccSearchName";
            this.tbxAccSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxAccSearchName.TabIndex = 2;
            // 
            // lblAccSearchName
            // 
            this.lblAccSearchName.AutoSize = true;
            this.lblAccSearchName.Location = new System.Drawing.Point(34, 22);
            this.lblAccSearchName.Name = "lblAccSearchName";
            this.lblAccSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblAccSearchName.TabIndex = 1;
            this.lblAccSearchName.Text = "&Rechercher";
            // 
            // btnAccDelAll
            // 
            this.btnAccDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccDelAll.Location = new System.Drawing.Point(731, 38);
            this.btnAccDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccDelAll.Name = "btnAccDelAll";
            this.btnAccDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnAccDelAll.TabIndex = 4;
            this.btnAccDelAll.Text = "&Supprimer";
            this.btnAccDelAll.UseVisualStyleBackColor = true;
            // 
            // dgvAcc
            // 
            this.dgvAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcc.AutoGenerateColumns = false;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCIDDataGridViewTextBoxColumn,
            this.aCCLASTNAMEDataGridViewTextBoxColumn,
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn,
            this.aCCEMAILDataGridViewTextBoxColumn,
            this.aCCPASSWORDDataGridViewTextBoxColumn,
            this.aCCTYPEDataGridViewTextBoxColumn});
            this.dgvAcc.DataSource = this.fOOACCOUNTBindingSource;
            this.dgvAcc.Location = new System.Drawing.Point(35, 92);
            this.dgvAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidth = 51;
            this.dgvAcc.RowTemplate.Height = 24;
            this.dgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcc.Size = new System.Drawing.Size(802, 360);
            this.dgvAcc.TabIndex = 12;
            this.dgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcc_CellDoubleClick);
            // 
            // aCCIDDataGridViewTextBoxColumn
            // 
            this.aCCIDDataGridViewTextBoxColumn.DataPropertyName = "ACC_ID";
            this.aCCIDDataGridViewTextBoxColumn.HeaderText = "ACC_ID";
            this.aCCIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCIDDataGridViewTextBoxColumn.Name = "aCCIDDataGridViewTextBoxColumn";
            this.aCCIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCLASTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACC_LAST_NAME";
            this.aCCLASTNAMEDataGridViewTextBoxColumn.HeaderText = "ACC_LAST_NAME";
            this.aCCLASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCLASTNAMEDataGridViewTextBoxColumn.Name = "aCCLASTNAMEDataGridViewTextBoxColumn";
            this.aCCLASTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCFIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACC_FIRST_NAME";
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "ACC_FIRST_NAME";
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn.Name = "aCCFIRSTNAMEDataGridViewTextBoxColumn";
            this.aCCFIRSTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCEMAILDataGridViewTextBoxColumn
            // 
            this.aCCEMAILDataGridViewTextBoxColumn.DataPropertyName = "ACC_EMAIL";
            this.aCCEMAILDataGridViewTextBoxColumn.HeaderText = "ACC_EMAIL";
            this.aCCEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCEMAILDataGridViewTextBoxColumn.Name = "aCCEMAILDataGridViewTextBoxColumn";
            this.aCCEMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCPASSWORDDataGridViewTextBoxColumn
            // 
            this.aCCPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "ACC_PASSWORD";
            this.aCCPASSWORDDataGridViewTextBoxColumn.HeaderText = "ACC_PASSWORD";
            this.aCCPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCPASSWORDDataGridViewTextBoxColumn.Name = "aCCPASSWORDDataGridViewTextBoxColumn";
            this.aCCPASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCTYPEDataGridViewTextBoxColumn
            // 
            this.aCCTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACC_TYPE";
            this.aCCTYPEDataGridViewTextBoxColumn.HeaderText = "ACC_TYPE";
            this.aCCTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCTYPEDataGridViewTextBoxColumn.Name = "aCCTYPEDataGridViewTextBoxColumn";
            this.aCCTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // fOOACCOUNTBindingSource
            // 
            this.fOOACCOUNTBindingSource.DataMember = "FOO_ACCOUNT";
            this.fOOACCOUNTBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOO_ACCOUNTTableAdapter
            // 
            this.fOO_ACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 483);
            this.Controls.Add(this.btnAccAdd);
            this.Controls.Add(this.lblAccSearchName);
            this.Controls.Add(this.tbxAccSearchName);
            this.Controls.Add(this.dgvAcc);
            this.Controls.Add(this.btnAccDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(595, 530);
            this.Name = "FormAccounts";
            this.Text = "Comptes";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOOACCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccAdd;
        private System.Windows.Forms.TextBox tbxAccSearchName;
        private System.Windows.Forms.Label lblAccSearchName;
        private System.Windows.Forms.Button btnAccDelAll;
        private System.Windows.Forms.DataGridView dgvAcc;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource fOOACCOUNTBindingSource;
        private DataSet2TableAdapters.FOO_ACCOUNTTableAdapter fOO_ACCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCFIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCTYPEDataGridViewTextBoxColumn;
    }
}