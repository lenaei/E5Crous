using System;
using System.Windows.Forms;
using crous.models;
using crous.DAO;

namespace crous.views
{
    public partial class FModifierAppartement : Form
    {
        public Appartement Appartement { get; private set; }

        public FModifierAppartement(Appartement appartement)
        {
            InitializeComponent();
            Appartement = appartement;

            // Préremplir les champs avec les données existantes
            tbLibelle.Text = appartement.Libelle;
            tbDescription.Text = appartement.Description;
            tbAdresse.Text = appartement.Adresse;
            tbCodePostal.Text = appartement.CodePostal;
            tbVille.Text = appartement.Ville;
            tbSuperficie.Text = appartement.Superficie.ToString();

            btnModifier.Click += BtnModifier_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Mettre à jour les données
                Appartement.Libelle = tbLibelle.Text;
                Appartement.Description = tbDescription.Text;
                Appartement.Adresse = tbAdresse.Text;
                Appartement.CodePostal = tbCodePostal.Text;
                Appartement.Ville = tbVille.Text;
                Appartement.Superficie = decimal.Parse(tbSuperficie.Text);

                // Mise à jour en BDD
                new AppartementDAO().UpdateAppartement(Appartement);

                MessageBox.Show("Appartement modifié avec succès !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
