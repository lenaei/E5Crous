using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using crous.models;

namespace crous.DAO
{
    public class EtudiantDAO
    {
        private Database db;

        public EtudiantDAO()
        {
            db = new Database();
        }

        public List<Etudiant> GetAllEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            string query = "SELECT * FROM etudiant";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection); 
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Etudiant etudiant = new Etudiant()
                    {
                        IdEtudiant = Convert.ToInt32(dataReader["id_etudiant"]),
                        Nom = dataReader["nom"].ToString(),
                        Prenom = dataReader["prenom"].ToString(),
                        DateNaissance = Convert.ToDateTime(dataReader["date_naissance"]),
                        Email = dataReader["email"].ToString()
                    };
                    etudiants.Add(etudiant);
                }
                dataReader.Close();
                db.CloseConnection();
            }
            return etudiants;
        }

        public void DeleteEtudiant(int id)
        {
            string query = "DELETE FROM etudiant WHERE id_etudiant = @Id";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public void UpdateEtudiant(Etudiant etudiant)
        {
            string query = "UPDATE etudiant SET nom = @Nom, prenom = @Prenom, date_naissance = @DateNaissance, email = @Email WHERE id_etudiant = @Id";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Id", etudiant.IdEtudiant);
                cmd.Parameters.AddWithValue("@Nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@Email", etudiant.Email);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public void AddEtudiant(Etudiant etudiant)
        {
            string query = "INSERT INTO etudiant (nom, prenom, date_naissance, email) VALUES (@Nom, @Prenom, @DateNaissance, @Email)";

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@Email", etudiant.Email);

                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        //Methode pour récupérer un appartement par rapport à l'id de l'étudiant
        /***
        public (string libelle, string adresse, decimal superficie)? GetAppartementByEtudiantId(int idEtudiant)
        {
            string query = @"
        SELECT a.libelle, a.adresse, a.superficie
        FROM locataire l
        INNER JOIN appartement a ON l.id_appartement = a.id_appartement
        WHERE l.id_etudiant = @Id";

            if (db.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", idEtudiant);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string libelle = reader.GetString("libelle");
                            string adresse = reader.GetString("adresse");
                            decimal superficie = reader.GetDecimal("superficie");

                            reader.Close();
                            db.CloseConnection();
                            return (libelle, adresse, superficie);
                        }
                        reader.Close();
                    }
                }
                db.CloseConnection();
            }
            return null;
        }
        ***/
        public (int idAppartement, string libelle, string adresse, decimal superficie)? GetAppartementByEtudiantId(int idEtudiant)
        {
            string query = @"
        SELECT a.id_appartement, a.libelle, a.adresse, a.superficie
        FROM locataire l
        INNER JOIN appartement a ON l.id_appartement = a.id_appartement
        WHERE l.id_etudiant = @Id";

            if (db.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", idEtudiant);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idAppartement = reader.GetInt32("id_appartement");
                            string libelle = reader.GetString("libelle");
                            string adresse = reader.GetString("adresse");
                            decimal superficie = reader.GetDecimal("superficie");

                            reader.Close();
                            db.CloseConnection();
                            return (idAppartement, libelle, adresse, superficie);
                        }
                        reader.Close();
                    }
                }
                db.CloseConnection();
            }
            return null;
        }


    }
}
