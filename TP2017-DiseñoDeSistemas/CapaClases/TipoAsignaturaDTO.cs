using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class TipoAsignaturaDTO
    {
        public string descripcion;
        public int id_tipoAsignatura;

        public TipoAsignaturaDTO(int id, string descripcion)
        {
            this.id_tipoAsignatura = id;
            this.descripcion = descripcion;
        }
    }
}
