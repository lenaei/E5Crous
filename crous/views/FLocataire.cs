using System;
using System.Windows.Forms;

namespace crous.views
{
    public partial class FLocataire : Form
    {
        // Stocke l'id de l'appartement associé pour une utilisation ultérieure
        private int _idAppartement;

        public FLocataire(string etudiantNom, string etudiantPrenom, int idAppartement, string libelle, string adresse, decimal superficie)
        {
            InitializeComponent();

            _idAppartement = idAppartement;
            lblEtudiant.Text = $"Étudiant : {etudiantPrenom} {etudiantNom}";
            lblLibelle.Text = $"Type : {libelle}";
            lblAdresse.Text = $"Adresse : {adresse}";
            lblSuperficie.Text = $"Superficie : {superficie} m²";

            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bouton pour rediriger vers la Form FAppartements (si besoin)
        private void btnOuvrirAppartement_Click(object sender, EventArgs e)
        {
            FAppartements fAppartements = new FAppartements();
            fAppartements.SelectAppartementById(_idAppartement);
            fAppartements.ShowDialog();
            

        }
    }
}
