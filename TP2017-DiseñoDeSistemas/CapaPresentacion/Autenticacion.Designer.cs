namespace Autenticacion
{
    partial class Autenticacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacion));
            this.label1 = new System.Windows.Forms.Label();
            this.bAdmin = new System.Windows.Forms.Button();
            this.bBedel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un perfil:";
            // 
            // bAdmin
            // 
            this.bAdmin.Location = new System.Drawing.Point(165, 23);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(109, 41);
            this.bAdmin.TabIndex = 1;
            this.bAdmin.Text = "Administrador";
            this.bAdmin.UseVisualStyleBackColor = true;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // bBedel
            // 
            this.bBedel.Location = new System.Drawing.Point(165, 80);
            this.bBedel.Name = "bBedel";
            this.bBedel.Size = new System.Drawing.Size(109, 41);
            this.bBedel.TabIndex = 2;
            this.bBedel.Text = "Bedel";
            this.bBedel.UseVisualStyleBackColor = true;
            this.bBedel.Click += new System.EventHandler(this.bBedel_Click);
            // 
            // Autenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.loginmanager_100291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(286, 136);
            this.Controls.Add(this.bBedel);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 174);
            this.MinimumSize = new System.Drawing.Size(302, 174);
            this.Name = "Autenticacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Button bBedel;
    }
}

