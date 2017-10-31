namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnioLectivo")]
    public partial class AnioLectivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnioLectivo()
        {
            Periodo = new HashSet<Periodo>();
        }

        [Key]
        public int id_anio_lectivo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_fin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodo> Periodo { get; set; }
    }
}
