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
        private string nickUsuario;
        private string tipoReserva;
        private int cantAlumnos;
        private int idDocente;
        private int idAsignatura;
        public int idAula;
        DataGridViewRowCollection fechas;

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
