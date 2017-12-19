using CapaClases;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class GestorAnioLectivo
    {
        private AnioLectivoDAODB anioDAO = new AnioLectivoDAODB();

        public GestorAnioLectivo() { }

        public List<CuatrimestreDTO> obtenerTodosLosPeriodos()
        {
            return anioDAO.obtenerTodosLosPeriodos();
        }
    }
}
