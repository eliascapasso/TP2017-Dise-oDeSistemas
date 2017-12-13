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

        public GestorDeAula()
        {
            this.aulaDAO = new AulaDAODB();
            this.reservaDAO = new ReservaDAODB();
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
                    Console.Write(f.ToShortDateString() + '\n'); //Visualiza en consola las fechas que fueron convertidas del dia de la reserva
                    fechas.Add(f);
                }
            }
            return fechas;
        }
    }
}
