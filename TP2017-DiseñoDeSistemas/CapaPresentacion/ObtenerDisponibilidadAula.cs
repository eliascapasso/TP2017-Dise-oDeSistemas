using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaClases;

namespace CapaPresentacion
{
    public partial class ObtenerDisponibilidadAula : Form
    {
        private Form padre;
        private GestorDeAula gestorAula;
        private AulaDTO aulaDTO;
        public ObtenerDisponibilidadAula(Form papa)
        {
            this.padre = papa;
            gestorAula = new GestorDeAula();
            InitializeComponent();
        }

        private void ObtenerDisponibilidadAula_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }



        public void obtenerDisponibilidad(ReservaDTO reservaDTO)
        {
            //gestorAula.obtenerDisponibilidad(reservaDTO);
        }
    }
}
