using CapaClases;
using CapaDatos;
using Excepciones;
using System;
using System.Collections.Generic;
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
            HashSet<AulaDTO> disponibilidad = new HashSet<AulaDTO>();
            
            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservas)
            { //TODO: ver como concatenar al agregar aula DTO
                AulaDTO aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                      reservaDTO.idTipoAula,
                                      detalleReserva,
                                      reservaDTO.tipoReserva,
                                      gestorAula.calcularPeriodo(detalleReserva, reservaDTO.tipoReserva));
                
                //bool todaviaDisponible = false;
                //foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                //{
                //    if (aulaDisponible.idAula.Equals(detalleReserva.idAula))
                //    {
                //        todaviaDisponible = true;
                        
                //    }
                //}

                //if (!todaviaDisponible)
                //{
                //    throw new DisponibilidadException();
                //}
            }

            //Obtiene el docente seleccionado
            Docente docente = docenteDAO.getDocente(reservaDTO.idDocente);
            Asignatura asignatura = asignaturaDAO.getAsignatura(reservaDTO.idAsignatura);
            Bedel bedel = usuarioDAO.obtenerBedel(reservaDTO.nickUsuario);

            Reserva reserva = new Reserva(bedel,
                                          reservaDTO.tipoReserva,
                                          reservaDTO.cantAlumnos,
                                          docente,
                                          asignatura);
            //TODO:No carga los detalles de reserva
            foreach (DetalleReservaDTO detalle in reservaDTO.detallesReservas)
            {
                Aula aula = aulaDAO.getAula(detalle.idAula);
                
                DetalleReserva detalleReserva = new DetalleReserva(TimeSpan.Parse(detalle.horaInicio),
                                                                   TimeSpan.Parse(detalle.duracion),
                                                                   detalle.diaReserva,
                                                                   aula,
                                                                   reserva);

                reserva.agregarDetalle(detalleReserva);
            }

           reservaDAO.guardarReserva(reserva);
        }


    }
}
