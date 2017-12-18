using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface AsignaturaDAO
    {
        ArrayList obtenerAsignaturas();
        ArrayList obtenerTiposAsignatura();
        Asignatura getAsignatura(int idAsignatura);
    }
}
