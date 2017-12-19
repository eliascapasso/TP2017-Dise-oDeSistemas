using CapaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;
using System.Windows.Forms;
using System.Globalization;

namespace CapaLogica
{
    public class GestorDeAula
    {
        private AulaDAODB aulaDAO;
        private ReservaDAODB reservaDAO;
        private List<CuatrimestreDTO> todosLosPeriodos;

        public GestorDeAula()
        {
            this.aulaDAO = new AulaDAODB();
            this.reservaDAO = new ReservaDAODB();
            this.todosLosPeriodos = new AnioLectivoDAODB().obtenerTodosLosPeriodos();
        }

        public ArrayList obtenerTiposAula()
        {
            return aulaDAO.obtenerTiposAula();
        }

        public HashSet<AulaDTO> obtenerDisponibilidad(AulaDTO aulaDTO)
        {
            HashSet<DateTime> fechasReserva = new HashSet<DateTime>(); //Fechas a ser convertidas a una lista de fechas

            if (aulaDTO.tipoReserva.Equals("Anual") || aulaDTO.tipoReserva.Equals("Cuatrimestral"))
            {
                fechasReserva = this.convertToFechas(aulaDTO.detalleReserva.diaOFecha, aulaDTO.periodo);
            }
            else //Esporadica
            {
                fechasReserva.Add(Convert.ToDateTime(aulaDTO.detalleReserva.diaOFecha));
            }

            HashSet<Aula> aulasCumplen = aulaDAO.obtenerAulas(aulaDTO.capacidad, aulaDTO.idTipoAula);
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();
            HashSet<AulaDTO> aulasLibres = new HashSet<AulaDTO>();

            //Obtiene las aulas ocupadas
            foreach (DateTime fechaReserva in fechasReserva)
            {
                aulasOcupadas= reservaDAO.obtenerAulasOcupadas(fechaReserva,
                                                               aulaDTO.detalleReserva.horaInicio,                               
                                                               aulaDTO.detalleReserva.duracion) ;

                //Obtiene las aulas libres
                foreach (Aula aulaLibre in this.obtenerAulasLibres(aulasCumplen, aulasOcupadas))
                {
                    AulaDTO aulaLibreDTO = new AulaDTO(aulaLibre.id_aula,
                                                       aulaLibre.capacidad,
                                                       aulaLibre.id_tipo_aula,
                                                       aulaDTO.detalleReserva,
                                                       aulaDTO.tipoReserva,
                                                       aulaDTO.detalleReserva.periodo);

                    //descarta aulas libres repetidas
                    bool noExisteAula = true;
                    foreach (AulaDTO aula in aulasLibres) 
                        if (aula.idAula == aulaLibreDTO.idAula) { noExisteAula = false; }

                    if (noExisteAula) { aulasLibres.Add(aulaLibreDTO); }
                }
            }

            Console.WriteLine("Cantidad de aulas libres: " + aulasLibres.Count);
            return aulasLibres;
        }

        private HashSet<Aula> obtenerAulasLibres(HashSet<Aula> aulasCumplen, HashSet<Aula> aulasOcupadas)
        {
            if (!(aulasOcupadas.Count == 0))
            {
                HashSet<Aula> aulasReservadas = new HashSet<Aula>();

                foreach (Aula aulaOcupada in aulasOcupadas)
                {
                    aulasCumplen.RemoveWhere(aulaCumple => aulaCumple.id_aula.Equals(aulaOcupada.id_aula));
                }

                return aulasCumplen;
            }
            else
            {
                return aulasCumplen;
            }
        }

        public HashSet<DateTime> convertToFechas(string diaReserva, HashSet<CuatrimestreDTO> periodo)
        {
            HashSet<DateTime> fechas = new HashSet<DateTime>();
            DateTime fecha = DateTime.Now;
            string diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES")).ToUpper(); //Convierte la fecha en su dia correspondiente de la semana
            
            while (!diaDeFecha.Equals(diaReserva.ToUpper()))
            {
                fecha = fecha.AddDays(1); //incrementa 1 dia hasta que la fecha sea la correspondiente a diaReserva

                diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES")).ToUpper();
            }
            
            foreach (CuatrimestreDTO cuatrimestre in periodo)
            {
                if (fecha < cuatrimestre.FechaInicio)
                {
                    fecha = DateTime.Parse(cuatrimestre.FechaInicio.ToString());
                }

                for (DateTime f = fecha; f <= cuatrimestre.FechaFin; f=f.AddDays(7))
                {
                    Console.WriteLine("Fecha a reservar: " + f.ToShortDateString()); //Visualiza en consola las fechas que fueron convertidas del dia de la reserva
                    fechas.Add(f);
                }
            }
            return fechas;
        }
        
        public HashSet<CuatrimestreDTO> calcularPeriodo(DetalleReservaDTO detalleReserva, string tipoReserva)
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
                            if (cuatrimestre.IdAnioLectivo == periodo.Last<CuatrimestreDTO>().IdAnioLectivo)
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

                        if (DateTime.Now >= cuatrimestre.FechaInicio && DateTime.Now <= cuatrimestre.FechaFin)
                        {
                            periodo.Add(cuatrimestre);
                        }
                        break;
                    case "Esporádica":
                        //Agrega un solo cuatrimestre
                        DateTime dia = Convert.ToDateTime(detalleReserva.diaOFecha);

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
