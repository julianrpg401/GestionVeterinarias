using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Factura
    {
        public int FacturaId { get; set; }
        public int CitaId { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string EstadoPago { get; set; }
    }
}
