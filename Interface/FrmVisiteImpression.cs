using Interface;
using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteImpression : FrmBase
    {
        private List<Visite> lesVisites = new List<Visite>();

        public FrmVisiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();

            this.Load += FrmVisiteImpression_Load;
        }

        private void FrmVisiteImpression_Load(object? sender, EventArgs e)
        {
            // recentrer le formulaire
            centrerFormulaire();

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddMonths(2);

            // initialisation de la collection des visites actuelles
            lesVisites = getVisitesActuelles();

            // paramétrage des composants spécifiques à ce formulaire
            parametrerComposant();
        }
        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Impression des rendez-vous sur une période";

            this.pictureBox3.Click += new System.EventHandler(this.BtnImprimer_Click);
            this.pictureBox2.Click += new System.EventHandler(this.BtnApercu_Click);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
        }

            private List<Visite> getVisitesActuelles()
            {
                if (session?.MesVisites == null)
                    return new List<Visite>();

                return session.MesVisites
                    .Where(v => v.Bilan is null)
                    .OrderBy(v => v.DateEtHeure)
                    .ToList();
            }

            private bool controlerPeriode()
            {
                if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                {
                    MessageBox.Show("La date de début doit être inférieure ou égale à la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            private int _indexImpression = 0;

            private void BtnImprimer_Click(object? sender, EventArgs e)
            {
                if (!controlerPeriode()) return;

                lesVisites = getVisitesActuelles();

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    _indexImpression = 0;
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.Print();
                }
            }

            private void BtnApercu_Click(object? sender, EventArgs e)
            {
                if (!controlerPeriode()) return;

                lesVisites = getVisitesActuelles();

                _indexImpression = 0;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            private void PrintDocument1_PrintPage(object? sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                if (e.Graphics == null) return;

                Font fontTitre = new Font("Arial", 14, FontStyle.Bold);
                Font fontTexte = new Font("Arial", 12);
                float yPos = e.MarginBounds.Top;
                float leftMargin = e.MarginBounds.Left;

                DateTime dateDebut = dateTimePicker1.Value.Date;
                DateTime dateFin = dateTimePicker2.Value.Date;

                if (_indexImpression == 0)
                {
                    e.Graphics.DrawString("Liste des rendez-vous", fontTitre, Brushes.Black, leftMargin, yPos);
                    yPos += 40;

                    e.Graphics.DrawString($"Du {dateDebut.ToShortDateString()} au {dateFin.ToShortDateString()}", fontTexte, Brushes.Black, leftMargin, yPos);
                    yPos += 40;
                }

                var visitesFiltrees = lesVisites
                    .Where(v => v.DateEtHeure.Date >= dateDebut && v.DateEtHeure.Date <= dateFin)
                    .ToList();

                if (visitesFiltrees.Count == 0 && _indexImpression == 0)
                {
                    e.Graphics.DrawString("Aucun rendez-vous sur cette période.", fontTexte, Brushes.Black, leftMargin, yPos);
                    e.HasMorePages = false;
                    return;
                }

                while (_indexImpression < visitesFiltrees.Count)
                {
                    var visite = visitesFiltrees[_indexImpression];
                    string texte = $"- {visite.DateEtHeure.ToString("g")} : {visite.LePraticien.Nom} {visite.LePraticien.Prenom} à {visite.LePraticien.Ville} ({visite.LePraticien.Rue})";
                    e.Graphics.DrawString(texte, fontTexte, Brushes.Black, leftMargin, yPos);
                    yPos += 30;
                    _indexImpression++;

                    if (yPos + 30 > e.MarginBounds.Bottom && _indexImpression < visitesFiltrees.Count)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                e.HasMorePages = false;
            }
        }
    }