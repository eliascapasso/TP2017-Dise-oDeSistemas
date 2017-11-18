namespace CapaDatos.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dia")]
    public partial class Dia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dia()
        {
            DetalleReserva = new HashSet<DetalleReserva>();
        }

        [Key]
        public int id_dia { get; set; }

        public int? id_periodo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        public int? id_nombre_dia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReserva> DetalleReserva { get; set; }

        public virtual NombreDia NombreDia { get; set; }

        public virtual Periodo Periodo { get; set; }
    }
}
