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
    public partial class RegistrarBedel : Form
    {
        public RegistrarBedel()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            if (!pass.ToString().Equals(confPass.ToString())){
                //holaasdasd
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK);
            }
            //Se validan los campos y se guarda el bedel en la b

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegistrarBedel_Load(object sender, EventArgs e)
        {

        }
    }
}
