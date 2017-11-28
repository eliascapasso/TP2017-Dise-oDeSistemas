namespace CapaClases
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class ReservaDTO
    {
        public string nickUsuario;
        public string tipoReserva;
        public int cantAlumnos;
        public int idDocente;
        public int idAsignatura;
        public int idAula;
        public DataGridViewRowCollection fechas; /*Columna 1: Dia, Columna 2: horaInicio, Columna 3: duracion*/

        public ReservaDTO(string nickUsuario, string tipoReserva, DataGridViewRowCollection fecha, int cantAlumnos, int idDocente, int idAsignatura)
        {
            this.nickUsuario= nickUsuario;
            this.tipoReserva = tipoReserva;
            this.fechas = fecha;
            this.cantAlumnos = cantAlumnos;
            this.idDocente = idDocente;
            this.idAsignatura = idAsignatura;
        }
    }
}
