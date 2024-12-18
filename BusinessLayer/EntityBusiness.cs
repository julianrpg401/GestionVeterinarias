﻿using DataLayer;
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

        // Método para actualizar un administrador
        public void ActualizarUsuario(string nombre, string telefono, string clave)
        {
            Administrador administrador = (Administrador)UsuarioFactory.CrearUsuario(nombre, telefono, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Update(administrador);
                unitOfWork.Complete();
            }
        }

        // Método para actualizar un veterinario
        public void ActualizarUsuario(string nombre, string especializacion, string horario, string email, string clave)
        {
            Veterinario veterinario = (Veterinario)UsuarioFactory.CrearUsuario(nombre, especializacion, horario, email, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Update(veterinario);
                unitOfWork.Complete();
            }
        }

        // Método para actualizar un recepcionista
        public void ActualizarUsuario(string nombre, string email, string telefono, string clave)
        {
            Recepcionista recepcionista = (Recepcionista)UsuarioFactory.CrearUsuario(nombre, email, telefono, clave);

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.Update(recepcionista);
                unitOfWork.Complete();
            }
        }

        // Método para eliminar un administrador
        public void EliminarAdministrador(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El Id del administrador debe ser un número positivo.");
            }

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.DeleteAdministrador(id);
                unitOfWork.Complete(); // Confirmar la transacción
            }
        }

        // Método para eliminar un veterinario
        public void EliminarVeterinario(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El Id del veterinario debe ser un número positivo.");
            }

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.DeleteVeterinario(id);
                unitOfWork.Complete(); // Confirmar la transacción
            }
        }

        // Método para eliminar un recepcionista
        public void EliminarRecepcionista(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El Id del recepcionista debe ser un número positivo.");
            }

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Usuario.DeleteRecepcionista(id);
                unitOfWork.Complete(); // Confirmar la transacción
            }
        }

        // Método para obtener todos los administradores
        public IEnumerable<Administrador> GetAllAdministradores()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.Usuario.GetAllDbAdministradores();
            }
        }

        // Método para obtener todos los veterinarios
        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.Usuario.GetAllDbVeterinarios();
            }
        }

        // Método para obtener todos los recepcionistas
        public IEnumerable<Recepcionista> GetAllRecepcionistas()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.Usuario.GetAllDbRecepcionistas();
            }
        }
    }
}
