using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Veterinario
    {
        public int VeterinarioId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Especializacion { get; set; }
        public string Horario { get; set; }
    }
}
