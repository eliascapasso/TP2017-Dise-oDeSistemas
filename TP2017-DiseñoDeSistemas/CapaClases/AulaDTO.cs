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
        public DataGridViewRow lista; //diaReserva, horaInicio, Duracion
        public string tipoReserva;
        public HashSet<CuatrimestreDTO> periodo;

        public AulaDTO(int capacidad, int idtipoaula, DataGridViewRow lista, string tiporeserva, HashSet<CuatrimestreDTO> periodo)
        {
            this.capacidad = capacidad;
            idTipoAula = idtipoaula;
            this.lista = lista;
            tipoReserva = tiporeserva;
            this.periodo = periodo;
        }
    }
}
