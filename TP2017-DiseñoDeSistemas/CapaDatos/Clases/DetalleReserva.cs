namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class DetalleReserva
    {
        public DetalleReserva() { }
        
        public DetalleReserva(TimeSpan? hora_inicio, TimeSpan? duracion, string dia, Aula aula, Reserva reserva)
        {
            this.dia = dia;
            this.id_aula = aula.id_aula;
            this.id_reserva = reserva.id_reserva;
            this.hora_inicio = hora_inicio;
            this.duracion = duracion;
        }
    }
}