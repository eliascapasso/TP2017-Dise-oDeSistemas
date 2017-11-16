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
            string nickBedel = vistaBusqueda.SelectedRows[0].ToString();

            ModificarBedel modBedel = new ModificarBedel(nickBedel);
            modBedel.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbApellido.Equals("") && cbTurno.SelectedItem.ToString().Equals(""))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No ingresó ningun criterio de busqueda", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UsuarioDAODB  usuDao= new UsuarioDAODB();

                ArrayList bedeles = usuDao.obtenerBedeles(tbApellido.Text, cbTurno.SelectedItem.ToString());
            }
        }

        private void BuscarBedel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tP2017DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.tP2017DataSet.Usuario);

        }
    }
}
