namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CapaDatos;

    public class UsuarioDAODB
    {
        public UsuarioDAODB() { }


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
