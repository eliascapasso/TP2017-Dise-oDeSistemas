using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReservaDAODB
    {
        public ReservaDAODB() { }

        public HashSet<Aula> obtenerAulasOcupadas(string fechaReserva, string horaInicio, string duaracion)
        {
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var aulas = from DetalleReserva in bd.DetalleReservas where DetalleReserva.dia.Equals(fechaReserva) && DetalleReserva.hora_inicio.Equals(horaInicio) && DetalleReserva.duracion.Equals(duaracion) select DetalleReserva.Aula;

                foreach(Aula aula in aulas)
                {
                    aulasOcupadas.Add(aula);
                }
            }
            return aulasOcupadas;
        }
    }
}
