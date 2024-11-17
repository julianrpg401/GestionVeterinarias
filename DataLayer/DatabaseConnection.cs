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
        private readonly DatabaseConnection _instance;
        private readonly SqlConnection _connection;

        private DatabaseConnection()
        {
            _connection = new SqlConnection("Data Source=JULIAN;Initial Catalog=GestionVeterinarias;Integrated Security=True");
        }



        //public Administrador GetAdmin()
        //{
        //    Administrador admin = null;

        //    string query = "SELECT * FROM Administrador";

        //    using (SqlConnection connection = new SqlConnection(cadenaConexion))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);

        //        try
        //        {
        //            connection.Open();

        //            SqlDataReader reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                int id = reader.GetInt32(0);
        //                int cod = reader.GetInt32(1);
        //                string nombre = reader.GetString(2);
        //                string tel = reader.GetString(3);

        //                admin = new Administrador
        //                {
        //                    Id = id,
        //                    Cod = cod,
        //                    Nombre = nombre,
        //                    Tel = tel,
        //                };
        //            }

        //            reader.Close();

        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Hay un error en la BD" + ex.Message);
        //        }
        //    }

        //    return admin;
        //}

        //public void VerficiarConexion()
        //{
        //    using (SqlConnection connection = new SqlConnection(cadenaConexion))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            Console.WriteLine("Conexión exitosa");

        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }
}
