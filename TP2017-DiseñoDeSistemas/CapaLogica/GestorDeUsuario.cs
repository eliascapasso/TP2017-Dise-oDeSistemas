using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        public GestorDeUsuario()
        {

        }

        private Turno.TipoTurno obtenerTurno(String turno)
        {
            switch (turno.ToLower())
            {
                case "mañana":
                    return Turno.TipoTurno.MAÑANA;
                case "tarde":
                    return Turno.TipoTurno.TARDE;
                case "noche":
                    return Turno.TipoTurno.NOCHE;
                default:
                    return Turno.TipoTurno.MAÑANA;
            }
        }

        public void registrarBedel(String nick, String pass, String nombre, String apellido, String turn)
        {
            //Falta crear instancia de la bd y validar el nick

            //Falta comprobar las politicas de contraseña

            Turno.TipoTurno turno = this.obtenerTurno(turn); //Si el campo esta vacio obtiene por defecto en turno mañana
            Bedel bedelNuevo = new Bedel(nick, pass, nombre, apellido, turno);

            //Falta guardar el bedel nuevo en la bd
        }

    }
}
