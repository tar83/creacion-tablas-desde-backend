﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using taffur_limones.Models;

#nullable disable

namespace taffur_limones.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230606195429_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("taffur_limones.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("taffur_limones.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("generoId")
                        .HasColumnType("int");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("generoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("taffur_limones.Models.Usuario", b =>
                {
                    b.HasOne("taffur_limones.Models.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("generoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genero");
                });
#pragma warning restore 612, 618
        }
    }
}
