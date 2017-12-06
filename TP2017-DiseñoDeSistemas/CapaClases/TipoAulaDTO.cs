using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class TipoAulaDTO
    {
        public int idTipoAula;
        public string descripcion;

        public TipoAulaDTO(int idTipoAula, string descripcion)
        {
            this.idTipoAula = idTipoAula;
            this.descripcion = descripcion;
        }
    }
}
