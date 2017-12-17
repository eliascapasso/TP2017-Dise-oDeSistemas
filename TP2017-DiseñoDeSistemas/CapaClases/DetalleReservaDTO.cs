using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class DetalleReservaDTO
    {
        public string diaOFecha;
        public string horaInicio;
        public string duracion;
        public int idAula;
        public HashSet<CuatrimestreDTO> periodo;

        public DetalleReservaDTO(string diaReserva, string horaInicio, string duracion)
        {
            this.diaOFecha = diaReserva;
            this.horaInicio = horaInicio;
            this.duracion = duracion;
        }
    }
}
