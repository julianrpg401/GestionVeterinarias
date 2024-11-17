using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depurar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection conexion = new DatabaseConnection();

            Administrador admin = conexion.GetAdmin();

            Console.WriteLine($"Id: {admin.Id}\nCod: {admin.Cod}\nNombre: {admin.Nombre}\nTel: {admin.Tel}");
        }
    }
}
