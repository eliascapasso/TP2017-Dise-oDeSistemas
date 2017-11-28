using System;
using Excepciones;
using CapaDatos;
using System.Windows.Forms;
using System.Collections;
using CapaClases;

namespace CapaLogica
{
    public class GestorDeUsuario
    {
        private UsuarioDAODB userDAODB;
        GestorDePoliticaDeContrasenia gestorPoliticas = new GestorDePoliticaDeContrasenia();

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

        //METODO PARA BUSCAR BEDELES
        public ArrayList buscarBedel(string apellido, string turno)
        {
            ArrayList bedeles = userDAODB.obtenerBedeles(apellido, turno);
            ArrayList bedelesDTO = new ArrayList();

            foreach (Bedel bedel in bedeles)
            {
                bedelesDTO.Add(new BedelDTO(bedel.nick, bedel.contrasenia, bedel.nombre, bedel.apellido, bedel.turno));
            }

            return bedelesDTO;
        }

        //METODO PARA VERIFICAR SI EXISTE UN BEDEL CON EL NICK Y PASS INGRESADOS
        public bool existeBedel(string nick, string pass)
        {
            return userDAODB.existeBedel(nick, pass);
        }

        //METODO PARA MODIFICAR UN BEDEL
        public void modificarBedel(BedelDTO bedelSeleccionado, string apellido, string nombre, string turno, string pass)
        {
            bool passModificada = !pass.Equals(bedelSeleccionado.contrasenia);
            
            

            //Comprueba politicas de contraseña o que no haya sido modificada
            if (!passModificada || gestorPoliticas.comprobarPoliticas(pass))
            {
                Bedel bedelObt = userDAODB.obtenerBedel(bedelSeleccionado.nick);

                bedelObt.setValores(nombre, apellido, turno, pass);

                if (passModificada)
                {
                    HistContrasenia historial = new HistContrasenia(pass, bedelObt.id_usuario);
                    bedelObt.agregarHistorial(historial);
                }

                userDAODB.guardarBedelModificado(bedelObt);
            }
            else
            {
                throw new PoliticasContraseniaException();
            }
        }

        //METODO PARA ELIMINAR UN BEDEL
        public void eliminarBedel(string nick)
        {
            userDAODB.eliminarBedel(nick);
        }
    }
}
