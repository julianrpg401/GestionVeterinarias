using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Veterinario : Usuario
    {
        public int VeterinarioId { get; set; }
        public string Especializacion { get; set; }
        public string Horario { get; set; }
        public string Email { get; set; }

        public Veterinario(string nombre, string especializacion, string horario, string email, string clave, string rol = "Veterinario") : base (nombre, clave, rol)
        {
            Especializacion = especializacion;
            Horario = horario;
            Email = email;
        }
    }
}
