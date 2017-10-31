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
        public UsuarioDAODB(){}

        public bool comprobarNickRepetido(string nick)
        {
            //Debe revisar que el nick no esta repetido en la BD
            using (TP2017 bd = new TP2017())
            {
                var query = (from Usuario in bd.Usuario where Usuario.nick == nick select nick).Count();
                if (query == 0)
                    return true;
                else
                    return false;
            }
        }

        public void guardarBedel(Usuario bedel)
        {
            var db = new TP2017();
            using (db)
            {
                //Aca va el agregar en la db, en los corchetes van todos los datos excepto el id
                db.Usuario.Add(bedel);
                db.SaveChanges();
            }

        }

    }
}
