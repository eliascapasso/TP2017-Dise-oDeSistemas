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
            this.labelPoliticas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(181, 314);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(289, 314);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tbNick
            // 
            this.tbNick.Enabled = false;
            this.tbNick.Location = new System.Drawing.Point(103, 167);
            this.tbNick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNick.Name = "tbNick";
            this.tbNick.ReadOnly = true;
            this.tbNick.Size = new System.Drawing.Size(259, 22);
            this.tbNick.TabIndex = 27;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(103, 89);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(259, 22);
            this.tbApellido.TabIndex = 25;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(103, 55);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(259, 22);
            this.tbNombre.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 39);
            this.label7.TabIndex = 23;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 17);
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
            this.cbTurno.Location = new System.Drawing.Point(103, 128);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(259, 24);
            this.cbTurno.TabIndex = 26;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(103, 207);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(259, 22);
            this.tbPass.TabIndex = 28;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            // 
            // tbConfPass
            // 
            this.tbConfPass.Location = new System.Drawing.Point(103, 260);
            this.tbConfPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfPass.MaxLength = 20;
            this.tbConfPass.Name = "tbConfPass";
            this.tbConfPass.Size = new System.Drawing.Size(259, 22);
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
            this.btnMostrarPass.Location = new System.Drawing.Point(371, 206);
            this.btnMostrarPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(28, 25);
            this.btnMostrarPass.TabIndex = 32;
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // labelPoliticas
            // 
            this.labelPoliticas.AutoSize = true;
            this.labelPoliticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoliticas.ForeColor = System.Drawing.Color.Red;
            this.labelPoliticas.Location = new System.Drawing.Point(103, 233);
            this.labelPoliticas.Name = "labelPoliticas";
            this.labelPoliticas.Size = new System.Drawing.Size(227, 18);
            this.labelPoliticas.TabIndex = 81;
            this.labelPoliticas.Text = "Acá se muestran las politicas incumplidas";
            this.labelPoliticas.UseCompatibleTextRendering = true;
            this.labelPoliticas.Visible = false;
            // 
            // ModificarBedel
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(405, 364);
            this.Controls.Add(this.labelPoliticas);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 605);
            this.MinimumSize = new System.Drawing.Size(406, 400);
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
        private System.Windows.Forms.Label labelPoliticas;
    }
}