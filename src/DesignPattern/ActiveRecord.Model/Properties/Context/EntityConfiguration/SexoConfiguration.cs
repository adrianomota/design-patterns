﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ActiveRecord.Model.Context.EntityConfiguration
{
    public sealed class SexoConfiguration : EntityTypeConfiguration<Sexo>
    {
        public SexoConfiguration()
        {
            HasKey(k => k.Codigo);
            Property(p => p.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("TB_SEXO");
        }
    }
}