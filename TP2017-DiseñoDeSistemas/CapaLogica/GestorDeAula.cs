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

        public HashSet<DataGridViewRow> obtenerDisponibilidad(AulaDTO aulaDTO)
        {
            HashSet<DateTime> fechasReserva = new HashSet<DateTime>();

            if (aulaDTO.tipoReserva.Equals("Anual") || aulaDTO.tipoReserva.Equals("Cuatrimestral"))
            {                                                         /*diaReserva*/
                fechasReserva = this.convertToFechas(aulaDTO.lista.Cells[0].Value.ToString(), aulaDTO.periodo);
            }
            else //Esporadica
            {                                                           /*diaReserva*/
                fechasReserva.Add(Convert.ToDateTime(aulaDTO.lista.Cells[0].Value.ToString()));
            }

            HashSet<Aula> aulasCumplen = aulaDAO.obtenerAulas(aulaDTO.capacidad, aulaDTO.idTipoAula);

            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();
            HashSet<Aula> aulasLibres = new HashSet<Aula>();
            HashSet<DataGridViewRow> disponibilidad = new HashSet<DataGridViewRow>();

            foreach (DateTime fecha in fechasReserva)
            {
                aulasOcupadas.Concat(reservaDAO.obtenerAulasOcupadas(aulaDTO.lista.Cells[0].Value.ToString(), //fechaReserva
                                                                                aulaDTO.lista.Cells[1].Value.ToString(), //horaInicio
                                                                                aulaDTO.lista.Cells[2].Value.ToString())); //duracion

                aulasLibres.Concat(this.obtenerAulasLibres(aulasCumplen, aulasOcupadas));

                foreach (Aula aula in aulasLibres)
                {
                    DataGridViewRow fila = new DataGridViewRow();

                    fila.Cells[0].Value = aula.id_aula;
                    fila.Cells[1].Value = aula.capacidad;
                    fila.Cells[2].Value = "";

                    if (aulaDTO.tipoReserva.Equals("Anual") || aulaDTO.tipoReserva.Equals("Cuatrimestral"))
                    {
                        fila.Cells[3].Value = fecha.ToString("dddd", new CultureInfo("es-ES"));
                    }
                    else //Esporadica
                    {
                        fila.Cells[3].Value = fecha.ToShortDateString();
                    }

                    disponibilidad.Add(fila);
            }
            }

            if (disponibilidad.Equals(null))
            {
                throw new NullReferenceException(); //No existen aulas libres para los dias u horarios especificados
            }

            return disponibilidad;
        }

        private HashSet<Aula> obtenerAulasLibres(HashSet<Aula> aulasCumplen, HashSet<Aula> aulasOcupadas)
        {
            return (HashSet<Aula>)aulasCumplen.Intersect(aulasCumplen);
        }

        private HashSet<DateTime> convertToFechas(string diaReserva, HashSet<CuatrimestreDTO> periodo)
        {
            HashSet<DateTime> fechas = new HashSet<DateTime>();
            DateTime fecha = DateTime.Now;
            string diaDeFecha = fecha.ToString("dddd", new CultureInfo("es-ES"));

            while(!diaDeFecha.Equals(diaReserva))
            {
                fecha.AddDays(1); //incrementa 1 dia hasta que la fecha sea la correspondiente a diaReserva
            }

            foreach(CuatrimestreDTO cuatrimestre in periodo)
            {
                for(DateTime f = fecha; f <= cuatrimestre.FechaFin; f.AddDays(7))
                {
                    fechas.Add(f);
                }
            }
            return fechas;
        }
    }
}
