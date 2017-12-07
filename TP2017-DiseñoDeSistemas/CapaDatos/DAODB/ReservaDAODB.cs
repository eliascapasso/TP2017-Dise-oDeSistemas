using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class ReservaDAODB
    {
        public ReservaDAODB() { }

        public HashSet<AnioLectivo> getAnio()
        {
            HashSet<AnioLectivo> anios = new HashSet<AnioLectivo>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (AnioLectivo anio in bd.AnioLectivoes)
                {
                    anios.Add(anio);
                }
            }
            return anios;
        }

        public HashSet<Cuatrimestre> getCuatrimestre() {
            HashSet<Cuatrimestre> cuatrimestres = new HashSet<Cuatrimestre>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Cuatrimestre cuatrimestre in bd.Cuatrimestres)
                {
                    cuatrimestres.Add(cuatrimestre);
                }
            }
            return cuatrimestres;
        }
    }
}
