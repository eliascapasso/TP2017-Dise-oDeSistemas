using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Bedel : Usuario
    {
        public Bedel(string nick, string pass, string nombre, string apellido, string turno)
        {
            this.nick = nick;
            this.contrasenia = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.turno = turno;
            this.activo = true;
            this.id_tipo_usuario = 1;

            //HistContrasenia = new HashSet<HistContrasenia>();
            //Reserva = new HashSet<Reserva>();
        }

        //Agrega un historial a la lista de historiales del bedel creado
        public void agregarHistorial(HistContrasenia historial)
        {
            this.HistContrasenias.Add(historial);
        }
    }
}
