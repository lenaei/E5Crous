using System;

namespace crous.models
{
    public class Etudiant
    {
        public int IdEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }

        // Constructeur sans paramètres
        public Etudiant() { }

        // Constructeur avec paramètres
        public Etudiant(int id, string nom, string prenom, DateTime dateNaissance, string email)
        {
            IdEtudiant = id;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
        }

        // Surcharge de la méthode ToString pour l'affichage
        public override string ToString()
        {
            return $"{Prenom} {Nom} - {Email}";
        }
    }
}
