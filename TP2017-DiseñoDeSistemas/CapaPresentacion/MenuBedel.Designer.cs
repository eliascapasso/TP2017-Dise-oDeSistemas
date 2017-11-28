namespace Autenticacion
{
    partial class MenuBedel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBedel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.btnBuscarAula = new System.Windows.Forms.Button();
            this.btnListaResDia = new System.Windows.Forms.Button();
            this.btnListaResCurso = new System.Windows.Forms.Button();
            this.tsBotones = new System.Windows.Forms.ToolStrip();
            this.tsCerrarSesion = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.university_cap_icon_icons1;
            this.pictureBox1.Location = new System.Drawing.Point(100, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Location = new System.Drawing.Point(12, 28);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(133, 60);
            this.btnRegistrarReserva.TabIndex = 1;
            this.btnRegistrarReserva.Text = "Registrar Reserva";
            this.btnRegistrarReserva.UseVisualStyleBackColor = true;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscarAula
            // 
            this.btnBuscarAula.Location = new System.Drawing.Point(204, 28);
            this.btnBuscarAula.Name = "btnBuscarAula";
            this.btnBuscarAula.Size = new System.Drawing.Size(133, 60);
            this.btnBuscarAula.TabIndex = 2;
            this.btnBuscarAula.Text = "Buscar Aula";
            this.btnBuscarAula.UseVisualStyleBackColor = true;
            this.btnBuscarAula.Click += new System.EventHandler(this.btnBuscarAula_Click);
            // 
            // btnListaResDia
            // 
            this.btnListaResDia.Location = new System.Drawing.Point(12, 109);
            this.btnListaResDia.Name = "btnListaResDia";
            this.btnListaResDia.Size = new System.Drawing.Size(133, 60);
            this.btnListaResDia.TabIndex = 3;
            this.btnListaResDia.Text = "Listar reservas del dia";
            this.btnListaResDia.UseVisualStyleBackColor = true;
            // 
            // btnListaResCurso
            // 
            this.btnListaResCurso.Location = new System.Drawing.Point(204, 109);
            this.btnListaResCurso.Name = "btnListaResCurso";
            this.btnListaResCurso.Size = new System.Drawing.Size(133, 60);
            this.btnListaResCurso.TabIndex = 4;
            this.btnListaResCurso.Text = "Listar reservas de curso";
            this.btnListaResCurso.UseVisualStyleBackColor = true;
            // 
            // tsBotones
            // 
            this.tsBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCerrarSesion});
            this.tsBotones.Location = new System.Drawing.Point(0, 0);
            this.tsBotones.Name = "tsBotones";
            this.tsBotones.Size = new System.Drawing.Size(354, 25);
            this.tsBotones.TabIndex = 6;
            this.tsBotones.Text = "toolStrip1";
            // 
            // tsCerrarSesion
            // 
            this.tsCerrarSesion.CheckOnClick = true;
            this.tsCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsCerrarSesion.Image")));
            this.tsCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCerrarSesion.Name = "tsCerrarSesion";
            this.tsCerrarSesion.Size = new System.Drawing.Size(80, 22);
            this.tsCerrarSesion.Text = "Cerrar Sesión";
            this.tsCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsCerrarSesion.Click += new System.EventHandler(this.tsCerrarSesion_Click);
            // 
            // MenuBedel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 184);
            this.Controls.Add(this.tsBotones);
            this.Controls.Add(this.btnListaResCurso);
            this.Controls.Add(this.btnListaResDia);
            this.Controls.Add(this.btnBuscarAula);
            this.Controls.Add(this.btnRegistrarReserva);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsBotones.ResumeLayout(false);
            this.tsBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.Button btnBuscarAula;
        private System.Windows.Forms.Button btnListaResDia;
        private System.Windows.Forms.Button btnListaResCurso;
        private System.Windows.Forms.ToolStrip tsBotones;
        private System.Windows.Forms.ToolStripButton tsCerrarSesion;
    }
}