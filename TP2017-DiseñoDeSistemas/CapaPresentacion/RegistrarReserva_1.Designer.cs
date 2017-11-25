﻿using System;

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
            this.calendarioEsporadico = new System.Windows.Forms.DateTimePicker();
            this.cbNoEsporadico = new System.Windows.Forms.ComboBox();
            this.tbCantidadAlumnos = new System.Windows.Forms.NumericUpDown();
            this.dgvSolicitantes = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitantes)).BeginInit();
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
            this.cbTipoReserva.DropDownHeight = 60;
            this.cbTipoReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoReserva.FormattingEnabled = true;
            this.cbTipoReserva.IntegralHeight = false;
            this.cbTipoReserva.Items.AddRange(new object[] {
            "Esporádica",
            "Cuatrimestral",
            "Anual"});
            this.cbTipoReserva.Location = new System.Drawing.Point(93, 6);
            this.cbTipoReserva.Name = "cbTipoReserva";
            this.cbTipoReserva.Size = new System.Drawing.Size(172, 21);
            this.cbTipoReserva.TabIndex = 2;
            this.cbTipoReserva.SelectedValueChanged += new System.EventHandler(this.cbTipoReserva_SelectedValueChanged);
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
            this.cbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btnAgregar.Location = new System.Drawing.Point(348, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(348, 135);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Aula*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seleccione un solicitante*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre Curso*";
            // 
            // cbTipoAula
            // 
            this.cbTipoAula.DropDownHeight = 60;
            this.cbTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAula.FormattingEnabled = true;
            this.cbTipoAula.IntegralHeight = false;
            this.cbTipoAula.Location = new System.Drawing.Point(121, 276);
            this.cbTipoAula.Name = "cbTipoAula";
            this.cbTipoAula.Size = new System.Drawing.Size(226, 21);
            this.cbTipoAula.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cantidad Alumnos*";
            // 
            // cbNombreCurso
            // 
            this.cbNombreCurso.DropDownHeight = 60;
            this.cbNombreCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreCurso.FormattingEnabled = true;
            this.cbNombreCurso.IntegralHeight = false;
            this.cbNombreCurso.Location = new System.Drawing.Point(121, 337);
            this.cbNombreCurso.Name = "cbNombreCurso";
            this.cbNombreCurso.Size = new System.Drawing.Size(226, 21);
            this.cbNombreCurso.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Location = new System.Drawing.Point(12, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Campos obligatorios (*)";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(348, 485);
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
            this.btnCancelar.Location = new System.Drawing.Point(258, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
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
            this.columnaDuracion});
            this.dgvResultados.Location = new System.Drawing.Point(15, 106);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(332, 150);
            this.dgvResultados.TabIndex = 26;
            this.dgvResultados.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResultados_RowHeaderMouseClick);
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
            this.columnaDuracion.HeaderText = "Duracion";
            this.columnaDuracion.Name = "columnaDuracion";
            this.columnaDuracion.ReadOnly = true;
            // 
            // calendarioEsporadico
            // 
            this.calendarioEsporadico.Location = new System.Drawing.Point(45, 69);
            this.calendarioEsporadico.Name = "calendarioEsporadico";
            this.calendarioEsporadico.Size = new System.Drawing.Size(115, 20);
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
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbNoEsporadico.Location = new System.Drawing.Point(45, 69);
            this.cbNoEsporadico.Name = "cbNoEsporadico";
            this.cbNoEsporadico.Size = new System.Drawing.Size(115, 21);
            this.cbNoEsporadico.TabIndex = 28;
            // 
            // tbCantidadAlumnos
            // 
            this.tbCantidadAlumnos.Location = new System.Drawing.Point(121, 309);
            this.tbCantidadAlumnos.Name = "tbCantidadAlumnos";
            this.tbCantidadAlumnos.Size = new System.Drawing.Size(51, 20);
            this.tbCantidadAlumnos.TabIndex = 29;
            // 
            // dgvSolicitantes
            // 
            this.dgvSolicitantes.AllowUserToAddRows = false;
            this.dgvSolicitantes.AllowUserToDeleteRows = false;
            this.dgvSolicitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Email});
            this.dgvSolicitantes.Location = new System.Drawing.Point(15, 386);
            this.dgvSolicitantes.Name = "dgvSolicitantes";
            this.dgvSolicitantes.ReadOnly = true;
            this.dgvSolicitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitantes.Size = new System.Drawing.Size(408, 81);
            this.dgvSolicitantes.TabIndex = 30;
            this.dgvSolicitantes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSolicitante_RowHeaderMouseClick);
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
            // RegistrarReserva_1
            // 
            this.AcceptButton = this.btnSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 520);
            this.Controls.Add(this.dgvSolicitantes);
            this.Controls.Add(this.tbCantidadAlumnos);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 569);
            this.MinimumSize = new System.Drawing.Size(456, 558);
            this.Name = "RegistrarReserva_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de reserva de aulas";
            this.Load += new System.EventHandler(this.RegistrarReserva_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidadAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitantes)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDuracion;
        private System.Windows.Forms.DateTimePicker calendarioEsporadico;
        private System.Windows.Forms.ComboBox cbNoEsporadico;
        private System.Windows.Forms.NumericUpDown tbCantidadAlumnos;
        private System.Windows.Forms.DataGridView dgvSolicitantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}