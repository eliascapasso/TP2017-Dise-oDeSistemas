﻿using System;
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
    public partial class DisponibilidadAulas : Form
    {
        private Form padre;
        public DisponibilidadAulas(Form papa)
        {
            this.padre = papa;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
