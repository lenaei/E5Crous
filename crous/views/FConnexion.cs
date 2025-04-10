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
using crous.DAO;

namespace crous
{
    public partial class FConnexion : Form
    {

        //Création de la donnée membre contenant les informations de connexion à la bdd
        private Database db;

        public FConnexion()
        {
            InitializeComponent();
            btnConnexion.Click += BtnConnexion_Click;
            btnQuitter.Click += BtnQuitter_Click;
            //PasswordChar pour cacher le champ mot de passe.
            tbMdp.PasswordChar = '*';
            // Initialisation de la connexion à la base de données
            db = new Database();
        }

        //Bouton pour quitter l'application
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Bouton de connexion
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (db.CheckLogin(tbEmail.Text, tbMdp.Text))
            {
                MessageBox.Show("Identifiants corrects");
                FMenu menu = new FMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects");
            }
        }
    }
}
