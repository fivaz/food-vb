namespace WindowsFormsApp2
{
    partial class FormAddTable
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
            this.lblATaName = new System.Windows.Forms.Label();
            this.tbxATaName = new System.Windows.Forms.TextBox();
            this.btnATaSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblATaName
            // 
            this.lblATaName.AutoSize = true;
            this.lblATaName.Location = new System.Drawing.Point(50, 36);
            this.lblATaName.Name = "lblATaName";
            this.lblATaName.Size = new System.Drawing.Size(37, 17);
            this.lblATaName.TabIndex = 1;
            this.lblATaName.Text = "&Nom";
            // 
            // tbxATaName
            // 
            this.tbxATaName.Location = new System.Drawing.Point(54, 56);
            this.tbxATaName.Name = "tbxATaName";
            this.tbxATaName.Size = new System.Drawing.Size(196, 22);
            this.tbxATaName.TabIndex = 2;
            // 
            // btnATaSubmit
            // 
            this.btnATaSubmit.Location = new System.Drawing.Point(115, 98);
            this.btnATaSubmit.Name = "btnATaSubmit";
            this.btnATaSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnATaSubmit.TabIndex = 3;
            this.btnATaSubmit.Text = "&Créer";
            this.btnATaSubmit.UseVisualStyleBackColor = true;
            // 
            // FormAddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 155);
            this.Controls.Add(this.btnATaSubmit);
            this.Controls.Add(this.tbxATaName);
            this.Controls.Add(this.lblATaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddTable";
            this.Text = "Nouvelle table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblATaName;
        private System.Windows.Forms.TextBox tbxATaName;
        private System.Windows.Forms.Button btnATaSubmit;
    }
}