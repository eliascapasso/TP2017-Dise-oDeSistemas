using CapaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AnioLectivoDAODB
    {
        public AnioLectivoDAODB() { }

        public HashSet<CuatrimestreDTO> obtenerTodosLosPeriodos()
        {
            HashSet<CuatrimestreDTO> periodos = new HashSet<CuatrimestreDTO>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach(Cuatrimestre cuat in bd.Cuatrimestres)
                {
                    periodos.Add(new CuatrimestreDTO(cuat.fecha_inicio, cuat.fecha_fin));
                }
            }
            return periodos;
        }
    }
}
