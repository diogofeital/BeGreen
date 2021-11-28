﻿// <auto-generated />
using System;
using BeGreen.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeGreen.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20211127221144_PrimeiraMigration")]
    partial class PrimeiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeGreen.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lagradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("ParceiroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParceiroId");

                    b.HasIndex(new[] { "Id" }, "IX_Id_Endereco")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("BeGreen.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCadastro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IX_Id_Login")
                        .IsUnique();

                    b.ToTable("Login");
                });

            modelBuilder.Entity("BeGreen.Models.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int?>("ParceiroId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParceiroId");

                    b.HasIndex(new[] { "Id" }, "IX_Id_Oferta")
                        .IsUnique();

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("BeGreen.Models.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoLogin")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ramo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCadastro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoLogin")
                        .IsUnique();

                    b.HasIndex(new[] { "Id" }, "IX_Id_Parceiro")
                        .IsUnique();

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("BeGreen.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoLogin")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCadastro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoLogin")
                        .IsUnique();

                    b.HasIndex(new[] { "Id" }, "IX_Id_Usuario")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BeGreen.Models.Endereco", b =>
                {
                    b.HasOne("BeGreen.Models.Parceiro", "Parceiro")
                        .WithMany("Enderecos")
                        .HasForeignKey("ParceiroId");

                    b.Navigation("Parceiro");
                });

            modelBuilder.Entity("BeGreen.Models.Oferta", b =>
                {
                    b.HasOne("BeGreen.Models.Parceiro", "Parceiro")
                        .WithMany("Ofertas")
                        .HasForeignKey("ParceiroId");

                    b.Navigation("Parceiro");
                });

            modelBuilder.Entity("BeGreen.Models.Parceiro", b =>
                {
                    b.HasOne("BeGreen.Models.Login", "Login")
                        .WithOne("Parceiro")
                        .HasForeignKey("BeGreen.Models.Parceiro", "CodigoLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("BeGreen.Models.Usuario", b =>
                {
                    b.HasOne("BeGreen.Models.Login", "Login")
                        .WithOne("Usuario")
                        .HasForeignKey("BeGreen.Models.Usuario", "CodigoLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("BeGreen.Models.Login", b =>
                {
                    b.Navigation("Parceiro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeGreen.Models.Parceiro", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Ofertas");
                });
#pragma warning restore 612, 618
        }
    }
}
