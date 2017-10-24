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
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
