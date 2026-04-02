using Donnee;
using Metier;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Interface
{
    public partial class FrmVisiteConsultation : FrmBase
    {
        public FrmVisiteConsultation(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
            parametrerComposant();
            remplirDgv();
        }
        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }




        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Consultation des visites";
            // paramétrage du datagridview
            parametrerDgv(dgvVisites);
        }


        private void parametrerDgv(DataGridView dgv)
        {
            // initialisation du datagridview : supprimerRendezVous des colonnes et des lignes ajoutées par défaut dans le composant
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage concernant le datagridview dans son ensemble

            // Accessibilité (doit être sur true si on veut pouvoir utiliser les barres de défilement)
            dgv.Enabled = true;

            // style de bordure
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // couleur de fond 
            dgv.BackgroundColor = Color.White;

            // couleur de texte  
            dgv.ForeColor = Color.Black;

            // police de caractères par défaut
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);

            // mode de sélection dans le composant : FullRowSelect, CellSelect ...
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // sélection multiple 
            dgv.MultiSelect = false;

            // l'utilisateur peut-il ajouter ou supprimer des lignes ?
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;

            // L'utilisateur peut-il modifier le contenu des cellules ou est-elle réservée à la programmation ?
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            // l'utilisateur peut-il redimensionner les colonnes et les lignes ?
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            // l'utilisateur peut-il modifier l'ordre des colonnes ?
            dgv.AllowUserToOrderColumns = false;

            // le composant accepte t'il le 'déposer' dans un Glisser - Déposer ?
            dgv.AllowDrop = false;

            // Largeur : à contrôler avec la largeur des colonnes si elle est définie
            // dgv.Width = 700;

            // faut-il ajuster automatiquement la taille des colonnes par un ajustement proportionnel à la largeur totale (commenter la ligne si non)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #endregion

            #region paramètrage concernant la ligne d'entête 

            // visibilité
            dgv.ColumnHeadersVisible = true;

            // bordure
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // style  [à adapter] (ici : noir sur fond transparent sans mise en évidence de la sélection)
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;    // même couleur que backColor pour ne pas mettre en évidence la colonne sélectionnée
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);


            // hauteur 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne (la colonne d'entête ou le sélecteur)

            // visible 
            dgv.RowHeadersVisible = false;

            // style de bordure  
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            #endregion

            #region paramètrage au niveau des lignes

            // Hauteur 
            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            // style de bordure 
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // couleur de fond, ne pas utiliser transparent car la couleur de la ligne sélectionnée restera après sélection
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Couleur alternative appliquée une ligne sur deux
            // unDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            // couleur de fond mettre la même que les cellules si on ne veut pas mettre la zone en évidence 
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;

            // couleur du texte
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramètrage des colonnes

            // faut-il ajuster automatiquement la taille des colonnes par un ajustement proportionnel à la largeur totale (commenter la ligne si non)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            // description de chaque colonne  [partie à personnaliser] 
            DataGridViewColumn col;

            // la première colonne contient l'objet visite : elle est masquée
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "Visite";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 0 : La date de la visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 1 :  heure du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 2 : ville du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // faut-il désactiver le tri sur toutes les colonnes ? (commenter les lignes si non)
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            #endregion
        }
        private void remplirDgv()
        {
            // vider le datagridview
            dgvVisites.Rows.Clear();

            int ligne = 0;
            // Parcourir les visites dans l'ordre chronologique
            foreach (Visite v in session.MesVisites.OrderBy(v => v.DateEtHeure))
            {
                dgvVisites.Rows.Add(
                         v,
                         v.DateEtHeure.ToLongDateString(),
                         v.DateEtHeure.ToString("HH:mm"),
                         v.LePraticien.Ville);

                if (v.Bilan != null)
                {
                    for (int i = 1; i <= 3; i++)
                    { dgvVisites.Rows[ligne].Cells[i].Style.ForeColor = Color.Green; }
                }
                ligne++;
            }
            //afficher le détail de la première visite contenue dans le datagridview
            afficher();
        }

        // Afficher le détail de la visite sélectionnée dans le datagridview
        private void afficher()
        {
            if (dgvVisites.Rows.Count == 0 || dgvVisites.SelectedRows.Count == 0)
            {
                return; 
            }
            //afficher le détail de la visite sélectionnée
            Visite uneVisite = (Visite)dgvVisites.SelectedRows[0].Cells[0].Value;
            lblPraticien.Text = uneVisite.LePraticien.NomPrenom;
            lblEmail.Text = uneVisite.LePraticien.Email;
            lblRue.Text = uneVisite.LePraticien.Rue;
            lblTelephone.Text = uneVisite.LePraticien.Telephone;
            lblType.Text = uneVisite.LePraticien.Type != null ? uneVisite.LePraticien.Type.Libelle : "";
            lblSpecialite.Text = uneVisite.LePraticien.Specialite != null ? uneVisite.LePraticien.Specialite.Libelle : "";
        }
    }
}

    