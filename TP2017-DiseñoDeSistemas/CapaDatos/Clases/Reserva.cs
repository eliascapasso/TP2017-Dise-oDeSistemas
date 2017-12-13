﻿namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class Reserva
    {
        public Reserva(Bedel bedel, string tipoReserva, int cantAlumnos, Docente docente, Asignatura asignatura)
        {
            this.id_usuario = bedel.id_usuario;
            this.tipo_reserva = tipoReserva;
            this.capacidad = cantAlumnos;
            this.id_docente = docente.id_docente;
            this.id_asignatura = asignatura.id_asignatura;
            this.DetalleReservas = new HashSet<DetalleReserva>();
            this.activa = true;
        }

        public void agregarDetalle(DetalleReserva detalleReserva)
        {
            this.DetalleReservas.Add(detalleReserva);
        }
    }
}
