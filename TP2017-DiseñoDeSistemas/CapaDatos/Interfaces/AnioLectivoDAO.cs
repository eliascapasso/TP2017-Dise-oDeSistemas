using CapaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface AnioLectivoDAO
    {
        HashSet<CuatrimestreDTO> obtenerTodosLosPeriodos();
    }
}
