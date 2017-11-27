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
using CapaClases;
using System.Collections;

namespace CapaPresentacion
{
    public partial class RegistrarReserva_2 : Form
    {
        private Form padre;
        private ReservaDTO reservaDTO;
        private ArrayList disponibilidad;
        public RegistrarReserva_2(Form papa,ReservaDTO reservaDTO, ArrayList disponibilidad)
        {
            this.disponibilidad = disponibilidad;
            this.reservaDTO = reservaDTO;
            InitializeComponent();
        }
        public RegistrarReserva_2(Form papa)
        {
            padre = papa;
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            padre.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
