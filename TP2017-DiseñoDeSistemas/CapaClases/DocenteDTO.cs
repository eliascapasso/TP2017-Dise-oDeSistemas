using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class DocenteDTO
    {
        public string apellido;
        public string nombre;
        public string email;
        public int id_docente;
        public List<AsignaturaDTO> asignaturas = new List<AsignaturaDTO>();

        public DocenteDTO(int id, string apellido, string nombre, string email)
        {
            this.id_docente = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.email = email;
        }
    }
}
