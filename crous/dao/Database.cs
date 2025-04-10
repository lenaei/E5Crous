using System;
using MySql.Data.MySqlClient;

namespace crous.DAO
{
    public class Database
    {
        private MySqlConnection connection;

        // Propriété publique pour accéder à la connexion
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public Database()
        {
            // Informations de connexion à la base de données
            string connectionString = "server=localhost;database=crous;user=root;password=siojjr;";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        public bool CheckLogin(string email, string password)
        {
            string query = "SELECT * FROM utilisateurs WHERE email = @Email AND password = @Password";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            if (OpenConnection())
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                bool hasRows = reader.HasRows;
                reader.Close();
                CloseConnection();
                return hasRows;
            }
            return false;
        }
    }
}
