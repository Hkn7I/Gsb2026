namespace Interface
{
    partial class FrmPraticienModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienModification));
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtRue = new TextBox();
            txtTelephone = new TextBox();
            txtMail = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            panelCentral = new Panel();
            button2 = new Button();
            button1 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNom = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            cbxVille = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // txtNom
            // 
            txtNom.Location = new Point(42, 37);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(155, 23);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(603, 46);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(153, 23);
            txtPrenom.TabIndex = 1;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(42, 96);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(485, 23);
            txtRue.TabIndex = 2;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(41, 226);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(190, 23);
            txtTelephone.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(470, 226);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(276, 23);
            txtMail.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(259, 226);
            maskedTextBox1.Mask = "00 00 00 00 00 ";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(89, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(289, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 23);
            comboBox1.TabIndex = 7;
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Controls.Add(button2);
            panelCentral.Controls.Add(button1);
            panelCentral.Controls.Add(label14);
            panelCentral.Controls.Add(label13);
            panelCentral.Controls.Add(label12);
            panelCentral.Controls.Add(label11);
            panelCentral.Controls.Add(label10);
            panelCentral.Controls.Add(label9);
            panelCentral.Controls.Add(label8);
            panelCentral.Controls.Add(label7);
            panelCentral.Controls.Add(lblNom);
            panelCentral.Controls.Add(comboBox3);
            panelCentral.Controls.Add(comboBox2);
            panelCentral.Controls.Add(cbxVille);
            panelCentral.Controls.Add(label6);
            panelCentral.Controls.Add(label5);
            panelCentral.Controls.Add(label4);
            panelCentral.Controls.Add(label3);
            panelCentral.Controls.Add(label2);
            panelCentral.Controls.Add(label1);
            panelCentral.Controls.Add(comboBox1);
            panelCentral.Controls.Add(maskedTextBox1);
            panelCentral.Controls.Add(txtMail);
            panelCentral.Controls.Add(txtTelephone);
            panelCentral.Controls.Add(txtRue);
            panelCentral.Controls.Add(txtPrenom);
            panelCentral.Controls.Add(txtNom);
            panelCentral.Location = new Point(0, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(800, 386);
            panelCentral.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(470, 336);
            button2.Name = "button2";
            button2.Size = new Size(226, 28);
            button2.TabIndex = 27;
            button2.Text = "Supprimer la fiche du praticien";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(41, 336);
            button1.Name = "button1";
            button1.Size = new Size(226, 28);
            button1.TabIndex = 26;
            button1.Text = "Modifier la fiche du praticien";
            button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(289, 7);
            label14.Name = "label14";
            label14.Size = new Size(111, 15);
            label14.TabIndex = 25;
            label14.Text = "Praticien Recherché";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 208);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 24;
            label13.Text = "Telephone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(470, 208);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 23;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(470, 276);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 22;
            label11.Text = "Specialité";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 276);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 21;
            label10.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 145);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 20;
            label9.Text = "Ville";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 78);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 19;
            label8.Text = "Rue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 25);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 18;
            label7.Text = "Prenom";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(42, 19);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 17;
            lblNom.Text = "Nom";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(470, 294);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(276, 23);
            comboBox3.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(42, 294);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(189, 23);
            comboBox2.TabIndex = 15;
            // 
            // cbxVille
            // 
            cbxVille.FormattingEnabled = true;
            cbxVille.Location = new Point(42, 163);
            cbxVille.Name = "cbxVille";
            cbxVille.Size = new Size(485, 23);
            cbxVille.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(470, 252);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 13;
            label6.Text = "msg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(42, 122);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "msg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(42, 189);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "msg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(41, 252);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "msg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(603, 72);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 9;
            label2.Text = "msg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(41, 63);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 8;
            label1.Text = "msg";
            // 
            // FrmPraticienModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienModification";
            Text = "FrmModifierPraticien";
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtRue;
        private TextBox txtTelephone;
        private TextBox txtMail;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Panel panelCentral;
        private Label label1;
        private ComboBox cbxVille;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblNom;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Button button1;
        private Label label14;
        private Label label13;
        private Button button2;
    }
}