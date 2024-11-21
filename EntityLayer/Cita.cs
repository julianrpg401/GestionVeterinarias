using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Cita
    {
        public int CitaId { get; set; }
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
    }
}
