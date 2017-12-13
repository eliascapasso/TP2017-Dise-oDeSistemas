using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaClases
{
    public class ReservaDTO
    {
        public string nickUsuario;
        public string tipoReserva;
        public int cantAlumnos;
        public int idDocente;
        public int idAsignatura;
        public HashSet<DetalleReservaDTO> detallesReservas; /*diaReserva, horaInicio, duracion, idAula, periodo*/
        public int idTipoAula;

        public ReservaDTO(string nickUsuario, string tipoReserva, HashSet<DetalleReservaDTO> detallesReservas, int cantAlumnos, int idDocente, int idAsignatura,int idtipoaula)
        {
            this.idTipoAula = idtipoaula;
            this.nickUsuario= nickUsuario;
            this.tipoReserva = tipoReserva;
            this.detallesReservas = detallesReservas;
            this.cantAlumnos = cantAlumnos;
            this.idDocente = idDocente;
            this.idAsignatura = idAsignatura;
        }
    }
}
