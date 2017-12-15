using CapaClases;
using CapaDatos;
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
        private BedelDTO bedelSeleccionado;

        private Form padre;

        public ModificarBedel(BedelDTO bedelSeleccionado, Form papa)
        {
            this.padre = papa;
            InitializeComponent();
            this.bedelSeleccionado = bedelSeleccionado;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            //Validacion de la confirmacion de la contraseña
            if (tbPass.Text.Equals(tbConfPass.Text))
            {
                try
                {
                    labelPoliticas.Visible = false;
                    //Se intenta modificar el bedel
                    GestorDeUsuario gestor = new GestorDeUsuario();
                    gestor.modificarBedel(this.bedelSeleccionado, tbApellido.Text, tbNombre.Text, cbTurno.SelectedItem.ToString(), tbPass.Text);

                    //Llegado a este punto el bedel se modifico con exito
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("Bedel modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Close();
                    padre.Show();
                    
                }
                catch (PoliticasContraseniaException p)
                {
                    Console.Write(p.Message);

                    //Muestra la pass y su confimacion
                    tbPass.UseSystemPasswordChar = false;
                    tbConfPass.UseSystemPasswordChar = false;
                    tbConfPass.Text = "";

                    //Muestra el la politica que falta cumplir
                    labelPoliticas.Visible = true;
                    bool caracterEspecial = tbPass.Text.Any(x => x.Equals('@') || x.Equals('#') || x.Equals('$') || x.Equals('%') || x.Equals('&') || x.Equals('*'));
                    bool tieneMayusculas = tbPass.Text.Any(c => char.IsUpper(c));
                    bool tieneDigitos = tbPass.Text.Any(c => char.IsDigit(c));

                    if (tbPass.Text.Count() < 8)
                    {
                        labelPoliticas.Text = "La longitud debe ser mínimo de 8 caracteres";
                    }
                    else if (!caracterEspecial)
                    {
                        labelPoliticas.Text = "Debe haber almenos un caracter especial (@ # $ % & *)";
                    }
                    else if (!tieneMayusculas)
                    {
                        labelPoliticas.Text = "No hay almenos una letra mayúscula";
                    }
                    else if (!tieneDigitos)
                    {
                        labelPoliticas.Text = "Debe haber almenos un dígito";
                    }
                }
                catch (NickException n)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show(n.Message.ToString(), "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            this.padre.Show();
        }

        private void ModificarBedel_Load(object sender, EventArgs e)
        {
            tbNombre.Text = bedelSeleccionado.nombre;
            tbApellido.Text = bedelSeleccionado.apellido;
            tbPass.Text = bedelSeleccionado.contrasenia;
            tbConfPass.Text = bedelSeleccionado.contrasenia;
            tbNick.Text = bedelSeleccionado.nick;
            cbTurno.Text = bedelSeleccionado.turno;
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
                tbConfPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
                tbConfPass.UseSystemPasswordChar = true;
            }
        }
    }
}
