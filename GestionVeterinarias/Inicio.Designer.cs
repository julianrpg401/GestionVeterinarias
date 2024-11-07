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
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.btnEntrar);
            this.gbLogin.Controls.Add(this.txtClave);
            this.gbLogin.Controls.Add(this.gbRol);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.lblClave);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Location = new System.Drawing.Point(8, 8);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLogin.Size = new System.Drawing.Size(375, 261);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Iniciar sesión";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(133, 194);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 44);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(143, 69);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(109, 20);
            this.txtClave.TabIndex = 7;
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.rbVeterinario);
            this.gbRol.Controls.Add(this.rbRecepcionista);
            this.gbRol.Controls.Add(this.rbAdministrador);
            this.gbRol.Location = new System.Drawing.Point(23, 105);
            this.gbRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRol.Name = "gbRol";
            this.gbRol.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRol.Size = new System.Drawing.Size(320, 68);
            this.gbRol.TabIndex = 3;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol";
            // 
            // rbVeterinario
            // 
            this.rbVeterinario.AutoSize = true;
            this.rbVeterinario.Location = new System.Drawing.Point(121, 29);
            this.rbVeterinario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVeterinario.Name = "rbVeterinario";
            this.rbVeterinario.Size = new System.Drawing.Size(75, 17);
            this.rbVeterinario.TabIndex = 1;
            this.rbVeterinario.TabStop = true;
            this.rbVeterinario.Text = "Veterinario";
            this.rbVeterinario.UseVisualStyleBackColor = true;
            // 
            // rbRecepcionista
            // 
            this.rbRecepcionista.AutoSize = true;
            this.rbRecepcionista.Location = new System.Drawing.Point(199, 29);
            this.rbRecepcionista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRecepcionista.Name = "rbRecepcionista";
            this.rbRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.rbRecepcionista.TabIndex = 2;
            this.rbRecepcionista.TabStop = true;
            this.rbRecepcionista.Text = "Recepcionista";
            this.rbRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(29, 29);
            this.rbAdministrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 41);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(71, 71);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(71, 43);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 278);
            this.Controls.Add(this.gbLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}

