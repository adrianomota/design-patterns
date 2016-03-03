using System.Data.Entity;
using ActiveRecord.Model.Context.EntityConfiguration;

namespace ActiveRecord.Model.Context
{
    public sealed class ActiveRecordContext:DbContext
    {
        public ActiveRecordContext():base("ActiveRecordCOnnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<Contato> Contato { get; set; }
        public IDbSet<EstadoCivil> EstadoCivil { get; set; }
        public IDbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new EstadoCivilConfiguration());
            modelBuilder.Configurations.Add(new SexoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}