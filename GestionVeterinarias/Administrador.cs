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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnVeterinarios_Click(object sender, EventArgs e)
        {
            GestionVeterinarios gestionVeterinarios = new GestionVeterinarios();
            gestionVeterinarios.ShowDialog();
        }

        private void btnRecepcionistas_Click(object sender, EventArgs e)
        {
            GestionRecepcionistas gestionRecepcionistas = new GestionRecepcionistas();
            gestionRecepcionistas.ShowDialog();
        }

        private void btnPropietarios_Click(object sender, EventArgs e)
        {
            GestionPropietarios gestionPropietarios = new GestionPropietarios();
            gestionPropietarios.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            GestionMascotas gestionMascotas = new GestionMascotas();
            gestionMascotas.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            GestionCitas gestionCitas = new GestionCitas();
            gestionCitas.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            GestionAdministradores gestionAdministradores = new GestionAdministradores();
            gestionAdministradores.ShowDialog();
        }
    }
}
