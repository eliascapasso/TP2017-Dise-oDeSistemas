using CapaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class GestorDeReserva
    {
        private GestorDeAula gestorAula;

        public GestorDeReserva()
        {
            this.gestorAula = new GestorDeAula();
        }

        public void registrarReserva(ReservaDTO reservadto)
        {
            gestorAula.obtenerDisponibilidad(reservadto);
        } 
    }
}
