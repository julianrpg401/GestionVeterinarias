namespace GestionVeterinarias
{
    partial class GestionAdministradores
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
            this.gbDatosAdministrador = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.gbDatosAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosAdministrador
            // 
            this.gbDatosAdministrador.Controls.Add(this.txtClave);
            this.gbDatosAdministrador.Controls.Add(this.lblClave);
            this.gbDatosAdministrador.Controls.Add(this.btnModificar);
            this.gbDatosAdministrador.Controls.Add(this.btnConsultar);
            this.gbDatosAdministrador.Controls.Add(this.btnEliminar);
            this.gbDatosAdministrador.Controls.Add(this.btnRegistrar);
            this.gbDatosAdministrador.Controls.Add(this.txtTelefono);
            this.gbDatosAdministrador.Controls.Add(this.txtNombreA);
            this.gbDatosAdministrador.Controls.Add(this.lblTelefono);
            this.gbDatosAdministrador.Controls.Add(this.lblNombreA);
            this.gbDatosAdministrador.Location = new System.Drawing.Point(12, 12);
            this.gbDatosAdministrador.Name = "gbDatosAdministrador";
            this.gbDatosAdministrador.Size = new System.Drawing.Size(446, 217);
            this.gbDatosAdministrador.TabIndex = 2;
            this.gbDatosAdministrador.TabStop = false;
            this.gbDatosAdministrador.Text = "Datos del administrador";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(193, 94);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(156, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(78, 97);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(130, 155);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(223, 155);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 35);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(316, 155);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(38, 155);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(193, 68);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(193, 42);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(156, 20);
            this.txtNombreA.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(78, 71);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Location = new System.Drawing.Point(78, 45);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(44, 13);
            this.lblNombreA.TabIndex = 0;
            this.lblNombreA.Text = "Nombre";
            // 
            // GestionAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 239);
            this.Controls.Add(this.gbDatosAdministrador);
            this.Name = "GestionAdministradores";
            this.Text = "Gestion de administradores";
            this.gbDatosAdministrador.ResumeLayout(false);
            this.gbDatosAdministrador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosAdministrador;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreA;
    }
}