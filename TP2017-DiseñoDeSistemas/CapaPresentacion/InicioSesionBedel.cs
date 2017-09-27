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
        public InicioSesionBedel()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Autenticacion autenticacion = new Autenticacion();
            autenticacion.Show();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            //Falta validar los campos

            this.Hide();

            MenuBedel bedel = new MenuBedel();
            bedel.Show();
        }
    }
}
