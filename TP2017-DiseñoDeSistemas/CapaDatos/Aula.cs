//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aula()
        {
            this.DetalleReservas = new HashSet<DetalleReserva>();
        }
    
        public int id_aula { get; set; }
        public Nullable<bool> habilitado { get; set; }
        public int piso { get; set; }
        public Nullable<bool> aire_acond { get; set; }
        public int capacidad { get; set; }
        public Nullable<bool> canion { get; set; }
        public string tipo_pizarron { get; set; }
        public Nullable<int> id_tipo_aula { get; set; }
    
        public virtual TipoAula TipoAula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReserva> DetalleReservas { get; set; }
    }
}
