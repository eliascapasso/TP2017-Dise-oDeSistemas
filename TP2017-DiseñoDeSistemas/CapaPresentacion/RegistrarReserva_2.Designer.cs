namespace CapaPresentacion
{
    partial class RegistrarReserva_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarReserva_2));
            this.label1 = new System.Windows.Forms.Label();
            this.tcPestañasDias = new System.Windows.Forms.TabControl();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvAulasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.columnaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasSeleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregue un aula disponible para cada día";
            // 
            // tcPestañasDias
            // 
            this.tcPestañasDias.Location = new System.Drawing.Point(20, 47);
            this.tcPestañasDias.Margin = new System.Windows.Forms.Padding(4);
            this.tcPestañasDias.Name = "tcPestañasDias";
            this.tcPestañasDias.SelectedIndex = 0;
            this.tcPestañasDias.Size = new System.Drawing.Size(551, 181);
            this.tcPestañasDias.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 236);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aulas seleccionadas";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(20, 506);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 28);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(235, 610);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "<- Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(343, 610);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(471, 610);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvAulasSeleccionadas
            // 
            this.dgvAulasSeleccionadas.AllowUserToAddRows = false;
            this.dgvAulasSeleccionadas.AllowUserToDeleteRows = false;
            this.dgvAulasSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAulasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulasSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaDia,
            this.Aula,
            this.Capacidad,
            this.Caracteristicas});
            this.dgvAulasSeleccionadas.Location = new System.Drawing.Point(20, 313);
            this.dgvAulasSeleccionadas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAulasSeleccionadas.Name = "dgvAulasSeleccionadas";
            this.dgvAulasSeleccionadas.ReadOnly = true;
            this.dgvAulasSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulasSeleccionadas.Size = new System.Drawing.Size(551, 185);
            this.dgvAulasSeleccionadas.TabIndex = 27;
            // 
            // columnaDia
            // 
            this.columnaDia.HeaderText = "Dia";
            this.columnaDia.Name = "columnaDia";
            this.columnaDia.ReadOnly = true;
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // Caracteristicas
            // 
            this.Caracteristicas.HeaderText = "Caracteristicas";
            this.Caracteristicas.Name = "Caracteristicas";
            this.Caracteristicas.ReadOnly = true;
            // 
            // RegistrarReserva_2
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(584, 642);
            this.Controls.Add(this.dgvAulasSeleccionadas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tcPestañasDias);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 689);
            this.MinimumSize = new System.Drawing.Size(602, 676);
            this.Name = "RegistrarReserva_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de reserva de aulas";
            this.Load += new System.EventHandler(this.RegistrarReserva_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasSeleccionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcPestañasDias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvAulasSeleccionadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
    }
}