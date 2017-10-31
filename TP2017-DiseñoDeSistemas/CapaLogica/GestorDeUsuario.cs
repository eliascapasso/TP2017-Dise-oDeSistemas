using System;
using CapaDatos;
using Excepciones;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        public GestorDeUsuario()
        {

        }

        public void registrarBedel(String nick, String pass, String nombre, String apellido, String turno)
        {
           
            UsuarioDAODB userDAODB=new UsuarioDAODB();
            GestorDePoliticaDeContrasenia gestorPoliticas = new GestorDePoliticaDeContrasenia();
                    
            if (gestorPoliticas.comprobarPoliticas(pass)) //Comprueba politicas de contraseña
            {
                if (userDAODB.comprobarNickRepetido(nick))
                {
                    Usuario bedelNuevo = Usuario.CreateBedel(nick, pass, nombre, apellido, turno);
                    userDAODB.guardarBedel(bedelNuevo);
                }
                else
                {
                    throw new NickException();
                }
            }
            else
            {
                throw new PoliticasContraseniaException();
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
