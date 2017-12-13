using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaClases
{
    public class AulaDTO
    {
        public int capacidad;
        public int? idTipoAula;
        public DetalleReservaDTO detalleReserva; //diaReserva, horaInicio, Duracion, periodo
        public string tipoReserva;
        public HashSet<CuatrimestreDTO> periodo;
        public int idAula;

        public AulaDTO(int capacidad, int idtipoaula, DetalleReservaDTO detalleReserva, string tiporeserva, HashSet<CuatrimestreDTO> periodo)
        {
            this.capacidad = capacidad;
            this.idTipoAula = idtipoaula;
            this.detalleReserva = detalleReserva;
            this.tipoReserva = tiporeserva;
            this.periodo = periodo;
        }

        public AulaDTO(int idAula, int capacidad, int? idtipoaula, DetalleReservaDTO detalleReserva, string tiporeserva, HashSet<CuatrimestreDTO> periodo)
        {
            this.idAula = idAula;
            this.capacidad = capacidad;
            this.idTipoAula = idtipoaula;
            this.detalleReserva = detalleReserva;
            //this.detalleReserva.idAula = this.idAula;
            this.tipoReserva = tiporeserva;
            this.periodo = periodo;
        }
    }
}
