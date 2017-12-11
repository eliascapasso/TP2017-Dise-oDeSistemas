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

            foreach (DataGridViewRow filaDiaHInicioDuracion in reservaDTO.fechas)
            { //TODO: ver como concatenar al agregar aula DTO
                aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                      reservaDTO.idTipoAula,
                                      filaDiaHInicioDuracion,
                                      reservaDTO.tipoReserva,
                                      this.calcularPeriodo(filaDiaHInicioDuracion, reservaDTO.tipoReserva));

                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    disponibilidad.Add(aulaDisponible);
                }
            }

            
            return disponibilidad;
        }

        private HashSet<CuatrimestreDTO> calcularPeriodo(DataGridViewRow filaDiaHInicioDuracion, string tipoReserva)
        {
            HashSet<CuatrimestreDTO> periodo = new HashSet<CuatrimestreDTO>();

            //Obtenemos el periodo actual
            

            foreach (CuatrimestreDTO cuatrimestre in todosLosPeriodos)
            {
                switch (tipoReserva)
                {

                    case "Anual":
                        if (periodo.Count != 0)
                        {
                                
                            if (cuatrimestre.IdAnioLectivo==periodo.Last<CuatrimestreDTO>().IdAnioLectivo){

                                periodo.Add(cuatrimestre);
                            }
                        }
                        else
                        {
                            
                            periodo.Add(cuatrimestre);
                        } 
                        break;
                    case "Cuatrimestral":
                        if (DateTime.Now >= cuatrimestre.FechaInicio && DateTime.Now <= cuatrimestre.FechaFin)
                        {
                            periodo.Add(cuatrimestre);
                        }

                        break;
                    case "Esporádica":
                        DateTime dia = Convert.ToDateTime(filaDiaHInicioDuracion.Cells[0].Value.ToString());

                        if (dia >= cuatrimestre.FechaInicio && dia <= cuatrimestre.FechaFin) //solo se agrega un cuatrimestre
                        {
                            periodo.Add(cuatrimestre);
                        }
                        break;
                }
                
            }
            
            return periodo;
        }

    }
}
