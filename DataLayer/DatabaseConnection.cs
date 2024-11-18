using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Net.Http;
using EntityLayer;

namespace DataLayer
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;
        public string ConnectionString => _connectionString;

        public DatabaseConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }

        public Administrador GetAdmin()
        {
            Administrador admin = null;

            string query = "SELECT * FROM Administrador";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int cod = reader.GetInt32(1);
                        string nombre = reader.GetString(2);
                        string tel = reader.GetString(3);

                        admin = new Administrador
                        {
                            AdminId = id,
                            UsuarioId = cod,
                            Nombre = nombre,
                            Tel = tel
                        };
                    }

                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BD" + ex.Message);
                }
            }

            return admin;
        }
    }
}
