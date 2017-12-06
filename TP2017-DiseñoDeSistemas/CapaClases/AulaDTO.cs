using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaClases
{
    public class AulaDTO
    {
        public int capacidad;
        public int idTipoAula;
        public DataGridViewRow lista; //dia, horaInicio, Duracion
        public string tipoReserva;
        public int idPeriodo;

        public AulaDTO(int capacidad, int idtipoaula, DataGridViewRow lista, string tiporeserva, int idperiodo)
        {
            this.capacidad = capacidad;
            idTipoAula = idtipoaula;
            this.lista = lista;
            tipoReserva = tiporeserva;
            idPeriodo = idperiodo;
        }
    }
}
