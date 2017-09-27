namespace Autenticacion
{
    partial class RegistrarBedel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarBedel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.turno = new System.Windows.Forms.ComboBox();
            this.idUsuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.confPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo Bedel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Usuario*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña*";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmar Contraseña*";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(77, 45);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(195, 20);
            this.nombre.TabIndex = 7;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(77, 72);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(195, 20);
            this.apellido.TabIndex = 8;
            // 
            // turno
            // 
            this.turno.FormattingEnabled = true;
            this.turno.Location = new System.Drawing.Point(77, 104);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(195, 21);
            this.turno.TabIndex = 9;
            // 
            // idUsuario
            // 
            this.idUsuario.Location = new System.Drawing.Point(77, 136);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(195, 20);
            this.idUsuario.TabIndex = 10;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(77, 168);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(195, 20);
            this.pass.TabIndex = 11;
            // 
            // confPass
            // 
            this.confPass.Location = new System.Drawing.Point(77, 204);
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(195, 20);
            this.confPass.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Campos obligatorios (*)";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(197, 255);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 15;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(116, 255);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 16;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // RegistrarBedel
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 339);
            this.MinimumSize = new System.Drawing.Size(300, 339);
            this.Name = "RegistrarBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Bedel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.ComboBox turno;
        private System.Windows.Forms.TextBox idUsuario;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCerrar;
    }
}