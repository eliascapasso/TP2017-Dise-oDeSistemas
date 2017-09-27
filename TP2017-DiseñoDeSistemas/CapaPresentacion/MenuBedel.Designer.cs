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
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bBuscarAula = new System.Windows.Forms.Button();
            this.bListaResDia = new System.Windows.Forms.Button();
            this.bListaResCurso = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(12, 12);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(133, 60);
            this.bRegistrar.TabIndex = 1;
            this.bRegistrar.Text = "Registrar Reserva";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bBuscarAula
            // 
            this.bBuscarAula.Location = new System.Drawing.Point(204, 12);
            this.bBuscarAula.Name = "bBuscarAula";
            this.bBuscarAula.Size = new System.Drawing.Size(133, 60);
            this.bBuscarAula.TabIndex = 2;
            this.bBuscarAula.Text = "Buscar Aula";
            this.bBuscarAula.UseVisualStyleBackColor = true;
            this.bBuscarAula.Click += new System.EventHandler(this.bBuscarAula_Click);
            // 
            // bListaResDia
            // 
            this.bListaResDia.Location = new System.Drawing.Point(12, 109);
            this.bListaResDia.Name = "bListaResDia";
            this.bListaResDia.Size = new System.Drawing.Size(133, 60);
            this.bListaResDia.TabIndex = 3;
            this.bListaResDia.Text = "Listar reservas del dia";
            this.bListaResDia.UseVisualStyleBackColor = true;
            // 
            // bListaResCurso
            // 
            this.bListaResCurso.Location = new System.Drawing.Point(204, 109);
            this.bListaResCurso.Name = "bListaResCurso";
            this.bListaResCurso.Size = new System.Drawing.Size(133, 60);
            this.bListaResCurso.TabIndex = 4;
            this.bListaResCurso.Text = "Listar reservas de curso";
            this.bListaResCurso.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(12, 182);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 5;
            this.bAtras.Text = "<- Atras";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // MenuBedel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 217);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bListaResCurso);
            this.Controls.Add(this.bListaResDia);
            this.Controls.Add(this.bBuscarAula);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuBedel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bBuscarAula;
        private System.Windows.Forms.Button bListaResDia;
        private System.Windows.Forms.Button bListaResCurso;
        private System.Windows.Forms.Button bAtras;
    }
}