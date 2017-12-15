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
    public partial class InicioSesionAdmin : Form
    {
        private Form padre;
        private GestorDeUsuario gestorUsuario = new GestorDeUsuario();

        public InicioSesionAdmin(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            padre.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!gestorUsuario.existeUsuario(tbNick.Text, tbPass.Text) || !tbNick.Text.Equals("admin"))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Los datos ingresados no son válidos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();

                MenuAdmin admin = new MenuAdmin(this);
                admin.Show();
            }
        }

        private void InicioSesionAdmin_Load(object sender, EventArgs e)
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
