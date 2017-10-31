namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reserva")]
    public partial class Reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserva()
        {
            DetalleReserva = new HashSet<DetalleReserva>();
        }

        [Key]
        public int id_reserva { get; set; }

        public TimeSpan? hora_inicio { get; set; }

        public int? capacidad { get; set; }

        public bool? activa { get; set; }

        public int? id_usuario { get; set; }

        public int? id_asignatura { get; set; }

        public int? id_tipo_reserva { get; set; }

        public int? id_docente { get; set; }

        public virtual Asignatura Asignatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReserva> DetalleReserva { get; set; }

        public virtual Docente Docente { get; set; }

        public virtual TipoReserva TipoReserva { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
