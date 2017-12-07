using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaClases;
using System.Collections;

namespace CapaPresentacion
{
    public partial class ObtenerDisponibilidadAula : Form
    {
        private Form padre;
        private GestorDeAula gestorAula;
        private AulaDTO aulaDTO;
        private ArrayList anios;
        private ArrayList cuatrimestres;

        public ObtenerDisponibilidadAula(Form papa, ArrayList anios, ArrayList cuatrimestres)
        {
            this.anios = anios;
            this.cuatrimestres = cuatrimestres;
            this.padre = papa;
            gestorAula = new GestorDeAula();
            InitializeComponent();
        }

        private void ObtenerDisponibilidadAula_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }



        public HashSet<DataGridViewRow> obtenerDisponibilidad(ReservaDTO reservaDTO)
        {
            HashSet<DataGridViewRow> disponibilidad = new HashSet<DataGridViewRow>();

            foreach (DataGridViewRow fecha in reservaDTO.fechas)
            {
                
                aulaDTO = new AulaDTO(reservaDTO.cantAlumnos, reservaDTO.idTipoAula, fecha, reservaDTO.tipoReserva, obtenerIdPeriodo(fecha, reservaDTO.tipoReserva));
                disponibilidad.Add(gestorAula.obtenerDisponibilidad(aulaDTO));
            }
            return disponibilidad;
        }

        private int obtenerIdPeriodo(DataGridViewRow fecha, string tipoReserva)
        {
            if (tipoReserva == "Anual")
            {
                ArrayList idPeriodos = new ArrayList() ;
                foreach (AnioLectivoDTO anio in this.anios)
                {
                    if (fecha.Cells[0].Value.ToString().Equals(anio.fecha_inicio.Value.ToShortDateString()))
                    {
                        idPeriodos.Add(anio.cuatrimestres[0]);
                        //idPeriodos.add
                    }
                }
            }
            return 0;
        }
        
    }
}
