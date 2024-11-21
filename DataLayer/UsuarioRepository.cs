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

        // Método para agregar un administrador
        public void Add(Administrador administrador)
        {
            try
            {
                string insertUsuarioQuery = @"INSERT INTO Usuario (nombreUsuario, clave, rol)
                                            OUTPUT INSERTED.UsuarioId
                                            VALUES (@nombre, @clave, @rol)";

                int usuarioId;

                using (SqlCommand command = new SqlCommand(insertUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", administrador.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", administrador.Clave);
                    command.Parameters.AddWithValue("@rol", administrador.Rol);

                    usuarioId = (int)command.ExecuteScalar();
                }

                string insertAdministradorQuery = @"INSERT INTO Administrador (usuarioId, nombre, telefono)
                                                VALUES (@usuarioId, @nombre, @telefono)";

                using (SqlCommand command = new SqlCommand(insertAdministradorQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@nombre", administrador.NombreUsuario);
                    command.Parameters.AddWithValue("@telefono", administrador.Telefono);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar administrador: " + ex.Message);
            }
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
                throw new Exception("Error al agregar veterinario: " + ex.Message);
            }
        }

        // Método para agregar un recepcionista
        public void Add(Recepcionista recepcionista)
        {
            try
            {
                string insertUsuarioQuery = @"INSERT INTO Usuario (nombreUsuario, clave, rol)
                                            OUTPUT INSERTED.UsuarioId
                                            VALUES (@nombre, @clave, @rol)";

                int usuarioId;

                using (SqlCommand command = new SqlCommand(insertUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", recepcionista.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", recepcionista.Clave);
                    command.Parameters.AddWithValue("@rol", recepcionista.Rol);

                    usuarioId = (int)command.ExecuteScalar();
                }

                string insertRecepcionistaQuery = @"INSERT INTO Recepcionista (usuarioId, nombre, telefono, email)
                                                VALUES (@usuarioId, @nombre, @telefono, @email)";

                using (SqlCommand command = new SqlCommand(insertRecepcionistaQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@nombre", recepcionista.NombreUsuario);
                    command.Parameters.AddWithValue("@telefono", recepcionista.Telefono);
                    command.Parameters.AddWithValue("@email", recepcionista.Email);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar recepcionista: " + ex.Message);
            }
        }

        // Método para obtener todos los veterinarios
        public IEnumerable<Veterinario> GetAll()
        {
            List<Veterinario> veterinarios = new List<Veterinario>();

            try
            {
                string query = @"SELECT v.usuarioId, v.nombre, v.especializacion, v.horario, v.email, u.clave
                                FROM Veterinario v
                                INNER JOIN Usuario u ON v.usuarioId = u.UsuarioId";

                using (SqlCommand command = new SqlCommand(query, _connection, _transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Veterinario veterinario =
                            new Veterinario
                            (
                                nombre: reader["nombre"].ToString(),
                                especializacion: reader["especializacion"].ToString(),
                                horario: reader["horario"].ToString(),
                                email: reader["email"].ToString(),
                                clave: reader["clave"].ToString()
                            )
                            {
                                UsuarioId = Convert.ToInt32(reader["usuarioId"])
                            };

                            veterinarios.Add(veterinario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener veterinarios: " + ex.Message);
            }

            return veterinarios;
        }
    }
}
