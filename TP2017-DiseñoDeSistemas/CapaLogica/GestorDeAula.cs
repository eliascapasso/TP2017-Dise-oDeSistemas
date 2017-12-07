using CapaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;
using System.Windows.Forms;

namespace CapaLogica
{
    public class GestorDeAula
    {
        private AulaDAODB aulaDAODB;
        private string tipoPeriodo;

        public GestorDeAula()
        {
            this.aulaDAODB = new AulaDAODB();
        }

        public ArrayList obtenerTiposAula()
        {
            return aulaDAODB.obtenerTiposAula();
        }

        public DataGridViewRow obtenerDisponibilidad(AulaDTO auladto)
        {
            if (!auladto.tipoReserva.Equals("Esporádica"))
            {
                this.convertToDia(auladto.lista.Cells[0].Value.ToString());
            }
            //TODO: No implementado
            return new DataGridViewRow();
        }

        private List<DateTime> convertToDia(string dia)
        {
            return new List<DateTime>();
        }
    }
}
