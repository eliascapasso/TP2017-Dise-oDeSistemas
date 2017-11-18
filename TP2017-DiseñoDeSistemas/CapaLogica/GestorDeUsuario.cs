using System;
using Excepciones;
using CapaDatos;
using System.Windows.Forms;
using System.Collections;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        private UsuarioDAODB userDAODB;

        public GestorDeUsuario()
        {
            this.userDAODB = new UsuarioDAODB();
        }

        //METODO PARA REGISTRAR UN BEDEL
        public void registrarBedel(String nick, String pass, String nombre, String apellido, String turno)
        {
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

        public ArrayList buscarBedel(string apellido, string turno)
        {
            
            return userDAODB.obtenerBedeles(apellido, turno);
            
        }

        //METODO PARA MODIFICAR UN BEDEL
        public void modificarBedel(string nickActual, string nick, string apellido, string nombre, string turno, string pass)
        {
            bool passmodificada = !pass.Equals("");
            
            GestorDePoliticaDeContrasenia gestorPoliticas = new GestorDePoliticaDeContrasenia();

            //Comprueba politicas de contraseña o que no haya sido modificada
            if (gestorPoliticas.comprobarPoliticas(pass) || !passmodificada)
            {
                //Comprueba que no exista el nick ingresado o que no haya sido modificada
                if (nick.Equals("") || userDAODB.comprobarNickRepetido(nick))
                {
                    Bedel bedelObt = userDAODB.obtenerBedel(nickActual);
                    //delObt.apellido = apellido;

                    Bedel bedelMod = new Bedel(bedelObt.nick, bedelObt.contrasenia, bedelObt.nombre, bedelObt.apellido, bedelObt.turno);

                    foreach (var historial in bedelMod.HistContrasenias)
                    {
                        MessageBox.Show(historial.contrasenia, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    bedelMod = this.setModificaciones(bedelMod, nick, apellido, nombre, turno, pass);

                    if (passmodificada)
                    {
                        HistContrasenia historial = new HistContrasenia(pass, bedelMod.id_usuario);
                        bedelMod.agregarHistorial(historial);
                    }

                    userDAODB.guardarBedelModificado(nickActual, bedelMod);
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

        private Bedel setModificaciones(Bedel bedelMod, string nick, string apellido, string nombre, string turno, string pass)
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

        public void eliminarBedel(string nick)
        {
            userDAODB.eliminarBedel(nick);
        }
    }
}
