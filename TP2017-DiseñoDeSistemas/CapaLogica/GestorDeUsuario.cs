using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        public GestorDeUsuario()
        {

        }

        public bool registrarBedel(String nick, String pass, String nombre, String apellido, String turno)
        {
           
            UsuarioDAODB userDAODB=new UsuarioDAODB();
            GestorDePoliticaDeContrasenia gestorPoliticas = new GestorDePoliticaDeContrasenia();

            if (gestorPoliticas.comprobarPoliticas(pass) && userDAODB.comprobarNickRepetido(nick)) //Comprueba politicas de contraseña
            {
                Usuario bedelNuevo = Usuario.CreateBedel(nick, pass, nombre, apellido, turno);

                userDAODB.guardarBedel(bedelNuevo);

                return true;
            }
            else
            {

                Console.Write("validacion politicas o comprobacion nick fallido");
                
                //MessageBox.Show("La contraseña ingresada no cumple las politicas de contraseña", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        /*private Turno.TipoTurno obtenerTurno(String turno)
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
        }*/
    }
}
