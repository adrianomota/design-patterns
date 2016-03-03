using System.Data.Entity;
using ActiveRecord.Model.Context.EntityConfiguration;

namespace ActiveRecord.Model.Properties.Context
{
    public sealed class ActiveRecordContext:DbContext
    {
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<EstadoCivil> EstadoCilvil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new SexoConfiguration());
            modelBuilder.Configurations.Add(new EstadoCivilConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}