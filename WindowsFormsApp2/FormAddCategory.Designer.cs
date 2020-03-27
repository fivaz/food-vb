namespace WindowsFormsApp2
{
    partial class FormAddCategory
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
            this.lblACaName = new System.Windows.Forms.Label();
            this.tbxACaName = new System.Windows.Forms.TextBox();
            this.btnACaSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblACaName
            // 
            this.lblACaName.AutoSize = true;
            this.lblACaName.Location = new System.Drawing.Point(53, 35);
            this.lblACaName.Name = "lblACaName";
            this.lblACaName.Size = new System.Drawing.Size(37, 17);
            this.lblACaName.TabIndex = 0;
            this.lblACaName.Text = "&Nom";
            // 
            // tbxACaName
            // 
            this.tbxACaName.Location = new System.Drawing.Point(57, 56);
            this.tbxACaName.Name = "tbxACaName";
            this.tbxACaName.Size = new System.Drawing.Size(224, 22);
            this.tbxACaName.TabIndex = 1;
            // 
            // btnACaSubmit
            // 
            this.btnACaSubmit.Location = new System.Drawing.Point(132, 98);
            this.btnACaSubmit.Name = "btnACaSubmit";
            this.btnACaSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnACaSubmit.TabIndex = 2;
            this.btnACaSubmit.Text = "&Créer";
            this.btnACaSubmit.UseVisualStyleBackColor = true;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 155);
            this.Controls.Add(this.btnACaSubmit);
            this.Controls.Add(this.tbxACaName);
            this.Controls.Add(this.lblACaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddCategory";
            this.Text = "Nouvelle catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblACaName;
        private System.Windows.Forms.TextBox tbxACaName;
        private System.Windows.Forms.Button btnACaSubmit;
    }
}