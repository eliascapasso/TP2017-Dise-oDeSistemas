using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    class Usuario
    {
        private String _Nick;
        private String _Pass; 

        public Usuario(String nick, String pass)
        {
            this.Nick = nick;
            this.Pass = pass;
        }

        public string Nick
        {
            get
            {
                return _Nick;
            }

            set
            {
                _Nick = value;
            }
        }

        public string Pass
        {
            get
            {
                return _Pass;
            }

            set
            {
                _Pass = value;
            }
        }
    }
}
