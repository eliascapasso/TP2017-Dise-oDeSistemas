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
    
    public partial class DetalleReserva
    {
        public int id_detalle_reserva { get; set; }
        public Nullable<int> id_dia { get; set; }
        public Nullable<int> id_reserva { get; set; }
        public Nullable<int> id_aula { get; set; }
        public Nullable<System.TimeSpan> hora_inicio { get; set; }
        public Nullable<System.TimeSpan> duracion { get; set; }
    
        public virtual Aula Aula { get; set; }
        public virtual Dia Dia { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
