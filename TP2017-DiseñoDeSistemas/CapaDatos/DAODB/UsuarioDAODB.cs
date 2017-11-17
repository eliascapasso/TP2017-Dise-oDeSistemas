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

        public Bedel obtenerBedel(string nickActual)
        {
            Bedel bedelRetornado = new Bedel();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach (Bedel bedel in bd.Usuarios)
                {
                    if (bedel.nick.Equals(nickActual))
                    {
                        bedelRetornado = bedel;
                    }
                }
            }
            return bedelRetornado;
        }

        public void guardarBedelModificado(string nickActual, Bedel bedelMod, Bedel bedelActual)
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
                var query = (from usuario in bd.Usuarios where usuario.nick == nick select nick).Count();
                if (query == 0)
                    return true;
                else
                    return false;
            }
        }

        public void guardarBedel(Bedel bedel)
        {
             using (var bd = new TP2017Entities())
             {
                 bd.Usuarios.Add(bedel);
                 bd.SaveChanges();
             }
        }
    }
}
