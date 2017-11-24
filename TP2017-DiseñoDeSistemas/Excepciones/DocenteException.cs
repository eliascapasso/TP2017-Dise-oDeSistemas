using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DocenteException : System.Exception
    {
        public DocenteException() : base("Los datos del solicitante no son validos")
        {

        }
    }
}