namespace GestionVeterinarias
{
    partial class GestionRecepcionistas
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
            this.gbDatosRecepcionista = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.dgvRecepcionistas = new System.Windows.Forms.DataGridView();
            this.gbDatosRecepcionista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionistas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosRecepcionista
            // 
            this.gbDatosRecepcionista.Controls.Add(this.txtClave);
            this.gbDatosRecepcionista.Controls.Add(this.lblClave);
            this.gbDatosRecepcionista.Controls.Add(this.btnActualizar);
            this.gbDatosRecepcionista.Controls.Add(this.btnConsultar);
            this.gbDatosRecepcionista.Controls.Add(this.btnEliminar);
            this.gbDatosRecepcionista.Controls.Add(this.btnRegistrar);
            this.gbDatosRecepcionista.Controls.Add(this.txtTelefono);
            this.gbDatosRecepcionista.Controls.Add(this.txtEmail);
            this.gbDatosRecepcionista.Controls.Add(this.txtNombreR);
            this.gbDatosRecepcionista.Controls.Add(this.lblTelefono);
            this.gbDatosRecepcionista.Controls.Add(this.lblEmail);
            this.gbDatosRecepcionista.Controls.Add(this.lblNombreR);
            this.gbDatosRecepcionista.Location = new System.Drawing.Point(12, 12);
            this.gbDatosRecepcionista.Name = "gbDatosRecepcionista";
            this.gbDatosRecepcionista.Size = new System.Drawing.Size(446, 269);
            this.gbDatosRecepcionista.TabIndex = 1;
            this.gbDatosRecepcionista.TabStop = false;
            this.gbDatosRecepcionista.Text = "Datos del recepcionista";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(193, 120);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(156, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(78, 123);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(129, 196);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 35);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(222, 196);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 35);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(315, 196);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(37, 196);
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
            this.txtTelefono.Location = new System.Drawing.Point(193, 94);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNombreR
            // 
            this.txtNombreR.Location = new System.Drawing.Point(193, 42);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(156, 20);
            this.txtNombreR.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(78, 97);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(78, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblNombreR
            // 
            this.lblNombreR.AutoSize = true;
            this.lblNombreR.Location = new System.Drawing.Point(78, 45);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(44, 13);
            this.lblNombreR.TabIndex = 0;
            this.lblNombreR.Text = "Nombre";
            // 
            // dgvRecepcionistas
            // 
            this.dgvRecepcionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepcionistas.Location = new System.Drawing.Point(464, 12);
            this.dgvRecepcionistas.Name = "dgvRecepcionistas";
            this.dgvRecepcionistas.Size = new System.Drawing.Size(573, 269);
            this.dgvRecepcionistas.TabIndex = 2;
            this.dgvRecepcionistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepcionistas_CellClick);
            // 
            // GestionRecepcionistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 291);
            this.Controls.Add(this.dgvRecepcionistas);
            this.Controls.Add(this.gbDatosRecepcionista);
            this.Name = "GestionRecepcionistas";
            this.Text = "GestionRecepcionistas";
            this.gbDatosRecepcionista.ResumeLayout(false);
            this.gbDatosRecepcionista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosRecepcionista;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreR;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvRecepcionistas;
    }
}