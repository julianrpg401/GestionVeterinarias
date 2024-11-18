using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

namespace DataLayer
{
    public class UsuarioRepository
    {
        private static DatabaseConnection _connection = new DatabaseConnection();

        public static bool ValidarUsuario(string nombre, string clave, string rol)
        {
            bool usuarioValido = false;

            // Query para verificar los parámetros en la base de datos.
            string query = "SELECT COUNT(*) FROM Usuario WHERE nombreUsuario = @nombre AND clave = @clave AND rol = @rol";

            using (SqlConnection connection = new SqlConnection(_connection.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar los valores a los parámetros para evitar SQL Injection.
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@clave", clave); // Considera usar una versión encriptada si es sensible.
                        command.Parameters.AddWithValue("@rol", rol);

                        // Ejecutar el comando y verificar si existe algún registro.
                        int count = (int)command.ExecuteScalar();
                        usuarioValido = count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al validar el usuario: " + ex.Message);
                }
            }

            return usuarioValido;
        }
    }
}
