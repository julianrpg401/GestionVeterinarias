namespace GestionVeterinarias
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
            this.lblNombreV = new System.Windows.Forms.Label();
            this.lblEspecializacion = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.txtEspecializacion = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbAgendarCita = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEspecializacionV = new System.Windows.Forms.TextBox();
            this.txtVeterinario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gbDatosVeterinario.SuspendLayout();
            this.gbAgendarCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosVeterinario
            // 
            this.gbDatosVeterinario.Controls.Add(this.btnModificar);
            this.gbDatosVeterinario.Controls.Add(this.btnConsultar);
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
            this.gbDatosVeterinario.Size = new System.Drawing.Size(446, 212);
            this.gbDatosVeterinario.TabIndex = 0;
            this.gbDatosVeterinario.TabStop = false;
            this.gbDatosVeterinario.Text = "Datos del veterinario";
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(30, 48);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(44, 13);
            this.lblNombreV.TabIndex = 0;
            this.lblNombreV.Text = "Nombre";
            // 
            // lblEspecializacion
            // 
            this.lblEspecializacion.AutoSize = true;
            this.lblEspecializacion.Location = new System.Drawing.Point(30, 74);
            this.lblEspecializacion.Name = "lblEspecializacion";
            this.lblEspecializacion.Size = new System.Drawing.Size(80, 13);
            this.lblEspecializacion.TabIndex = 1;
            this.lblEspecializacion.Text = "Especialización";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(30, 100);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario";
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(145, 45);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(156, 20);
            this.txtNombreV.TabIndex = 3;
            // 
            // txtEspecializacion
            // 
            this.txtEspecializacion.Location = new System.Drawing.Point(145, 71);
            this.txtEspecializacion.Name = "txtEspecializacion";
            this.txtEspecializacion.Size = new System.Drawing.Size(156, 20);
            this.txtEspecializacion.TabIndex = 4;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(145, 97);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(156, 20);
            this.txtHorario.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(129, 155);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(222, 155);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 35);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(315, 155);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(37, 155);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // gbAgendarCita
            // 
            this.gbAgendarCita.Controls.Add(this.cmbEstado);
            this.gbAgendarCita.Controls.Add(this.lblEstado);
            this.gbAgendarCita.Controls.Add(this.txtHora);
            this.gbAgendarCita.Controls.Add(this.lblHora);
            this.gbAgendarCita.Controls.Add(this.dtpFecha);
            this.gbAgendarCita.Controls.Add(this.lblFecha);
            this.gbAgendarCita.Controls.Add(this.button1);
            this.gbAgendarCita.Controls.Add(this.button2);
            this.gbAgendarCita.Controls.Add(this.button3);
            this.gbAgendarCita.Controls.Add(this.button4);
            this.gbAgendarCita.Controls.Add(this.txtEspecializacionV);
            this.gbAgendarCita.Controls.Add(this.txtVeterinario);
            this.gbAgendarCita.Controls.Add(this.label2);
            this.gbAgendarCita.Controls.Add(this.lblVeterinario);
            this.gbAgendarCita.Location = new System.Drawing.Point(12, 230);
            this.gbAgendarCita.Name = "gbAgendarCita";
            this.gbAgendarCita.Size = new System.Drawing.Size(446, 243);
            this.gbAgendarCita.TabIndex = 1;
            this.gbAgendarCita.TabStop = false;
            this.gbAgendarCita.Text = "Citas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 190);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 190);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "REGISTRAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEspecializacionV
            // 
            this.txtEspecializacionV.Location = new System.Drawing.Point(145, 64);
            this.txtEspecializacionV.Name = "txtEspecializacionV";
            this.txtEspecializacionV.Size = new System.Drawing.Size(156, 20);
            this.txtEspecializacionV.TabIndex = 14;
            // 
            // txtVeterinario
            // 
            this.txtVeterinario.Location = new System.Drawing.Point(145, 38);
            this.txtVeterinario.Name = "txtVeterinario";
            this.txtVeterinario.Size = new System.Drawing.Size(156, 20);
            this.txtVeterinario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Especialización";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(30, 41);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinario.TabIndex = 10;
            this.lblVeterinario.Text = "Veterinario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(30, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(145, 90);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(206, 20);
            this.dtpFecha.TabIndex = 22;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(145, 116);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(156, 20);
            this.txtHora.TabIndex = 24;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(30, 119);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 23;
            this.lblHora.Text = "Hora";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 145);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Completada",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(145, 142);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(156, 21);
            this.cmbEstado.TabIndex = 26;
            // 
            // GestionVeterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.gbAgendarCita);
            this.Controls.Add(this.gbDatosVeterinario);
            this.Name = "GestionVeterinarios";
            this.Text = "Gestión de veterinarios";
            this.gbDatosVeterinario.ResumeLayout(false);
            this.gbDatosVeterinario.PerformLayout();
            this.gbAgendarCita.ResumeLayout(false);
            this.gbAgendarCita.PerformLayout();
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbAgendarCita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtEspecializacionV;
        private System.Windows.Forms.TextBox txtVeterinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}