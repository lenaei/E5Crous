using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crous.DAO;
using crous.models;

namespace crous.views
{
    public partial class FEtudiants : Form
    {
        public FEtudiants()
        {
            InitializeComponent();
            btnAjouter.Click += BtnAjouter_Click;
            btnModifier.Click += BtnModifier_Click;
            btnSupprimer.Click += BtnSupprimer_Click;
            btnQuitter.Click += BtnQuitter_Click;
            btnMenu.Click += BtnMenu_Click;
            RefreshEtudiants(); // Charge et affiche la liste des étudiants
            btnAfficher.Click += BtnAfficher_Click;
        }

        //Methode pour afficher les étudiants
        private void RefreshEtudiants()
        {
            lbEtudiants.Items.Clear();
            List<Etudiant> etudiants = new EtudiantDAO().GetAllEtudiants();
            foreach (Etudiant etudiant in etudiants)
            {
                lbEtudiants.Items.Add(etudiant);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FMenu menu = new FMenu();
            menu.Show();
            this.Hide();
        }

        //Bouton pour quitter
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            if (lbEtudiants.SelectedItem is Etudiant selectedEtudiant)
            {
                EtudiantDAO dao = new EtudiantDAO();
                var appartement = dao.GetAppartementByEtudiantId(selectedEtudiant.IdEtudiant);
                if (appartement != null)
                {
                    int idAppartement = appartement.Value.idAppartement;
                    string libelle = appartement.Value.libelle;
                    string adresse = appartement.Value.adresse;
                    decimal superficie = appartement.Value.superficie;

                    // On appelle le constructeur en passant bien les 6 paramètres
                    FLocataire formLocataire = new FLocataire(
                        selectedEtudiant.Nom,
                        selectedEtudiant.Prenom,
                        idAppartement,     //l'ID de l'appartement
                        libelle,
                        adresse,
                        superficie
                    );
                    formLocataire.ShowDialog(); //On affiche la Form Flocatiare dans un show dialog
                }
                else
                {
                    MessageBox.Show("Cet étudiant n'a pas d'appartement associé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant dans la liste.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbEtudiants.SelectedItem != null)
            {
                Etudiant selectedEtudiant = (Etudiant)lbEtudiants.SelectedItem;
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new EtudiantDAO().DeleteEtudiant(selectedEtudiant.IdEtudiant);
                    RefreshEtudiants();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (lbEtudiants.SelectedItem != null)
            {
                Etudiant selectedEtudiant = (Etudiant)lbEtudiants.SelectedItem;
                FModifierEtudiant modifierEtudiant = new FModifierEtudiant(selectedEtudiant);
                if (modifierEtudiant.ShowDialog() == DialogResult.OK)
                {
                    new EtudiantDAO().UpdateEtudiant(modifierEtudiant.Etudiant);
                    RefreshEtudiants();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FAjouterEtudiant ajouterEtudiant = new FAjouterEtudiant();
            ajouterEtudiant.Show();
            this.Hide();
        }
    }
}
