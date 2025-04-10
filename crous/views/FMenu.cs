using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crous.views;

namespace crous.views
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            btnAppartements.Click += BtnAppartements_Click;
            btnEtudiants.Click += BtnEtudiants_Click;
            btnQuitter.Click += BtnQuitter_Click;
            btnDeconnexion.Click += BtnDeconnexion_Click;
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            FConnexion connexion = new FConnexion();
            connexion.Show();
            this.Close();
        }

        //Bouton pour quitter
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Bouton pour afficher la Form des étudiants
        private void BtnEtudiants_Click(object sender, EventArgs e)
        {
            FEtudiants etudiants = new FEtudiants();
            etudiants.Show();
            this.Hide();
        }

        //Bouton pour afficher la Form des appartements
        private void BtnAppartements_Click(object sender, EventArgs e)
        {
            FAppartements appartements = new FAppartements();
            appartements.Show();
            this.Hide();
        }
    }
}
