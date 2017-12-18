using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReservaDAODB : ReservaDAO
    {
        public ReservaDAODB() { }

        public HashSet<Aula> obtenerAulasOcupadas(DateTime fechaReserva, string horaInicio, string duracion)
        {
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (DetalleReserva detalle in bd.DetalleReservas)
                {
                    if (detalle.fecha.Equals(DateTime.Parse(fechaReserva.ToShortDateString()))
                            && detalle.hora_inicio.Equals(TimeSpan.Parse(horaInicio))
                            && detalle.duracion.Equals(TimeSpan.Parse(duracion)))
                    {
                        aulasOcupadas.Add(detalle.Aula);
                    }
                }
            }
            return aulasOcupadas;
        }

        public void guardarReserva(Reserva reserva)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                bd.Reservas.Add(reserva);
                //reserva.Docente.Asignaturas.Add(reserva.Asignatura);
                //reserva.Asignatura.Docentes.Add(reserva.Docente);

                //TODO:poner dentro del try
                bd.SaveChanges();
                try
                {
                    
                }
                catch (Exception e)
                {
                    Console.Write("ERROR: No se pudieron guardar los cambios en la base de datos, " + e.Message);
                }
            }
        }
    }
}
