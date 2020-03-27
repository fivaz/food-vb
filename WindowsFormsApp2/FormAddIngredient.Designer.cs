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
            this.rbtAInStandart = new System.Windows.Forms.RadioButton();
            this.rbtAInSpice = new System.Windows.Forms.RadioButton();
            this.tbxAInName = new System.Windows.Forms.TextBox();
            this.lblAInUnity = new System.Windows.Forms.Label();
            this.cbxAInUnity = new System.Windows.Forms.ComboBox();
            this.tbxAInPrice = new System.Windows.Forms.TextBox();
            this.lblAInPrice = new System.Windows.Forms.Label();
            this.tbxAInInitialQuantity = new System.Windows.Forms.TextBox();
            this.lblAInInitialQuantity = new System.Windows.Forms.Label();
            this.btnAInSubmit = new System.Windows.Forms.Button();
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
            this.lblAInType.Location = new System.Drawing.Point(35, 36);
            this.lblAInType.Name = "lblAInType";
            this.lblAInType.Size = new System.Drawing.Size(118, 17);
            this.lblAInType.TabIndex = 1;
            this.lblAInType.Text = "&Type d\'ingredient";
            // 
            // rbtAInStandart
            // 
            this.rbtAInStandart.AutoSize = true;
            this.rbtAInStandart.Location = new System.Drawing.Point(184, 34);
            this.rbtAInStandart.Name = "rbtAInStandart";
            this.rbtAInStandart.Size = new System.Drawing.Size(83, 21);
            this.rbtAInStandart.TabIndex = 2;
            this.rbtAInStandart.TabStop = true;
            this.rbtAInStandart.Text = "Standart";
            this.rbtAInStandart.UseVisualStyleBackColor = true;
            // 
            // rbtAInSpice
            // 
            this.rbtAInSpice.AutoSize = true;
            this.rbtAInSpice.Location = new System.Drawing.Point(288, 34);
            this.rbtAInSpice.Name = "rbtAInSpice";
            this.rbtAInSpice.Size = new System.Drawing.Size(64, 21);
            this.rbtAInSpice.TabIndex = 3;
            this.rbtAInSpice.TabStop = true;
            this.rbtAInSpice.Text = "Épice";
            this.rbtAInSpice.UseVisualStyleBackColor = true;
            // 
            // tbxAInName
            // 
            this.tbxAInName.Location = new System.Drawing.Point(37, 101);
            this.tbxAInName.Name = "tbxAInName";
            this.tbxAInName.Size = new System.Drawing.Size(100, 22);
            this.tbxAInName.TabIndex = 5;
            // 
            // lblAInUnity
            // 
            this.lblAInUnity.AutoSize = true;
            this.lblAInUnity.Location = new System.Drawing.Point(247, 82);
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
            this.cbxAInUnity.Location = new System.Drawing.Point(250, 100);
            this.cbxAInUnity.Name = "cbxAInUnity";
            this.cbxAInUnity.Size = new System.Drawing.Size(100, 24);
            this.cbxAInUnity.TabIndex = 7;
            this.cbxAInUnity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbxAInPrice
            // 
            this.tbxAInPrice.Location = new System.Drawing.Point(37, 168);
            this.tbxAInPrice.Name = "tbxAInPrice";
            this.tbxAInPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxAInPrice.TabIndex = 9;
            // 
            // lblAInPrice
            // 
            this.lblAInPrice.AutoSize = true;
            this.lblAInPrice.Location = new System.Drawing.Point(34, 148);
            this.lblAInPrice.Name = "lblAInPrice";
            this.lblAInPrice.Size = new System.Drawing.Size(31, 17);
            this.lblAInPrice.TabIndex = 8;
            this.lblAInPrice.Text = "&Prix";
            // 
            // tbxAInInitialQuantity
            // 
            this.tbxAInInitialQuantity.Location = new System.Drawing.Point(250, 168);
            this.tbxAInInitialQuantity.Name = "tbxAInInitialQuantity";
            this.tbxAInInitialQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbxAInInitialQuantity.TabIndex = 11;
            // 
            // lblAInInitialQuantity
            // 
            this.lblAInInitialQuantity.AutoSize = true;
            this.lblAInInitialQuantity.Location = new System.Drawing.Point(247, 148);
            this.lblAInInitialQuantity.Name = "lblAInInitialQuantity";
            this.lblAInInitialQuantity.Size = new System.Drawing.Size(106, 17);
            this.lblAInInitialQuantity.TabIndex = 10;
            this.lblAInInitialQuantity.Text = "&Quantité initiale";
            // 
            // btnAInSubmit
            // 
            this.btnAInSubmit.Location = new System.Drawing.Point(153, 224);
            this.btnAInSubmit.Name = "btnAInSubmit";
            this.btnAInSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnAInSubmit.TabIndex = 12;
            this.btnAInSubmit.Text = "&Créer";
            this.btnAInSubmit.UseVisualStyleBackColor = true;
            // 
            // FormAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 278);
            this.Controls.Add(this.btnAInSubmit);
            this.Controls.Add(this.tbxAInInitialQuantity);
            this.Controls.Add(this.lblAInInitialQuantity);
            this.Controls.Add(this.tbxAInPrice);
            this.Controls.Add(this.lblAInPrice);
            this.Controls.Add(this.cbxAInUnity);
            this.Controls.Add(this.lblAInUnity);
            this.Controls.Add(this.tbxAInName);
            this.Controls.Add(this.rbtAInSpice);
            this.Controls.Add(this.rbtAInStandart);
            this.Controls.Add(this.lblAInType);
            this.Controls.Add(this.lblAInName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 325);
            this.MinimumSize = new System.Drawing.Size(405, 325);
            this.Name = "FormAddIngredient";
            this.Text = "Nouvel Ingrédient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAInName;
        private System.Windows.Forms.Label lblAInType;
        private System.Windows.Forms.RadioButton rbtAInStandart;
        private System.Windows.Forms.RadioButton rbtAInSpice;
        private System.Windows.Forms.TextBox tbxAInName;
        private System.Windows.Forms.Label lblAInUnity;
        private System.Windows.Forms.ComboBox cbxAInUnity;
        private System.Windows.Forms.TextBox tbxAInPrice;
        private System.Windows.Forms.Label lblAInPrice;
        private System.Windows.Forms.TextBox tbxAInInitialQuantity;
        private System.Windows.Forms.Label lblAInInitialQuantity;
        private System.Windows.Forms.Button btnAInSubmit;
    }
}