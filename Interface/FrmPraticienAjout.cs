using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPraticienAjout : FrmBase
    {
        public FrmPraticienAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmPraticienAjout_Load(object sender, EventArgs e)
            {
                parametrerComposant();
            }

            #region Paramétrage

            private void parametrerComposant()
            {
                // Remplissage cbxType
                cbxType.DataSource = session.LesTypesPraticien;
                cbxType.DisplayMember = "Libelle";
                cbxType.SelectedIndex = -1;

                // Remplissage cbxSpecialite (optionnel)
                cbxSpecialite.DataSource = session.LesSpecialites;
                cbxSpecialite.DisplayMember = "Libelle";
                cbxSpecialite.SelectedIndex = -1;

                // Autocomplétion sur la ville
                txtVille.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtVille.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var source = new AutoCompleteStringCollection();
                foreach (Ville ville in session.MesVilles)
                    source.Add(ville.Nom);
                txtVille.AutoCompleteCustomSource = source;

                // Cacher tous les messages d'erreur au départ
                messageNom.Visible = false;
                messagePrenom.Visible = false;
                messageRue.Visible = false;
                messageVille.Visible = false;
                messageEmail.Visible = false;
                messageTelephone.Visible = false;
                messageType.Visible = false;
            }

            #endregion

            #region Contrôles de saisie

            private bool controlerChamp(TextBox txt, Label lblMessage, string message)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    lblMessage.Text = message;
                    lblMessage.Visible = true;
                    return false;
                }
                lblMessage.Text = "";
                lblMessage.Visible = false;
                return true;
            }

            private bool controlerVille()
            {
                if (string.IsNullOrWhiteSpace(txtVille.Text))
                {
                    messageVille.Text = "La ville doit être renseignée";
                    messageVille.Visible = true;
                    return false;
                }
                Ville? laVille = session.MesVilles.Find(x => x.Nom == txtVille.Text);
                if (laVille == null)
                {
                    messageVille.Text = "Cette ville ne fait pas partie du secteur géré";
                    messageVille.Visible = true;
                    return false;
                }
                messageVille.Visible = false;
                return true;
            }

            private bool controlerEmail()
            {
                if (txtEmail.Text == string.Empty)
                {
                    messageEmail.Text = "L'adresse mail du praticien doit être précisée";
                    messageEmail.Visible = true;
                    return false;
                }
                Regex uneExpression = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                if (!uneExpression.IsMatch(txtEmail.Text))
                {
                    messageEmail.Text = "L'adresse mail n'est pas valide";
                    messageEmail.Visible = true;
                    return false;
                }
                messageEmail.Text = "";
                messageEmail.Visible = false;
                return true;
            }

            private bool controlerTelephone()
            {
                if (!mtbTelephone.MaskFull)
                {
                    messageTelephone.Text = "Le téléphone du praticien doit être précisé";
                    messageTelephone.Visible = true;
                    return false;
                }
                messageTelephone.Visible = false;
                return true;
            }

            private bool controlerType()
            {
                if (cbxType.SelectedIndex == -1)
                {
                    messageType.Text = "Veuillez sélectionner le type de praticien.";
                    messageType.Visible = true;
                    return false;
                }
                messageType.Text = "";
                messageType.Visible = false;
                return true;
            }

            #endregion

            #region Ajout

            private void ajout()
            {
                bool nomOk = controlerChamp(txtNom, messageNom, "Le nom du praticien doit être précisé");
                bool prenomOk = controlerChamp(txtPrenom, messagePrenom, "Le prénom du praticien doit être précisé");
                bool rueOk = controlerChamp(txtRue, messageRue, "La rue du praticien doit être précisée");
                bool villeOk = controlerVille();
                bool emailOk = controlerEmail();
                bool telephoneOk = controlerTelephone();
                bool typeOk = controlerType();

                if (nomOk && prenomOk && rueOk && villeOk && emailOk && telephoneOk && typeOk)
                    ajouter();
            }

            private void ajouter()
            {
                // Récupération des valeurs
                Ville laVille = session.MesVilles.Find(x => x.Nom == txtVille.Text)!;
                string codePostal = laVille.Code;

                string idType = ((TypePraticien)cbxType.SelectedItem!).Id;

                string? idSpecialite = cbxSpecialite.SelectedIndex != -1
                    ? ((Specialite)cbxSpecialite.SelectedItem!).Id
                    : null;

                // Téléphone sans espaces (MaskedTextBox renvoie le masque avec espaces)
                string telephone = mtbTelephone.Text.Replace(" ", "");

                try
                {
                    int idPraticien = Passerelle.ajouterPraticien(
                        txtNom.Text.Trim(),
                        txtPrenom.Text.Trim(),
                        txtRue.Text.Trim(),
                        codePostal,
                        txtVille.Text.Trim(),
                        telephone,
                        txtEmail.Text.Trim(),
                        idType,
                        idSpecialite
                    );

                    // Mise à jour de la session
                    TypePraticien letype = session.LesTypesPraticien.Find(t => t.Id == idType)!;
                    Specialite? laSpecialite = idSpecialite != null
                        ? session.LesSpecialites.Find(s => s.Id == idSpecialite)
                        : null;

                    Praticien nouveauPraticien = new Praticien(
                        idPraticien,
                        txtNom.Text.Trim(),
                        txtPrenom.Text.Trim(),
                        txtRue.Text.Trim(),
                        codePostal,
                        txtVille.Text.Trim(),
                        txtEmail.Text.Trim(),
                        telephone,
                        letype,
                        laSpecialite
                    );

                    session.MesPraticiens.Add(nouveauPraticien);
                    session.MesPraticiens.Sort();

                    // Réinitialisation du formulaire
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtRue.Clear();
                    txtVille.Clear();
                    txtEmail.Clear();
                    mtbTelephone.Clear();
                    cbxType.SelectedIndex = -1;
                    cbxSpecialite.SelectedIndex = -1;

                    MessageBox.Show("Praticien ajouté avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            #endregion

            #region Événements

            private void btnAjouter_Click(object sender, EventArgs e)
            {
                ajout();
            }

            // Permet de déclencher l'ajout via la touche Entrée
            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter) ajout();
                base.OnKeyDown(e);
            }

            #endregion
        }
}
