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
    public partial class ModificarBedel : Form
    {
        private string nickBedelActual;
        public ModificarBedel(string nick)
        {
            InitializeComponent();
            this.nickBedelActual = nick;

            tbNombre.Text = "";
            tbApellido.Text = "";
            tbPass.Text = "";
            tbNick.Text = "";
            cbTurno.Text = "Mañana";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Equals(tbConfPass.Text))
            {
                GestorDeUsuario gestor = new GestorDeUsuario();
                gestor.modificarBedel(this.nickBedelActual, tbNick.Text, tbApellido.Text, tbNombre.Text, cbTurno.SelectedItem.ToString(), tbPass.Text);
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
