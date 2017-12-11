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

namespace CapaPresentacion
{
    public partial class ObtenerDisponibilidadAula : Form
    {
        private Form padre;
        private GestorDeAula gestorAula;
        private AulaDTO aulaDTO;
        private HashSet<CuatrimestreDTO> todosLosPeriodos;

        public ObtenerDisponibilidadAula(Form papa, HashSet<CuatrimestreDTO> todosLosPeriodos)
        {
            this.todosLosPeriodos = todosLosPeriodos;
            this.padre = papa;
            this.gestorAula = new GestorDeAula();
            InitializeComponent();
        }
        
        public HashSet<AulaDTO> obtenerDisponibilidad(ReservaDTO reservaDTO)
        {
            HashSet<AulaDTO> disponibilidad = new HashSet<AulaDTO>();

            foreach (DataGridViewRow fecha in reservaDTO.fechas)
            {
                aulaDTO = new AulaDTO(reservaDTO.cantAlumnos, reservaDTO.idTipoAula, fecha, reservaDTO.tipoReserva, this.calcularPeriodo(fecha, reservaDTO.tipoReserva));

                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    disponibilidad.Add(aulaDisponible);
                }
            }
            return disponibilidad;
        }

        private HashSet<CuatrimestreDTO> calcularPeriodo(DataGridViewRow fecha, string tipoReserva)
        {
            HashSet<CuatrimestreDTO> periodo = new HashSet<CuatrimestreDTO>();

            foreach (CuatrimestreDTO cuatrimestre in todosLosPeriodos)
            {
                if (tipoReserva.Equals("Anual"))
                {
                    if (DateTime.Now >= cuatrimestre.FechaInicio) //se agregan 1 o 2 cuatrimestres
                    {
                        periodo.Add(cuatrimestre);
                    }
                }
                else if (tipoReserva.Equals("Cuatrimestral"))
                {
                    if (DateTime.Now >= cuatrimestre.FechaInicio && DateTime.Now <= cuatrimestre.FechaFin) //solo se agrega un cuatrimestre
                    {
                        periodo.Add(cuatrimestre);
                    }
                }
                else //Esporadica
                {
                    DateTime dia = Convert.ToDateTime(fecha.Cells[0].Value.ToString());

                    if (dia >= cuatrimestre.FechaInicio && dia <= cuatrimestre.FechaFin) //solo se agrega un cuatrimestre
                    {
                        periodo.Add(cuatrimestre);
                    }
                }
            }
            return periodo;
        }
    }
}
