using GymProjectMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectMvc.Infra.Data.EntitiesConfiguration
{
    public class PlanoConfiguration : IEntityTypeConfiguration<Plano>
    {
        public void Configure(EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Valor).HasPrecision(12, 2).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            //builder.HasMany(x => x.Matriculas).WithOne(x => x.Plano).HasForeignKey(x => x.PlanoId);
        }
    }
}
