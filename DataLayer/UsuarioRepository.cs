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
        private readonly SqlConnection _connection;
        private readonly SqlTransaction _transaction;

        public UsuarioRepository(SqlConnection connection, SqlTransaction transaction = null)
        {
            _connection = connection;
            _transaction = transaction;
        }

        // Método para agregar un veterinario
        public void Add(Veterinario veterinario)
        {
            try
            {
                string insertUsuarioQuery = @"INSERT INTO Usuario (nombreUsuario, clave, rol)
                                            OUTPUT INSERTED.UsuarioId
                                            VALUES (@nombre, @clave, @rol)";

                int usuarioId;

                using (SqlCommand command = new SqlCommand(insertUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", veterinario.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", veterinario.Clave);
                    command.Parameters.AddWithValue("@rol", veterinario.Rol);

                    usuarioId = (int)command.ExecuteScalar();
                }

                string insertVeterinarioQuery = @"INSERT INTO Veterinario (usuarioId, nombre, especializacion, horario, email)
                                                VALUES (@usuarioId, @nombre, @especializacion, @horario, @email)";

                using (SqlCommand command = new SqlCommand(insertVeterinarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@nombre", veterinario.NombreUsuario);
                    command.Parameters.AddWithValue("@especializacion", veterinario.Especializacion);
                    command.Parameters.AddWithValue("@horario", veterinario.Horario);
                    command.Parameters.AddWithValue("@email", veterinario.Email);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar empleado: " + ex.Message);
            }
        }
    }
}
