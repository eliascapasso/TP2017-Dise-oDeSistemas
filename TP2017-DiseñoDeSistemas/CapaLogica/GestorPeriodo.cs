using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class GestorPeriodo
    {
        private ReservaDAODB reservadao;
        public GestorPeriodo() {
            this.reservadao = new ReservaDAODB();
        }

        public HashSet<AnioLectivo> getAnios() {
            return reservadao.getAnio();
        }

        public HashSet<Cuatrimestre> getCuatrimestres() {
            return reservadao.getCuatrimestre();
        }
    }
}
