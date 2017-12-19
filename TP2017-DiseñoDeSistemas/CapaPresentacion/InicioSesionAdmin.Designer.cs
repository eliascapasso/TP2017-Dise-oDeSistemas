namespace Autenticacion
{
    partial class InicioSesionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionAdmin));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(297, 123);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(189, 123);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(136, 18);
            this.tbNick.Margin = new System.Windows.Forms.Padding(4);
            this.tbNick.MaxLength = 50;
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(225, 22);
            this.tbNick.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(136, 78);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.MaxLength = 50;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(225, 22);
            this.tbPass.TabIndex = 5;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackgroundImage = global::CapaPresentacion.Properties.Resources.eye_of_a_human_icon_icons_com_70972;
            this.btnMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarPass.Location = new System.Drawing.Point(369, 77);
            this.btnMostrarPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(28, 25);
            this.btnMostrarPass.TabIndex = 15;
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // InicioSesionAdmin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(403, 153);
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(394, 200);
            this.Name = "InicioSesionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión Administrador";
            this.Load += new System.EventHandler(this.InicioSesionAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnMostrarPass;
    }
}