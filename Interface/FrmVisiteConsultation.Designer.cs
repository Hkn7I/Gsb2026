namespace Interface
{
    partial class FrmVisiteConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteConsultation));
            panelCentral = new Panel();
            label4 = new Label();
            lstMedicament = new ListBox();
            dgvEchantillion = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelPraticien = new Panel();
            lblSpecialite = new Label();
            lblType = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblRue = new Label();
            lblPraticien = new Label();
            dgvVisites = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillion).BeginInit();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Controls.Add(label6);
            panelCentral.Controls.Add(label4);
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(dgvEchantillion);
            panelCentral.Controls.Add(label3);
            panelCentral.Controls.Add(label2);
            panelCentral.Controls.Add(label1);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Location = new Point(0, 92);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(800, 310);
            panelCentral.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(278, 214);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 7;
            label4.Text = "Medicament présentés";
            // 
            // lstMedicament
            // 
            lstMedicament.FormattingEnabled = true;
            lstMedicament.Location = new Point(278, 242);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(245, 64);
            lstMedicament.TabIndex = 6;
            // 
            // dgvEchantillion
            // 
            dgvEchantillion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillion.Location = new Point(560, 160);
            dgvEchantillion.Name = "dgvEchantillion";
            dgvEchantillion.Size = new Size(200, 100);
            dgvEchantillion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(278, 160);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Bilan de  la visite";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Motif";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Praticien";
            // 
            // panelPraticien
            // 
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Location = new Point(278, 48);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(510, 83);
            panelPraticien.TabIndex = 1;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(231, 35);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(258, 15);
            lblSpecialite.TabIndex = 5;
            lblSpecialite.Text = "lable1";
            // 
            // lblType
            // 
            lblType.Location = new Point(287, 6);
            lblType.Name = "lblType";
            lblType.Size = new Size(119, 15);
            lblType.TabIndex = 4;
            lblType.Text = "lable1";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(3, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(135, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "lable1";
            // 
            // lblTelephone
            // 
            lblTelephone.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelephone.Location = new Point(8, 47);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(82, 13);
            lblTelephone.TabIndex = 2;
            lblTelephone.Text = "lable1";
            
            // 
            // lblRue
            // 
            lblRue.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRue.Location = new Point(8, 22);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(69, 13);
            lblRue.TabIndex = 1;
            lblRue.Text = "lable1";
            // 
            // lblPraticien
            // 
            lblPraticien.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPraticien.Location = new Point(3, 9);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(68, 13);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "lable1";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Location = new Point(3, 9);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(269, 297);
            dgvVisites.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(229, 15);
            label5.TabIndex = 8;
            label5.Text = "Selectionner la visite pour afficher le detail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 186);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // FrmVisiteConsultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(label5);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteConsultation";
            Text = "FrmVisiteConsultation";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(label5, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillion).EndInit();
            panelPraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private DataGridView dgvVisites;
        private Label label1;
        private Panel panelPraticien;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblRue;
        private Label lblPraticien;
        private Label lblSpecialite;
        private Label lblType;
        private ListBox lstMedicament;
        private DataGridView dgvEchantillion;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}