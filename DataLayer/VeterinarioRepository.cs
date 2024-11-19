using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class VeterinarioRepository
    {
        //private static DatabaseConnection _connection = new DatabaseConnection();

        //// Método para validar si el veterinario existe
        //public static bool ValidarVeterinario(Veterinario veterinario)
        //{
        //    bool usuarioValido = false;

        //    // Query para verificar los parámetros en la base de datos.
        //    string query = "SELECT COUNT(*) FROM Veterinario WHERE nombre = @nombre AND especializacion = @especializacion AND horario = @horario AND email = @email";

        //    using (SqlConnection connection = new SqlConnection(_connection.ConnectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                // Asignar los valores a los parámetros para evitar SQL Injection.
        //                command.Parameters.AddWithValue("@nombre", veterinario.NombreUsuario);
        //                command.Parameters.AddWithValue("@especializacion", veterinario.Especializacion);
        //                command.Parameters.AddWithValue("@horario", veterinario.Horario);
        //                command.Parameters.AddWithValue("@email", veterinario.Email);

        //                // Ejecutar el comando y verificar si existe algún registro.
        //                int count = (int)command.ExecuteScalar();
        //                usuarioValido = count > 0;
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show("Error al validar el veterinario: " + ex.Message);
        //        }
        //    }

        //    return usuarioValido;
        //}
    }
}
