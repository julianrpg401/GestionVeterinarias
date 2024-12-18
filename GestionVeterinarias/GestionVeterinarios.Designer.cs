﻿namespace GestionVeterinarias
{
    partial class GestionVeterinarios
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
            this.gbDatosVeterinario = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtEspecializacion = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblEspecializacion = new System.Windows.Forms.Label();
            this.lblNombreV = new System.Windows.Forms.Label();
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.gbDatosVeterinario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosVeterinario
            // 
            this.gbDatosVeterinario.Controls.Add(this.txtEmail);
            this.gbDatosVeterinario.Controls.Add(this.lblEmail);
            this.gbDatosVeterinario.Controls.Add(this.txtClave);
            this.gbDatosVeterinario.Controls.Add(this.lblClave);
            this.gbDatosVeterinario.Controls.Add(this.btnActualizar);
            this.gbDatosVeterinario.Controls.Add(this.btnLimpiar);
            this.gbDatosVeterinario.Controls.Add(this.btnEliminar);
            this.gbDatosVeterinario.Controls.Add(this.btnRegistrar);
            this.gbDatosVeterinario.Controls.Add(this.txtHorario);
            this.gbDatosVeterinario.Controls.Add(this.txtEspecializacion);
            this.gbDatosVeterinario.Controls.Add(this.txtNombreV);
            this.gbDatosVeterinario.Controls.Add(this.lblHorario);
            this.gbDatosVeterinario.Controls.Add(this.lblEspecializacion);
            this.gbDatosVeterinario.Controls.Add(this.lblNombreV);
            this.gbDatosVeterinario.Location = new System.Drawing.Point(12, 12);
            this.gbDatosVeterinario.Name = "gbDatosVeterinario";
            this.gbDatosVeterinario.Size = new System.Drawing.Size(446, 269);
            this.gbDatosVeterinario.TabIndex = 0;
            this.gbDatosVeterinario.TabStop = false;
            this.gbDatosVeterinario.Text = "Datos del veterinario";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(78, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(193, 146);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(156, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(78, 149);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(125, 217);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 35);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(218, 217);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 35);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(311, 217);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(33, 217);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(193, 94);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(156, 20);
            this.txtHorario.TabIndex = 5;
            // 
            // txtEspecializacion
            // 
            this.txtEspecializacion.Location = new System.Drawing.Point(193, 68);
            this.txtEspecializacion.Name = "txtEspecializacion";
            this.txtEspecializacion.Size = new System.Drawing.Size(156, 20);
            this.txtEspecializacion.TabIndex = 4;
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(193, 42);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(156, 20);
            this.txtNombreV.TabIndex = 3;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(78, 97);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario";
            // 
            // lblEspecializacion
            // 
            this.lblEspecializacion.AutoSize = true;
            this.lblEspecializacion.Location = new System.Drawing.Point(78, 71);
            this.lblEspecializacion.Name = "lblEspecializacion";
            this.lblEspecializacion.Size = new System.Drawing.Size(80, 13);
            this.lblEspecializacion.TabIndex = 1;
            this.lblEspecializacion.Text = "Especialización";
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(78, 45);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(44, 13);
            this.lblNombreV.TabIndex = 0;
            this.lblNombreV.Text = "Nombre";
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Location = new System.Drawing.Point(464, 12);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.Size = new System.Drawing.Size(573, 269);
            this.dgvVeterinarios.TabIndex = 1;
            this.dgvVeterinarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeterinarios_CellClick);
            // 
            // GestionVeterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 293);
            this.Controls.Add(this.dgvVeterinarios);
            this.Controls.Add(this.gbDatosVeterinario);
            this.Name = "GestionVeterinarios";
            this.Text = "Gestión de veterinarios";
            this.gbDatosVeterinario.ResumeLayout(false);
            this.gbDatosVeterinario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosVeterinario;
        private System.Windows.Forms.Label lblEspecializacion;
        private System.Windows.Forms.Label lblNombreV;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtEspecializacion;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
    }
}