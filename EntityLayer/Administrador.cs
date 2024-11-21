using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Administrador : Usuario
    {
        public string Telefono { get; set; }

        public Administrador(string nombre, string telefono, string clave, string rol = "Administrador") : base(nombre, clave, rol)
        {
            Telefono = telefono;
        }
    }
}
