﻿using System;
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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Bregistrar_Click(object sender, EventArgs e)
        {
            RegistrarBedel registro = new RegistrarBedel();
            registro.Show();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            BuscarBedel busqueda = new BuscarBedel();
            busqueda.Show();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Autenticacion inicio = new Autenticacion();
            inicio.Show();
        }
    }
}
