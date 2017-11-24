namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public class AsignaturaDAODB
    {
        public AsignaturaDAODB() { }

        //Obtiene todas las asignaturas almacenadas en la bd
        public ArrayList obtenerAsgignaturas()
        {
            ArrayList asignaturas = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Asignatura asignatura in bd.Asignaturas)
                {
                    asignaturas.Add(asignatura);
                }
            }
            return asignaturas;
        }
    }
}
