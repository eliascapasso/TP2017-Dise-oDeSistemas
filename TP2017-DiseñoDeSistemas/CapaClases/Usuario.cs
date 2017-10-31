using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Usuario
    {
        private string _Nick;
        private string _Pass;

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

        public Usuario()
        {

        }

        public Usuario(string nick, string pass)
        {
            this.Nick = nick;
            this.Pass = pass;
        }
    }
}
