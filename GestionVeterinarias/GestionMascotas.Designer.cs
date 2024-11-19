namespace GestionVeterinarias
{
    partial class GestionMascotas
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
            this.gbDatosMascota = new System.Windows.Forms.GroupBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.gbDatosMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(49, 160);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 35);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(327, 160);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(234, 160);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 35);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(141, 160);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // gbDatosMascota
            // 
            this.gbDatosMascota.Controls.Add(this.txtEspecie);
            this.gbDatosMascota.Controls.Add(this.btnModificar);
            this.gbDatosMascota.Controls.Add(this.lblNombreM);
            this.gbDatosMascota.Controls.Add(this.btnConsultar);
            this.gbDatosMascota.Controls.Add(this.btnEliminar);
            this.gbDatosMascota.Controls.Add(this.lblEspecie);
            this.gbDatosMascota.Controls.Add(this.btnRegistrar);
            this.gbDatosMascota.Controls.Add(this.lblRaza);
            this.gbDatosMascota.Controls.Add(this.txtNombreM);
            this.gbDatosMascota.Controls.Add(this.txtRaza);
            this.gbDatosMascota.Location = new System.Drawing.Point(11, 11);
            this.gbDatosMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosMascota.Name = "gbDatosMascota";
            this.gbDatosMascota.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosMascota.Size = new System.Drawing.Size(466, 220);
            this.gbDatosMascota.TabIndex = 16;
            this.gbDatosMascota.TabStop = false;
            this.gbDatosMascota.Text = "Datos de la mascota";
            // 
            // txtEspecie
            // 
            this.txtEspecie.AcceptsTab = true;
            this.txtEspecie.Location = new System.Drawing.Point(188, 68);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(161, 20);
            this.txtEspecie.TabIndex = 9;
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(116, 46);
            this.lblNombreM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(44, 13);
            this.lblNombreM.TabIndex = 4;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(116, 70);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 5;
            this.lblEspecie.Text = "Especie";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(116, 94);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 7;
            this.lblRaza.Text = "Raza";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(188, 44);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(161, 20);
            this.txtNombreM.TabIndex = 8;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(188, 92);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(161, 20);
            this.txtRaza.TabIndex = 10;
            // 
            // GestionMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 242);
            this.Controls.Add(this.gbDatosMascota);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionMascotas";
            this.Text = "Gestión de mascotas";
            this.gbDatosMascota.ResumeLayout(false);
            this.gbDatosMascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbDatosMascota;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtRaza;
    }
}