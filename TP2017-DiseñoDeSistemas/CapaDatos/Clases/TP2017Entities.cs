namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class TP2017Entities : DbContext
    {
        public virtual DbSet<Bedel> Bedeles { get; set; }
        public virtual DbSet<AulaInformatica> AulasInformatica { get; set; }
        public virtual DbSet<AulaMultimedios> AulasMultimedios { get; set; }
        public virtual DbSet<AulaSinRecursosAdicionales> AulasSinRecursosAdicionales { get; set; }
    }
}
