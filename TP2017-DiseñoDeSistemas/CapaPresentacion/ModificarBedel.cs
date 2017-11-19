using CapaLogica;
using Excepciones;
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

        private Form padre;

        public ModificarBedel(string nick, Form papa)
        {
            this.padre = papa;
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
            //Validacion de la confirmacion de la contraseña
            if (tbPass.Text.Equals(tbConfPass.Text))
            {
                try
                {
                    //Se intenta modificar el bedel
                    GestorDeUsuario gestor = new GestorDeUsuario();
                    gestor.modificarBedel(this.nickBedelActual, tbNick.Text, tbApellido.Text, tbNombre.Text, cbTurno.SelectedItem.ToString(), tbPass.Text);

                    //Llegado a este punto el bedel se modifico con exito
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("Bedel modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Close();
                }
                catch (PoliticasContraseniaException p)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show("No se cumplen las políticas de contraseña", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (NickException n)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show("El Nick ingresado ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
