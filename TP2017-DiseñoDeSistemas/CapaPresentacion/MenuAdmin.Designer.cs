namespace Autenticacion
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.Bregistrar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bregistrar
            // 
            this.Bregistrar.Location = new System.Drawing.Point(12, 27);
            this.Bregistrar.Name = "Bregistrar";
            this.Bregistrar.Size = new System.Drawing.Size(118, 40);
            this.Bregistrar.TabIndex = 0;
            this.Bregistrar.Text = "Registrar Bedel";
            this.Bregistrar.UseVisualStyleBackColor = true;
            this.Bregistrar.Click += new System.EventHandler(this.Bregistrar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(12, 82);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(118, 40);
            this.bBuscar.TabIndex = 1;
            this.bBuscar.Text = "Buscar Bedel";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.user_male_icon_343321;
            this.pictureBox1.Location = new System.Drawing.Point(145, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(12, 147);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 3;
            this.bAtras.Text = "<- Atras";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.Bregistrar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 220);
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bregistrar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bAtras;
    }
}