using Metier;
using Donnee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
            parametrerComposant();
            remplirDgv();

            // S'abonner aux événements
            button1.Click += btnModifier_Click;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;
            dgvVisites.CellContentClick += dgvVisites_CellContentClick;
        }

        private void btnModifier_Click(object? sender, EventArgs e)
        {
            modifier();
        }

        private void dgvVisites_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVisites.SelectedRows.Count > 0)
            {
                Visite v = (Visite)dgvVisites.SelectedRows[0].Cells["Visite"].Value;
                lbNom.Text = v.LePraticien.NomPrenom;
                label3.Text = $"prévue initialement le {v.DateEtHeure.ToString("dd/MM/yyyy HH:mm")}";
                dtpDate.Value = v.DateEtHeure.Date;
                dateTimePicker1.Value = v.DateEtHeure;
            }
        }

        private void dgvVisites_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si le clic est sur la colonne Supprimer (index 1)
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                Visite v = (Visite)dgvVisites.Rows[e.RowIndex].Cells["Visite"].Value;
                supprimer(v);
            }
        }

        private void parametrerComposant()
        {
            // paramétrage du datagridview
            parametrerDgv(dgvVisites);
        }

        private void parametrerDgv(DataGridView dgv)
        {
            // initialisation du datagridview
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage concernant le datagridview dans son ensemble

            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #endregion

            #region paramètrage concernant la ligne d'entête 

            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 11, FontStyle.Bold);

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne (la colonne d'entête ou le sélecteur)

            dgv.RowHeadersVisible = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            #endregion

            #region paramètrage au niveau des lignes

            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.Lavender;
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramètrage des colonnes

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn col;
            DataGridViewImageColumn colImg;

            // Colonne 0 : cachée, contient l'objet visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "Visite";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : image permettant de supprimer la visite
            colImg = new DataGridViewImageColumn();
            colImg.Name = "Supprimer";
            colImg.HeaderText = "";
            colImg.Image = Properties.Resources.supprimer;
            colImg.Width = 30;
            colImg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colImg.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(colImg);

            // Colonne 2 : date
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 3 : heure du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 4 : ville
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 5 : praticien à rencontrer
            col = new DataGridViewTextBoxColumn();
            col.Name = "Praticien";
            col.HeaderText = "chez";
            col.Width = 250;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Désactiver le tri sur toutes les colonnes
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            #endregion
        }

        private void remplirDgv()
        {
            // vider le datagridview
            dgvVisites.Rows.Clear();

            // Parcourir les visites
            foreach (Visite v in session.MesVisites.Where(v => v.Bilan is null).OrderBy(v => v.DateEtHeure))
            {
                dgvVisites.Rows.Add(
                         v,
                         Properties.Resources.supprimer,
                         v.DateEtHeure.ToString("dddd d MMMM yyyy"),
                         v.DateEtHeure.ToString("HH:mm"),
                         v.LePraticien.Ville,
                         v.LePraticien.NomPrenom);
            }
        }

        private void ajouter(Praticien p, Motif m, DateTime date)
        {
            try
            {
                int id = Passerelle.ajouterRendezVous(p.Id, m.Id, date);
                session.MesVisites.Add(new Visite(id, p, m, date));
                remplirDgv();
                MessageBox.Show("Rendez-vous ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifier()
        {
            if (dgvVisites.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Visite v = (Visite)dgvVisites.SelectedRows[0].Cells["Visite"].Value;
            DateTime nouvelleDate = dtpDate.Value.Date + dateTimePicker1.Value.TimeOfDay;

            if (nouvelleDate < DateTime.Now.AddHours(1))
            {
                MessageBox.Show("Veuillez sélectionner une date et une heure futures.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (nouvelleDate.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Veuillez sélectionner une date qui n'est pas un dimanche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nouvelleDate.Hour < 8 || nouvelleDate.Hour >= 19)
            {
                MessageBox.Show("Veuillez sélectionner une heure entre 8 h et 19 h.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // vérifier les conflits
            if (session.MesVisites.Any(vis => vis.Id != v.Id && vis.LePraticien == v.LePraticien && vis.Bilan is null && vis.DateEtHeure == nouvelleDate))
            {
                MessageBox.Show("Le praticien sélectionné a déjà un rendez-vous programmé à cette heure.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Passerelle.modifierRendezVous(v.Id, nouvelleDate);
                v.DateEtHeure = nouvelleDate;
                remplirDgv();
                MessageBox.Show("Le rendez-vous a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer(Visite v)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer ce rendez-vous ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.supprimerRendezVous(v.Id);
                    session.MesVisites.Remove(v);
                    remplirDgv();
                    MessageBox.Show("Le rendez-vous a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
