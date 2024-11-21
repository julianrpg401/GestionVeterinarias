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
using System.Xml.Linq;

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
            CargarVeterinarios();
        }

        private void LimpiarCampos()
        {
            txtNombreV.Clear();
            txtEspecializacion.Clear();
            txtHorario.Clear();
            txtEmail.Clear();
            txtClave.Clear();
        }

        private void CargarVeterinarios()
        {
            dgvVeterinarios.ReadOnly = true; // Establecer el data grid view solo para lectura
            dgvVeterinarios.AutoGenerateColumns = false; // Desactiva la generación automática de columnas
            dgvVeterinarios.DataSource = null; // Limpia la fuente de datos actual

            dgvVeterinarios.Columns.Clear(); // Elimina columnas previas

            // Define manualmente las columnas en el orden deseado
            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UsuarioId", HeaderText = "ID" });
            dgvVeterinarios.Columns[0].Name = dgvVeterinarios.Columns[0].DataPropertyName;

            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreUsuario", HeaderText = "NOMBRE" });
            dgvVeterinarios.Columns[1].Name = dgvVeterinarios.Columns[1].DataPropertyName;

            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Especializacion", HeaderText = "ESPECIALIZACIÓN" });
            dgvVeterinarios.Columns[2].Name = dgvVeterinarios.Columns[2].DataPropertyName;

            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Horario", HeaderText = "HORARIO" });
            dgvVeterinarios.Columns[3].Name = dgvVeterinarios.Columns[3].DataPropertyName;

            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "EMAIL" });
            dgvVeterinarios.Columns[4].Name = dgvVeterinarios.Columns[4].DataPropertyName;

            dgvVeterinarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Clave", HeaderText = "CLAVE" });
            dgvVeterinarios.Columns[5].Name = dgvVeterinarios.Columns[5].DataPropertyName;

            // Asigna la fuente de datos
            IEnumerable<Veterinario> veterinarios = entityBusiness.GetAllVeterinarios();
            dgvVeterinarios.DataSource = veterinarios;

            dgvVeterinarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvVeterinarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvVeterinarios.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los campos del formulario
                txtNombreV.Text = filaSeleccionada.Cells["NombreUsuario"].Value?.ToString();
                txtEspecializacion.Text = filaSeleccionada.Cells["Especializacion"].Value?.ToString();
                txtHorario.Text = filaSeleccionada.Cells["Horario"].Value?.ToString();
                txtEmail.Text = filaSeleccionada.Cells["Email"].Value?.ToString();
                txtClave.Text = filaSeleccionada.Cells["Clave"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreV.Text;
            especializacion = txtEspecializacion.Text;
            horario = txtHorario.Text;
            email = txtEmail.Text;
            clave = txtClave.Text;

            entityBusiness.AgregarUsuario(nombre, especializacion, horario, email, clave);

            MessageBox.Show("Veterinario agregado exitosamente.");

            CargarVeterinarios();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeterinarios.CurrentRow != null)
                {
                    nombre = txtNombreV.Text;
                    especializacion = txtEspecializacion.Text;
                    horario = txtHorario.Text;
                    email = txtEmail.Text;
                    clave = txtClave.Text;

                    entityBusiness.ActualizarUsuario(nombre, especializacion, horario, email, clave);

                    MessageBox.Show("Veterinario actualizado exitosamente.");

                    CargarVeterinarios();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar veterinario: " + ex.Message);
            }
        }
    }
}
