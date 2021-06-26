﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumehMaker.Models;

namespace ResumehMaker.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210626185237_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResumehMaker.Models.Curriculo", b =>
                {
                    b.Property<int>("CurriculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CurriculoId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Curriculos");
                });

            modelBuilder.Entity("ResumehMaker.Models.ExperienciaProfissional", b =>
                {
                    b.Property<int>("ExperienciaProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFim")
                        .HasColumnType("int");

                    b.Property<int>("AnoInicio")
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CurriculoId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoAtividades")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ExperienciaProfissionalId");

                    b.HasIndex("CurriculoId");

                    b.ToTable("ExperienciasProfissionais");
                });

            modelBuilder.Entity("ResumehMaker.Models.FormacaoAcademica", b =>
                {
                    b.Property<int>("FormacacaoAcademicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFim")
                        .HasColumnType("int");

                    b.Property<int>("AnoInicio")
                        .HasColumnType("int");

                    b.Property<int>("CurriculoId")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TipoCursoId")
                        .HasColumnType("int");

                    b.HasKey("FormacacaoAcademicaId");

                    b.HasIndex("CurriculoId");

                    b.HasIndex("TipoCursoId");

                    b.ToTable("FormacoesAcademicas");
                });

            modelBuilder.Entity("ResumehMaker.Models.Idioma", b =>
                {
                    b.Property<int>("IdiomaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurriculoId")
                        .HasColumnType("int");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("NivelIdiomaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdiomaId");

                    b.HasIndex("CurriculoId");

                    b.HasIndex("NivelIdiomaId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Idiomas");
                });

            modelBuilder.Entity("ResumehMaker.Models.InformacaoLogin", b =>
                {
                    b.Property<int>("InformacaoLoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("InformacaoLoginId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InformacoesLogin");
                });

            modelBuilder.Entity("ResumehMaker.Models.NivelIdioma", b =>
                {
                    b.Property<int>("NivelIdiomaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nivel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NivelIdiomaId");

                    b.ToTable("NiveisIdiomas");
                });

            modelBuilder.Entity("ResumehMaker.Models.Objetivo", b =>
                {
                    b.Property<int>("ObjetivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurriculoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("ObjetivoId");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("ResumehMaker.Models.TipoCurso", b =>
                {
                    b.Property<int>("TipoCursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TipoCursoId");

                    b.HasIndex("Tipo")
                        .IsUnique();

                    b.ToTable("TipoCursos");
                });

            modelBuilder.Entity("ResumehMaker.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UsuarioId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ResumehMaker.Models.Curriculo", b =>
                {
                    b.HasOne("ResumehMaker.Models.Usuario", "Usuario")
                        .WithMany("Curriculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumehMaker.Models.ExperienciaProfissional", b =>
                {
                    b.HasOne("ResumehMaker.Models.Curriculo", "Curriculo")
                        .WithMany("ExperienciasProfissionais")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumehMaker.Models.FormacaoAcademica", b =>
                {
                    b.HasOne("ResumehMaker.Models.Curriculo", "Curriculo")
                        .WithMany("FormacoesAcademicas")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumehMaker.Models.TipoCurso", "TipoCurso")
                        .WithMany("FormacoesAcademicas")
                        .HasForeignKey("TipoCursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumehMaker.Models.Idioma", b =>
                {
                    b.HasOne("ResumehMaker.Models.Curriculo", "Curriculo")
                        .WithMany("Idiomas")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumehMaker.Models.NivelIdioma", "NivelIdioma")
                        .WithMany("Idiomas")
                        .HasForeignKey("NivelIdiomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumehMaker.Models.InformacaoLogin", b =>
                {
                    b.HasOne("ResumehMaker.Models.Usuario", "Usuario")
                        .WithMany("InformacoesLogin")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumehMaker.Models.Objetivo", b =>
                {
                    b.HasOne("ResumehMaker.Models.Curriculo", "Curriculo")
                        .WithMany("Objetivos")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
