﻿using BusinessLayer;
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombreR.Text;
            email = txtEmail.Text;
            telefono = txtTelefono.Text;
            clave = txtClave.Text;

            entityBusiness.AgregarUsuario(nombre, email, telefono, clave);

            MessageBox.Show("Recepcionista agregado exitosamente.");
        }
    }
}
