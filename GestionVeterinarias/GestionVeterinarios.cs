using BusinessLayer;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVeterinarias
{
    public partial class GestionVeterinarios : Form
    {
        EntityBusiness entityBusiness = new EntityBusiness();
        private string nombre;
        private string especializacion;
        private string horario;
        private string email;
        private string clave;

        public GestionVeterinarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreV.Text;
            especializacion = txtEspecializacion.Text;
            horario = txtHorario.Text;
            email = txtEmail.Text;
            clave = txtClave.Text;

            Veterinario veterinario = EntityFactory.CreateVeterinario(nombre, especializacion, horario, email, clave);

            var validarUsuario = VeterinarioRepository.ValidarVeterinario(veterinario);

            if (validarUsuario)
            {
                MessageBox.Show($"El usuario ya existe en la base de datos.");
                return;
            }

            entityBusiness.
        }
    }
}
