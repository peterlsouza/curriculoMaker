using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumehMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.Mappings
{
    public class TipoCursoMapping : IEntityTypeConfiguration<TipoCurso>
    {
        public void Configure(EntityTypeBuilder<TipoCurso> builder)
        {
            builder.HasKey(tc => tc.TipoCursoId);

            builder.Property(tc => tc.Tipo).IsRequired();
            builder.HasIndex(tc => tc.Tipo).IsUnique();

            builder.HasMany(tc => tc.FormacoesAcademicas).WithOne(tc => tc.TipoCurso).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("TipoCursos");
        }
    }
}
