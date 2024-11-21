using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string HistorialMedico { get; set; }
        public int PropietarioId { get; set; }
    }
}
