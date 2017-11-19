using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Autenticacion
{
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        { 
            this.Hide();

            InicioSesionAdmin admin = new InicioSesionAdmin(this);
            admin.Show();
        }

        private void btnBedel_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioSesionBedel bedel = new InicioSesionBedel(this);
            bedel.Show();
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}

/*EJEMPLO DE CARGA DE DATOS A LA BD
           var db = new TP2017();
           using (db)
           {
               //Aca va el agregar en la db, en los corchetes van todos los datos excepto el id
               db.NombreDia.Add(new NombreDia() { descripcion="Lunes"});
               db.SaveChanges();
           }*/
