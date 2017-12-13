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

            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservas)
            { 
                AulaDTO aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                              reservaDTO.idTipoAula,
                                              detalleReserva,
                                              reservaDTO.tipoReserva,
                                              this.calcularPeriodo(detalleReserva, reservaDTO.tipoReserva));

                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    disponibilidad.Add(aulaDisponible);
                }
            }
            
            return disponibilidad;
        }

        private HashSet<CuatrimestreDTO> calcularPeriodo(DetalleReservaDTO detalleReserva, string tipoReserva)
        {
            HashSet<CuatrimestreDTO> periodo = new HashSet<CuatrimestreDTO>();
            
            //Obtenemos el periodo actual
            foreach (CuatrimestreDTO cuatrimestre in todosLosPeriodos)
            {
                switch (tipoReserva)
                {
                    case "Anual":
                        //Puede agregar 1 o 2 cuatrimestres
                        if (periodo.Count != 0) 
                        {   
                            if (cuatrimestre.IdAnioLectivo==periodo.Last<CuatrimestreDTO>().IdAnioLectivo)
                            {
                                periodo.Add(cuatrimestre);
                            }
                        }
                        else //la lista de periodos está vacia
                        {
                            periodo.Add(cuatrimestre);
                        } 
                        break;
                    case "Cuatrimestral":
                        //Solo agrega un cuatrimestre
                        Console.Write(DateTime.Now.ToShortDateString() +" "+cuatrimestre.FechaInicio + "\n");
                        if (DateTime.Now >= cuatrimestre.FechaInicio && DateTime.Now <= cuatrimestre.FechaFin)
                        {
                            periodo.Add(cuatrimestre);
                        }
                        else if (todosLosPeriodos.Last().Equals(cuatrimestre)) //Agrega el cuatrimestre mas proximo
                        {
                            periodo.Add(todosLosPeriodos.First());
                        }
                        break;
                    case "Esporádica":
                        //Agrega un solo cuatrimestre
                        DateTime dia = Convert.ToDateTime(detalleReserva.diaReserva);

                        if (dia >= cuatrimestre.FechaInicio && dia <= cuatrimestre.FechaFin) //solo se agrega un cuatrimestre
                        {
                            periodo.Add(cuatrimestre);
                        }
                        return periodo;
                }
            }
            return periodo;
        }
    }
}
