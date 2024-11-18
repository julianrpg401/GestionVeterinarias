using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace Depurar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrador admin = new Administrador();

            DatabaseConnection databaseConnection = new DatabaseConnection();

            admin = databaseConnection.GetAdmin();

            Console.WriteLine($"{admin.AdminId}\n{admin.Nombre}\n{admin.Tel}");
        }
    }
}
