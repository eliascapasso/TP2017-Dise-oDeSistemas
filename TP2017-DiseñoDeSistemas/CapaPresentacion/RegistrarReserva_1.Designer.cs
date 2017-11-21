namespace Autenticacion
{
    partial class RegistrarReserva_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarReserva_1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoReserva = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHoraInicio = new System.Windows.Forms.ComboBox();
            this.cbHoraFin = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoAula = new System.Windows.Forms.ComboBox();
            this.tbCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.tbNombreSolicitante = new System.Windows.Forms.TextBox();
            this.tbApellidoSolicitante = new System.Windows.Forms.TextBox();
            this.tbEmailSolicitante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNombreCurso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarioDia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Reserva*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregue los horarios en que quiere hacer una reserva";
            // 
            // cbTipoReserva
            // 
            this.cbTipoReserva.FormattingEnabled = true;
            this.cbTipoReserva.Items.AddRange(new object[] {
            "Esporadica",
            "Cuatrimestral",
            "Anual"});
            this.cbTipoReserva.Location = new System.Drawing.Point(93, 6);
            this.cbTipoReserva.Name = "cbTipoReserva";
            this.cbTipoReserva.Size = new System.Drawing.Size(172, 21);
            this.cbTipoReserva.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora Inicio*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora Fin*";
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.DropDownHeight = 60;
            this.cbHoraInicio.FormatString = "t";
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.IntegralHeight = false;
            this.cbHoraInicio.Location = new System.Drawing.Point(234, 68);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(63, 21);
            this.cbHoraInicio.TabIndex = 7;
            this.cbHoraInicio.SelectedValueChanged += new System.EventHandler(this.cbHoraInicio_SelectedValueChanged);
            // 
            // cbHoraFin
            // 
            this.cbHoraFin.DropDownHeight = 60;
            this.cbHoraFin.FormatString = "t";
            this.cbHoraFin.FormattingEnabled = true;
            this.cbHoraFin.IntegralHeight = false;
            this.cbHoraFin.Location = new System.Drawing.Point(360, 68);
            this.cbHoraFin.Name = "cbHoraFin";
            this.cbHoraFin.Size = new System.Drawing.Size(63, 21);
            this.cbHoraFin.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(353, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(353, 165);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Aula*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre Solicitante*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Apellido Solicitante*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "E-mail Solicitante*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre Curso*";
            // 
            // cbTipoAula
            // 
            this.cbTipoAula.FormattingEnabled = true;
            this.cbTipoAula.Location = new System.Drawing.Point(128, 307);
            this.cbTipoAula.Name = "cbTipoAula";
            this.cbTipoAula.Size = new System.Drawing.Size(226, 21);
            this.cbTipoAula.TabIndex = 16;
            // 
            // tbCantidadAlumnos
            // 
            this.tbCantidadAlumnos.Location = new System.Drawing.Point(128, 333);
            this.tbCantidadAlumnos.Name = "tbCantidadAlumnos";
            this.tbCantidadAlumnos.Size = new System.Drawing.Size(51, 20);
            this.tbCantidadAlumnos.TabIndex = 17;
            // 
            // tbNombreSolicitante
            // 
            this.tbNombreSolicitante.Location = new System.Drawing.Point(128, 358);
            this.tbNombreSolicitante.Name = "tbNombreSolicitante";
            this.tbNombreSolicitante.Size = new System.Drawing.Size(226, 20);
            this.tbNombreSolicitante.TabIndex = 18;
            // 
            // tbApellidoSolicitante
            // 
            this.tbApellidoSolicitante.Location = new System.Drawing.Point(128, 385);
            this.tbApellidoSolicitante.Name = "tbApellidoSolicitante";
            this.tbApellidoSolicitante.Size = new System.Drawing.Size(226, 20);
            this.tbApellidoSolicitante.TabIndex = 19;
            // 
            // tbEmailSolicitante
            // 
            this.tbEmailSolicitante.Location = new System.Drawing.Point(128, 411);
            this.tbEmailSolicitante.Name = "tbEmailSolicitante";
            this.tbEmailSolicitante.Size = new System.Drawing.Size(226, 20);
            this.tbEmailSolicitante.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cantidad Alumnos*";
            // 
            // cbNombreCurso
            // 
            this.cbNombreCurso.FormattingEnabled = true;
            this.cbNombreCurso.Location = new System.Drawing.Point(128, 436);
            this.cbNombreCurso.Name = "cbNombreCurso";
            this.cbNombreCurso.Size = new System.Drawing.Size(226, 21);
            this.cbNombreCurso.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Location = new System.Drawing.Point(12, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Campos obligatorios (*)";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(336, 494);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.Text = "Siguiente ->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(249, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvResultados.Location = new System.Drawing.Point(15, 136);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(332, 150);
            this.dgvResultados.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dia";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora Inicio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duracion";
            this.Column3.Name = "Column3";
            // 
            // calendarioDia
            // 
            this.calendarioDia.Location = new System.Drawing.Point(45, 68);
            this.calendarioDia.Name = "calendarioDia";
            this.calendarioDia.Size = new System.Drawing.Size(115, 20);
            this.calendarioDia.TabIndex = 27;
            // 
            // RegistrarReserva_1
            // 
            this.AcceptButton = this.btnSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 531);
            this.Controls.Add(this.calendarioDia);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbNombreCurso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbEmailSolicitante);
            this.Controls.Add(this.tbApellidoSolicitante);
            this.Controls.Add(this.tbNombreSolicitante);
            this.Controls.Add(this.tbCantidadAlumnos);
            this.Controls.Add(this.cbTipoAula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbHoraFin);
            this.Controls.Add(this.cbHoraInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 569);
            this.MinimumSize = new System.Drawing.Size(456, 558);
            this.Name = "RegistrarReserva_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de reserva de aulas";
            this.Load += new System.EventHandler(this.RegistrarReserva_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHoraInicio;
        private System.Windows.Forms.ComboBox cbHoraFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoAula;
        private System.Windows.Forms.TextBox tbCantidadAlumnos;
        private System.Windows.Forms.TextBox tbNombreSolicitante;
        private System.Windows.Forms.TextBox tbApellidoSolicitante;
        private System.Windows.Forms.TextBox tbEmailSolicitante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNombreCurso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker calendarioDia;
    }
}