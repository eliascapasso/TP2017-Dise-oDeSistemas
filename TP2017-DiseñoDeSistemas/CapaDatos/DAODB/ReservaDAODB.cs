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

        public HashSet<Aula> obtenerAulasOcupadas(string fechaReserva, string horaInicio, string duracion)
        {
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (DetalleReserva detalle in bd.DetalleReservas)
                {
                    Console.Write(TimeSpan.Parse(horaInicio) + " - " + TimeSpan.Parse(duracion) + "\n");
                    //TODO: cambiar el detalle.dia
                    if (detalle.dia.Equals(fechaReserva)
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

                try
                {
                    bd.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.Write("ERROR: No se pudieron guardar los cambios en la base de datos, " + e.Message);
                }
            }
        }
    }
}
