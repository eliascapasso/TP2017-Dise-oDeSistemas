namespace CapaPresentacion
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class ReservaDTO
    {
        private int idUsuario;
        private string tipoReserva;
        private ArrayList lista;
        private int cantAlumnos;
        private int idDocente;
        private int idAsignatura;

        public ReservaDTO(int idUsuario, string tipoReserva, ArrayList lista, int cantAlumnos, int idDocente, int idAsignatura)
        {
            this.idUsuario = idUsuario;
            this.tipoReserva = tipoReserva;
            this.lista = lista;
            this.cantAlumnos = cantAlumnos;
            this.idDocente = idDocente;
            this.idAsignatura = idAsignatura;
        }
    }
}
