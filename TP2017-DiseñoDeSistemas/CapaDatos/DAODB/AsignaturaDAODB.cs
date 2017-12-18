namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public class AsignaturaDAODB : AsignaturaDAO
    {
        public AsignaturaDAODB() { }

        //Obtiene todas las asignaturas almacenadas en la bd
        public ArrayList obtenerAsignaturas()
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

        public ArrayList obtenerTiposAsignatura()
        {
            ArrayList tipos = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (TipoAsignatura tipo in bd.TipoAsignaturas)
                {
                    tipos.Add(tipo);
                }
            }
            return tipos;
        }

        public Asignatura getAsignatura(int idAsignatura)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Asignatura asignatura in bd.Asignaturas)
                {
                    if (asignatura.id_asignatura.Equals(idAsignatura))
                    {
                        return asignatura;
                    }
                }
            }
            return null;
        }
    }
}
