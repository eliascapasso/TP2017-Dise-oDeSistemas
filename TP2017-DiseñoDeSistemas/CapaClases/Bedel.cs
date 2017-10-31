using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Bedel : Usuario
    {
        private String _Nombre;
        private String _Apellido;
        private Turno.TipoTurno _Turno;

        internal Turno.TipoTurno Turno
        {
            get
            {
                return _Turno;
            }

            set
            {
                _Turno = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public Bedel(string nick, string pass, string nombre, string apellido, Turno.TipoTurno turno)
        {
            this.Nick = nick;
            this.Pass = pass;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Turno = turno;
        }
    }
}
