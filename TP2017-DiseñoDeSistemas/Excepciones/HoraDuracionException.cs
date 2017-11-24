using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class HoraDuracionException : System.Exception
    {
        public HoraDuracionException(string dia, string horaInicio, string duracion) : base("La hora de inicio " + horaInicio +" y duración " + duracion + " ya fueron asignados al dia " + dia)
        {

        }
    }
}