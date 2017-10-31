namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula")]
    public partial class Aula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aula()
        {
            DetalleReserva = new HashSet<DetalleReserva>();
        }

        [Key]
        public int id_aula { get; set; }

        public bool? habilitado { get; set; }

        public int piso { get; set; }

        public bool? aire_acond { get; set; }

        public int capacidad { get; set; }

        public bool? ventilador { get; set; }

        public int? cant_pc { get; set; }

        public bool? canion { get; set; }

        public bool? dvd { get; set; }

        public bool? tv { get; set; }

        public bool? pc { get; set; }

        public int? id_tipo_pizarron { get; set; }

        public int? id_tipo_aula { get; set; }

        public virtual TipoAula TipoAula { get; set; }

        public virtual TipoPizarron TipoPizarron { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReserva> DetalleReserva { get; set; }
    }
}
