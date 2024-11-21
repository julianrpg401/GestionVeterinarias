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

        // Método para actualizar un administrador
        public void Update(Administrador administrador)
        {
            try
            {
                string updateUsuarioQuery = @"UPDATE Usuario
                                            SET nombreUsuario = @nombreUsuario,
                                                clave = @clave
                                            WHERE nombreUsuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(updateUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", administrador.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", administrador.Clave);

                    command.ExecuteNonQuery();
                }

                string updateAdministradorQuery = @"UPDATE Administrador
                                                SET nombre = @nombre,
                                                    telefono = @telefono
                                                WHERE nombre = @nombre";

                using (SqlCommand command = new SqlCommand(updateAdministradorQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", administrador.NombreUsuario);
                    command.Parameters.AddWithValue("@telefono", administrador.Telefono);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar administrador: " + ex.Message);
            }
        }

        // Método para actualizar un veterinario
        public void Update(Veterinario veterinario)
        {
            try
            {
                string updateUsuarioQuery = @"UPDATE Usuario
                                            SET nombreUsuario = @nombreUsuario,
                                                clave = @clave
                                            WHERE nombreUsuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(updateUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", veterinario.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", veterinario.Clave);

                    command.ExecuteNonQuery();
                }

                string updateVeterinarioQuery = @"UPDATE Veterinario
                                                SET nombre = @nombre,
                                                    especializacion = @especializacion,
                                                    horario = @horario,
                                                    email = @email
                                                WHERE nombre = @nombre";

                using (SqlCommand command = new SqlCommand(updateVeterinarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", veterinario.NombreUsuario);
                    command.Parameters.AddWithValue("@especializacion", veterinario.Especializacion);
                    command.Parameters.AddWithValue("@horario", veterinario.Horario);
                    command.Parameters.AddWithValue("@email", veterinario.Email);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar veterinario: " + ex.Message);
            }
        }

        // Método para actualizar un recepcionista
        public void Update(Recepcionista recepcionista)
        {
            try
            {
                string updateUsuarioQuery = @"UPDATE Usuario
                                            SET nombreUsuario = @nombreUsuario,
                                                clave = @clave
                                            WHERE nombreUsuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(updateUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", recepcionista.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", recepcionista.Clave);

                    command.ExecuteNonQuery();
                }

                string updateRecepcionistaQuery = @"UPDATE Recepcionista
                                                SET nombre = @nombre,
                                                    email = @email,
                                                    telefono = @telefono
                                                WHERE nombre = @nombre";

                using (SqlCommand command = new SqlCommand(updateRecepcionistaQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@nombre", recepcionista.NombreUsuario);
                    command.Parameters.AddWithValue("@email", recepcionista.Email);
                    command.Parameters.AddWithValue("@telefono", recepcionista.Telefono);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar recepcionista: " + ex.Message);
            }
        }

        // Método para eliminar un administrador
        public void DeleteAdministrador(int id)
        {
            try
            {
                string deleteAdministradorQuery = @"DELETE FROM Administrador WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteAdministradorQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                string deleteUsuarioQuery = @"DELETE FROM Usuario WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar administrador: " + ex.Message);
            }
        }

        // Método para eliminar un veterinario
        public void DeleteVeterinario(int id)
        {
            try
            {
                string deleteVeterinarioQuery = @"DELETE FROM Veterinario WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteVeterinarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                string deleteUsuarioQuery = @"DELETE FROM Usuario WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar veterinario: " + ex.Message);
            }
        }

        // Método para eliminar un recepcionista
        public void DeleteRecepcionista(int id)
        {
            try
            {
                string deleteRecepcionistaQuery = @"DELETE FROM Recepcionista WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteRecepcionistaQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                string deleteUsuarioQuery = @"DELETE FROM Usuario WHERE usuarioId = @id";

                using (SqlCommand command = new SqlCommand(deleteUsuarioQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar recepcionista: " + ex.Message);
            }
        }

        // Método para obtener todos los administradores
        public IEnumerable<Administrador> GetAllDbAdministradores()
        {
            List<Administrador> administradores = new List<Administrador>();

            try
            {
                string query = @"SELECT a.usuarioId, a.nombre, a.telefono, u.clave
                                FROM Administrador a
                                INNER JOIN Usuario u ON a.usuarioId = u.UsuarioId";

                using (SqlCommand command = new SqlCommand(query, _connection, _transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Administrador administrador =
                            new Administrador
                            (
                                nombre: reader["nombre"].ToString(),
                                telefono: reader["telefono"].ToString(),
                                clave: reader["clave"].ToString()
                            )
                            {
                                UsuarioId = Convert.ToInt32(reader["usuarioId"])
                            };

                            administradores.Add(administrador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener administradores: " + ex.Message);
            }

            return administradores;
        }

        // Método para obtener todos los veterinarios
        public IEnumerable<Veterinario> GetAllDbVeterinarios()
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

        // Método para obtener todos los recepcionistas
        public IEnumerable<Recepcionista> GetAllDbRecepcionistas()
        {
            List<Recepcionista> recepcionistas = new List<Recepcionista>();

            try
            {
                string query = @"SELECT r.usuarioId, r.nombre, r.telefono, r.email, u.clave
                                FROM Recepcionista r
                                INNER JOIN Usuario u ON r.usuarioId = u.UsuarioId";

                using (SqlCommand command = new SqlCommand(query, _connection, _transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recepcionista recepcionista =
                            new Recepcionista
                            (
                                nombre: reader["nombre"].ToString(),
                                telefono: reader["telefono"].ToString(),
                                email: reader["email"].ToString(),
                                clave: reader["clave"].ToString()
                            )
                            {
                                UsuarioId = Convert.ToInt32(reader["usuarioId"])
                            };

                            recepcionistas.Add(recepcionista);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener recepcionistas: " + ex.Message);
            }

            return recepcionistas;
        }
    }
}
