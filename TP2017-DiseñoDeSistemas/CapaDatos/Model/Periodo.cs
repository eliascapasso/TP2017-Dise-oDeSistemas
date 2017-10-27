namespace CapaDatos.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Periodo")]
    public partial class Periodo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Periodo()
        {
            Dia = new HashSet<Dia>();
        }

        [Key]
        public int id_periodo { get; set; }

        public int? id_tipo_periodo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_fin { get; set; }

        public int? id_anio_lectivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dia> Dia { get; set; }

        public virtual TipoPeriodo TipoPeriodo { get; set; }

        public virtual AnioLectivo AnioLectivo { get; set; }


    }
}
