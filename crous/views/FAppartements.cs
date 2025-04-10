using System;
using System.Collections.Generic;
using System.Windows.Forms;
using crous.DAO;
using crous.models;

namespace crous.views
{
    public partial class FAppartements : Form
    {
        public FAppartements()
        {
            InitializeComponent();
            btnQuitter.Click += BtnQuitter_Click;
            btnAjouter.Click += BtnAjouter_Click;
            btnSupprimer.Click += BtnSupprimer_Click;
            btnModifier.Click += BtnModifier_Click1;
            btnMenu.Click += BtnMenu_Click;
            LoadAppartements(); // Charge les appartements au démarrage
        }

        // Nouvelle méthode pour sélectionner un appartement par son id
        public void SelectAppartementById(int idAppartement)
        {
            // Recharge (ou s'assure que la liste est chargée)
            LoadAppartements();
            foreach (var item in lbAppartements.Items)
            {
                if (item is Appartement appartement && appartement.IdAppartement == idAppartement)
                {
                    lbAppartements.SelectedItem = item;
                    break;
                }
            }
        }

        private void LoadAppartements()
        {
            List<Appartement> appartements = new AppartementDAO().GetAllAppartements();
            lbAppartements.Items.Clear();
            foreach (var appartement in appartements)
            {
                lbAppartements.Items.Add(appartement);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FMenu menu = new FMenu();
            menu.Show();
            this.Hide();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbAppartements.SelectedItem != null)
            {
                Appartement selectedAppartement = (Appartement)lbAppartements.SelectedItem;
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet appartement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new AppartementDAO().DeleteAppartement(selectedAppartement.IdAppartement);
                    LoadAppartements();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un appartement à supprimer.");
            }
        }

        private void BtnModifier_Click1(object sender, EventArgs e)
        {
            if (lbAppartements.SelectedItem != null)
            {
                Appartement selectedAppartement = (Appartement)lbAppartements.SelectedItem;
                FModifierAppartement modifierAppartement = new FModifierAppartement(selectedAppartement);
                if (modifierAppartement.ShowDialog() == DialogResult.OK)
                {
                    new AppartementDAO().UpdateAppartement(modifierAppartement.Appartement);
                    LoadAppartements();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un appartement à modifier.");
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FAjouterAppartement ajouterAppartement = new FAjouterAppartement();
            if (ajouterAppartement.ShowDialog() == DialogResult.OK)
            {
                Appartement newAppartement = ajouterAppartement.Appartement;
                new AppartementDAO().AddAppartement(newAppartement);
                LoadAppartements();
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
