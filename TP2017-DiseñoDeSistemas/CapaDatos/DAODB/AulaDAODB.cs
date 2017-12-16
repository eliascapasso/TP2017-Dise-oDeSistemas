namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public class AulaDAODB : AulaDAO
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

        public HashSet<Aula> obtenerAulas(int capacidadAula, int? idTipoAula)
        {
            HashSet<Aula> aulasCumplen = new HashSet<Aula>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                //var aulas = from Aula in bd.AulasInformatica
                //            where Aula.capacidad >= capacidadAula 
                //            && Aula.id_tipo_aula.Equals(idTipoAula)
                //            select Aula;

                foreach(Aula aula in bd.Aulas)
                {
                    if(aula.capacidad >= capacidadAula && aula.id_tipo_aula.Equals(idTipoAula))
                    {
                        aulasCumplen.Add(aula);
                    }
                }
            }
            return aulasCumplen;
        }

        public Aula getAula(int idAula)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Aula aula in bd.Aulas)
                {
                    if (aula.id_aula.Equals(idAula))
                    {
                        return aula;
                    }
                }
            }
            return null;
        }
    }
}