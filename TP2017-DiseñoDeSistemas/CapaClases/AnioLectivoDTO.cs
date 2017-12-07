using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class AnioLectivoDTO
    {
        public int id_anio_lectivo;
        public ArrayList cuatrimestres;
        public DateTime? fecha_inicio;
        public DateTime? fecha_fin;

        public AnioLectivoDTO(int id_anio_lectivo, DateTime? fecha_inicio, DateTime? fecha_fin, ArrayList cuatrimestres)
        {
            this.id_anio_lectivo = id_anio_lectivo;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.cuatrimestres = cuatrimestres;
        }
    }
}
