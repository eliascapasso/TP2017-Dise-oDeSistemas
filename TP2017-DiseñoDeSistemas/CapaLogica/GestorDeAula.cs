namespace CapaLogica
{
    using CapaDatos;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CapaClases;
    using System.Windows.Forms;

    public class GestorDeAula
    {
        private AulaDAODB aulaDAODB;

        public GestorDeAula()
        {
            this.aulaDAODB = new AulaDAODB();
        }

        public ArrayList obtenerTiposAula()
        {
            return aulaDAODB.obtenerTiposAula();
        }

        public HashSet<DataGridViewRow> obtenerDisponibilidad(ReservaDTO reservadto)
        {
            //TODO: No implementado
            return new HashSet<DataGridViewRow>();
        }
    }
}
