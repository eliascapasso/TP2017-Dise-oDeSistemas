namespace CapaLogica
{
    using CapaDatos;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class GestorDeReserva
    {
        private AsignaturaDAODB asigDAODB;

        public GestorDeReserva()
        {
            this.asigDAODB = new AsignaturaDAODB();
        }

        public ArrayList obtenerAsignaturas()
        {
            return asigDAODB.obtenerAsgignaturas();
        }
    }
}
