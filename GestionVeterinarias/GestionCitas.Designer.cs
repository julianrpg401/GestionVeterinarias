namespace GestionVeterinarias
{
    partial class GestionCitas
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
            this.gbAgendarCita = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEspecializacionV = new System.Windows.Forms.TextBox();
            this.txtVeterinario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.gbAgendarCita.SuspendLayout();
            this.SuspendLayout();
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
            this.gbAgendarCita.Location = new System.Drawing.Point(13, 14);
            this.gbAgendarCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAgendarCita.Name = "gbAgendarCita";
            this.gbAgendarCita.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAgendarCita.Size = new System.Drawing.Size(669, 374);
            this.gbAgendarCita.TabIndex = 2;
            this.gbAgendarCita.TabStop = false;
            this.gbAgendarCita.Text = "Citas";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Completada",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(218, 218);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(232, 28);
            this.cmbEstado.TabIndex = 26;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 223);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(218, 178);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(232, 26);
            this.txtHora.TabIndex = 24;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(45, 183);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 23;
            this.lblHora.Text = "Hora";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(218, 138);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(307, 26);
            this.dtpFecha.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(45, 143);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 19;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 54);
            this.button3.TabIndex = 17;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 54);
            this.button4.TabIndex = 16;
            this.button4.Text = "REGISTRAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEspecializacionV
            // 
            this.txtEspecializacionV.Location = new System.Drawing.Point(218, 98);
            this.txtEspecializacionV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEspecializacionV.Name = "txtEspecializacionV";
            this.txtEspecializacionV.Size = new System.Drawing.Size(232, 26);
            this.txtEspecializacionV.TabIndex = 14;
            // 
            // txtVeterinario
            // 
            this.txtVeterinario.Location = new System.Drawing.Point(218, 58);
            this.txtVeterinario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVeterinario.Name = "txtVeterinario";
            this.txtVeterinario.Size = new System.Drawing.Size(232, 26);
            this.txtVeterinario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Especialización";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(45, 63);
            this.lblVeterinario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(86, 20);
            this.lblVeterinario.TabIndex = 10;
            this.lblVeterinario.Text = "Veterinario";
            // 
            // GestionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 404);
            this.Controls.Add(this.gbAgendarCita);
            this.Name = "GestionCitas";
            this.Text = "Gestión de citas";
            this.gbAgendarCita.ResumeLayout(false);
            this.gbAgendarCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgendarCita;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtEspecializacionV;
        private System.Windows.Forms.TextBox txtVeterinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVeterinario;
    }
}