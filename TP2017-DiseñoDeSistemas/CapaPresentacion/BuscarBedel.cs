using CapaDatos;
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

        public BuscarBedel()
        {
            InitializeComponent();
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
            //Falta la seleccion del bedel
            /*System.Media.SystemSounds.Asterisk.Play();
            DialogResult resultadoElim = MessageBox.Show("¿Seguro que desea eliminar el Bedel? \nNombre: \nApellido: \nTurno: ", "ADVERTENCIA", MessageBoxButtons.YesNo);

            if (resultadoElim == DialogResult.Yes)
            {
                //Falta poner la info del bedel
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Se ha eliminado el Bedel seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }*/
        }

        private void btnBuscar_Click()
        {
            if(tbApellido.Equals("") && cbTurno.SelectedItem.ToString().Equals(""))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No ingresó ningun criterio de busqueda", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //No implementado
            }
        }

        private void BuscarBedel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tP2017DataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter1.Fill(this.tP2017DataSet1.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'tP2017DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.tP2017DataSet.Usuario);
        }

        private void vistaBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = vistaBusqueda.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            this.nickSeleccionado = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la primer columna
         }
    }
}
