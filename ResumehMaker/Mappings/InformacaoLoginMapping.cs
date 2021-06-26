using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumehMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.Mappings
{
    public class InformacaoLoginMapping : IEntityTypeConfiguration<InformacaoLogin>
    {
        public void Configure(EntityTypeBuilder<InformacaoLogin> builder)
        {
            builder.HasKey(i => i.InformacaoLoginId);
            
            builder.Property(i => i.EnderecoIP).IsRequired();
            builder.Property(i => i.Horario).IsRequired();
            builder.Property(i => i.Data).IsRequired();

            builder.HasOne(i => i.Usuario).WithMany(i => i.InformacoesLogin).HasForeignKey(i => i.UsuarioId);

            builder.ToTable("InformacoesLogin");
        }
    }
}
