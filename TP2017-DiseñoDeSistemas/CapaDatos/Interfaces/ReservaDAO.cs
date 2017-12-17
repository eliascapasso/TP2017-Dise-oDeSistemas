using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface ReservaDAO
    {
        HashSet<Aula> obtenerAulasOcupadas(DateTime fechaReserva, string horaInicio, string duracion);
        void guardarReserva(Reserva reserva);
    }
}
