namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class DocenteDAODB : DocenteDAO
    {
        public DocenteDAODB() { }

        public ArrayList obtenerDocentes()
        {
            ArrayList docentes = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Docente docente in bd.Docentes)
                {
                    docentes.Add(docente);
                }
            }
            return docentes;
        }

        public ArrayList obtenerAsignaturasDeDocente(Docente docente)
        {
            ArrayList asignaturas = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Docente docenteBD in bd.Docentes)
                {
                    if (docenteBD.id_docente == docente.id_docente)
                    {
                        foreach (Asignatura asignatura in docenteBD.Asignaturas)
                        {
                            asignaturas.Add(asignatura);
                        }
                    }
                }
            }
            return asignaturas;
        }

        public Docente getDocente(int idDocente)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Docente docente in bd.Docentes)
                {
                    if (docente.id_docente.Equals(idDocente))
                    {
                        return docente;
                    }
                }
            }
            return null;
        }
    }
}
