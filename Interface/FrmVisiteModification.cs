using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteModification : FrmBase
    {
        public FrmVisiteModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmVisiteModification_Load(object sender, EventArgs e)
        {
            lblTitre.Text = "Modification d'une visite";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvVisites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
