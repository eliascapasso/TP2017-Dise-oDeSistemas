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

            //Comprueba politicas de contraseña        
            if (gestorPoliticas.comprobarPoliticas(pass)) 
            {
                //Comprueba que no exista el nick ingresado
                if (userDAODB.comprobarNickRepetido(nick)) 
                {
                    Usuario bedelNuevo = new Usuario(nick, pass, nombre, apellido, turno);
                    HistContrasenia historial = new HistContrasenia(pass, bedelNuevo.id_usuario);
                    bedelNuevo.agregarHistorial(historial); 

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
    }
}
