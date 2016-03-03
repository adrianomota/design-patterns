using DataAccessObject.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessObject.EntityConfiguration
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            //key
            HasKey(k => k.Codigo);
            Property(p => p.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         

            //relationships
            HasRequired(t => t.EstadoCivil)
                .WithMany()
                .HasForeignKey(f => f.CodigoEstadoCivil);

            HasRequired(t => t.Sexo)
                .WithMany()
                .HasForeignKey(f => f.CodigoSexo);
                
            //tables
            ToTable("TB_CONTATO");
        }
    }
}