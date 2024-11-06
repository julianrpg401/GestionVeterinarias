namespace GestionVeterinarias
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.gbRol = new System.Windows.Forms.GroupBox();
            this.rbVeterinario = new System.Windows.Forms.RadioButton();
            this.rbRecepcionista = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnEntrar);
            this.gbLogin.Controls.Add(this.txtClave);
            this.gbLogin.Controls.Add(this.gbRol);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.lblClave);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(563, 402);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Iniciar sesión";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(199, 298);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(147, 67);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(215, 106);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(161, 26);
            this.txtClave.TabIndex = 7;
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.rbVeterinario);
            this.gbRol.Controls.Add(this.rbRecepcionista);
            this.gbRol.Controls.Add(this.rbAdministrador);
            this.gbRol.Location = new System.Drawing.Point(34, 162);
            this.gbRol.Name = "gbRol";
            this.gbRol.Size = new System.Drawing.Size(480, 104);
            this.gbRol.TabIndex = 3;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol";
            // 
            // rbVeterinario
            // 
            this.rbVeterinario.AutoSize = true;
            this.rbVeterinario.Location = new System.Drawing.Point(181, 44);
            this.rbVeterinario.Name = "rbVeterinario";
            this.rbVeterinario.Size = new System.Drawing.Size(111, 24);
            this.rbVeterinario.TabIndex = 1;
            this.rbVeterinario.TabStop = true;
            this.rbVeterinario.Text = "Veterinario";
            this.rbVeterinario.UseVisualStyleBackColor = true;
            // 
            // rbRecepcionista
            // 
            this.rbRecepcionista.AutoSize = true;
            this.rbRecepcionista.Location = new System.Drawing.Point(298, 44);
            this.rbRecepcionista.Name = "rbRecepcionista";
            this.rbRecepcionista.Size = new System.Drawing.Size(135, 24);
            this.rbRecepcionista.TabIndex = 2;
            this.rbRecepcionista.TabStop = true;
            this.rbRecepcionista.Text = "Recepcionista";
            this.rbRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(43, 44);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(132, 24);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(215, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 26);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(107, 109);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(48, 20);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(107, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 428);
            this.Controls.Add(this.gbLogin);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbRol.ResumeLayout(false);
            this.gbRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.RadioButton rbRecepcionista;
        private System.Windows.Forms.RadioButton rbVeterinario;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
    }
}

