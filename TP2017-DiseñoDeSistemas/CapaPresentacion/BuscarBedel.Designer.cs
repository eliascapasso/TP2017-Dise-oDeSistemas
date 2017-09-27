namespace Autenticacion
{
    partial class BuscarBedel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarBedel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.turno = new System.Windows.Forms.ComboBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tablaBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(57, 17);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(122, 20);
            this.apellido.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(235, 17);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 20);
            this.nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // turno
            // 
            this.turno.FormattingEnabled = true;
            this.turno.Location = new System.Drawing.Point(404, 17);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(122, 21);
            this.turno.TabIndex = 5;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(538, 15);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // tablaBusqueda
            // 
            this.tablaBusqueda.ColumnCount = 4;
            this.tablaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaBusqueda.Location = new System.Drawing.Point(12, 43);
            this.tablaBusqueda.Name = "tablaBusqueda";
            this.tablaBusqueda.RowCount = 2;
            this.tablaBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBusqueda.Size = new System.Drawing.Size(601, 149);
            this.tablaBusqueda.TabIndex = 7;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(12, 198);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(93, 198);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 9;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(538, 226);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 10;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // BuscarBedel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 261);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.tablaBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 299);
            this.MinimumSize = new System.Drawing.Size(641, 299);
            this.Name = "BuscarBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Bedeles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox turno;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TableLayoutPanel tablaBusqueda;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bCerrar;
    }
}