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
            label5 = new Label();
            button2 = new Button();
            panel10 = new Panel();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            panel7 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(800, 301);
            panel6.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(numericUpDown1);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textBox1);
            panel8.Location = new Point(11, 67);
            panel8.Name = "panel8";
            panel8.Size = new Size(776, 219);
            panel8.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 5);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(327, 160);
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
            panel10.Location = new Point(509, 23);
            panel10.Name = "panel10";
            panel10.Size = new Size(249, 175);
            panel10.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(650, 5);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            panel7.Size = new Size(784, 47);
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
            // FrmVisiteBilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}