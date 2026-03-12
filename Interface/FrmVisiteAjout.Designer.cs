namespace Interface
{
    partial class FrmVisiteAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteAjout));
            panelDroite = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            Praticien = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbxMotif = new ComboBox();
            label3 = new Label();
            cbxPraticien = new ComboBox();
            panelGauche = new Panel();
            label1 = new Label();
            dgvVisites = new DataGridView();
            panelDroite.SuspendLayout();
            panel3.SuspendLayout();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(873, 74);
            // 
            // panelDroite
            // 
            panelDroite.BackColor = Color.White;
            panelDroite.Controls.Add(label4);
            panelDroite.Controls.Add(panel3);
            panelDroite.Dock = DockStyle.Right;
            panelDroite.Location = new Point(440, 98);
            panelDroite.Name = "panelDroite";
            panelDroite.Size = new Size(433, 307);
            panelDroite.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 13);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 15;
            label4.Text = "Nouveau rendez-vous";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(Praticien);
            panel3.Controls.Add(dtpDate);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cbxMotif);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbxPraticien);
            panel3.Location = new Point(16, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 250);
            panel3.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(174, 193);
            button1.Name = "button1";
            button1.Size = new Size(111, 34);
            button1.TabIndex = 15;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // Praticien
            // 
            Praticien.AutoSize = true;
            Praticien.Location = new Point(27, 26);
            Praticien.Name = "Praticien";
            Praticien.Size = new Size(53, 15);
            Praticien.TabIndex = 15;
            Praticien.Text = "Praticien";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(152, 142);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Motif";
            // 
            // cbxMotif
            // 
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Location = new Point(152, 83);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(200, 23);
            cbxMotif.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 148);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 15;
            label3.Text = "Date et Heure";
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(152, 26);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(200, 23);
            cbxPraticien.TabIndex = 15;
            // 
            // panelGauche
            // 
            panelGauche.BackColor = SystemColors.Window;
            panelGauche.Controls.Add(label1);
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Dock = DockStyle.Fill;
            panelGauche.Location = new Point(0, 98);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(10);
            panelGauche.Size = new Size(440, 307);
            panelGauche.TabIndex = 14;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(420, 15);
            label1.TabIndex = 15;
            label1.Text = "Liste des rendez-vous dejà programmé";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(10, 10);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(420, 287);
            dgvVisites.TabIndex = 16;
            // 
            // FrmVisiteAjout
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(873, 450);
            Controls.Add(panelGauche);
            Controls.Add(panelDroite);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteAjout";
            Text = "FrmVisiteAjout";
            Load += FrmVisiteAjout_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroite, 0);
            Controls.SetChildIndex(panelGauche, 0);
            panelDroite.ResumeLayout(false);
            panelDroite.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGauche;
        private Label label1;
        private Label Praticien;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel3;
        private DataGridView dgvVisites;
        private DateTimePicker dtpDate;
        private ComboBox cbxMotif;
        private ComboBox cbxPraticien;
        private Panel panelDroite;
    }
}