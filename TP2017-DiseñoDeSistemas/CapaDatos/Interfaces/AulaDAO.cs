using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface AulaDAO
    {
        ArrayList obtenerTiposAula();
        HashSet<Aula> obtenerAulas(int capacidadAula, int? idTipoAula);
        Aula getAula(int idAula);
    }
}
