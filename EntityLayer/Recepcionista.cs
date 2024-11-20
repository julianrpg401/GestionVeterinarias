using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Recepcionista : Usuario
    {
        public int RecepcionistaId { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Recepcionista(string nombre, string email, string telefono, string clave, string rol = "Recepcionista") : base (nombre, clave, rol)
        {
            Email = email;
            Telefono = telefono;
        }
    }
}
