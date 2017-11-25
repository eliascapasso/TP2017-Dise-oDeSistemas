namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public class AulaDAODB
    {
        public AulaDAODB() { }

        //Se obtienen todos los tipos de aula
        public ArrayList obtenerTiposAula()
        {
            ArrayList tiposAula = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (TipoAula tipoAula in bd.TipoAulas)
                {
                    tiposAula.Add(tipoAula);
                }
            }
            return tiposAula;
        }
    }
}