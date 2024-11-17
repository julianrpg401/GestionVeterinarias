using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Recepcionista
    {
        public int RecepcionistaId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
