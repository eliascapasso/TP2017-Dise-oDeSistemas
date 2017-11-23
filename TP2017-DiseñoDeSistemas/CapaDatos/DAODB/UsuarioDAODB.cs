namespace CapaDatos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

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

        //OBTIENE UN SOLO BEDEL 
        public Bedel obtenerBedel(string nickActual)
        {
            HistContraseniaDAODB histDAO = new HistContraseniaDAODB();
            Bedel bedelObtenido = new Bedel();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var bedeles = from usuario in bd.Bedeles where usuario.nick.Equals(nickActual) select usuario;
                
                foreach (var bedel in bedeles)
                {
                    bedelObtenido = bedel;

                    //bedel.HistContrasenias = histDAO.obtenerHistorial(bedel);
                }
            }
            return bedelObtenido;
        }

        //METODO PARA GUARDAR UN BEDEL MODIFICADO
        public void guardarBedelModificado(Bedel bedel)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {    
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

        public void modificarBedel(BedelDTO bedelSeleccionado, string apellido, string nombre, string turno, string pass, bool passModificada)
        {
            using (var bd = new TP2017Entities())
            {
                var bedeles = (from usuario in bd.Bedeles where usuario.nick.Equals(bedelSeleccionado.nick) select usuario);

                foreach (var bedel in bedeles)
                {
                    bedel.setValores(nombre,apellido,turno,pass);

                    if (passModificada)
                    {
                        HistContrasenia historial = new HistContrasenia(pass, bedel.id_usuario);
                        bedel.agregarHistorial(historial);
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
                    where HistContrasenia.id_usuario == bedel.id_usuario
                    select HistContrasenia;

                    foreach (HistContrasenia hist in historiales)
                    {
                        bd.HistContrasenias.Remove(hist);
                    }
                    bd.Bedeles.Remove(bedel);
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
