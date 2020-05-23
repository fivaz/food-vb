namespace WindowsFormsApp2
{
    partial class FormAddAccount
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
            this.lblAAcUserType = new System.Windows.Forms.Label();
            this.rbtAAcManager = new System.Windows.Forms.RadioButton();
            this.rbtAAcWaiter = new System.Windows.Forms.RadioButton();
            this.lblAAcLastName = new System.Windows.Forms.Label();
            this.tbxAAcLastName = new System.Windows.Forms.TextBox();
            this.tbxAAcFirstName = new System.Windows.Forms.TextBox();
            this.lblAAcFirstName = new System.Windows.Forms.Label();
            this.tbxAAcEmail = new System.Windows.Forms.TextBox();
            this.lblAAcEmail = new System.Windows.Forms.Label();
            this.tbxAAcPassword1 = new System.Windows.Forms.TextBox();
            this.lblAAcPassword1 = new System.Windows.Forms.Label();
            this.tbxAAcPassword2 = new System.Windows.Forms.TextBox();
            this.lblAAcPassword2 = new System.Windows.Forms.Label();
            this.btnAAcSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAAcUserType
            // 
            this.lblAAcUserType.AutoSize = true;
            this.lblAAcUserType.Location = new System.Drawing.Point(21, 29);
            this.lblAAcUserType.Name = "lblAAcUserType";
            this.lblAAcUserType.Size = new System.Drawing.Size(116, 17);
            this.lblAAcUserType.TabIndex = 1;
            this.lblAAcUserType.Text = "&Type d\'utilisateur";
            // 
            // rbtAAcManager
            // 
            this.rbtAAcManager.AutoSize = true;
            this.rbtAAcManager.Location = new System.Drawing.Point(200, 25);
            this.rbtAAcManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtAAcManager.Name = "rbtAAcManager";
            this.rbtAAcManager.Size = new System.Drawing.Size(85, 21);
            this.rbtAAcManager.TabIndex = 2;
            this.rbtAAcManager.TabStop = true;
            this.rbtAAcManager.Text = "Manager";
            this.rbtAAcManager.UseVisualStyleBackColor = true;
            // 
            // rbtAAcWaiter
            // 
            this.rbtAAcWaiter.AutoSize = true;
            this.rbtAAcWaiter.Location = new System.Drawing.Point(298, 25);
            this.rbtAAcWaiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtAAcWaiter.Name = "rbtAAcWaiter";
            this.rbtAAcWaiter.Size = new System.Drawing.Size(79, 21);
            this.rbtAAcWaiter.TabIndex = 3;
            this.rbtAAcWaiter.TabStop = true;
            this.rbtAAcWaiter.Text = "Serveur";
            this.rbtAAcWaiter.UseVisualStyleBackColor = true;
            // 
            // lblAAcLastName
            // 
            this.lblAAcLastName.AutoSize = true;
            this.lblAAcLastName.Location = new System.Drawing.Point(21, 87);
            this.lblAAcLastName.Name = "lblAAcLastName";
            this.lblAAcLastName.Size = new System.Drawing.Size(37, 17);
            this.lblAAcLastName.TabIndex = 4;
            this.lblAAcLastName.Text = "&Nom";
            // 
            // tbxAAcLastName
            // 
            this.tbxAAcLastName.Location = new System.Drawing.Point(24, 108);
            this.tbxAAcLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAAcLastName.Name = "tbxAAcLastName";
            this.tbxAAcLastName.Size = new System.Drawing.Size(145, 22);
            this.tbxAAcLastName.TabIndex = 5;
            this.tbxAAcLastName.TextChanged += new System.EventHandler(this.tbxAAcLastName_TextChanged);
            // 
            // tbxAAcFirstName
            // 
            this.tbxAAcFirstName.Location = new System.Drawing.Point(232, 108);
            this.tbxAAcFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAAcFirstName.Name = "tbxAAcFirstName";
            this.tbxAAcFirstName.Size = new System.Drawing.Size(147, 22);
            this.tbxAAcFirstName.TabIndex = 7;
            // 
            // lblAAcFirstName
            // 
            this.lblAAcFirstName.AutoSize = true;
            this.lblAAcFirstName.Location = new System.Drawing.Point(228, 87);
            this.lblAAcFirstName.Name = "lblAAcFirstName";
            this.lblAAcFirstName.Size = new System.Drawing.Size(57, 17);
            this.lblAAcFirstName.TabIndex = 6;
            this.lblAAcFirstName.Text = "&Prénom";
            // 
            // tbxAAcEmail
            // 
            this.tbxAAcEmail.Location = new System.Drawing.Point(24, 172);
            this.tbxAAcEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAAcEmail.Name = "tbxAAcEmail";
            this.tbxAAcEmail.Size = new System.Drawing.Size(356, 22);
            this.tbxAAcEmail.TabIndex = 9;
            // 
            // lblAAcEmail
            // 
            this.lblAAcEmail.AutoSize = true;
            this.lblAAcEmail.Location = new System.Drawing.Point(21, 151);
            this.lblAAcEmail.Name = "lblAAcEmail";
            this.lblAAcEmail.Size = new System.Drawing.Size(42, 17);
            this.lblAAcEmail.TabIndex = 8;
            this.lblAAcEmail.Text = "&Email";
            // 
            // tbxAAcPassword1
            // 
            this.tbxAAcPassword1.Location = new System.Drawing.Point(24, 231);
            this.tbxAAcPassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAAcPassword1.Name = "tbxAAcPassword1";
            this.tbxAAcPassword1.Size = new System.Drawing.Size(145, 22);
            this.tbxAAcPassword1.TabIndex = 11;
            // 
            // lblAAcPassword1
            // 
            this.lblAAcPassword1.AutoSize = true;
            this.lblAAcPassword1.Location = new System.Drawing.Point(21, 210);
            this.lblAAcPassword1.Name = "lblAAcPassword1";
            this.lblAAcPassword1.Size = new System.Drawing.Size(93, 17);
            this.lblAAcPassword1.TabIndex = 10;
            this.lblAAcPassword1.Text = "&Mot de passe";
            // 
            // tbxAAcPassword2
            // 
            this.tbxAAcPassword2.Location = new System.Drawing.Point(232, 231);
            this.tbxAAcPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAAcPassword2.Name = "tbxAAcPassword2";
            this.tbxAAcPassword2.Size = new System.Drawing.Size(147, 22);
            this.tbxAAcPassword2.TabIndex = 13;
            // 
            // lblAAcPassword2
            // 
            this.lblAAcPassword2.AutoSize = true;
            this.lblAAcPassword2.Location = new System.Drawing.Point(228, 210);
            this.lblAAcPassword2.Name = "lblAAcPassword2";
            this.lblAAcPassword2.Size = new System.Drawing.Size(150, 17);
            this.lblAAcPassword2.TabIndex = 12;
            this.lblAAcPassword2.Text = "&Répetez mot de passe";
            // 
            // btnAAcSubmit
            // 
            this.btnAAcSubmit.Location = new System.Drawing.Point(137, 286);
            this.btnAAcSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAAcSubmit.Name = "btnAAcSubmit";
            this.btnAAcSubmit.Size = new System.Drawing.Size(130, 30);
            this.btnAAcSubmit.TabIndex = 14;
            this.btnAAcSubmit.Text = "Créer &compte";
            this.btnAAcSubmit.UseVisualStyleBackColor = true;
            this.btnAAcSubmit.Click += new System.EventHandler(this.btnAAcSubmit_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 338);
            this.Controls.Add(this.btnAAcSubmit);
            this.Controls.Add(this.tbxAAcPassword2);
            this.Controls.Add(this.lblAAcPassword2);
            this.Controls.Add(this.tbxAAcPassword1);
            this.Controls.Add(this.lblAAcPassword1);
            this.Controls.Add(this.tbxAAcEmail);
            this.Controls.Add(this.lblAAcEmail);
            this.Controls.Add(this.tbxAAcFirstName);
            this.Controls.Add(this.lblAAcFirstName);
            this.Controls.Add(this.tbxAAcLastName);
            this.Controls.Add(this.lblAAcLastName);
            this.Controls.Add(this.rbtAAcWaiter);
            this.Controls.Add(this.rbtAAcManager);
            this.Controls.Add(this.lblAAcUserType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 385);
            this.MinimumSize = new System.Drawing.Size(422, 385);
            this.Name = "FormAddAccount";
            this.Text = "Nouveau compte";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAAcUserType;
        private System.Windows.Forms.Label lblAAcLastName;
        private System.Windows.Forms.Label lblAAcFirstName;
        private System.Windows.Forms.Label lblAAcEmail;
        private System.Windows.Forms.TextBox tbxAAcPassword1;
        private System.Windows.Forms.Label lblAAcPassword1;
        private System.Windows.Forms.TextBox tbxAAcPassword2;
        private System.Windows.Forms.Label lblAAcPassword2;
        private System.Windows.Forms.Button btnAAcSubmit;
        public System.Windows.Forms.TextBox tbxAAcLastName;
        public System.Windows.Forms.RadioButton rbtAAcManager;
        public System.Windows.Forms.RadioButton rbtAAcWaiter;
        public System.Windows.Forms.TextBox tbxAAcFirstName;
        public System.Windows.Forms.TextBox tbxAAcEmail;
    }
}