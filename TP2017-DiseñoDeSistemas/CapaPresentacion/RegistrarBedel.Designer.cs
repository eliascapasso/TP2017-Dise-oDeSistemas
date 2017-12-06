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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarBedel));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.lbTurno = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbConfirmarPass = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbConfirmarPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo Bedel:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 55);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(63, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre*";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(16, 92);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(63, 17);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido*";
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Location = new System.Drawing.Point(16, 132);
            this.lbNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(51, 17);
            this.lbNick.TabIndex = 3;
            this.lbNick.Text = "Turno*";
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Location = new System.Drawing.Point(16, 171);
            this.lbTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(40, 17);
            this.lbTurno.TabIndex = 4;
            this.lbTurno.Text = "Nick*";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(16, 210);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(86, 17);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Contraseña*";
            // 
            // lbConfirmarPass
            // 
            this.lbConfirmarPass.Location = new System.Drawing.Point(16, 251);
            this.lbConfirmarPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConfirmarPass.Name = "lbConfirmarPass";
            this.lbConfirmarPass.Size = new System.Drawing.Size(93, 39);
            this.lbConfirmarPass.TabIndex = 6;
            this.lbConfirmarPass.Text = "Confirmar Contraseña*";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(103, 55);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(259, 22);
            this.tbNombre.TabIndex = 7;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(103, 89);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(259, 22);
            this.tbApellido.TabIndex = 8;
            // 
            // cbTurno
            // 
            this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cbTurno.Location = new System.Drawing.Point(103, 128);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(259, 24);
            this.cbTurno.TabIndex = 9;
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(103, 167);
            this.tbNick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(259, 22);
            this.tbNick.TabIndex = 10;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(103, 207);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(259, 22);
            this.tbPass.TabIndex = 11;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            // 
            // tbConfirmarPass
            // 
            this.tbConfirmarPass.Location = new System.Drawing.Point(103, 251);
            this.tbConfirmarPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmarPass.MaxLength = 20;
            this.tbConfirmarPass.Name = "tbConfirmarPass";
            this.tbConfirmarPass.Size = new System.Drawing.Size(259, 22);
            this.tbConfirmarPass.TabIndex = 12;
            this.tbConfirmarPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(16, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "Campos obligatorios (*)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(287, 327);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(179, 327);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // notificacion
            // 
            this.notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacion.Icon")));
            this.notificacion.Text = "Notificacion";
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackgroundImage = global::CapaPresentacion.Properties.Resources.eye_of_a_human_icon_icons_com_70972;
            this.btnMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarPass.Location = new System.Drawing.Point(371, 207);
            this.btnMostrarPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(28, 25);
            this.btnMostrarPass.TabIndex = 15;
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // RegistrarBedel
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 370);
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbConfirmarPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbConfirmarPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.lbTurno);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 605);
            this.MinimumSize = new System.Drawing.Size(394, 406);
            this.Name = "RegistrarBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Bedel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbConfirmarPass;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbConfirmarPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.Button btnMostrarPass;
    }
}