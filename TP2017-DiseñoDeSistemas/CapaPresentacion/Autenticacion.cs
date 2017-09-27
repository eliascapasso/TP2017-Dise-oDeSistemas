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
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioSesionAdmin admin = new InicioSesionAdmin();
            admin.Show();
        }

        private void bBedel_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioSesionBedel bedel = new InicioSesionBedel();
            bedel.Show();
        }
    }
}
