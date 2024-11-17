namespace GestionVeterinarias
{
    partial class Recepcionista
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
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.gbCitas = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtEspecializacionV = new System.Windows.Forms.TextBox();
            this.txtVeterinarioId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVeterinarioId = new System.Windows.Forms.Label();
            this.txtMotivoVisita = new System.Windows.Forms.TextBox();
            this.lblMotivoVisita = new System.Windows.Forms.Label();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.gbCitas.SuspendLayout();
            this.gbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(110, 333);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(169, 57);
            this.btnAgendarCita.TabIndex = 0;
            this.btnAgendarCita.Text = "AGENDAR CITA";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.Location = new System.Drawing.Point(362, 333);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(169, 57);
            this.btnEditarCita.TabIndex = 1;
            this.btnEditarCita.Text = "EDITAR CITA";
            this.btnEditarCita.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(141, 325);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(221, 57);
            this.btnGenerarFactura.TabIndex = 2;
            this.btnGenerarFactura.Text = "GENERAR FACTURA";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // gbCitas
            // 
            this.gbCitas.Controls.Add(this.txtMotivoVisita);
            this.gbCitas.Controls.Add(this.lblMotivoVisita);
            this.gbCitas.Controls.Add(this.cmbEstado);
            this.gbCitas.Controls.Add(this.lblEstado);
            this.gbCitas.Controls.Add(this.txtHora);
            this.gbCitas.Controls.Add(this.lblHora);
            this.gbCitas.Controls.Add(this.dtpFecha);
            this.gbCitas.Controls.Add(this.lblFecha);
            this.gbCitas.Controls.Add(this.txtEspecializacionV);
            this.gbCitas.Controls.Add(this.txtVeterinarioId);
            this.gbCitas.Controls.Add(this.label2);
            this.gbCitas.Controls.Add(this.lblVeterinarioId);
            this.gbCitas.Controls.Add(this.btnAgendarCita);
            this.gbCitas.Controls.Add(this.btnEditarCita);
            this.gbCitas.Location = new System.Drawing.Point(12, 12);
            this.gbCitas.Name = "gbCitas";
            this.gbCitas.Size = new System.Drawing.Size(629, 426);
            this.gbCitas.TabIndex = 3;
            this.gbCitas.TabStop = false;
            this.gbCitas.Text = "Cita";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Completada",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(283, 226);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(232, 28);
            this.cmbEstado.TabIndex = 36;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(35, 229);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(283, 154);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(232, 26);
            this.txtHora.TabIndex = 34;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(35, 157);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "Hora";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(283, 118);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(307, 26);
            this.dtpFecha.TabIndex = 32;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 123);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha";
            // 
            // txtEspecializacionV
            // 
            this.txtEspecializacionV.Location = new System.Drawing.Point(283, 82);
            this.txtEspecializacionV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEspecializacionV.Name = "txtEspecializacionV";
            this.txtEspecializacionV.Size = new System.Drawing.Size(232, 26);
            this.txtEspecializacionV.TabIndex = 30;
            // 
            // txtVeterinarioId
            // 
            this.txtVeterinarioId.Location = new System.Drawing.Point(283, 46);
            this.txtVeterinarioId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVeterinarioId.Name = "txtVeterinarioId";
            this.txtVeterinarioId.Size = new System.Drawing.Size(232, 26);
            this.txtVeterinarioId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Especialización";
            // 
            // lblVeterinarioId
            // 
            this.lblVeterinarioId.AutoSize = true;
            this.lblVeterinarioId.Location = new System.Drawing.Point(35, 52);
            this.lblVeterinarioId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeterinarioId.Name = "lblVeterinarioId";
            this.lblVeterinarioId.Size = new System.Drawing.Size(205, 20);
            this.lblVeterinarioId.TabIndex = 27;
            this.lblVeterinarioId.Text = "Identificación del veterinario";
            // 
            // txtMotivoVisita
            // 
            this.txtMotivoVisita.Location = new System.Drawing.Point(283, 190);
            this.txtMotivoVisita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotivoVisita.Name = "txtMotivoVisita";
            this.txtMotivoVisita.Size = new System.Drawing.Size(232, 26);
            this.txtMotivoVisita.TabIndex = 38;
            // 
            // lblMotivoVisita
            // 
            this.lblMotivoVisita.AutoSize = true;
            this.lblMotivoVisita.Location = new System.Drawing.Point(35, 193);
            this.lblMotivoVisita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivoVisita.Name = "lblMotivoVisita";
            this.lblMotivoVisita.Size = new System.Drawing.Size(132, 20);
            this.lblMotivoVisita.TabIndex = 37;
            this.lblMotivoVisita.Text = "Motivo de la visita";
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.btnGenerarFactura);
            this.gbFactura.Location = new System.Drawing.Point(647, 12);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(481, 426);
            this.gbFactura.TabIndex = 4;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            // 
            // Recepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbCitas);
            this.Name = "Recepcionista";
            this.Text = "Recepcionista";
            this.gbCitas.ResumeLayout(false);
            this.gbCitas.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.GroupBox gbCitas;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtEspecializacionV;
        private System.Windows.Forms.TextBox txtVeterinarioId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVeterinarioId;
        private System.Windows.Forms.TextBox txtMotivoVisita;
        private System.Windows.Forms.Label lblMotivoVisita;
        private System.Windows.Forms.GroupBox gbFactura;
    }
}