namespace Interface
{
    partial class FrmPraticienAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienAjout));
            PanelCentral = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtRue = new TextBox();
            txtVille = new TextBox();
            txtEmail = new TextBox();
            btnAjouter = new Button();
            cbxSpecialite = new ComboBox();
            cbxType = new ComboBox();
            mtbTelephone = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            messageNom = new Label();
            messageRue = new Label();
            messageTelephone = new Label();
            messageEmail = new Label();
            messageType = new Label();
            messageSpecialité = new Label();
            messageVille = new Label();
            messagePrenom = new Label();
            PanelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // PanelCentral
            // 
            PanelCentral.Controls.Add(messagePrenom);
            PanelCentral.Controls.Add(messageVille);
            PanelCentral.Controls.Add(messageSpecialité);
            PanelCentral.Controls.Add(messageType);
            PanelCentral.Controls.Add(messageEmail);
            PanelCentral.Controls.Add(messageTelephone);
            PanelCentral.Controls.Add(messageRue);
            PanelCentral.Controls.Add(messageNom);
            PanelCentral.Controls.Add(label8);
            PanelCentral.Controls.Add(label7);
            PanelCentral.Controls.Add(label6);
            PanelCentral.Controls.Add(label5);
            PanelCentral.Controls.Add(label4);
            PanelCentral.Controls.Add(label3);
            PanelCentral.Controls.Add(mtbTelephone);
            PanelCentral.Controls.Add(cbxType);
            PanelCentral.Controls.Add(cbxSpecialite);
            PanelCentral.Controls.Add(btnAjouter);
            PanelCentral.Controls.Add(txtEmail);
            PanelCentral.Controls.Add(txtVille);
            PanelCentral.Controls.Add(txtRue);
            PanelCentral.Controls.Add(txtPrenom);
            PanelCentral.Controls.Add(txtNom);
            PanelCentral.Controls.Add(label2);
            PanelCentral.Controls.Add(label1);
            PanelCentral.Location = new Point(0, 113);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(800, 289);
            PanelCentral.TabIndex = 13;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 17);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(29, 44);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(140, 23);
            txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(478, 44);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(140, 23);
            txtPrenom.TabIndex = 3;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(29, 119);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(140, 23);
            txtRue.TabIndex = 4;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(478, 119);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(140, 23);
            txtVille.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(478, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(140, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Location = new Point(362, 240);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // cbxSpecialite
            // 
            cbxSpecialite.FormattingEnabled = true;
            cbxSpecialite.Location = new Point(478, 241);
            cbxSpecialite.Name = "cbxSpecialite";
            cbxSpecialite.Size = new Size(121, 23);
            cbxSpecialite.TabIndex = 9;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(29, 241);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(121, 23);
            cbxType.TabIndex = 10;
            // 
            // mtbTelephone
            // 
            mtbTelephone.Location = new Point(29, 185);
            mtbTelephone.Mask = "00 00 00 00 00 ";
            mtbTelephone.Name = "mtbTelephone";
            mtbTelephone.Size = new Size(100, 23);
            mtbTelephone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "Rue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 90);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 13;
            label4.Text = "Ville";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 167);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Telephone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(478, 167);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 223);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 16;
            label7.Text = "Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 223);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 17;
            label8.Text = "Specialité";
            // 
            // messageNom
            // 
            messageNom.AutoSize = true;
            messageNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageNom.ForeColor = Color.Red;
            messageNom.Location = new Point(29, 70);
            messageNom.Name = "messageNom";
            messageNom.Size = new Size(30, 15);
            messageNom.TabIndex = 18;
            messageNom.Text = "msg";
            // 
            // messageRue
            // 
            messageRue.AutoSize = true;
            messageRue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageRue.ForeColor = Color.Red;
            messageRue.Location = new Point(193, 127);
            messageRue.Name = "messageRue";
            messageRue.Size = new Size(30, 15);
            messageRue.TabIndex = 19;
            messageRue.Text = "msg";
            // 
            // messageTelephone
            // 
            messageTelephone.AutoSize = true;
            messageTelephone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageTelephone.ForeColor = Color.Red;
            messageTelephone.Location = new Point(165, 193);
            messageTelephone.Name = "messageTelephone";
            messageTelephone.Size = new Size(30, 15);
            messageTelephone.TabIndex = 20;
            messageTelephone.Text = "msg";
            // 
            // messageEmail
            // 
            messageEmail.AutoSize = true;
            messageEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageEmail.ForeColor = Color.Red;
            messageEmail.Location = new Point(478, 211);
            messageEmail.Name = "messageEmail";
            messageEmail.Size = new Size(30, 15);
            messageEmail.TabIndex = 21;
            messageEmail.Text = "msg";
            // 
            // messageType
            // 
            messageType.AutoSize = true;
            messageType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageType.ForeColor = Color.Red;
            messageType.Location = new Point(156, 249);
            messageType.Name = "messageType";
            messageType.Size = new Size(30, 15);
            messageType.TabIndex = 22;
            messageType.Text = "msg";
            // 
            // messageSpecialité
            // 
            messageSpecialité.AutoSize = true;
            messageSpecialité.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageSpecialité.ForeColor = Color.Red;
            messageSpecialité.Location = new Point(605, 249);
            messageSpecialité.Name = "messageSpecialité";
            messageSpecialité.Size = new Size(30, 15);
            messageSpecialité.TabIndex = 23;
            messageSpecialité.Text = "msg";
            // 
            // messageVille
            // 
            messageVille.AutoSize = true;
            messageVille.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageVille.ForeColor = Color.Red;
            messageVille.Location = new Point(421, 127);
            messageVille.Name = "messageVille";
            messageVille.Size = new Size(30, 15);
            messageVille.TabIndex = 25;
            messageVille.Text = "msg";
            // 
            // messagePrenom
            // 
            messagePrenom.AutoSize = true;
            messagePrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messagePrenom.ForeColor = Color.Red;
            messagePrenom.Location = new Point(458, 70);
            messagePrenom.Name = "messagePrenom";
            messagePrenom.Size = new Size(30, 15);
            messagePrenom.TabIndex = 26;
            messagePrenom.Text = "msg";
            // 
            // FrmPraticienAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienAjout";
            Text = "FrmPraticienAjout";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(PanelCentral, 0);
            PanelCentral.ResumeLayout(false);
            PanelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelCentral;
        private TextBox txtNom;
        private Label label2;
        private Label label1;
        private ComboBox cbxType;
        private ComboBox cbxSpecialite;
        private Button btnAjouter;
        private TextBox txtEmail;
        private TextBox txtVille;
        private TextBox txtRue;
        private TextBox txtPrenom;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtbTelephone;
        private Label messagePrenom;
        private Label messageVille;
        private Label messageSpecialité;
        private Label messageType;
        private Label messageEmail;
        private Label messageTelephone;
        private Label messageRue;
        private Label messageNom;
    }
}
