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
        private HashSet<CuatrimestreDTO> todosLosPeriodos;

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
                fechasReserva = this.convertToFechas(aulaDTO.detalleReserva.diaReserva, aulaDTO.periodo);
            }
            else //Esporadica
            {
                fechasReserva.Add(Convert.ToDateTime(aulaDTO.detalleReserva.diaReserva));
            }

            HashSet<Aula> aulasCumplen = aulaDAO.obtenerAulas(aulaDTO.capacidad, aulaDTO.idTipoAula);
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();
            HashSet<AulaDTO> aulasLibres = new HashSet<AulaDTO>();

            //Obtiene las aulas ocupadas
            foreach (DateTime fechaReserva in fechasReserva)
            {
                foreach (Aula aulaOcupada in reservaDAO.obtenerAulasOcupadas(fechaReserva.ToShortDateString(), //fechaReserva
                                                                            aulaDTO.detalleReserva.horaInicio,
                                                                            aulaDTO.detalleReserva.duracion)) 
                {
                    aulasOcupadas.Add(aulaOcupada);
                }
                if(aulasOcupadas.Count == 0)
                {
                    Console.Write("algo\n");
                }
                //Obtiene las aulas libres
                foreach (Aula aulaLibre in this.obtenerAulasLibres(aulasCumplen, aulasOcupadas))
                {
                    AulaDTO aulaLibreDTO = new AulaDTO(aulaLibre.id_aula,
                                                       aulaLibre.capacidad,
                                                       aulaLibre.id_tipo_aula,
                                                       aulaDTO.detalleReserva,
                                                       aulaDTO.tipoReserva,
                                                       aulaDTO.detalleReserva.periodo);

                    //TODO:Intentar optimizar
                    bool noExisteAula = true;
                    foreach (AulaDTO aula in aulasLibres) //descarta aulas libres repetidas
                        if (aula.idAula == aulaLibreDTO.idAula) { noExisteAula = false; }

                    if (noExisteAula) { aulasLibres.Add(aulaLibreDTO); }
                }
            }
            return aulasLibres;
        }

        private HashSet<Aula> obtenerAulasLibres(HashSet<Aula> aulasCumplen, HashSet<Aula> aulasOcupadas)
        {
            //TODO: intentar optimizar, complejidad muy alta
            
            if (!(aulasOcupadas.Count == 0))
            {
                HashSet<Aula> aulasLibres = new HashSet<Aula>();

                foreach (Aula aulaCumple in aulasCumplen)
                {
                    foreach (Aula aulaOcupada in aulasOcupadas)
                    {
                        if (!aulaOcupada.id_aula.Equals(aulaCumple.id_aula))
                        {
                            aulasLibres.Add(aulaCumple);
                        }
                    }
                }
                return aulasLibres;
            }
            else
            {
                return aulasCumplen;
            }
        }

        private HashSet<DateTime> convertToFechas(string diaReserva, HashSet<CuatrimestreDTO> periodo)
        {
            HashSet<DateTime> fechas = new HashSet<DateTime>();
            DateTime fecha = DateTime.Now;
            string diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES")).ToUpper();
            
            while (!diaDeFecha.Equals(diaReserva.ToUpper()))
            {
                fecha = fecha.AddDays(1); //incrementa 1 dia hasta que la fecha sea la correspondiente a diaReserva

                diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES")).ToUpper();
            }
            
            foreach (CuatrimestreDTO cuatrimestre in periodo)
            {
                for (DateTime f = fecha; f <= cuatrimestre.FechaFin; f=f.AddDays(7))
                {
                    //Console.Write(f.ToShortDateString() + '\n'); //Visualiza en consola las fechas que fueron convertidas del dia de la reserva
                    fechas.Add(f);
                }
            }
            return fechas;
        }

        //TODO: Quitar de aca o de obtener disponibilidad?
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

                        break;
                }

            }
            return periodo;
        }
    }
}
