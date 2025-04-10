using crous.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace crous.DAO
{
    public class AppartementDAO
    {
        private Database db;

        public AppartementDAO()
        {
            db = new Database();
        }

        public List<Appartement> GetAllAppartements()
        {
            List<Appartement> appartements = new List<Appartement>();
            string query = "SELECT * FROM appartement";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Appartement appartement = new Appartement()
                    {
                        IdAppartement = Convert.ToInt32(dataReader["id_appartement"]),
                        Libelle = dataReader["libelle"].ToString(),
                        Description = dataReader["description"].ToString(),
                        Adresse = dataReader["adresse"].ToString(),
                        CodePostal = dataReader["code_postal"].ToString(),
                        Ville = dataReader["ville"].ToString(),
                        Superficie = Convert.ToDecimal(dataReader["superficie"])
                    };
                    appartements.Add(appartement);
                }
                dataReader.Close();
                db.CloseConnection();
            }
            return appartements;
        }

        //Methode pour ajouter un appartement
        public void AddAppartement(Appartement appartement)
        {
            string query = @"INSERT INTO appartement (libelle, description, adresse, code_postal, ville, superficie)
                     VALUES (@Libelle, @Description, @Adresse, @CodePostal, @Ville, @Superficie)";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@Libelle", appartement.Libelle);
                cmd.Parameters.AddWithValue("@Description", appartement.Description);
                cmd.Parameters.AddWithValue("@Adresse", appartement.Adresse);
                cmd.Parameters.AddWithValue("@CodePostal", appartement.CodePostal);
                cmd.Parameters.AddWithValue("@Ville", appartement.Ville);
                cmd.Parameters.AddWithValue("@Superficie", appartement.Superficie);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        //Methode pour modifier un appartement
        public void UpdateAppartement(Appartement appartement)
        {
            string query = @"UPDATE appartement SET libelle=@Libelle, description=@Description, adresse=@Adresse, code_postal=@CodePostal, ville=@Ville, superficie=@Superficie
                     WHERE id_appartement=@IdAppartement";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@IdAppartement", appartement.IdAppartement);
                cmd.Parameters.AddWithValue("@Libelle", appartement.Libelle);
                cmd.Parameters.AddWithValue("@Description", appartement.Description);
                cmd.Parameters.AddWithValue("@Adresse", appartement.Adresse);
                cmd.Parameters.AddWithValue("@CodePostal", appartement.CodePostal);
                cmd.Parameters.AddWithValue("@Ville", appartement.Ville);
                cmd.Parameters.AddWithValue("@Superficie", appartement.Superficie);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        //Methode pour supprimer un appartement
        public void DeleteAppartement(int id)
        {
            string query = "DELETE FROM appartement WHERE id_appartement=@IdAppartement";
            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@IdAppartement", id);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }


    }
}
