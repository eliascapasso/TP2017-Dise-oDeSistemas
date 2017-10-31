namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TP2017 : DbContext
    {
        public TP2017()
            //: base("name=TP2017")
            : base("Data Source=ELIAS;Initial Catalog=TP2017; App=EntityFramework; Persist Security Info = True;Integrated Security=True ")

        {
        }

        public virtual DbSet<AnioLectivo> AnioLectivo { get; set; }
        public virtual DbSet<Asignatura> Asignatura { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<DetalleReserva> DetalleReserva { get; set; }
        public virtual DbSet<Dia> Dia { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<HistContrasenia> HistContrasenia { get; set; }
        public virtual DbSet<NombreDia> NombreDia { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoAsignatura> TipoAsignatura { get; set; }
        public virtual DbSet<TipoAula> TipoAula { get; set; }
        public virtual DbSet<TipoPeriodo> TipoPeriodo { get; set; }
        public virtual DbSet<TipoPizarron> TipoPizarron { get; set; }
        public virtual DbSet<TipoReserva> TipoReserva { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignatura>()
                .Property(e => e.nombre_asignatura)
                .IsUnicode(false);

            modelBuilder.Entity<Asignatura>()
                .HasMany(e => e.Docente)
                .WithMany(e => e.Asignatura)
                .Map(m => m.ToTable("DocenteAsignatura").MapLeftKey("id_asignatura").MapRightKey("id_docente"));

            modelBuilder.Entity<Docente>()
                .Property(e => e.nombre_docente)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.apellido_docente)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.email_docente)
                .IsUnicode(false);

            modelBuilder.Entity<HistContrasenia>()
                .Property(e => e.contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<NombreDia>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoAsignatura>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoAula>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPeriodo>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPizarron>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoReserva>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUsuario>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nick)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.turno)
                .IsUnicode(false);
        }
    }
}
