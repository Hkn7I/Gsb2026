namespace Interface
{
    partial class FrmVisiteModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteModification));
            panel5 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            lbDate = new Label();
            lbNom = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            panelDroit = new Panel();
            panel2 = new Panel();
            dgvVisites = new DataGridView();
            label2 = new Label();
            panel5.SuspendLayout();
            panelDroit.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1270, 74);
            // 
            // panel5
            // 
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(dtpDate);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lbDate);
            panel5.Controls.Add(lbNom);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(34, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 403);
            panel5.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(30, 279);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(30, 244);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 59);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Le rendez vous chez";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(30, 159);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(178, 15);
            lbDate.TabIndex = 3;
            lbDate.Text = "Date et Heure du rendez vous ";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNom.Location = new Point(30, 90);
            lbNom.Name = "lbNom";
            lbNom.RightToLeft = RightToLeft.No;
            lbNom.Size = new Size(103, 15);
            lbNom.TabIndex = 1;
            lbNom.Text = "Nom du praticien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "prévue initialement le";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(247, 333);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 6;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 193);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "est remis au ";
            // 
            // panelDroit
            // 
            panelDroit.Controls.Add(panel5);
            panelDroit.Dock = DockStyle.Right;
            panelDroit.Location = new Point(766, 98);
            panelDroit.Name = "panelDroit";
            panelDroit.Size = new Size(504, 419);
            panelDroit.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvVisites);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(766, 419);
            panel2.TabIndex = 14;
            // 
            // dgvVisites
            // 
            dgvVisites.BackgroundColor = SystemColors.ButtonShadow;
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(0, 15);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(766, 404);
            dgvVisites.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 15);
            label2.TabIndex = 0;
            label2.Text = "Selectionner la visite afin de modifier le rendez vous ";
            // 
            // FrmVisiteModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 562);
            Controls.Add(panel2);
            Controls.Add(panelDroit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteModification";
            Text = "FrmVisiteModification";
            Load += FrmVisiteModification_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroit, 0);
            Controls.SetChildIndex(panel2, 0);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelDroit.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Panel panel5;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label lbDate;
        private Label lbNom;
        private Label label3;
        private Button button1;
        private Label label5;
        private Panel panelDroit;
        private Panel panel2;
        private Label label2;
        private DataGridView dgvVisites;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Visite;
        private DataGridViewTextBoxColumn Supprimer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Ville;
        private DataGridViewTextBoxColumn Praticien;
    }
}