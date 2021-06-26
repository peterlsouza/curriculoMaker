using Microsoft.EntityFrameworkCore;
using ResumehMaker.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<TipoCurso> TiposCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacoesAcademicas { get; set; }
        public DbSet<Objetivo> Objetivos{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InformacaoLogin> InformacoesLogin { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciasProfissionais { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CurriculoMapping());
            modelBuilder.ApplyConfiguration(new ExperienciaProfissionalMapping());
            modelBuilder.ApplyConfiguration(new FormacaoAcademicaMapping());
            modelBuilder.ApplyConfiguration(new IdiomaMapping());
            modelBuilder.ApplyConfiguration(new InformacaoLoginMapping());
            modelBuilder.ApplyConfiguration(new ObjetivoMapping());
            modelBuilder.ApplyConfiguration(new TipoCursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }

    }
}
