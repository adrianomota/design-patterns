using DataAccessObject.EntityConfiguration;
using DataAccessObject.Model;
using System.Data.Entity;

namespace DataAccessObject
{
    //DAO - PAdrão da Sun(2005)
    //è um padrão de projeto de acesso a dados

    public sealed class ConnectionContext : DbContext
    {
        public ConnectionContext() : base("DAOContext"){}

        public IDbSet<Contato> Contato { get; set; }
        public IDbSet<EstadoCivil> EstadoCivil { get; set; }
        public IDbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new EstadoCivilConfiguration());
            modelBuilder.Configurations.Add(new SexoConfiguration());
        }
    }
}
