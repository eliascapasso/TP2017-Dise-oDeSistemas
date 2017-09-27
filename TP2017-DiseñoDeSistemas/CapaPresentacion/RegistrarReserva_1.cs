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
        public RegistrarReserva_1()
        {
            InitializeComponent();
        }

        private void bSig_Click(object sender, EventArgs e)
        {
            this.Hide(); //Falta validar todos los campos

            RegistrarReserva_2 reserva = new RegistrarReserva_2();
            reserva.Show();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
