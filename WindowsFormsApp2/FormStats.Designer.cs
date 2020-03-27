namespace WindowsFormsApp2
{
    partial class FormStats
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
            this.gpbStaIngredient = new System.Windows.Forms.GroupBox();
            this.lblStaIngredient = new System.Windows.Forms.Label();
            this.dgvStaIngredient = new System.Windows.Forms.DataGridView();
            this.lblStaDish = new System.Windows.Forms.Label();
            this.dgvStaDish = new System.Windows.Forms.DataGridView();
            this.gpbStaDish = new System.Windows.Forms.GroupBox();
            this.gpbStaIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaDish)).BeginInit();
            this.gpbStaDish.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbStaIngredient
            // 
            this.gpbStaIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbStaIngredient.Controls.Add(this.lblStaIngredient);
            this.gpbStaIngredient.Controls.Add(this.dgvStaIngredient);
            this.gpbStaIngredient.Location = new System.Drawing.Point(34, 33);
            this.gpbStaIngredient.Name = "gpbStaIngredient";
            this.gpbStaIngredient.Size = new System.Drawing.Size(909, 290);
            this.gpbStaIngredient.TabIndex = 2;
            this.gpbStaIngredient.TabStop = false;
            this.gpbStaIngredient.Text = "Ingrédients";
            this.gpbStaIngredient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStaIngredient
            // 
            this.lblStaIngredient.AutoSize = true;
            this.lblStaIngredient.Location = new System.Drawing.Point(23, 32);
            this.lblStaIngredient.Name = "lblStaIngredient";
            this.lblStaIngredient.Size = new System.Drawing.Size(116, 17);
            this.lblStaIngredient.TabIndex = 4;
            this.lblStaIngredient.Text = "Les plus utilisées";
            // 
            // dgvStaIngredient
            // 
            this.dgvStaIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaIngredient.Location = new System.Drawing.Point(23, 61);
            this.dgvStaIngredient.Name = "dgvStaIngredient";
            this.dgvStaIngredient.RowHeadersWidth = 51;
            this.dgvStaIngredient.RowTemplate.Height = 24;
            this.dgvStaIngredient.Size = new System.Drawing.Size(864, 203);
            this.dgvStaIngredient.TabIndex = 3;
            // 
            // lblStaDish
            // 
            this.lblStaDish.AutoSize = true;
            this.lblStaDish.Location = new System.Drawing.Point(23, 32);
            this.lblStaDish.Name = "lblStaDish";
            this.lblStaDish.Size = new System.Drawing.Size(141, 17);
            this.lblStaDish.TabIndex = 4;
            this.lblStaDish.Text = "Les plus commandés";
            // 
            // dgvStaDish
            // 
            this.dgvStaDish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaDish.Location = new System.Drawing.Point(23, 61);
            this.dgvStaDish.Name = "dgvStaDish";
            this.dgvStaDish.RowHeadersWidth = 51;
            this.dgvStaDish.RowTemplate.Height = 24;
            this.dgvStaDish.Size = new System.Drawing.Size(864, 203);
            this.dgvStaDish.TabIndex = 6;
            // 
            // gpbStaDish
            // 
            this.gpbStaDish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbStaDish.Controls.Add(this.lblStaDish);
            this.gpbStaDish.Controls.Add(this.dgvStaDish);
            this.gpbStaDish.Location = new System.Drawing.Point(34, 350);
            this.gpbStaDish.Name = "gpbStaDish";
            this.gpbStaDish.Size = new System.Drawing.Size(909, 290);
            this.gpbStaDish.TabIndex = 5;
            this.gpbStaDish.TabStop = false;
            this.gpbStaDish.Text = "Plats";
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 677);
            this.Controls.Add(this.gpbStaDish);
            this.Controls.Add(this.gpbStaIngredient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(344, 392);
            this.Name = "FormStats";
            this.Text = "Statistiques";
            this.gpbStaIngredient.ResumeLayout(false);
            this.gpbStaIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaDish)).EndInit();
            this.gpbStaDish.ResumeLayout(false);
            this.gpbStaDish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbStaIngredient;
        private System.Windows.Forms.Label lblStaIngredient;
        private System.Windows.Forms.DataGridView dgvStaIngredient;
        private System.Windows.Forms.Label lblStaDish;
        private System.Windows.Forms.DataGridView dgvStaDish;
        private System.Windows.Forms.GroupBox gpbStaDish;
    }
}