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
    public partial class FrmVisiteAjout : FrmBase
    {
        public FrmVisiteAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmVisiteAjout_Load(object sender, EventArgs e)
        {
            ParametreComposant();

        }



        private void ParametreComposant()
        {
            lblTitre.Text = "Ajouter une visite";
            //qsds
            foreach (Praticien unPraticien in session.MesPraticiens)
            {
                cbxPraticien.Items.Add(unPraticien);
            }
            cbxPraticien.DisplayMember = "NomPrenom";
            cbxPraticien.ValueMember = "ID";
            cbxPraticien.SelectedIndex = 0;
            //
            cbxMotif.DataSource = session.LesMotifs;
            cbxMotif.DisplayMember = "Libelle";
            cbxMotif.ValueMember = "Id";
        }

        //parametrage du DataGridView
        paramatrerDgv(dgvVisites);

        #region procedures
        private void paramatrerComposant()

        private void paramatrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Add("Date", "Date de la visite");
            dgv.Columns.Add("Motif", "Motif de la visite");
            dgv.Columns.Add("Praticien", "Praticien visité");
        }
        private void remplirDgv()
        {
            dgvVisites.Rows.Clear();
            foreach (Visite uneVisite in session.MesVisites.Where(v => v.Bilan is null))
            {
                dgvVisites.Rows.Add(v.DateEtHeure, v.DateEtHeure);

            }
            {
                dgvVisites.Rows.Add(uneVisite.Date, uneVisite.UnMotif.Libelle, uneVisite.UnPraticien.NomPrenom);
            }
        }














        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelGauche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVisites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
