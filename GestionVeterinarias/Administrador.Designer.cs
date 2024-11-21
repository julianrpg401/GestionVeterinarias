namespace GestionVeterinarias
{
    partial class Administrador
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
            this.btnVeterinarios = new System.Windows.Forms.Button();
            this.btnRecepcionistas = new System.Windows.Forms.Button();
            this.btnPropietarios = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVeterinarios
            // 
            this.btnVeterinarios.Location = new System.Drawing.Point(147, 11);
            this.btnVeterinarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnVeterinarios.Name = "btnVeterinarios";
            this.btnVeterinarios.Size = new System.Drawing.Size(123, 35);
            this.btnVeterinarios.TabIndex = 0;
            this.btnVeterinarios.Text = "VETERINARIOS";
            this.btnVeterinarios.UseVisualStyleBackColor = true;
            this.btnVeterinarios.Click += new System.EventHandler(this.btnVeterinarios_Click);
            // 
            // btnRecepcionistas
            // 
            this.btnRecepcionistas.Location = new System.Drawing.Point(147, 50);
            this.btnRecepcionistas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecepcionistas.Name = "btnRecepcionistas";
            this.btnRecepcionistas.Size = new System.Drawing.Size(123, 35);
            this.btnRecepcionistas.TabIndex = 1;
            this.btnRecepcionistas.Text = "RECEPCIONISTAS";
            this.btnRecepcionistas.UseVisualStyleBackColor = true;
            this.btnRecepcionistas.Click += new System.EventHandler(this.btnRecepcionistas_Click);
            // 
            // btnPropietarios
            // 
            this.btnPropietarios.Location = new System.Drawing.Point(20, 50);
            this.btnPropietarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropietarios.Name = "btnPropietarios";
            this.btnPropietarios.Size = new System.Drawing.Size(123, 35);
            this.btnPropietarios.TabIndex = 2;
            this.btnPropietarios.Text = "PROPIETARIOS";
            this.btnPropietarios.UseVisualStyleBackColor = true;
            this.btnPropietarios.Click += new System.EventHandler(this.btnPropietarios_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(147, 89);
            this.btnMascotas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(123, 35);
            this.btnMascotas.TabIndex = 3;
            this.btnMascotas.Text = "MASCOTAS";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(20, 89);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(123, 35);
            this.btnCitas.TabIndex = 4;
            this.btnCitas.Text = "CITAS";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(20, 11);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(123, 35);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "ADMINISTRADORES";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 132);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnPropietarios);
            this.Controls.Add(this.btnRecepcionistas);
            this.Controls.Add(this.btnVeterinarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeterinarios;
        private System.Windows.Forms.Button btnRecepcionistas;
        private System.Windows.Forms.Button btnPropietarios;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnAdmin;
    }
}