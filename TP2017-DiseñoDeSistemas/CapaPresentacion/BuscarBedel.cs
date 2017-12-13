using CapaClases;
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
        private BedelDTO bedelSeleccionado;
        private ArrayList bedelesBuscados;
        private GestorDeUsuario gestor = new GestorDeUsuario();
        private Form padre;

        public BuscarBedel(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
            this.bedelesBuscados = new ArrayList();
            this.bedelSeleccionado = new BedelDTO();
            cbTurno.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.bedelSeleccionado.vacio)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No seleccionó ningun bedel", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.Hide();
                    dgvResultadosBusqueda.Rows.Clear();
                    ModificarBedel modBedel = new ModificarBedel(this.bedelSeleccionado, this);
                    modBedel.Show();

                }
                catch (NullReferenceException l)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show("Seleccione un bedel para modificar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Console.Write(l.Message.ToString());
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            MessageBox.Show("CU No solicitado");
            //DialogResult resultadoElim = MessageBox.Show("¿Seguro que desea eliminar el Bedel? \nApellido: " + this.bedelSeleccionado.apellido+ "\nNombre: " +this.bedelSeleccionado.nombre + "\nTurno: " + this.bedelSeleccionado.turno, "ADVERTENCIA", MessageBoxButtons.YesNo);

            //if (resultadoElim == DialogResult.Yes)
            //{
            //    gestor.eliminarBedel(this.bedelSeleccionado.nick);

            //    System.Media.SystemSounds.Asterisk.Play();
            //    MessageBox.Show("Se ha eliminado el Bedel seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    dgvResultadosBusqueda.Rows.Clear();
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.bedelesBuscados = gestor.buscarBedel(tbApellido.Text, cbTurno.SelectedItem.ToString());

            dgvResultadosBusqueda.Rows.Clear();
            
            if (this.bedelesBuscados.Count != 0)
            {
                int i = 0;
                foreach (BedelDTO bedel in this.bedelesBuscados)
                {
                    if (!bedel.nick.Equals("admin"))
                    {
                        dgvResultadosBusqueda.Rows.Insert(i, bedel.nick, bedel.apellido, bedel.nombre, bedel.turno);

                        i++;
                    }
                }
            }
            //No existen bedeles que cumplan con los criterios ingresados
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No existen bedeles que cumplan con los criterios ingresados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvResultadosBusqueda_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow fila = dgvResultadosBusqueda.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            string nickSeleccionado = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna

            foreach (BedelDTO bedel in this.bedelesBuscados)
            {
                if (bedel.nick.Equals(nickSeleccionado))
                {
                    this.bedelSeleccionado = bedel;
                }
            }
        }
    }
}
