namespace GestionVeterinarias
{
    partial class GestionPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gbDatosPropietario = new System.Windows.Forms.GroupBox();
            this.gbDatosMascota = new System.Windows.Forms.GroupBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.gbDatosPropietario.SuspendLayout();
            this.gbDatosMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(169, 264);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 54);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 264);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 54);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(447, 264);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(133, 54);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(308, 264);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 54);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(28, 65);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(65, 20);
            this.lblNombreP.TabIndex = 4;
            this.lblNombreP.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(28, 161);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 129);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(136, 62);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(239, 26);
            this.txtNombreP.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(136, 126);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 26);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(136, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 26);
            this.txtDireccion.TabIndex = 11;
            // 
            // gbDatosPropietario
            // 
            this.gbDatosPropietario.Controls.Add(this.txtEmail);
            this.gbDatosPropietario.Controls.Add(this.lblNombreP);
            this.gbDatosPropietario.Controls.Add(this.lblEmail);
            this.gbDatosPropietario.Controls.Add(this.lblDireccion);
            this.gbDatosPropietario.Controls.Add(this.lblTelefono);
            this.gbDatosPropietario.Controls.Add(this.txtDireccion);
            this.gbDatosPropietario.Controls.Add(this.txtNombreP);
            this.gbDatosPropietario.Controls.Add(this.txtTelefono);
            this.gbDatosPropietario.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPropietario.Name = "gbDatosPropietario";
            this.gbDatosPropietario.Size = new System.Drawing.Size(418, 218);
            this.gbDatosPropietario.TabIndex = 15;
            this.gbDatosPropietario.TabStop = false;
            this.gbDatosPropietario.Text = "Datos del propietario";
            // 
            // gbDatosMascota
            // 
            this.gbDatosMascota.Controls.Add(this.txtEspecie);
            this.gbDatosMascota.Controls.Add(this.lblNombreM);
            this.gbDatosMascota.Controls.Add(this.lblEspecie);
            this.gbDatosMascota.Controls.Add(this.lblRaza);
            this.gbDatosMascota.Controls.Add(this.txtNombreM);
            this.gbDatosMascota.Controls.Add(this.txtRaza);
            this.gbDatosMascota.Location = new System.Drawing.Point(457, 12);
            this.gbDatosMascota.Name = "gbDatosMascota";
            this.gbDatosMascota.Size = new System.Drawing.Size(418, 218);
            this.gbDatosMascota.TabIndex = 16;
            this.gbDatosMascota.TabStop = false;
            this.gbDatosMascota.Text = "Datos de la mascota";
            // 
            // txtEspecie
            // 
            this.txtEspecie.AcceptsTab = true;
            this.txtEspecie.Location = new System.Drawing.Point(136, 94);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(239, 26);
            this.txtEspecie.TabIndex = 9;
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(28, 65);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(65, 20);
            this.lblNombreM.TabIndex = 4;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(28, 97);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(66, 20);
            this.lblEspecie.TabIndex = 5;
            this.lblEspecie.Text = "Especie";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(28, 129);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(47, 20);
            this.lblRaza.TabIndex = 7;
            this.lblRaza.Text = "Raza";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(136, 62);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(239, 26);
            this.txtNombreM.TabIndex = 8;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(136, 126);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(239, 26);
            this.txtRaza.TabIndex = 10;
            // 
            // GestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 373);
            this.Controls.Add(this.gbDatosMascota);
            this.Controls.Add(this.gbDatosPropietario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "GestionPacientes";
            this.Text = "Gestion de pacientes";
            this.gbDatosPropietario.ResumeLayout(false);
            this.gbDatosPropietario.PerformLayout();
            this.gbDatosMascota.ResumeLayout(false);
            this.gbDatosMascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox gbDatosPropietario;
        private System.Windows.Forms.GroupBox gbDatosMascota;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtRaza;
    }
}