using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Administrador : Usuario
    {
        public int AdminId { get; set; }
        public string Telefono { get; set; }

        public Administrador(string nombre, string telefono, string clave, string rol) : base(nombre, clave, rol)
        {
            Telefono = telefono;
        }
    }
}
