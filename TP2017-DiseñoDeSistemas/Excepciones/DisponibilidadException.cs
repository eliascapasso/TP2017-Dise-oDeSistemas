using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DisponibilidadException : Exception
    {
        public DisponibilidadException() : base("La disponibilidad de las aulas cambió")
        {

        }
    }
}
