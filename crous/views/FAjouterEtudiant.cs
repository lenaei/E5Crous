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
    public partial class FAjouterEtudiant : Form
    {
        public FAjouterEtudiant()
        {
            InitializeComponent();
            btnAjouter.Click += BtnAjouter_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            FEtudiants etudiants = new FEtudiants();
            etudiants.Show();
            this.Hide();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Création de l'étudiant
                Etudiant nouvelEtudiant = new Etudiant
                {
                    Nom = textBox1.Text,
                    Prenom = textBox2.Text,
                    DateNaissance = dateTimePicker1.Value,
                    Email = textBox4.Text
                };

                // Insertion dans la BDD
                EtudiantDAO dao = new EtudiantDAO();
                dao.AddEtudiant(nouvelEtudiant);

                // Message de succès
                MessageBox.Show("Étudiant ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FEtudiants fenetreEtudiants = new FEtudiants();
                fenetreEtudiants.Show();
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Optionnel: Méthode pour réinitialiser les champs après l'ajout
        private void RéinitialiserChamps()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Today; // Réinitialiser à la date d'aujourd'hui ou à une autre valeur par défaut
        }

    }
}
