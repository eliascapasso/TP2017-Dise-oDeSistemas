using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases.Bedel;

namespace CapaLogica
{
    class GestorDeUsuario
    {
        public GestorDeUsuario()
        {

        }

        public void registrarBedel(String nick, String nombre, String apellido, Turno turno, String pass)
        {
            //Falta crear instancia de la bd y validar el nick

            //Falta comprobar las politicas de contraseña

            Bedel bedelNuevo = new Bedel(nick, nombre, apellido, turno, pass);

            //Falta guardar el bedel nuevo en la bd
        }

    }
}
