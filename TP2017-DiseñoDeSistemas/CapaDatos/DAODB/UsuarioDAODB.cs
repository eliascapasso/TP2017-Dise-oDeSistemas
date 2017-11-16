namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UsuarioDAODB
    {
        public UsuarioDAODB() { }

        public Usuario obtenerBedel(string nickActual)
        {
            Usuario bedelRetornado = new Usuario();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Usuario bedel in bd.Usuarios)
                {
                    if (bedel.nick.Equals(nickActual))
                    {
                        bedelRetornado = bedel;
                    }
                }
            }
            return bedelRetornado;
        }

        public void guardarBedelModificado(string nickActual, Usuario bedelMod, Usuario bedelActual)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from Usuario in bd.Usuarios where Usuario.nick.Equals(nickActual) select Usuario;

                foreach (var bedel in bedeles)
                {
                    bd.Usuarios.Remove(bedel);
                }

                try
                {

                    bd.Usuarios.Add(bedelMod);
                    bd.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
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
             }
        }
    }
}
