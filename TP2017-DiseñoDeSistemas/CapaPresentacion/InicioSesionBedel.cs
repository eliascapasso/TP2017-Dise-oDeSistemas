using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autenticacion
{
    public partial class InicioSesionBedel : Form
    {
        private Form padre;
        private GestorDeUsuario gestorUsuario;

        public InicioSesionBedel(Form papa)
        {
            this.padre = papa;
            this.gestorUsuario = new GestorDeUsuario();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            padre.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!gestorUsuario.existeBedel(tbNick.Text, tbPass.Text))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Los datos ingresados no son válidos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();

                MenuBedel bedel = new MenuBedel(this, tbNick.Text);
                bedel.Show();
            }
        }

        private void InicioSesionBedel_Load(object sender, EventArgs e)
        {
            tbNick.Text = "";
            tbPass.Text = "";
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }
    }
}
