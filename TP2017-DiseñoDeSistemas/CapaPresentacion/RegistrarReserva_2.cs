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
        private Form padre;
        public RegistrarReserva_2(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistrarReserva_1 reserva = new RegistrarReserva_1(this);
            reserva.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Falta validar la disponibilidad de las aulas

            DisponibilidadAulas dispAulas = new DisponibilidadAulas(this);
            dispAulas.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
