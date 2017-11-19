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
        private Form padre;

        public InicioSesionBedel(Form papa)
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
            //Falta validar los campos

            this.Hide();

            MenuBedel bedel = new MenuBedel(this);
            bedel.Show();
        }

        private void InicioSesionBedel_Load(object sender, EventArgs e)
        {

        }
    }
}
