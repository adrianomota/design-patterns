using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataAccessObject.Model;

namespace DataAccessObject.EntityConfiguration
{
    public class EstadoCivilConfiguration:EntityTypeConfiguration<EstadoCivil>
    {
        public EstadoCivilConfiguration()
        {
            HasKey(k => k.Codigo);
            Property(p => p.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
            ToTable("TB_ESTADO_CIVIL");
        }    
    }
}