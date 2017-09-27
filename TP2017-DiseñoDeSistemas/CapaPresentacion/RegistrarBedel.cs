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
            //Se validan los campos y se guarda el bedel en la bd
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
