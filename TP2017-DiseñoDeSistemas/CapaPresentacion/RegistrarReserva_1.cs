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
    public partial class RegistrarReserva_1 : Form
    {
        private Form padre;

        public RegistrarReserva_1(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide(); //Falta validar todos los campos

            RegistrarReserva_2 reserva = new RegistrarReserva_2(this);
            reserva.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
