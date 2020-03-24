namespace WindowsFormsApp2
{
    partial class frmTables
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
            this.dgvIng = new System.Windows.Forms.DataGridView();
            this.btnIngDelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngAdd
            // 
            this.btnIngAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngAdd.Location = new System.Drawing.Point(667, 38);
            this.btnIngAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngAdd.Name = "btnIngAdd";
            this.btnIngAdd.Size = new System.Drawing.Size(129, 30);
            this.btnIngAdd.TabIndex = 3;
            this.btnIngAdd.Text = "&nouvelle table";
            this.btnIngAdd.UseVisualStyleBackColor = true;
            this.btnIngAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxIngSearchName
            // 
            this.tbxIngSearchName.Location = new System.Drawing.Point(35, 46);
            this.tbxIngSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIngSearchName.Name = "tbxIngSearchName";
            this.tbxIngSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxIngSearchName.TabIndex = 2;
            // 
            // lblIngSearchName
            // 
            this.lblIngSearchName.AutoSize = true;
            this.lblIngSearchName.Location = new System.Drawing.Point(35, 22);
            this.lblIngSearchName.Name = "lblIngSearchName";
            this.lblIngSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblIngSearchName.TabIndex = 1;
            this.lblIngSearchName.Text = "Rechercher";
            // 
            // dgvIng
            // 
            this.dgvIng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIng.Location = new System.Drawing.Point(35, 92);
            this.dgvIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIng.Name = "dgvIng";
            this.dgvIng.RowHeadersWidth = 51;
            this.dgvIng.RowTemplate.Height = 24;
            this.dgvIng.Size = new System.Drawing.Size(892, 362);
            this.dgvIng.TabIndex = 5;
            // 
            // btnIngDelAll
            // 
            this.btnIngDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngDelAll.Location = new System.Drawing.Point(820, 38);
            this.btnIngDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngDelAll.Name = "btnIngDelAll";
            this.btnIngDelAll.Size = new System.Drawing.Size(107, 30);
            this.btnIngDelAll.TabIndex = 4;
            this.btnIngDelAll.Text = "&supprimer";
            this.btnIngDelAll.UseVisualStyleBackColor = true;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.btnIngAdd);
            this.Controls.Add(this.lblIngSearchName);
            this.Controls.Add(this.tbxIngSearchName);
            this.Controls.Add(this.dgvIng);
            this.Controls.Add(this.btnIngDelAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.FormTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngAdd;
        private System.Windows.Forms.TextBox tbxIngSearchName;
        private System.Windows.Forms.Label lblIngSearchName;
        private System.Windows.Forms.DataGridView dgvIng;
        private System.Windows.Forms.Button btnIngDelAll;
    }
}