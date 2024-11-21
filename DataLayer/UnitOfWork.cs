using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        private readonly SqlConnection connection;
        private SqlTransaction transaction;

        public UsuarioRepository Usuario { get; }

        public UnitOfWork()
        {
            connection = DatabaseConnection.GetInstance().GetConnection();
            connection.Open();

            transaction = connection.BeginTransaction();

            Usuario = new UsuarioRepository(connection, transaction);
        }

        public void Complete()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void Dispose()
        {
            transaction?.Dispose();
            connection.Close();
        }
    }
}
