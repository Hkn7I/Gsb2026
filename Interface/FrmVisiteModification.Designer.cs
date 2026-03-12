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
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(524, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 307);
            panel2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 178);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "est remis au ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 135);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 3;
            label4.Text = "Date et Heure du rendez vous ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "prévue initialement le";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Le rendez vous chez";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom du praticien";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 307);
            panel3.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 209);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(174, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmVisiteModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteModification";
            Text = "FrmVisiteModification";
            Load += FrmVisiteModification_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}