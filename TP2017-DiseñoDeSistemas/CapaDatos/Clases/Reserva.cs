namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class Reserva
    {
        public Reserva(Bedel bedel, string tipoReserva, int cantAlumnos, Docente docente, Asignatura asignatura, DateTime fechaReserva)
        {
            this.Bedel_id_usuario = bedel.id_usuario;
            this.tipo_reserva = tipoReserva;
            this.capacidad = cantAlumnos;
            this.id_docente = docente.id_docente;
            this.id_asignatura = asignatura.id_asignatura;
            this.DetalleReservas = new HashSet<DetalleReserva>();
            this.activa = true;
            this.fechaReserva = fechaReserva;
        }

        public void agregarDetalle(DetalleReserva detalleReserva)
        {
            this.DetalleReservas.Add(detalleReserva);
        }
    }
}
