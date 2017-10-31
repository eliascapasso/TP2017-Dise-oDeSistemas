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

            if (tbPass.Text != tbConfirmarPass.Text)
            {
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK);
            }
            else
            {
               
                    //VER COMO USAR EL TURNO
                    gestor.registrarBedel(tbNick.Text, tbPass.Text, tbNombre.Text, tbApellido.Text, cbTurno.SelectedItem.ToString());
                
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
