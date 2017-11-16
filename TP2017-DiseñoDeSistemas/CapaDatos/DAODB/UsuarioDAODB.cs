namespace CapaDatos
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UsuarioDAODB
    {
        public UsuarioDAODB() { }

        //Para la busqueda de un bedel
        public ArrayList obtenerBedeles(string ap, string tur)
        {
            ArrayList listaUsuarios = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                if (!ap.Equals("") && !tur.Equals(""))
                {
                    foreach (Usuario usuario in bd.Usuarios)
                    {
                        if (usuario.apellido.Equals(ap) && usuario.turno.Equals(tur))
                        {
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                else if(!ap.Equals("") && tur.Equals(""))
                {
                    foreach (Usuario usuario in bd.Usuarios)
                    {
                        if (usuario.apellido.Equals(ap))
                        {
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                else if (ap.Equals("") && !tur.Equals(""))
                {
                    foreach (Usuario usuario in bd.Usuarios)
                    {
                        if (usuario.turno.Equals(tur))
                        {
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                
            }
            return listaUsuarios;
        }

        public Usuario modificarBedel(string nickActual, string nick, string apellido, string nombre, string turno, string pass)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Usuario bedel in bd.Usuarios)
                {
                    if (bedel.nick.Equals(nickActual))
                    {
                        //Falta validar que campos se dejaron vacios
                        bedel.nick = nick;
                        bedel.apellido = apellido;
                        bedel.nombre = nombre;
                        bedel.turno = turno;
                        bedel.contrasenia = pass;

                        return bedel;
                    }
                }
            }
            return null;
        }

        public bool comprobarNickRepetido(string nick)
        {
            //Debe revisar que el nick no esta repetido en la BD
            using (TP2017Entities bd = new TP2017Entities())
            {
                var query = (from Usuario in bd.Usuarios where Usuario.nick == nick select nick).Count();
                if (query == 0)
                    return true;
                else
                    return false;
            }
        }

        public void guardarBedel(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario(usuario.nick, usuario.contrasenia, usuario.nombre, usuario.apellido, usuario.turno);
            usuarioAux.HistContrasenias = usuario.HistContrasenias;

            if (usuario.id_tipo_usuario == 1){usuarioAux.id_tipo_usuario = 1;}
            else{usuarioAux.id_tipo_usuario = 2;}

             using (var bd = new TP2017Entities())
             {
                 bd.Usuarios.Add(usuarioAux);
                 bd.SaveChanges();
                 //Aca manda el bedel a guardar el nuevo historial contrasenia
                 //HistContraseniaDAODB hc = new HistContraseniaDAODB();
                 //hc.guardarHistorialContrasenia(bedel);
             }
        }
    }
}
