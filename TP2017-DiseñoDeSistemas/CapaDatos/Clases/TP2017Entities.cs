namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class TP2017Entities : DbContext
    {
        public virtual DbSet<Bedel> Bedeles { get; set; }
    }
}
