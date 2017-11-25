namespace CapaLogica
{
    using CapaDatos;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GestorDeDocente
    {
        private DocenteDAODB docenteDAODB;

        public GestorDeDocente()
        {
            this.docenteDAODB = new DocenteDAODB();
        }

        public ArrayList obtenerDocentes()
        {
            return docenteDAODB.obtenerDocentes();
        }
    }
}
