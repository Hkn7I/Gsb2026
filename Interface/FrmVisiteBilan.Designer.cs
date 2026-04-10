namespace Interface
{
    partial class FrmVisiteBilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteBilan));
            panel6 = new Panel();
            panel8 = new Panel();
            button2 = new Button();
            panel10 = new Panel();
            textBox1 = new TextBox();
            panel7 = new Panel();
            label7 = new Label();
            label6 = new Label();
            dgvEchantillion = new DataGridView();
            Colonne0 = new DataGridViewTextBoxColumn();
            Colonne1 = new DataGridViewTextBoxColumn();
            Colonne2 = new DataGridViewTextBoxColumn();
            Colonne3 = new DataGridViewImageColumn();
            Colonne4 = new DataGridViewImageColumn();
            Colonne5 = new DataGridViewImageColumn();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillion).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1006, 74);
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(1006, 301);
            panel6.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(button2);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textBox1);
            panel8.Location = new Point(11, 67);
            panel8.Name = "panel8";
            panel8.Size = new Size(982, 219);
            panel8.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(367, 176);
            button2.Name = "button2";
            button2.Size = new Size(156, 38);
            button2.TabIndex = 2;
            button2.Text = "Enregistrer la fiche visite";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(dgvEchantillion);
            panel10.Location = new Point(586, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(378, 211);
            panel10.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 92);
            textBox1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(3, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(990, 47);
            panel7.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 4;
            label7.Text = "Chez";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 3;
            label6.Text = "Le";
            // 
            // dgvEchantillion
            // 
            dgvEchantillion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillion.Columns.AddRange(new DataGridViewColumn[] { Colonne0, Colonne1, Colonne2, Colonne3, Colonne4, Colonne5 });
            dgvEchantillion.Location = new Point(39, 27);
            dgvEchantillion.Name = "dgvEchantillion";
            dgvEchantillion.Size = new Size(304, 150);
            dgvEchantillion.TabIndex = 0;
            dgvEchantillion.CellContentClick += dgvEchantillion_CellContentClick;
            // 
            // Colonne0
            // 
            Colonne0.HeaderText = "Medicament";
            Colonne0.Name = "Colonne0";
            // 
            // Colonne1
            // 
            Colonne1.HeaderText = "Nom";
            Colonne1.Name = "Colonne1";
            // 
            // Colonne2
            // 
            Colonne2.HeaderText = "Quantité";
            Colonne2.Name = "Colonne2";
            // 
            // Colonne3
            // 
            Colonne3.HeaderText = "";
            Colonne3.Name = "Colonne3";
            // 
            // Colonne4
            // 
            Colonne4.HeaderText = "";
            Colonne4.Name = "Colonne4";
            // 
            // Colonne5
            // 
            Colonne5.HeaderText = "";
            Colonne5.Name = "Colonne5";
            // 
            // FrmVisiteBilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(panel6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteBilan";
            Text = "FrmVisiteBilan";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panel6, 0);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox cbxEchantillon;
        private Button button1;
        private Panel panel6;
        private Label label4;
        private TextBox textBox2;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private Panel panel10;
        private Button button2;
        private Label label7;
        private Label label6;
        private DataGridView dgvEchantillion;
        private DataGridViewTextBoxColumn Colonne0;
        private DataGridViewTextBoxColumn Colonne1;
        private DataGridViewTextBoxColumn Colonne2;
        private DataGridViewImageColumn Colonne3;
        private DataGridViewImageColumn Colonne4;
        private DataGridViewImageColumn Colonne5;
    }
}