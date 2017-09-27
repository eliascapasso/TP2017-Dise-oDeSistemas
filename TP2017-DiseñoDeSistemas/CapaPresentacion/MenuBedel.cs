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
        public MenuBedel()
        {
            InitializeComponent();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarReserva_1 reserva = new RegistrarReserva_1();
            reserva.Show();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Autenticacion autenticacion = new Autenticacion();
            autenticacion.Show();
        }

        private void bBuscarAula_Click(object sender, EventArgs e)
        {
            BuscarAula buscar = new BuscarAula();
            buscar.Show();
        }
    }
}
