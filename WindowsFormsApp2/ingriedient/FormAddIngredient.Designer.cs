namespace WindowsFormsApp2
{
    partial class FormAddIngredient
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
            this.lblAInName = new System.Windows.Forms.Label();
            this.lblAInType = new System.Windows.Forms.Label();
            this.rbtAInCountable = new System.Windows.Forms.RadioButton();
            this.rbtAInUncoutable = new System.Windows.Forms.RadioButton();
            this.tbxAInName = new System.Windows.Forms.TextBox();
            this.lblAInUnity = new System.Windows.Forms.Label();
            this.cbxAInUnity = new System.Windows.Forms.ComboBox();
            this.tbxAInQuantity = new System.Windows.Forms.TextBox();
            this.lblAInQuantity = new System.Windows.Forms.Label();
            this.btnAInSubmit = new System.Windows.Forms.Button();
            this.tbxAInMQuantity = new System.Windows.Forms.TextBox();
            this.lblAInMQuantity = new System.Windows.Forms.Label();
            this.tbxAInPrice = new System.Windows.Forms.TextBox();
            this.lblAInPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAInName
            // 
            this.lblAInName.AutoSize = true;
            this.lblAInName.Location = new System.Drawing.Point(34, 82);
            this.lblAInName.Name = "lblAInName";
            this.lblAInName.Size = new System.Drawing.Size(37, 17);
            this.lblAInName.TabIndex = 4;
            this.lblAInName.Text = "&Nom";
            // 
            // lblAInType
            // 
            this.lblAInType.AutoSize = true;
            this.lblAInType.Location = new System.Drawing.Point(34, 22);
            this.lblAInType.Name = "lblAInType";
            this.lblAInType.Size = new System.Drawing.Size(118, 17);
            this.lblAInType.TabIndex = 1;
            this.lblAInType.Text = "&Type d\'ingredient";
            // 
            // rbtAInCountable
            // 
            this.rbtAInCountable.AutoSize = true;
            this.rbtAInCountable.Location = new System.Drawing.Point(37, 41);
            this.rbtAInCountable.Name = "rbtAInCountable";
            this.rbtAInCountable.Size = new System.Drawing.Size(96, 21);
            this.rbtAInCountable.TabIndex = 2;
            this.rbtAInCountable.TabStop = true;
            this.rbtAInCountable.Text = "Comptable";
            this.rbtAInCountable.UseVisualStyleBackColor = true;
            // 
            // rbtAInUncoutable
            // 
            this.rbtAInUncoutable.AutoSize = true;
            this.rbtAInUncoutable.Location = new System.Drawing.Point(194, 41);
            this.rbtAInUncoutable.Name = "rbtAInUncoutable";
            this.rbtAInUncoutable.Size = new System.Drawing.Size(124, 21);
            this.rbtAInUncoutable.TabIndex = 3;
            this.rbtAInUncoutable.TabStop = true;
            this.rbtAInUncoutable.Text = "Non comptable";
            this.rbtAInUncoutable.UseVisualStyleBackColor = true;
            // 
            // tbxAInName
            // 
            this.tbxAInName.Location = new System.Drawing.Point(37, 101);
            this.tbxAInName.Name = "tbxAInName";
            this.tbxAInName.Size = new System.Drawing.Size(281, 22);
            this.tbxAInName.TabIndex = 5;
            // 
            // lblAInUnity
            // 
            this.lblAInUnity.AutoSize = true;
            this.lblAInUnity.Location = new System.Drawing.Point(35, 148);
            this.lblAInUnity.Name = "lblAInUnity";
            this.lblAInUnity.Size = new System.Drawing.Size(41, 17);
            this.lblAInUnity.TabIndex = 6;
            this.lblAInUnity.Text = "&Unité";
            // 
            // cbxAInUnity
            // 
            this.cbxAInUnity.FormattingEnabled = true;
            this.cbxAInUnity.Items.AddRange(new object[] {
            "Kg",
            "g",
            "ml",
            "L"});
            this.cbxAInUnity.Location = new System.Drawing.Point(38, 166);
            this.cbxAInUnity.Name = "cbxAInUnity";
            this.cbxAInUnity.Size = new System.Drawing.Size(100, 24);
            this.cbxAInUnity.TabIndex = 7;
            // 
            // tbxAInQuantity
            // 
            this.tbxAInQuantity.Location = new System.Drawing.Point(38, 232);
            this.tbxAInQuantity.Name = "tbxAInQuantity";
            this.tbxAInQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbxAInQuantity.TabIndex = 11;
            // 
            // lblAInQuantity
            // 
            this.lblAInQuantity.AutoSize = true;
            this.lblAInQuantity.Location = new System.Drawing.Point(35, 212);
            this.lblAInQuantity.Name = "lblAInQuantity";
            this.lblAInQuantity.Size = new System.Drawing.Size(62, 17);
            this.lblAInQuantity.TabIndex = 10;
            this.lblAInQuantity.Text = "&Quantité";
            // 
            // btnAInSubmit
            // 
            this.btnAInSubmit.Location = new System.Drawing.Point(137, 282);
            this.btnAInSubmit.Name = "btnAInSubmit";
            this.btnAInSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnAInSubmit.TabIndex = 12;
            this.btnAInSubmit.Text = "&Créer";
            this.btnAInSubmit.UseVisualStyleBackColor = true;
            this.btnAInSubmit.Click += new System.EventHandler(this.btnAInSubmit_Click);
            // 
            // tbxAInMQuantity
            // 
            this.tbxAInMQuantity.Location = new System.Drawing.Point(215, 232);
            this.tbxAInMQuantity.Name = "tbxAInMQuantity";
            this.tbxAInMQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbxAInMQuantity.TabIndex = 16;
            // 
            // lblAInMQuantity
            // 
            this.lblAInMQuantity.AutoSize = true;
            this.lblAInMQuantity.Location = new System.Drawing.Point(212, 212);
            this.lblAInMQuantity.Name = "lblAInMQuantity";
            this.lblAInMQuantity.Size = new System.Drawing.Size(121, 17);
            this.lblAInMQuantity.TabIndex = 15;
            this.lblAInMQuantity.Text = "Quantité &minimum";
            // 
            // tbxAInPrice
            // 
            this.tbxAInPrice.Location = new System.Drawing.Point(215, 168);
            this.tbxAInPrice.Name = "tbxAInPrice";
            this.tbxAInPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxAInPrice.TabIndex = 14;
            // 
            // lblAInPrice
            // 
            this.lblAInPrice.AutoSize = true;
            this.lblAInPrice.Location = new System.Drawing.Point(212, 148);
            this.lblAInPrice.Name = "lblAInPrice";
            this.lblAInPrice.Size = new System.Drawing.Size(31, 17);
            this.lblAInPrice.TabIndex = 13;
            this.lblAInPrice.Text = "&Prix";
            // 
            // FormAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 334);
            this.Controls.Add(this.tbxAInMQuantity);
            this.Controls.Add(this.lblAInMQuantity);
            this.Controls.Add(this.tbxAInPrice);
            this.Controls.Add(this.lblAInPrice);
            this.Controls.Add(this.btnAInSubmit);
            this.Controls.Add(this.tbxAInQuantity);
            this.Controls.Add(this.lblAInQuantity);
            this.Controls.Add(this.cbxAInUnity);
            this.Controls.Add(this.lblAInUnity);
            this.Controls.Add(this.tbxAInName);
            this.Controls.Add(this.rbtAInUncoutable);
            this.Controls.Add(this.rbtAInCountable);
            this.Controls.Add(this.lblAInType);
            this.Controls.Add(this.lblAInName);
            this.MaximizeBox = false;
            this.Name = "FormAddIngredient";
            this.Text = "Nouvel Ingrédient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddIngredient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAInName;
        private System.Windows.Forms.Label lblAInType;
        private System.Windows.Forms.Label lblAInUnity;
        private System.Windows.Forms.Label lblAInQuantity;
        private System.Windows.Forms.Button btnAInSubmit;
        private System.Windows.Forms.Label lblAInMQuantity;
        private System.Windows.Forms.Label lblAInPrice;
        public System.Windows.Forms.RadioButton rbtAInCountable;
        public System.Windows.Forms.RadioButton rbtAInUncoutable;
        public System.Windows.Forms.TextBox tbxAInName;
        public System.Windows.Forms.ComboBox cbxAInUnity;
        public System.Windows.Forms.TextBox tbxAInQuantity;
        public System.Windows.Forms.TextBox tbxAInMQuantity;
        public System.Windows.Forms.TextBox tbxAInPrice;
    }
}