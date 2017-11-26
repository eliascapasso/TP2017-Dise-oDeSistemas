using CapaPresentacion;
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
    public partial class MenuBedel : Form
    {
        private Form padre;
        public string nickBedel;

        public MenuBedel(Form papa, string nickBedel)
        {
            this.padre = papa;
            this.nickBedel = nickBedel;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarReserva_1 reserva = new RegistrarReserva_1(this, nickBedel);
            reserva.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Autenticacion autenticacion = new Autenticacion();
            autenticacion.Show();
        }

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            BuscarAula buscar = new BuscarAula(this);
            buscar.Show();
        }
    }
}
