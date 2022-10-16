using MvcClimaTempo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcClimaTempo.Contexts
{
    public class MvcClimaTempoContext : DbContext
    {
        public MvcClimaTempoContext() : base("MvcClimaTempoContext")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<PrevisaoClima>()
                            .HasRequired<Cidade>(s => s.Cidade)
                            .WithMany(g => g.PrevisaoClimas)
                            .HasForeignKey<int>(s => s.CidadeId);

            modelBuilder.Entity<Cidade>()
                        .HasRequired<Estado>(s => s.Estado)
                        .WithMany(g => g.Cidades)
                        .HasForeignKey<int>(s => s.EstadoId);
        }
    }
}