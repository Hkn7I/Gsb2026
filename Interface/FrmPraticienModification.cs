using Donnee;
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
    public partial class FrmPraticienModification : FrmBase
    {
        public FrmPraticienModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            parametrerComposant();
        }

      

        private void parametrerComposant()
        {
            lblTitre.Text = "Mettre à jour les coordonnées d'un praticien";

            this.CenterToScreen();

            // Types de praticiens (comboBox2)
            comboBox2.DataSource = session!.LesTypesPraticien;
            comboBox2.DisplayMember = "Libelle";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Spécialités (comboBox3)
            comboBox3.DataSource = session.LesSpecialites;
            comboBox3.DisplayMember = "Libelle";
            comboBox3.ValueMember = "Id";
            comboBox3.SelectedItem = null;

            // Villes (cbxVille)
            cbxVille.DataSource = session.MesVilles;
            cbxVille.DisplayMember = "Nom";
            cbxVille.ValueMember = "Code";
            cbxVille.SelectedIndex = -1;
            cbxVille.DropDownStyle = ComboBoxStyle.DropDown;

            // Liste des praticiens (comboBox1) — foreach pour mise à jour dynamique
            comboBox1.DisplayMember = "NomPrenom";
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            foreach (var p in session.MesPraticiens)
                comboBox1.Items.Add(p);

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                Praticien lePraticien = (Praticien)comboBox1.SelectedItem!;
                remplirPraticien(lePraticien);
            }

            // Branchement des événements
            button1.Click += btnModifier_Click;
            button2.Click += btnSupprimer_Click;
            comboBox1.SelectedIndexChanged += cbxPraticien_SelectedIndexChanged;

            // Masquer les messages d'erreur au départ
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

       

        private void remplirPraticien(Praticien lePraticien)
        {
            txtNom.Text = lePraticien.Nom;
            txtPrenom.Text = lePraticien.Prenom;
            txtRue.Text = lePraticien.Rue;
            txtMail.Text = lePraticien.Email;
            maskedTextBox1.Text = lePraticien.Telephone;

            // Ville
            foreach (Ville v in cbxVille.Items)
            {
                if (v.Code == lePraticien.CodePostal)
                {
                    cbxVille.SelectedItem = v;
                    break;
                }
            }

            // Type
            foreach (TypePraticien t in comboBox2.Items)
            {
                if (t.Id == lePraticien.Type.Id)
                {
                    comboBox2.SelectedItem = t;
                    break;
                }
            }

            // Spécialité
            if (lePraticien.Specialite != null)
            {
                foreach (Specialite s in comboBox3.Items)
                {
                    if (s.Id == lePraticien.Specialite.Id)
                    {
                        comboBox3.SelectedItem = s;
                        break;
                    }
                }
            }
            else
            {
                comboBox3.SelectedItem = null;
            }
        }

        

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Praticien lePraticien)
            {
                panelCentral.Visible = true;
                remplirPraticien(lePraticien);
            }
        }

        // ─────────────────────────────────────────────
        //  CONTRÔLES DE SAISIE
        // ─────────────────────────────────────────────

        private bool controlerChamp(TextBox txt, Label lblMessage, string message)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                lblMessage.Text = message;
                lblMessage.Visible = true;
                return false;
            }
            lblMessage.Text = string.Empty;
            lblMessage.Visible = false;
            return true;
        }

        private bool controlerEmail()
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                label6.Text = string.Empty;
                label6.Visible = false;
                return true; // non obligatoire
            }
            if (!txtMail.Text.Contains("@") || !txtMail.Text.Contains("."))
            {
                label6.Text = "L'adresse email n'est pas valide";
                label6.Visible = true;
                return false;
            }
            label6.Text = string.Empty;
            label6.Visible = false;
            return true;
        }

        private bool controlerTelephone()
        {
            if (maskedTextBox1.MaskCompleted)
            {
                label3.Text = string.Empty;
                label3.Visible = false;
                return true;
            }
            label3.Text = "Le téléphone doit comporter 10 chiffres";
            label3.Visible = true;
            return false;
        }

        // ─────────────────────────────────────────────
        //  BOUTON MODIFIER (button1)
        // ─────────────────────────────────────────────

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modification();
        }

        private void modification()
        {
            bool nomOk = controlerChamp(txtNom, label1, "Le nom du praticien doit être précisé");
            bool prenomOk = controlerChamp(txtPrenom, label2, "Le prénom du praticien doit être précisé");
            bool rueOk = controlerChamp(txtRue, label4, "La rue du praticien doit être précisée");
            bool emailOk = controlerEmail();
            bool telephoneOk = controlerTelephone();

            if (nomOk && prenomOk && rueOk && emailOk && telephoneOk)
                modifier();
        }

        private void modifier()
        {
            try
            {
                label5.Visible = false;
                Praticien lePraticien = (Praticien)comboBox1.SelectedItem!;
                Ville ville = (Ville)cbxVille.SelectedItem!;

                lePraticien.Nom = txtNom.Text;
                lePraticien.Prenom = txtPrenom.Text;
                lePraticien.Rue = txtRue.Text;
                lePraticien.Ville = ville.Nom;
                lePraticien.CodePostal = ville.Code;
                lePraticien.Email = txtMail.Text;
                lePraticien.Telephone = maskedTextBox1.Text;
                lePraticien.Type = (TypePraticien)comboBox2.SelectedItem!;
                lePraticien.Specialite = comboBox3.SelectedIndex >= 0
                                         ? (Specialite)comboBox3.SelectedItem!
                                         : null;

                Passerelle.modifierPraticien(lePraticien);

                // Forcer le rafraîchissement de l'affichage dans le ComboBox
                int currentIndex = comboBox1.SelectedIndex;
                comboBox1.SelectedIndex = -1;
                comboBox1.SelectedIndex = currentIndex;

                MessageBox.Show("Les coordonnées du praticien ont été modifiées",
                                "Modification coordonnées d'un praticien",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
                label5.Visible = true;
            }
        }

        // ─────────────────────────────────────────────
        //  BOUTON SUPPRIMER (button2)
        // ─────────────────────────────────────────────

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la suppression de ce praticien ?",
                                "Confirmation",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Supprimer();
            }
        }

        private void Supprimer()
        {
            try
            {
                label5.Visible = false;
                Praticien lePraticien = (Praticien)comboBox1.SelectedItem!;

                Passerelle.supprimerPraticien(lePraticien.Id);

                session!.MesPraticiens.Remove(lePraticien);
                panelCentral.Visible = false;

                int index = comboBox1.SelectedIndex;
                comboBox1.Items.Remove(lePraticien);

                if (index >= comboBox1.Items.Count)
                    index = comboBox1.Items.Count - 1;

                if (index >= 0)
                {
                    comboBox1.SelectedIndex = index;
                    remplirPraticien((Praticien)comboBox1.SelectedItem!);
                    panelCentral.Visible = true;
                }

                MessageBox.Show("Suppression réalisée", "Suppression",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
                label5.Visible = true;
            }
        }
    }
}