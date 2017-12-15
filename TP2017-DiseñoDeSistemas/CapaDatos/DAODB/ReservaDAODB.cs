﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReservaDAODB
    {
        public ReservaDAODB() { }

        public HashSet<Aula> obtenerAulasOcupadas(string fechaReserva, string horaInicio, string duaracion)
        {
            HashSet<Aula> aulasOcupadas = new HashSet<Aula>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                var aulas = from DetalleReserva in bd.DetalleReservas
                            where DetalleReserva.dia.Equals(fechaReserva) 
                            && DetalleReserva.hora_inicio.Equals(horaInicio) 
                            && DetalleReserva.duracion.Equals(duaracion)
                            select DetalleReserva.Aula;
                //TODO: Descomentar una vez que ya se haya guardado un detalleReserva
                //foreach (DetalleReserva detalle in bd.DetalleReservas)
                //{
                //    if (detalle.dia.Equals(fechaReserva)
                //            && detalle.hora_inicio.Equals(horaInicio)
                //            && detalle.duracion.Equals(duaracion))
                //    {
                //        aulasOcupadas.Add(detalle.Aula);
                //    }
                //}
            }
            return aulasOcupadas;
        }

        public void guardarReserva(Reserva reserva)
        {
            using (TP2017Entities bd = new TP2017Entities())
            {
                bd.Reservas.Add(reserva);

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
    }
}
