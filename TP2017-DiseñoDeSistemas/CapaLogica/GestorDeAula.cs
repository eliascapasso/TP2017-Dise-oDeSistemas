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
                
                                                            /*diaReserva*/
                fechasReserva = this.convertToFechas(aulaDTO.lista.Cells[0].Value.ToString(), aulaDTO.periodo);
                
            }
            else //Esporadica
            {                                                           /*diaReserva*/
                fechasReserva.Add(Convert.ToDateTime(aulaDTO.lista.Cells[0].Value.ToString()));
            }

            HashSet<Aula> aulasCumplen = aulaDAO.obtenerAulas(aulaDTO.capacidad, aulaDTO.idTipoAula);
            
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();
            HashSet<AulaDTO> aulasLibres = new HashSet<AulaDTO>();

            //Obtiene las aulas ocupadas
            foreach (DateTime fechaReserva in fechasReserva)
            {
                foreach (Aula aulaOcupada in reservaDAO.obtenerAulasOcupadas(fechaReserva.ToShortDateString(), //fechaReserva
                                                                            aulaDTO.lista.Cells[1].Value.ToString(), //horaInicio
                                                                            aulaDTO.lista.Cells[2].Value.ToString()))  //duracion)
                {
                    aulasOcupadas.Add(aulaOcupada);
                }
                
                //Obtiene las aulas libres
                foreach (Aula aulaLibre in this.obtenerAulasLibres(aulasCumplen, aulasOcupadas))
                {
                   
                    aulasLibres.Add(new AulaDTO(aulaLibre.id_aula, aulaLibre.capacidad, aulaLibre.id_tipo_aula, aulaDTO.lista, aulaDTO.tipoReserva, aulaDTO.periodo));
                }
            }

            return aulasLibres;
        }

        private HashSet<Aula> obtenerAulasLibres(HashSet<Aula> aulasCumplen, HashSet<Aula> aulasOcupadas)
        {
            //return (HashSet<Aula>)aulasCumplen.Intersect(aulasCumplen);
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
                Console.Write(diaDeFecha+'\n');
                fecha = fecha.AddDays(1);

                diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES")).ToUpper();
                //incrementa 1 dia hasta que la fecha sea la correspondiente a diaReserva
            }


            foreach (CuatrimestreDTO cuatrimestre in periodo)
            {
                for (DateTime f = fecha; f <= cuatrimestre.FechaFin; f=f.AddDays(7))
                {
                    Console.Write(f.ToString());
                    fechas.Add(f);
                }
            }
            
            return fechas;
        }
    }
}
