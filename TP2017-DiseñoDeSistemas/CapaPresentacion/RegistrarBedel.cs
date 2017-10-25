﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

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
                MessageBox.Show("La confirmación de contraseña no es valida", "ADVERTENCIA", MessageBoxButtons.OK);
            }

            GestorDeUsuario gestor = new GestorDeUsuario();
            //VER COMO USAR EL TURNO
            gestor.registrarBedel(nick.ToString(), pass.ToString(), nombre.ToString(), apellido.ToString(), turno.ToString());

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegistrarBedel_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarBedel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
