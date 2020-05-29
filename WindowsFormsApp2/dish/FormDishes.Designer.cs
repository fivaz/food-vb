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
            this.components = new System.ComponentModel.Container();
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
            this.vWDISHBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new WindowsFormsApp2.DataSet4();
            this.btnDisDel = new System.Windows.Forms.Button();
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.vWDISHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_DISHTableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.VW_DISHTableAdapter();
            this.dataSet2 = new WindowsFormsApp2.DataSet2();
            this.vWDISHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vW_DISHTableAdapter1 = new WindowsFormsApp2.DataSet2TableAdapters.VW_DISHTableAdapter();
            this.dataSet3 = new WindowsFormsApp2.DataSet3();
            this.vWACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_ACCOUNTTableAdapter = new WindowsFormsApp2.DataSet3TableAdapters.VW_ACCOUNTTableAdapter();
            this.vWDISHBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vW_DISHTableAdapter2 = new WindowsFormsApp2.DataSet4TableAdapters.VW_DISHTableAdapter();
            this.dataSet7 = new WindowsFormsApp2.DataSet7();
            this.vWDISHBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.vW_DISHTableAdapter3 = new WindowsFormsApp2.DataSet7TableAdapters.VW_DISHTableAdapter();
            this.dISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWACCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource4)).BeginInit();
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
            this.btnDisAdd.Click += new System.EventHandler(this.btnDisAdd_Click);
            // 
            // tbxDisSearchName
            // 
            this.tbxDisSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxDisSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDisSearchName.Name = "tbxDisSearchName";
            this.tbxDisSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxDisSearchName.TabIndex = 2;
            this.tbxDisSearchName.TextChanged += new System.EventHandler(this.tbxDisSearchName_TextChanged);
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
            this.dgvDis.AutoGenerateColumns = false;
            this.dgvDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dISIDDataGridViewTextBoxColumn,
            this.dISCATIDDataGridViewTextBoxColumn,
            this.dISNAMEDataGridViewTextBoxColumn,
            this.cATNAMEDataGridViewTextBoxColumn,
            this.pURCHASEPRICEDataGridViewTextBoxColumn});
            this.dgvDis.DataSource = this.vWDISHBindingSource4;
            this.dgvDis.Location = new System.Drawing.Point(36, 92);
            this.dgvDis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDis.Name = "dgvDis";
            this.dgvDis.RowHeadersWidth = 51;
            this.dgvDis.RowTemplate.Height = 24;
            this.dgvDis.Size = new System.Drawing.Size(1113, 383);
            this.dgvDis.TabIndex = 13;
            this.dgvDis.DoubleClick += new System.EventHandler(this.dgvDis_DoubleClick);
            // 
            // vWDISHBindingSource3
            // 
            this.vWDISHBindingSource3.DataMember = "VW_DISH";
            this.vWDISHBindingSource3.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDisDel
            // 
            this.btnDisDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisDel.Location = new System.Drawing.Point(1042, 38);
            this.btnDisDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisDel.Name = "btnDisDel";
            this.btnDisDel.Size = new System.Drawing.Size(107, 30);
            this.btnDisDel.TabIndex = 12;
            this.btnDisDel.Text = "&Supprimer";
            this.btnDisDel.UseVisualStyleBackColor = true;
            this.btnDisDel.Click += new System.EventHandler(this.btnDisDel_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWDISHBindingSource
            // 
            this.vWDISHBindingSource.DataMember = "VW_DISH";
            this.vWDISHBindingSource.DataSource = this.dataSet1;
            // 
            // vW_DISHTableAdapter
            // 
            this.vW_DISHTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWDISHBindingSource1
            // 
            this.vWDISHBindingSource1.DataMember = "VW_DISH";
            this.vWDISHBindingSource1.DataSource = this.dataSet2;
            // 
            // vW_DISHTableAdapter1
            // 
            this.vW_DISHTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWACCOUNTBindingSource
            // 
            this.vWACCOUNTBindingSource.DataMember = "VW_ACCOUNT";
            this.vWACCOUNTBindingSource.DataSource = this.dataSet3;
            // 
            // vW_ACCOUNTTableAdapter
            // 
            this.vW_ACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // vWDISHBindingSource2
            // 
            this.vWDISHBindingSource2.DataMember = "VW_DISH";
            this.vWDISHBindingSource2.DataSource = this.dataSet2;
            // 
            // vW_DISHTableAdapter2
            // 
            this.vW_DISHTableAdapter2.ClearBeforeFill = true;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWDISHBindingSource4
            // 
            this.vWDISHBindingSource4.DataMember = "VW_DISH";
            this.vWDISHBindingSource4.DataSource = this.dataSet7;
            // 
            // vW_DISHTableAdapter3
            // 
            this.vW_DISHTableAdapter3.ClearBeforeFill = true;
            // 
            // dISIDDataGridViewTextBoxColumn
            // 
            this.dISIDDataGridViewTextBoxColumn.DataPropertyName = "DIS_ID";
            this.dISIDDataGridViewTextBoxColumn.HeaderText = "DIS_ID";
            this.dISIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISIDDataGridViewTextBoxColumn.Name = "dISIDDataGridViewTextBoxColumn";
            this.dISIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISCATIDDataGridViewTextBoxColumn
            // 
            this.dISCATIDDataGridViewTextBoxColumn.DataPropertyName = "DIS_CAT_ID";
            this.dISCATIDDataGridViewTextBoxColumn.HeaderText = "DIS_CAT_ID";
            this.dISCATIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISCATIDDataGridViewTextBoxColumn.Name = "dISCATIDDataGridViewTextBoxColumn";
            this.dISCATIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISNAMEDataGridViewTextBoxColumn
            // 
            this.dISNAMEDataGridViewTextBoxColumn.DataPropertyName = "DIS_NAME";
            this.dISNAMEDataGridViewTextBoxColumn.HeaderText = "DIS_NAME";
            this.dISNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISNAMEDataGridViewTextBoxColumn.Name = "dISNAMEDataGridViewTextBoxColumn";
            this.dISNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATNAMEDataGridViewTextBoxColumn
            // 
            this.cATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT_NAME";
            this.cATNAMEDataGridViewTextBoxColumn.HeaderText = "CAT_NAME";
            this.cATNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATNAMEDataGridViewTextBoxColumn.Name = "cATNAMEDataGridViewTextBoxColumn";
            this.cATNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pURCHASEPRICEDataGridViewTextBoxColumn
            // 
            this.pURCHASEPRICEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_PRICE";
            this.pURCHASEPRICEDataGridViewTextBoxColumn.HeaderText = "PURCHASE_PRICE";
            this.pURCHASEPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pURCHASEPRICEDataGridViewTextBoxColumn.Name = "pURCHASEPRICEDataGridViewTextBoxColumn";
            this.pURCHASEPRICEDataGridViewTextBoxColumn.Width = 125;
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
            this.Controls.Add(this.btnDisDel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(980, 217);
            this.Name = "FormDishes";
            this.Text = "Plats";
            this.Load += new System.EventHandler(this.FormDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWACCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDISHBindingSource4)).EndInit();
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
        private System.Windows.Forms.Button btnDisDel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vWDISHBindingSource;
        private DataSet1TableAdapters.VW_DISHTableAdapter vW_DISHTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vWDISHBindingSource1;
        private DataSet2TableAdapters.VW_DISHTableAdapter vW_DISHTableAdapter1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource vWACCOUNTBindingSource;
        private DataSet3TableAdapters.VW_ACCOUNTTableAdapter vW_ACCOUNTTableAdapter;
        private System.Windows.Forms.BindingSource vWDISHBindingSource2;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource vWDISHBindingSource3;
        private DataSet4TableAdapters.VW_DISHTableAdapter vW_DISHTableAdapter2;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource vWDISHBindingSource4;
        private DataSet7TableAdapters.VW_DISHTableAdapter vW_DISHTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEPRICEDataGridViewTextBoxColumn;
    }
}