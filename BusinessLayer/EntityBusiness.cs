using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class EntityBusiness
    {

        // Método para agregar un nuevo veterinario
        public void AgregarUsuario(string nombre, string especializacion, string horario, string email, string clave)
        {
            Veterinario veterinario = (Veterinario)UsuarioFactory.CrearUsuario(nombre, especializacion, horario, email, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Add(veterinario); // Agregar el empleado al repositorio
                unitOfWork.Complete();
            }
        }
    }
}
