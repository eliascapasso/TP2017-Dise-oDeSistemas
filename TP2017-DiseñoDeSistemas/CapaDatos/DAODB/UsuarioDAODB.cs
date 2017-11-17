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
            Bedel bedelObtenido = new Bedel();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from usuario in bd.Usuarios where usuario.nick.Equals(nickActual) select usuario;

                foreach (Bedel bedel in bedeles)
                {
                    bedelObtenido = bedel;
                }
            }
            return bedelObtenido;
        }

        //METODO PARA GUARDAR UN BEDEL CUANDO ES MODIFICADO
        public void guardarBedelModificado(string nickActual, Bedel bedelMod)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from bedel in bd.Usuarios where bedel.nick.Equals(nickActual) select bedel;

                foreach (Bedel bedel in bedeles)
                {
                    bedel.nick = bedelMod.nick;
                    bedel.nombre = bedelMod.nombre;
                    bedel.apellido = bedelMod.apellido;
                    bedel.contrasenia = bedelMod.contrasenia;
                    bedel.HistContrasenias = bedelMod.HistContrasenias;
                    bedel.turno = bedelMod.turno;
                }
                try
                {
                    bd.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.Write("ERROR: No se pudieron guardar los cambios en la base de datos");
                }
            }
        }

        public bool comprobarNickRepetido(string nick)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                var query = (from usuario in bd.Usuarios where usuario.nick == nick select nick).Count();

                return (query == 0);
            }
        }

        //METODO PARA GUARDAR UN BEDEL EN EL MOMENTO DE REGISTRARLO
        public void guardarBedel(Bedel bedel)
        {
             using (var bd = new TP2017Entities())
             {
                bd.Usuarios.Add(bedel);

                try
                {
                    bd.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.Write("ERROR: No se pudieron guardar los cambios en la base de datos");
                }
                
             }
        }
    }
}
