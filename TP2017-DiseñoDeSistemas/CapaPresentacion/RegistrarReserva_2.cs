using Autenticacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistrarReserva_2 : Form
    {
        public RegistrarReserva_2()
        {
            InitializeComponent();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistrarReserva_1 reserva = new RegistrarReserva_1();
            reserva.Show();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            //Falta validar la disponibilidad de las aulas

            DisponibilidadAulas dispAulas = new DisponibilidadAulas();
            dispAulas.Show();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
