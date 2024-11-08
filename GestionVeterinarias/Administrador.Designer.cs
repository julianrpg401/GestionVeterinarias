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
            this.SuspendLayout();
            // 
            // btnVeterinarios
            // 
            this.btnVeterinarios.Location = new System.Drawing.Point(12, 22);
            this.btnVeterinarios.Name = "btnVeterinarios";
            this.btnVeterinarios.Size = new System.Drawing.Size(185, 54);
            this.btnVeterinarios.TabIndex = 0;
            this.btnVeterinarios.Text = "VETERINARIOS";
            this.btnVeterinarios.UseVisualStyleBackColor = true;
            // 
            // btnRecepcionistas
            // 
            this.btnRecepcionistas.Location = new System.Drawing.Point(203, 22);
            this.btnRecepcionistas.Name = "btnRecepcionistas";
            this.btnRecepcionistas.Size = new System.Drawing.Size(185, 54);
            this.btnRecepcionistas.TabIndex = 1;
            this.btnRecepcionistas.Text = "RECEPCIONISTAS";
            this.btnRecepcionistas.UseVisualStyleBackColor = true;
            // 
            // btnPropietarios
            // 
            this.btnPropietarios.Location = new System.Drawing.Point(12, 82);
            this.btnPropietarios.Name = "btnPropietarios";
            this.btnPropietarios.Size = new System.Drawing.Size(185, 54);
            this.btnPropietarios.TabIndex = 2;
            this.btnPropietarios.Text = "PROPIETARIOS";
            this.btnPropietarios.UseVisualStyleBackColor = true;
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(203, 82);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(185, 54);
            this.btnMascotas.TabIndex = 3;
            this.btnMascotas.Text = "MASCOTAS";
            this.btnMascotas.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 152);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnPropietarios);
            this.Controls.Add(this.btnRecepcionistas);
            this.Controls.Add(this.btnVeterinarios);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeterinarios;
        private System.Windows.Forms.Button btnRecepcionistas;
        private System.Windows.Forms.Button btnPropietarios;
        private System.Windows.Forms.Button btnMascotas;
    }
}