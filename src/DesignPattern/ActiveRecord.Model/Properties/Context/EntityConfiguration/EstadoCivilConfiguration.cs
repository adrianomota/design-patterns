using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ActiveRecord.Model.Context.EntityConfiguration
{
    public sealed class EstadoCivilConfiguration:EntityTypeConfiguration<EstadoCivil>
    {
        public EstadoCivilConfiguration()
        {
            HasKey(k => k.Codigo);
            Property(p => p.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("TB_ESTADO_CIVIL");
        }
    }
}