using BusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            CargarAdministradores();
        }

        private void LimpiarCampos()
        {
            txtNombreA.Clear();
            txtTelefono.Clear();
            txtClave.Clear();
        }

        private void CargarAdministradores()
        {
            dgvAdministradores.ReadOnly = true; // Establecer el data grid view solo para lectura
            dgvAdministradores.AutoGenerateColumns = false; // Desactiva la generación automática de columnas
            dgvAdministradores.DataSource = null; // Limpia la fuente de datos actual

            dgvAdministradores.Columns.Clear(); // Elimina columnas previas

            // Define manualmente las columnas en el orden deseado
            dgvAdministradores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UsuarioId", HeaderText = "ID" });
            dgvAdministradores.Columns[0].Name = dgvAdministradores.Columns[0].DataPropertyName;

            dgvAdministradores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreUsuario", HeaderText = "NOMBRE" });
            dgvAdministradores.Columns[1].Name = dgvAdministradores.Columns[1].DataPropertyName;

            dgvAdministradores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefono", HeaderText = "TELEFONO" });
            dgvAdministradores.Columns[2].Name = dgvAdministradores.Columns[2].DataPropertyName;

            dgvAdministradores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Clave", HeaderText = "CLAVE" });
            dgvAdministradores.Columns[3].Name = dgvAdministradores.Columns[3].DataPropertyName;

            // Asigna la fuente de datos
            IEnumerable<Administrador> administradores = entityBusiness.GetAllAdministradores();
            dgvAdministradores.DataSource = administradores;

            dgvAdministradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvAdministradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvAdministradores.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los campos del formulario
                txtNombreA.Text = filaSeleccionada.Cells["NombreUsuario"].Value?.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value?.ToString();
                txtClave.Text = filaSeleccionada.Cells["Clave"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreA.Text;
            telefono = txtTelefono.Text;
            clave = txtClave.Text;

            entityBusiness.AgregarUsuario(nombre, telefono, clave);

            MessageBox.Show("Administrador agregado exitosamente.");

            CargarAdministradores();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdministradores.CurrentRow != null)
                {
                    nombre = txtNombreA.Text;
                    telefono = txtTelefono.Text;
                    clave = txtClave.Text;

                    entityBusiness.ActualizarUsuario(nombre, telefono, clave);

                    MessageBox.Show("Administrador actualizado exitosamente.");

                    CargarAdministradores();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar administrador: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdministradores.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvAdministradores.CurrentRow.Cells["UsuarioId"].Value);

                    entityBusiness.EliminarAdministrador(id);

                    MessageBox.Show("administrador eliminado exitosamente.");

                    CargarAdministradores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Selecciona un administrador para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar administrador: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
