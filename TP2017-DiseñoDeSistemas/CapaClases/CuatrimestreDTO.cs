using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class CuatrimestreDTO
    {
        private DateTime? fechaInicio;
        private DateTime? fechaFin;
        private int? idAnioLectivo;

        public DateTime? FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public DateTime? FechaFin
        {
            get
            {
                return fechaFin;
            }

            set
            {
                fechaFin = value;
            }
        }

        public int? IdAnioLectivo
        {
            get
            {
                return idAnioLectivo;
            }

            set
            {
                idAnioLectivo = value;
            }
        }

        public CuatrimestreDTO(DateTime? fechaI, DateTime? fechaF, int? idAnioLectivo)
        {
            this.fechaInicio = fechaI;
            this.fechaFin = fechaF;
            this.idAnioLectivo = idAnioLectivo;
        }
    }
}
