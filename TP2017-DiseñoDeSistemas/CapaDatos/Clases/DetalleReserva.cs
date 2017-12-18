namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class DetalleReserva
    {
        public DetalleReserva() { }

        public DetalleReserva(TimeSpan? hora_inicio, TimeSpan? duracion, string dia, DateTime fecha, Aula aula, Reserva reserva, int idCuatrimestre)
        {
            this.Cuatrimestre_id_cuatrimestre = idCuatrimestre;
            this.fecha = fecha;
            this.dia = dia;
            this.Aula_id_aula = aula.id_aula;
            this.Reserva_id_reserva = reserva.id_reserva;
            this.hora_inicio = hora_inicio;
            this.duracion = duracion;
        }
    }
}