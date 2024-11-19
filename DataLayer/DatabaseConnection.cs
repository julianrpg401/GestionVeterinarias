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
    }
}
