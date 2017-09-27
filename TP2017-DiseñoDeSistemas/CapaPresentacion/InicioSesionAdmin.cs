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
        public InicioSesionAdmin()
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
            this.Hide(); //Falta hacer todas las validaciones para poder iniciar sesion

            MenuAdmin panAdmin = new MenuAdmin();
            panAdmin.Show();
        }
    }
}
