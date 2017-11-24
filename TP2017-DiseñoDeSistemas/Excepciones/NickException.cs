using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NickException : System.Exception
    {
        public NickException() : base("El nick ingresado ya existe")
        {

        }
    }
}
