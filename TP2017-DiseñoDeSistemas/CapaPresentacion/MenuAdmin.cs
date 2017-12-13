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
    public partial class MenuAdmin : Form
    {
        private Form padre;
        public MenuAdmin(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
        }
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            RegistrarBedel registro = new RegistrarBedel(this);
            registro.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarBedel busqueda = new BuscarBedel(this);
            this.Hide();
            busqueda.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autenticacion inicio = new Autenticacion();
            inicio.Show();
        }
    }
}
