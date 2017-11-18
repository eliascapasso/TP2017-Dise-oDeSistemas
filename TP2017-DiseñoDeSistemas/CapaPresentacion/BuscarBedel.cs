using CapaDatos;
using CapaLogica;
using Excepciones;
using System;
using System.Collections;
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
        private string nickSeleccionado;
        private GestorDeUsuario gestor;

        public BuscarBedel()
        {
            InitializeComponent();

            this.gestor = new GestorDeUsuario();
            cbTurno.Text = "";
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                ModificarBedel modBedel = new ModificarBedel(this.nickSeleccionado);
                modBedel.Show();
            }
            catch(NullReferenceException l)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Seleccione un bedel para modificar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            DialogResult resultadoElim = MessageBox.Show("¿Seguro que desea eliminar el Bedel? \nNick: "+this.nickSeleccionado, "ADVERTENCIA", MessageBoxButtons.YesNo);

            if (resultadoElim == DialogResult.Yes)
            {
                gestor.eliminarBedel(this.nickSeleccionado);

                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Se ha eliminado el Bedel seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void vistaBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = vistaBusqueda.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            this.nickSeleccionado = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la primer columna
         }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArrayList bedeles = gestor.buscarBedel(tbApellido.Text, cbTurno.SelectedItem.ToString());

            vistaBusqueda.Rows.Clear();
            
            if (bedeles.Count != 0)
            {
                int i = 0;
                foreach (Bedel bedel in bedeles)
                {
                    vistaBusqueda.Rows.Insert(i, bedel.id_usuario, bedel.nick, bedel.apellido, bedel.nombre, bedel.turno);

                    i++;
                }
            }
            //No existen bedeles que cumplan con los criterios ingresados
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No existen bedeles que cumplan con los criterios ingresados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
