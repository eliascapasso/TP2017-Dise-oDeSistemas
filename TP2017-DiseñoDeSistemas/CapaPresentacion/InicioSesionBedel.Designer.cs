namespace Autenticacion
{
    partial class InicioSesionBedel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionBedel));
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(102, 66);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(170, 20);
            this.tbPass.TabIndex = 11;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(102, 18);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(170, 20);
            this.tbNick.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nick";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(224, 102);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackgroundImage = global::CapaPresentacion.Properties.Resources.eye_of_a_human_icon_icons_com_70972;
            this.btnMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarPass.Location = new System.Drawing.Point(278, 66);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(21, 20);
            this.btnMostrarPass.TabIndex = 12;
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // InicioSesionBedel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 133);
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(300, 171);
            this.Name = "InicioSesionBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesionBedel";
            this.Load += new System.EventHandler(this.InicioSesionBedel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMostrarPass;
    }
}