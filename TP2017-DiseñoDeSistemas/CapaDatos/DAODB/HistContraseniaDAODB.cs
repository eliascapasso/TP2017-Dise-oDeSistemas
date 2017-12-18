using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class HistContraseniaDAODB : HistorialContraseniaDAO
    {
        public HistContraseniaDAODB() { }
        
        public HashSet<HistContrasenia> obtenerHistorial(Bedel bedelObt)
        {
            HashSet<HistContrasenia> historiales = new HashSet<HistContrasenia>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var query = from HistContrasenia 
                            in bd.HistContrasenias
                            where HistContrasenia.Usuario_id_usuario.Equals(bedelObt.id_usuario)
                            select HistContrasenia;

                foreach(var hist in query)
                {
                    historiales.Add(hist);
                }
            }
            return historiales;
        }
    }
}

