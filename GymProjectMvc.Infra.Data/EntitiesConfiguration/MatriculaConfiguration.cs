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
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Codigo).IsUnique();
            builder.Property(x => x.Codigo).IsRequired();
            builder.Property(x => x.DataPagamento).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Plano).WithMany(x => x.Matriculas).HasForeignKey(x => x.PlanoId);
            builder.HasOne(x => x.Aluno).WithOne(x => x.Matricula).HasForeignKey<Aluno>(x => x.MatriculaId);


        }
    }
}
