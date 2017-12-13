using System;

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
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoAula = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNombreCurso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.columnaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarioEsporadico = new System.Windows.Forms.DateTimePicker();
            this.cbNoEsporadico = new System.Windows.Forms.ComboBox();
            this.nudCantidadAlumnos = new System.Windows.Forms.NumericUpDown();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBusquedaDocente = new System.Windows.Forms.TextBox();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Reserva*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregue los horarios en que quiere hacer una reserva";
            // 
            // cbTipoReserva
            // 
            this.cbTipoReserva.DropDownHeight = 60;
            this.cbTipoReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoReserva.FormattingEnabled = true;
            this.cbTipoReserva.IntegralHeight = false;
            this.cbTipoReserva.Items.AddRange(new object[] {
            "Esporádica",
            "Cuatrimestral",
            "Anual"});
            this.cbTipoReserva.Location = new System.Drawing.Point(124, 7);
            this.cbTipoReserva.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoReserva.Name = "cbTipoReserva";
            this.cbTipoReserva.Size = new System.Drawing.Size(228, 24);
            this.cbTipoReserva.TabIndex = 1;
            this.cbTipoReserva.SelectedValueChanged += new System.EventHandler(this.cbTipoReserva_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora Inicio*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora Fin*";
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.DropDownHeight = 60;
            this.cbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraInicio.FormatString = "t";
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.IntegralHeight = false;
            this.cbHoraInicio.Location = new System.Drawing.Point(312, 84);
            this.cbHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(83, 24);
            this.cbHoraInicio.TabIndex = 3;
            this.cbHoraInicio.SelectedValueChanged += new System.EventHandler(this.cbHoraInicio_SelectedValueChanged);
            // 
            // cbHoraFin
            // 
            this.cbHoraFin.DropDownHeight = 60;
            this.cbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraFin.FormatString = "t";
            this.cbHoraFin.FormattingEnabled = true;
            this.cbHoraFin.IntegralHeight = false;
            this.cbHoraFin.Location = new System.Drawing.Point(480, 84);
            this.cbHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.cbHoraFin.Name = "cbHoraFin";
            this.cbHoraFin.Size = new System.Drawing.Size(83, 24);
            this.cbHoraFin.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(464, 130);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(464, 166);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 28);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Aula*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 470);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seleccione un docente*:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 418);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre Curso*";
            // 
            // cbTipoAula
            // 
            this.cbTipoAula.DropDownHeight = 60;
            this.cbTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAula.FormattingEnabled = true;
            this.cbTipoAula.IntegralHeight = false;
            this.cbTipoAula.Location = new System.Drawing.Point(161, 340);
            this.cbTipoAula.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoAula.Name = "cbTipoAula";
            this.cbTipoAula.Size = new System.Drawing.Size(300, 24);
            this.cbTipoAula.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 383);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cantidad Alumnos*";
            // 
            // cbNombreCurso
            // 
            this.cbNombreCurso.DropDownHeight = 60;
            this.cbNombreCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreCurso.FormattingEnabled = true;
            this.cbNombreCurso.IntegralHeight = false;
            this.cbNombreCurso.Location = new System.Drawing.Point(161, 415);
            this.cbNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cbNombreCurso.Name = "cbNombreCurso";
            this.cbNombreCurso.Size = new System.Drawing.Size(300, 24);
            this.cbNombreCurso.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Location = new System.Drawing.Point(23, 623);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Campos obligatorios (*)";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(464, 623);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.Text = "Siguiente ->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(356, 623);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaDia,
            this.columnaHoraInicio,
            this.columnaDuracion,
            this.TipoReserva});
            this.dgvResultados.Location = new System.Drawing.Point(20, 130);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(443, 185);
            this.dgvResultados.TabIndex = 7;
            // 
            // columnaDia
            // 
            this.columnaDia.HeaderText = "Dia";
            this.columnaDia.Name = "columnaDia";
            this.columnaDia.ReadOnly = true;
            // 
            // columnaHoraInicio
            // 
            this.columnaHoraInicio.HeaderText = "Hora Inicio";
            this.columnaHoraInicio.Name = "columnaHoraInicio";
            this.columnaHoraInicio.ReadOnly = true;
            // 
            // columnaDuracion
            // 
            this.columnaDuracion.HeaderText = "Duración (Min)";
            this.columnaDuracion.Name = "columnaDuracion";
            this.columnaDuracion.ReadOnly = true;
            // 
            // TipoReserva
            // 
            this.TipoReserva.HeaderText = "TipoReserva";
            this.TipoReserva.Name = "TipoReserva";
            this.TipoReserva.ReadOnly = true;
            this.TipoReserva.Visible = false;
            // 
            // calendarioEsporadico
            // 
            this.calendarioEsporadico.Location = new System.Drawing.Point(60, 85);
            this.calendarioEsporadico.Margin = new System.Windows.Forms.Padding(4);
            this.calendarioEsporadico.Name = "calendarioEsporadico";
            this.calendarioEsporadico.Size = new System.Drawing.Size(152, 22);
            this.calendarioEsporadico.TabIndex = 27;
            // 
            // cbNoEsporadico
            // 
            this.cbNoEsporadico.DropDownHeight = 60;
            this.cbNoEsporadico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoEsporadico.FormatString = "t";
            this.cbNoEsporadico.FormattingEnabled = true;
            this.cbNoEsporadico.IntegralHeight = false;
            this.cbNoEsporadico.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cbNoEsporadico.Location = new System.Drawing.Point(60, 85);
            this.cbNoEsporadico.Margin = new System.Windows.Forms.Padding(4);
            this.cbNoEsporadico.Name = "cbNoEsporadico";
            this.cbNoEsporadico.Size = new System.Drawing.Size(152, 24);
            this.cbNoEsporadico.TabIndex = 2;
            // 
            // nudCantidadAlumnos
            // 
            this.nudCantidadAlumnos.Location = new System.Drawing.Point(161, 380);
            this.nudCantidadAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadAlumnos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadAlumnos.Name = "nudCantidadAlumnos";
            this.nudCantidadAlumnos.Size = new System.Drawing.Size(68, 22);
            this.nudCantidadAlumnos.TabIndex = 9;
            this.nudCantidadAlumnos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Email});
            this.dgvDocentes.Location = new System.Drawing.Point(20, 501);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(544, 100);
            this.dgvDocentes.TabIndex = 13;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 165;
            // 
            // tbBusquedaDocente
            // 
            this.tbBusquedaDocente.Location = new System.Drawing.Point(225, 466);
            this.tbBusquedaDocente.Margin = new System.Windows.Forms.Padding(4);
            this.tbBusquedaDocente.Name = "tbBusquedaDocente";
            this.tbBusquedaDocente.Size = new System.Drawing.Size(229, 22);
            this.tbBusquedaDocente.TabIndex = 11;
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.Location = new System.Drawing.Point(464, 464);
            this.btnBuscarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarDocente.TabIndex = 12;
            this.btnBuscarDocente.Text = "Buscar";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // RegistrarReserva_1
            // 
            this.AcceptButton = this.btnSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(587, 657);
            this.Controls.Add(this.btnBuscarDocente);
            this.Controls.Add(this.tbBusquedaDocente);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.nudCantidadAlumnos);
            this.Controls.Add(this.cbNoEsporadico);
            this.Controls.Add(this.calendarioEsporadico);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbNombreCurso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTipoAula);
            this.Controls.Add(this.label10);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 974);
            this.MinimumSize = new System.Drawing.Size(602, 555);
            this.Name = "RegistrarReserva_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de reserva de aulas";
            this.Load += new System.EventHandler(this.RegistrarReserva_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoAula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNombreCurso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DateTimePicker calendarioEsporadico;
        private System.Windows.Forms.ComboBox cbNoEsporadico;
        private System.Windows.Forms.NumericUpDown nudCantidadAlumnos;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox tbBusquedaDocente;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReserva;
    }
}