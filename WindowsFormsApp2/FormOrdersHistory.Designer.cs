namespace WindowsFormsApp2
{
    partial class FormOrdersHistory
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
            this.dgvHis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHis
            // 
            this.dgvHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHis.Location = new System.Drawing.Point(40, 40);
            this.dgvHis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHis.Name = "dgvHis";
            this.dgvHis.RowHeadersWidth = 51;
            this.dgvHis.RowTemplate.Height = 24;
            this.dgvHis.Size = new System.Drawing.Size(900, 406);
            this.dgvHis.TabIndex = 4;
            // 
            // FormOrdersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 484);
            this.Controls.Add(this.dgvHis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(651, 289);
            this.Name = "FormOrdersHistory";
            this.Text = "Historique des commandes";
            this.Load += new System.EventHandler(this.FormOrdersHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHis;
    }
}