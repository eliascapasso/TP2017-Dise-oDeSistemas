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

        //OBTIENE UNA LISTA DE BEDELES
        public ArrayList obtenerBedeles(string apellido, string turno)
        {
            ArrayList bedelesObtenidos = new ArrayList();

            using (TP2017Entities bd = new TP2017Entities())
            {
                //Se ingresó apellido y turno como criterio de busqueda
                if (!apellido.Equals("") && !turno.Equals(""))
                {
                    foreach (Bedel bedel in bd.Bedeles)
                    {
                        if(bedel.apellido.Equals(apellido) && bedel.turno.Equals(turno))
                        {
                            bedelesObtenidos.Add(bedel);
                        }
                    }
                }
                //Se ingresó solo apellido como criterio de busqueda
                else if (!apellido.Equals("") && turno.Equals(""))
                {
                    foreach (Bedel bedel in bd.Bedeles)
                    {
                        if (bedel.apellido.Equals(apellido))
                        {
                            bedelesObtenidos.Add(bedel);
                        }
                    }
                }
                //Se ingresó solo turno como criterio de busqueda
                else if (apellido.Equals("") && !turno.Equals(""))
                {
                    foreach (Bedel bedel in bd.Bedeles)
                    {
                        if (bedel.turno.Equals(turno))
                        {
                            bedelesObtenidos.Add(bedel);
                        }
                    }
                }
                else
                {
                    foreach (Bedel bedel in bd.Bedeles)
                    {
                        bedelesObtenidos.Add(bedel);
                    }
                }
            }
            return bedelesObtenidos;
        }

        //OBTIENE UN SOLO BEDEL 
        public Bedel obtenerBedel(string nickActual)
        {
            Bedel bedelObtenido = new Bedel();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from usuario in bd.Bedeles where usuario.nick.Equals(nickActual) select usuario;

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
                var bedeles = from bedel in bd.Bedeles where bedel.nick.Equals(nickActual) select bedel;

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
                bd.Bedeles.Add(bedel);

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

        public void eliminarBedel(string nick)
        {
            using (var bd = new TP2017Entities())
            {
                foreach (Bedel bedel in bd.Usuarios)
                {
                    if (bedel.nick.Equals(nick))
                    {
                        bd.Usuarios.Remove(bedel);
                    }
                }

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
