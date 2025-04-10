using System;
using System.Windows.Forms;
using crous.models;

namespace crous.views
{
    public partial class FModifierEtudiant : Form
    {
        public Etudiant Etudiant { get; set; }

        public FModifierEtudiant(Etudiant etudiant)
        {
            InitializeComponent();
            this.Etudiant = etudiant;
            tbNom.Text = etudiant.Nom;
            tbPrenom.Text = etudiant.Prenom;
            dtpDateNaissance.Value = etudiant.DateNaissance;
            tbEmail.Text = etudiant.Email;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Etudiant.Nom = tbNom.Text;
            Etudiant.Prenom = tbPrenom.Text;
            Etudiant.DateNaissance = dtpDateNaissance.Value;
            Etudiant.Email = tbEmail.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
