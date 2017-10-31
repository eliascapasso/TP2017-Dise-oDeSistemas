using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using Excepciones;

namespace Autenticacion
{
    public partial class RegistrarBedel : Form
    {
        public RegistrarBedel()
        {
            InitializeComponent();
        }

        GestorDeUsuario gestor = new GestorDeUsuario();

        private void bAceptar_Click(object sender, EventArgs e)
        {

            if (tbPass.Text != tbConfirmarPass.Text) //Validacion de la confirmacion de la contraseña
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    gestor.registrarBedel(tbNick.Text, tbPass.Text, tbNombre.Text, tbApellido.Text, cbTurno.SelectedItem.ToString());
                }
                catch (PoliticasContraseniaException p)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("No se cumplen las políticas de contraseña", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (NickException n)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("El Nick ingresado ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegistrarBedel_Load(object sender, EventArgs e)
        {
            //gestor.cargarTurnos();
        }

    }
}
