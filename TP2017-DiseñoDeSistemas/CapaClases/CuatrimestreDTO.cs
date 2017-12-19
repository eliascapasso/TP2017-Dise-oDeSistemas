using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class CuatrimestreDTO : IComparable<CuatrimestreDTO>
    {
        private DateTime? fechaInicio;
        private DateTime? fechaFin;
        private int? idAnioLectivo;
        private int idCuatrimestre;

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

        public int IdCuatrimestre
        {
            get
            {
                return idCuatrimestre;
            }

            set
            {
                idCuatrimestre = value;
            }
        }

        public CuatrimestreDTO(DateTime? fechaI, DateTime? fechaF, int? idAnioLectivo, int idCuatrimestre)
        {
            this.IdCuatrimestre = idCuatrimestre;
            this.fechaInicio = fechaI;
            this.fechaFin = fechaF;
            this.idAnioLectivo = idAnioLectivo;
        }

        public int CompareTo(CuatrimestreDTO asignatura)
        {
            if (this.fechaInicio < asignatura.fechaInicio)
            {
                return -1;
            }
            else if (this.fechaInicio > asignatura.fechaInicio)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
