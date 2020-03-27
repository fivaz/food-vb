namespace WindowsFormsApp2
{
    partial class FormSignIn
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
            this.txbSInEmail = new System.Windows.Forms.TextBox();
            this.lblSInEmail = new System.Windows.Forms.Label();
            this.lblSInPassword = new System.Windows.Forms.Label();
            this.txbSInPassword = new System.Windows.Forms.TextBox();
            this.btnSInSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSInEmail
            // 
            this.txbSInEmail.Location = new System.Drawing.Point(29, 50);
            this.txbSInEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSInEmail.Name = "txbSInEmail";
            this.txbSInEmail.Size = new System.Drawing.Size(176, 22);
            this.txbSInEmail.TabIndex = 0;
            this.txbSInEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSInEmail
            // 
            this.lblSInEmail.AutoSize = true;
            this.lblSInEmail.Location = new System.Drawing.Point(29, 31);
            this.lblSInEmail.Name = "lblSInEmail";
            this.lblSInEmail.Size = new System.Drawing.Size(42, 17);
            this.lblSInEmail.TabIndex = 2;
            this.lblSInEmail.Text = "&Email";
            // 
            // lblSInPassword
            // 
            this.lblSInPassword.AutoSize = true;
            this.lblSInPassword.Location = new System.Drawing.Point(29, 90);
            this.lblSInPassword.Name = "lblSInPassword";
            this.lblSInPassword.Size = new System.Drawing.Size(93, 17);
            this.lblSInPassword.TabIndex = 4;
            this.lblSInPassword.Text = "&Mot de passe";
            // 
            // txbSInPassword
            // 
            this.txbSInPassword.Location = new System.Drawing.Point(29, 109);
            this.txbSInPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSInPassword.Name = "txbSInPassword";
            this.txbSInPassword.Size = new System.Drawing.Size(176, 22);
            this.txbSInPassword.TabIndex = 3;
            // 
            // btnSInSubmit
            // 
            this.btnSInSubmit.Location = new System.Drawing.Point(75, 153);
            this.btnSInSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSInSubmit.Name = "btnSInSubmit";
            this.btnSInSubmit.Size = new System.Drawing.Size(85, 28);
            this.btnSInSubmit.TabIndex = 5;
            this.btnSInSubmit.Text = "&Connexion";
            this.btnSInSubmit.UseVisualStyleBackColor = true;
            this.btnSInSubmit.Click += new System.EventHandler(this.btnSInSubmit_Click);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 207);
            this.Controls.Add(this.btnSInSubmit);
            this.Controls.Add(this.lblSInPassword);
            this.Controls.Add(this.txbSInPassword);
            this.Controls.Add(this.lblSInEmail);
            this.Controls.Add(this.txbSInEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSignIn";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSInEmail;
        private System.Windows.Forms.Label lblSInEmail;
        private System.Windows.Forms.Label lblSInPassword;
        private System.Windows.Forms.TextBox txbSInPassword;
        private System.Windows.Forms.Button btnSInSubmit;
    }
}