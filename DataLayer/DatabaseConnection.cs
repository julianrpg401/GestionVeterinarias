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
        private static DatabaseConnection _instance;
        private readonly SqlConnection _connection;

        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

            _connection = new SqlConnection(_connectionString);
        }

        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
            }

            return _instance;
        }

        //Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
