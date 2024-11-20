using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class UsuarioFactory
    {
        public static Usuario CrearUsuario(string nombre, string especializacion, string horario, string email, string clave)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especializacion) || string.IsNullOrEmpty(horario) || string.IsNullOrEmpty(clave))
            {
                throw new ArgumentException("Por favor, complete todos los campos.");
            }

            return new Veterinario(nombre, especializacion, horario, email, clave);
        }
    }
}
