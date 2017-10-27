using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;
using CapaDatos;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        public GestorDeUsuario()
        {

        }

        public void registrarBedel(String nick, String pass, String nombre, String apellido, String turn)
        {
            //Falta crear instancia de la bd y validar el nick
            UsuarioDAODB userDAODB=new UsuarioDAODB();
            userDAODB.comprobarNickRepetido(nick);

            GestorDePoliticaDeContrasenia gestor = new GestorDePoliticaDeContrasenia();
            if (gestor.comprobarPoliticas(pass)) //Comprueba politicas de contraseña
            {
                Turno.TipoTurno turno = this.obtenerTurno(turn);
                Bedel bedelNuevo = new Bedel(nick, pass, nombre, apellido, turno);

                //Falta guardar el bedel nuevo en la bd
            }
            else
            {
                //Devolver MSJ para decir que no cumple las politicas
                //MessageBox.Show("La contraseña ingresada no cumple las politicas de contraseña", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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
    }
}
