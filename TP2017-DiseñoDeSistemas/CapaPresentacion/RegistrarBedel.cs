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
using CapaPresentacion;

namespace Autenticacion
{
    public partial class RegistrarBedel : Form
    {
        public RegistrarBedel()
        {
            InitializeComponent();

            cbTurno.Text = "Mañana";
        }

        GestorDeUsuario gestor = new GestorDeUsuario();

        private void bAceptar_Click(object sender, EventArgs e)
        {
            //Validacion de la confirmacion de la contraseña
            if (tbPass.Text != tbConfirmarPass.Text) 
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Valida que todos los campos obligatorios esten completados
            else if (this.existeUnCampoVacio()) 
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Debe completar todos los campos marcados con *", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try 
                {
                    //Se intenta registrar el bedel
                    gestor.registrarBedel(tbNick.Text, tbPass.Text, tbNombre.Text, tbApellido.Text, cbTurno.SelectedItem.ToString());

                    //Llegado a este punto el bedel se registro con exito en la bd
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("Bedel registrado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegistrarBedel_Load(object sender, EventArgs e)
        {
            //No implementado
        }

        private bool existeUnCampoVacio()
        {
            return tbNombre.Text.Equals("") || 
                tbApellido.Text.Equals("") || 
                cbTurno.SelectedItem.ToString().Equals("") || 
                tbNick.Text.Equals("") || 
                tbPass.Text.Equals("");

        }
    }
}
