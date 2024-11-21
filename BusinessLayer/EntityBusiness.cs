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
        // Método para agregar un nuevo administrador
        public void AgregarUsuario(string nombre, string telefono, string clave)
        {
            Administrador administrador = (Administrador)UsuarioFactory.CrearUsuario(nombre, telefono, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Add(administrador); // Agregar el administrador al repositorio
                unitOfWork.Complete();
            }
        }

        // Método para agregar un nuevo veterinario
        public void AgregarUsuario(string nombre, string especializacion, string horario, string email, string clave)
        {
            Veterinario veterinario = (Veterinario)UsuarioFactory.CrearUsuario(nombre, especializacion, horario, email, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Add(veterinario); // Agregar el veterinario al repositorio
                unitOfWork.Complete();
            }
        }

        // Método para agregar un nuevo recepcionista
        public void AgregarUsuario(string nombre, string email, string telefono, string clave)
        {
            Recepcionista recepcionista = (Recepcionista)UsuarioFactory.CrearUsuario(nombre, email, telefono, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Add(recepcionista); // Agregar el recepcionista al repositorio
                unitOfWork.Complete();
            }
        }
    }
}
