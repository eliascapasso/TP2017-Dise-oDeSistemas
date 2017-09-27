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
    public partial class BuscarBedel : Form
    {
        public BuscarBedel()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            //Falta la seleccion del bedel

            ModificarBedel modBedel = new ModificarBedel();
            modBedel.Show();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            //Falta la seleccion del bedel

            DialogResult resultadoElim = MessageBox.Show("¿Seguro que desea eliminar el Bedel? \nNombre: \nApellido: \nTurno: ", "ADVERTENCIA", MessageBoxButtons.YesNo);

            if (resultadoElim == DialogResult.Yes)
            {
                //Falta poner la info del bedel
                MessageBox.Show("Se ha eliminado el Bedel seleccionado");
            }
        }
    }
}
