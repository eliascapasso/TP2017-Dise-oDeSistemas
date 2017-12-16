using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface HistorialContraseniaDAO
    {
        HashSet<HistContrasenia> obtenerHistorial(Bedel bedelObt);
    }
}
