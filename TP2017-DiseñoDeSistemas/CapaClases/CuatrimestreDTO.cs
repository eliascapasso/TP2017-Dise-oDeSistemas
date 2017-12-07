using System;

namespace CapaClases
{
    public class CuatrimestreDTO
    {
        private DateTime? fecha_fin;
        private DateTime? fecha_inicio;
        private int id_cuatrimestre;

        public CuatrimestreDTO(int id_cuatrimestre, DateTime? fecha_inicio, DateTime? fecha_fin)
        {
            this.id_cuatrimestre = id_cuatrimestre;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }
    }
}