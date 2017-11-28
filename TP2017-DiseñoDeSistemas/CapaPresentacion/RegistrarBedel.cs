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
        private Form padre;

        public RegistrarBedel(Form papa)
        {
            this.padre = papa;

            InitializeComponent();
        }

        GestorDeUsuario gestor = new GestorDeUsuario();

        private void btnAceptar_Click(object sender, EventArgs e)
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
                    MessageBox.Show(p.Message.ToString(), "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (NickException n)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show(n.Message.ToString(), "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void tbPass_Click(object sender, EventArgs e)
        {
            notificacion.Visible = true;
            notificacion.BalloonTipText = "Al menos:\n8 caractéres\nUn signo (@#$%&*)\nUna letra mayúscula\nUn dígito";

            notificacion.BalloonTipTitle = "Políticas de contraseña";
            notificacion.ShowBalloonTip(10000);
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar)
            {
                tbPass.UseSystemPasswordChar = false;
                tbConfirmarPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
                tbConfirmarPass.UseSystemPasswordChar = true;
            }
        }
    }
}
