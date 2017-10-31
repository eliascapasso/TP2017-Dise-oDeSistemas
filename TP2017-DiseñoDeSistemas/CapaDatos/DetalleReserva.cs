namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleReserva")]
    public partial class DetalleReserva
    {
        [Key]
        public int id_detalle_reserva { get; set; }

        public int? id_dia { get; set; }

        public int? id_reserva { get; set; }

        public int? id_aula { get; set; }

        public TimeSpan? hora_inicio { get; set; }

        public TimeSpan? duracion { get; set; }

        public virtual Aula Aula { get; set; }

        public virtual Dia Dia { get; set; }

        public virtual Reserva Reserva { get; set; }
    }
}
