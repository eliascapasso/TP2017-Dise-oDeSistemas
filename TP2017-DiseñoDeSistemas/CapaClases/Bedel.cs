using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    class Bedel : Usuario
    {
        private String _Nombre;
        private String _Apellido;
        private Turno _Turno;

        internal Turno Turno
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

        public Bedel(String nick, String nombre, String apellido, Turno turno, String pass)
        {
            super(nick, pass);
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Turno = turno;
        }


    }
}
