namespace CapaDatos.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Reserva = new HashSet<Reserva>();
        }

        [Key]
        public int id_usuario { get; set; }

        public bool? activo { get; set; }

        [Required]
        [StringLength(10)]
        public string nick { get; set; }

        [Required]
        [StringLength(20)]
        public string contrasenia { get; set; }

        [StringLength(20)]
        public string nombre { get; set; }

        [StringLength(20)]
        public string apellido { get; set; }

        public int? id_tipo_usuario { get; set; }

        public int? id_tipo_turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }

        public virtual TipoTurno TipoTurno { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
