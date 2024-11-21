using BusinessLayer;
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
    public partial class GestionAdministradores : Form
    {
        EntityBusiness entityBusiness = new EntityBusiness();

        private string nombre;
        private string telefono;
        private string clave;

        public GestionAdministradores()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreA.Text;
            telefono = txtTelefono.Text;
            clave = txtClave.Text;

            entityBusiness.AgregarUsuario(nombre, telefono, clave);

            MessageBox.Show("Administrador agregado exitosamente.");
        }
    }
}
