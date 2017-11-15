using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class HistContraseniaDAODB
    {
        public HistContraseniaDAODB() { }

        public TP2017 db = new TP2017();

        /*public void guardarHistorialContrasenia(Usuario bedel)
        {

            using (db)
            {
                //Aca va el agregar en la db, en los corchetes van todos los datos excepto el id
                db.HistContrasenia.Add(new HistContrasenia() { id_usuario = bedel.id_usuario,
                                                               contrasenia =bedel.contrasenia,
                                                               fecha_creacion=DateTime.Now});
                db.SaveChanges();
            }

        }*/
    }
}

