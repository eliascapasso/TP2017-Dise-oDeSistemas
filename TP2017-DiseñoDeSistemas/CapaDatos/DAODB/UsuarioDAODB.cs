namespace CapaDatos
{
    using CapaClases;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public class UsuarioDAODB : UsuarioDAO
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
                        if (bedel.apellido.ToLower().Contains(apellido.ToLower()))
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

        //OBTIENE UN SOLO BEDEL A TRAVEZ DE SU NICK
        public Bedel obtenerBedel(string nickActual)
        {
            Bedel bedelObtenido = new Bedel();
            HashSet<HistContrasenia> historiales = new HashSet<HistContrasenia>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from usuario in bd.Bedeles
                              where usuario.nick.Equals(nickActual)
                              select usuario;
                
                foreach (var bedel in bedeles)
                {
                    bedelObtenido = bedel;
                }

                foreach(HistContrasenia hist in bedelObtenido.HistContrasenias)
                {
                    historiales.Add(hist);
                }

                bedelObtenido.HistContrasenias = historiales;
            }
            return bedelObtenido;
        }

        //VERIFICA SI EXISTE UN USUARIO CON EL NICK Y PASS INGRESADOS
        public bool existeUsuario(string nickActual, string pass)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                var usuarios = from usuario in bd.Usuarios
                              where usuario.nick.Equals(nickActual) 
                              && usuario.contrasenia.Equals(pass)
                              select usuario;

                foreach (Usuario usuario in usuarios)
                {
                    return true;
                }
            }
            return false;
        }

        //METODO PARA GUARDAR UN BEDEL MODIFICADO
        public void guardarBedelModificado(Bedel bedel)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {    
                try
                {
                    bd.Entry(bedel).State = EntityState.Modified;

                    bd.Entry(bedel.HistContrasenias.Last()).State = EntityState.Added;

                    bd.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.Write("ERROR: No se pudieron guardar las modificaciones del bedel en la base de datos, " + e.Message);
                }
            }
        }

        //METODO PARA COMPROBAR SI EL NICK  YA EXISTE
        public bool comprobarNickRepetido(string nick)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                var query = (from usuario in bd.Usuarios
                            where usuario.nick.Equals(nick)
                            select nick).Count();

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
                    Console.Write("ERROR: No se pudieron guardar los cambios en la base de datos, " + e.Message);
                }
             }
        }

        //METODO PARA ELIMINAR UN BEDEL (no funciona)
        public void eliminarBedel(string nick)
        {
            using (var bd = new TP2017Entities())
            {
                var bedeles =
                from usuario in bd.Bedeles
                where usuario.nick.Equals(nick)
                select usuario;

                foreach (var bedel in bedeles)
                {
                    var historiales =
                    from HistContrasenia in bd.HistContrasenias
                    where HistContrasenia.Usuario_id_usuario == bedel.id_usuario
                    select HistContrasenia;

                    foreach (HistContrasenia hist in historiales)
                    {
                        bd.HistContrasenias.Remove(hist);
                    }

                    bd.Bedeles.Remove(bedel);
                    bd.Entry(bedel).State = EntityState.Deleted;
                }

                try
                {
                    bd.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
