using CapaClases;
using CapaDatos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class GestorDeReserva
    {
        private GestorDeAula gestorAula;
        private DocenteDAODB docenteDAO = new DocenteDAODB();
        private AsignaturaDAODB asignaturaDAO = new AsignaturaDAODB();
        private UsuarioDAODB usuarioDAO = new UsuarioDAODB();
        private AulaDAODB aulaDAO = new AulaDAODB();
        private ReservaDAODB reservaDAO = new ReservaDAODB();
        private HashSet<CuatrimestreDTO> todosLosPeriodos;

        public GestorDeReserva()
        {
            this.gestorAula = new GestorDeAula();
            this.todosLosPeriodos = new AnioLectivoDAODB().obtenerTodosLosPeriodos();
        }

        public void registrarReserva(ReservaDTO reservaDTO)
        {
            //Chequea que la disponibilidad de las aulas sean las mismas
            this.revalidarDisponibilidad(reservaDTO);
            
            //Obtiene el docente, asignatura y bedel seleccionados
            Docente docente = docenteDAO.getDocente(reservaDTO.idDocente);
            Asignatura asignatura = asignaturaDAO.getAsignatura(reservaDTO.idAsignatura);
            Bedel bedel = usuarioDAO.obtenerBedel(reservaDTO.nickUsuario);

            Reserva reserva = new Reserva(bedel,
                                          reservaDTO.tipoReserva,
                                          reservaDTO.cantAlumnos,
                                          docente,
                                          asignatura,
                                          DateTime.Now);

            this.agregarDetalles(reservaDTO, reserva);

            reservaDAO.guardarReserva(reserva);
        }

        private void agregarDetalles(ReservaDTO reservaDTO, Reserva reserva)
        {
            foreach (DetalleReservaDTO detalle in reservaDTO.detallesReservasDTOs)
            {
                HashSet<CuatrimestreDTO> periodo = gestorAula.calcularPeriodo(detalle, reservaDTO.tipoReserva);
                Aula aula = aulaDAO.getAula(detalle.idAula);

                //TODO:TRATAR DE OPTIMIZAR. IMPORTANTE!!!
                //Si es esporadica, se agrega un solo detale. Si es periodica se agregan tantos detalles como fechas reservadas existan
                if (reservaDTO.tipoReserva.Equals("Esporádica"))
                {
                    string nombreDia = DateTime.Parse(detalle.diaOFecha).ToString("dddd", new CultureInfo("es-ES"));
                    DateTime fecha = DateTime.Parse(detalle.diaOFecha);
                    fecha = DateTime.Parse(fecha.ToShortDateString());

                    DetalleReserva detalleReserva = new DetalleReserva(TimeSpan.Parse(detalle.horaInicio),
                                                                       TimeSpan.Parse(detalle.duracion),
                                                                       nombreDia,
                                                                       fecha,
                                                                       aula,
                                                                       reserva,
                                                                       this.obtenerIdCuatrimestre(DateTime.Parse(detalle.diaOFecha), periodo));

                    reserva.agregarDetalle(detalleReserva); //Se agrega un solo detalle
                }
                else //Periodica
                {
                    foreach (DateTime fecha in gestorAula.convertToFechas(detalle.diaOFecha.ToUpper(), periodo))
                    {
                        //TODO: ver el id cuatrimestre y el periodo del año
                        DetalleReserva detalleReserva = new DetalleReserva(TimeSpan.Parse(detalle.horaInicio),
                                                                           TimeSpan.Parse(detalle.duracion),
                                                                           detalle.diaOFecha,
                                                                           DateTime.Parse(fecha.ToShortDateString()),
                                                                           aula,
                                                                           reserva,
                                                                           this.obtenerIdCuatrimestre(fecha, periodo));

                        reserva.agregarDetalle(detalleReserva); //Se agregan 1 o varios detalles
                    }
                }
            }
        }

        private int obtenerIdCuatrimestre(DateTime fecha, HashSet<CuatrimestreDTO> periodo)
        {
            foreach (CuatrimestreDTO cuatrimestreDTO in periodo)
            {
                Console.WriteLine(cuatrimestreDTO.FechaInicio);
                if(fecha >= cuatrimestreDTO.FechaInicio && fecha <= cuatrimestreDTO.FechaFin)
                {
                    return cuatrimestreDTO.IdCuatrimestre;
                }
            }
            return -1;
        }

        private void revalidarDisponibilidad(ReservaDTO reservaDTO)
        {
            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservasDTOs)
            {
                AulaDTO aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                      reservaDTO.idTipoAula,
                                      detalleReserva,
                                      reservaDTO.tipoReserva,
                                      gestorAula.calcularPeriodo(detalleReserva, reservaDTO.tipoReserva));

                bool todaviaDisponible = false;
                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    if (aulaDisponible.idAula.Equals(detalleReserva.idAula))
                    {
                        todaviaDisponible = true;

                    }
                }

                if (!todaviaDisponible)
                {
                    throw new DisponibilidadException();
                }
            }
        }

        //TODO:Eliminar?
        //private TimeSpan convertToTimespan(string duracion)
        //{
        //    int aux = Int32.Parse(duracion);
        //    string straux;

        //    if (aux <= 59)
        //    {
        //        straux = "00:" + aux.ToString();
        //    }
        //    else 
        //    {
        //        straux = (aux / 60).ToString()+":"+(aux%60).ToString();
        //    }

        //    return TimeSpan.Parse(straux);
        //}
    }
}
