namespace CapaDatos.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistContrasenia")]
    public partial class HistContrasenia
    {
        [Key]
        public int id_historial { get; set; }

        [StringLength(20)]
        public string contrasenia { get; set; }

        public int? id_usuario { get; set; }

        public DateTime? fecha_creacion { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
