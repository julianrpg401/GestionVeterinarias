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

namespace GestionVeterinarias
{
    public partial class GestionRecepcionistas : Form
    {
        EntityBusiness entityBusiness = new EntityBusiness();

        private string nombre;
        private string email;
        private string telefono;
        private string clave;

        public GestionRecepcionistas()
        {
            InitializeComponent();
            CargarRecepcionistas();
        }

        private void LimpiarCampos()
        {
            txtNombreR.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtClave.Clear();
        }

        private void CargarRecepcionistas()
        {
            dgvRecepcionistas.ReadOnly = true; // Establecer el data grid view solo para lectura
            dgvRecepcionistas.AutoGenerateColumns = false; // Desactiva la generación automática de columnas
            dgvRecepcionistas.DataSource = null; // Limpia la fuente de datos actual

            dgvRecepcionistas.Columns.Clear(); // Elimina columnas previas

            // Define manualmente las columnas en el orden deseado
            dgvRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UsuarioId", HeaderText = "ID" });
            dgvRecepcionistas.Columns[0].Name = dgvRecepcionistas.Columns[0].DataPropertyName;

            dgvRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreUsuario", HeaderText = "NOMBRE" });
            dgvRecepcionistas.Columns[1].Name = dgvRecepcionistas.Columns[1].DataPropertyName;

            dgvRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "EMAIL" });
            dgvRecepcionistas.Columns[2].Name = dgvRecepcionistas.Columns[2].DataPropertyName;

            dgvRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefono", HeaderText = "TELEFONO" });
            dgvRecepcionistas.Columns[3].Name = dgvRecepcionistas.Columns[3].DataPropertyName;

            dgvRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Clave", HeaderText = "CLAVE" });
            dgvRecepcionistas.Columns[4].Name = dgvRecepcionistas.Columns[4].DataPropertyName;

            // Asigna la fuente de datos
            IEnumerable<Recepcionista> recepcionistas = entityBusiness.GetAllRecepcionistas();
            dgvRecepcionistas.DataSource = recepcionistas;

            dgvRecepcionistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRecepcionistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvRecepcionistas.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los campos del formulario
                txtNombreR.Text = filaSeleccionada.Cells["NombreUsuario"].Value?.ToString();
                txtEmail.Text = filaSeleccionada.Cells["Email"].Value?.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value?.ToString();
                txtClave.Text = filaSeleccionada.Cells["Clave"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreR.Text;
            email = txtEmail.Text;
            telefono = txtTelefono.Text;
            clave = txtClave.Text;

            entityBusiness.AgregarUsuario(nombre, email, telefono, clave);

            MessageBox.Show("Recepcionista agregado exitosamente.");

            CargarRecepcionistas();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecepcionistas.CurrentRow != null)
                {
                    nombre = txtNombreR.Text;
                    email = txtEmail.Text;
                    telefono = txtTelefono.Text;
                    clave = txtClave.Text;

                    entityBusiness.ActualizarUsuario(nombre, email, telefono, clave);

                    MessageBox.Show("Recepcionista actualizado exitosamente.");

                    CargarRecepcionistas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar recepcionista: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecepcionistas.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvRecepcionistas.CurrentRow.Cells["UsuarioId"].Value);

                    entityBusiness.EliminarRecepcionista(id);

                    MessageBox.Show("Recepcionista eliminado exitosamente.");

                    CargarRecepcionistas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Selecciona un recepcionista para eliminar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar recepcionista: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
