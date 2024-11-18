using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using BusinessLayer;
using DataLayer;

namespace GestionVeterinarias
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                string rol = null;

                foreach (Control control in gbRol.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                    {
                        rol = radioButton.Text;
                        rol = rol.ToUpper();
                        break;
                    }
                }

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                var validarUsuario = UsuarioRepository.ValidarUsuario(usuario, clave, rol);

                if (!validarUsuario)
                {
                    MessageBox.Show($"El usuario no existe o ha ingresado los datos incorrectos.");
                    return;
                }

                switch (rol)
                {
                    case "ADMINISTRADOR":
                        Administrador administrador = new Administrador();
                        administrador.ShowDialog();
                        break;
                    case "VETERINARIO":
                        Veterinario veterinario = new Veterinario();
                        veterinario.ShowDialog();
                        break;
                    case "RECEPCIONISTA":
                        Recepcionista recepcionista = new Recepcionista();
                        recepcionista.ShowDialog();
                        break;

                }

                MessageBox.Show($"{usuario}\n{clave}\n{rol}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al capturar los datos, verifique que el formulario esté correctamente diligenciado\n{ex.Message}\n{MessageBoxButtons.OK} {MessageBoxIcon.Error}");
            }
        }
    }
}
