using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class BarraProgresiva : Form
    {
        public BarraProgresiva()
        {
            InitializeComponent();
        }

        private void BarraProgresiva_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(30);

            if(progressBar1.Value.Equals(100))
            {
                timer1.Stop();
                this.Visible = false;
            }
        }
    }
}
