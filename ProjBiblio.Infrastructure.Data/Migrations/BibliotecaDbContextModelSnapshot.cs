﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjBiblio.Infrastructure.Data.Context;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    partial class BibliotecaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("AutorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("AutorID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Carrinho", b =>
                {
                    b.Property<long>("CarrinhoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("EmprestimoID")
                        .HasColumnType("integer");

                    b.Property<int>("LivroID")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<string>("SessionUserID")
                        .HasColumnType("text");

                    b.HasKey("CarrinhoID");

                    b.HasIndex("LivroID");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DataDevolucao")
                        .HasColumnType("text");

                    b.Property<string>("DataFim")
                        .HasColumnType("text");

                    b.Property<string>("DataInicio")
                        .HasColumnType("text");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("integer");

                    b.HasKey("EmprestimoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Genero", b =>
                {
                    b.Property<int>("GeneroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("GeneroID");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<int>("Edicao")
                        .HasColumnType("integer");

                    b.Property<string>("Editora")
                        .HasColumnType("text");

                    b.Property<string>("Foto")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<int?>("GeneroID")
                        .HasColumnType("integer");

                    b.Property<int>("Paginas")
                        .HasColumnType("integer");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasKey("LivroID");

                    b.HasIndex("GeneroID");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroAutor", b =>
                {
                    b.Property<int>("AutorID")
                        .HasColumnType("integer");

                    b.Property<int>("LivroID")
                        .HasColumnType("integer");

                    b.HasKey("AutorID", "LivroID");

                    b.HasIndex("LivroID");

                    b.ToTable("LivroAutor");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroEmprestimo", b =>
                {
                    b.Property<int>("LivroID")
                        .HasColumnType("integer");

                    b.Property<int>("EmprestimoID")
                        .HasColumnType("integer");

                    b.HasKey("LivroID", "EmprestimoID");

                    b.HasIndex("EmprestimoID");

                    b.ToTable("LivroEmprestimo");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroMarketing", b =>
                {
                    b.Property<int>("LivroID")
                        .HasColumnType("integer");

                    b.Property<int>("MarketingID")
                        .HasColumnType("integer");

                    b.HasKey("LivroID", "MarketingID");

                    b.HasIndex("MarketingID");

                    b.ToTable("LivroMarketing");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Marketing", b =>
                {
                    b.Property<int>("MarketingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DataFim")
                        .HasColumnType("text");

                    b.Property<string>("DataInicio")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<double?>("PercentualDesconto")
                        .HasColumnType("double precision");

                    b.HasKey("MarketingID");

                    b.ToTable("Marketing");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Carrinho", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Emprestimo", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.Livro", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroID");
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroAutor", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Autor", "Autor")
                        .WithMany("LivAutor")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjBiblio.Domain.Entities.Livro", "Livro")
                        .WithMany("LivAutor")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroEmprestimo", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Emprestimo", "Emprestimo")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("EmprestimoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjBiblio.Domain.Entities.Livro", "Livro")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjBiblio.Domain.Entities.LivroMarketing", b =>
                {
                    b.HasOne("ProjBiblio.Domain.Entities.Livro", "Livro")
                        .WithMany("LivMarketing")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjBiblio.Domain.Entities.Marketing", "Marketing")
                        .WithMany("LivMarketing")
                        .HasForeignKey("MarketingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
