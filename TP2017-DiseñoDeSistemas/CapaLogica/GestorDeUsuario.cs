using System;
using Excepciones;
using CapaDatos;

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
                    Bedel bedelNuevo = new Bedel(nick, pass, nombre, apellido, turno);
                    HistContrasenia historial = new HistContrasenia(pass,bedelNuevo.id_usuario);

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

        public void modificarBedel(string nickActual, String nick, String apellido, String nombre, String turno, String pass)
        {
            bool passmodificada = !pass.Equals("");

            UsuarioDAODB userDAODB = new UsuarioDAODB();
            GestorDePoliticaDeContrasenia gestorPoliticas = new GestorDePoliticaDeContrasenia();

            //Comprueba politicas de contraseña
            if (gestorPoliticas.comprobarPoliticas(pass) || !passmodificada)
            {
                //Comprueba que no exista el nick ingresado
                if (userDAODB.comprobarNickRepetido(nick))
                {
                    
                    Usuario bedelActual = userDAODB.obtenerBedel(nickActual);
                    Usuario bedelMod = this.setModificaciones(bedelActual, nick, apellido, nombre, turno, pass);

                    if (passmodificada)
                    {
                        HistContrasenia historial = new HistContrasenia(pass, bedelMod.id_usuario);
                        bedelMod.agregarHistorial(historial);
                    }

                    userDAODB.guardarBedelModificado(nickActual, bedelMod, bedelActual);
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

        private Usuario setModificaciones(Usuario bedelMod, string nick, string apellido, string nombre, string turno, string pass)
        {
            if (!nick.Equals(""))
            {
                bedelMod.nick = nick;
            }
            if (!apellido.Equals(""))
            {
                bedelMod.apellido = apellido;
            }
            if (!nombre.Equals(""))
            {
                bedelMod.nombre = nombre;
            }
            if (!turno.Equals(""))
            {
                bedelMod.turno = turno;
            }
            if (!pass.Equals(""))
            {
                bedelMod.contrasenia = pass;
            }

            return bedelMod;
        }
    }
}
