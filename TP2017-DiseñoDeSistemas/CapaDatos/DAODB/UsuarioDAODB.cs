using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class UsuarioDAODB
    {
        public UsuarioDAODB() { }


       public bool comprobarNickRepetido(string nick)
        {
            /*Debe revisar que el nick no esta repetido en la BD
            using ( TP2017 bd = new TP2017())
            {
                var query = (from Usuario in bd.Usuarios where Usuario.nick == nick select nick).Count();
                if (query == 0)
                    return true;
                else
                    return false;
            }*/
            return false;
        }

        public void guardarBedel(Usuario bedel)
        {

            /* using (var bd = new TP2017())
             {
                 bd.Usuarios.Add(bedel);
                 bd.SaveChanges();
                 //Aca manda el bedel a guardar el nuevo historial contrasenia
                 /*HistContraseniaDAODB hc = new HistContraseniaDAODB();
                 hc.guardarHistorialContrasenia(bedel);
             }*/
        }
    }
}
