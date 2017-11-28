namespace Autenticacion
{
    partial class ModificarBedel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarBedel));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbConfPass = new System.Windows.Forms.TextBox();
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(136, 255);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tbNick
            // 
            this.tbNick.Enabled = false;
            this.tbNick.Location = new System.Drawing.Point(77, 136);
            this.tbNick.Name = "tbNick";
            this.tbNick.ReadOnly = true;
            this.tbNick.Size = new System.Drawing.Size(195, 20);
            this.tbNick.TabIndex = 27;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(77, 72);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(195, 20);
            this.tbApellido.TabIndex = 25;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(77, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 20);
            this.tbNombre.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Modifique datos del Bedel seleccionado:";
            // 
            // cbTurno
            // 
            this.cbTurno.DisplayMember = "Mañana";
            this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Noche",
            "Tarde"});
            this.cbTurno.Location = new System.Drawing.Point(77, 104);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(195, 21);
            this.cbTurno.TabIndex = 26;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(77, 168);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(195, 20);
            this.tbPass.TabIndex = 28;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            // 
            // tbConfPass
            // 
            this.tbConfPass.Location = new System.Drawing.Point(77, 201);
            this.tbConfPass.MaxLength = 20;
            this.tbConfPass.Name = "tbConfPass";
            this.tbConfPass.Size = new System.Drawing.Size(195, 20);
            this.tbConfPass.TabIndex = 29;
            this.tbConfPass.UseSystemPasswordChar = true;
            // 
            // notificacion
            // 
            this.notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacion.Icon")));
            this.notificacion.Text = "notifyIcon1";
            this.notificacion.Visible = true;
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackgroundImage = global::CapaPresentacion.Properties.Resources.eye_of_a_human_icon_icons_com_70972;
            this.btnMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarPass.Location = new System.Drawing.Point(278, 167);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(21, 20);
            this.btnMostrarPass.TabIndex = 32;
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // ModificarBedel
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(304, 296);
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.tbConfPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(309, 334);
            this.Name = "ModificarBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Bedel";
            this.Load += new System.EventHandler(this.ModificarBedel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbConfPass;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.Button btnMostrarPass;
    }
}