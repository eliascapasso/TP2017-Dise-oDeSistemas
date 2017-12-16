using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public interface DocenteDAO
    {
        ArrayList obtenerDocentes();
        Docente getDocente(int idDocente);
    }
}
