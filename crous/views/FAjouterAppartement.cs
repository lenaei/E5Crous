using System;
using System.Windows.Forms;
using crous.models;

namespace crous.views
{
    public partial class FAjouterAppartement : Form
    {
        public Appartement Appartement { get; private set; }

        public FAjouterAppartement()
        {
            InitializeComponent();
            btnAjouter.Click += BtnAjouter_Click;
            btnAnnuler.Click += BtnAnnuler_Click;
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Appartement = new Appartement
                {
                    Libelle = tbLibelle.Text,
                    Description = tbDescription.Text,
                    Adresse = tbAdresse.Text,
                    CodePostal = tbCodePostal.Text,
                    Ville = tbVille.Text,
                    Superficie = decimal.Parse(tbSuperficie.Text)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
