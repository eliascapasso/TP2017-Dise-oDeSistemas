using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Reserva
    {
        private int _CantAlumnos;
        private TipoReserva _TipoReserva;
        private DateTime _FechayHora;

        public int CantAlumnos
        {
            get
            {
                return _CantAlumnos;
            }

            set
            {
                _CantAlumnos = value;
            }
        }

        internal TipoReserva TipoReserva
        {
            get
            {
                return _TipoReserva;
            }

            set
            {
                _TipoReserva = value;
            }
        }

        public DateTime FechayHora
        {
            get
            {
                return _FechayHora;
            }

            set
            {
                _FechayHora = value;
            }
        }

        public Reserva(TipoReserva reserva, DateTime fechaHora, int cantAlumnos)
        {
            this.TipoReserva = reserva;
            this.FechayHora = fechaHora;
            this.CantAlumnos = cantAlumnos;
        }
    }
}
