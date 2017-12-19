using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class AsignaturaDTO
    {
        public string nombre;
        public int id_asignatura; 

        public AsignaturaDTO(int id, string nombre)
        {
            id_asignatura = id;
            this.nombre = nombre;
        }
    }
}
