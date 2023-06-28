﻿// <auto-generated />
using AlbumApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlbumApi.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20230627232806_opa")]
    partial class opa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AlbumApi.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Banda")
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("album");
                });

            modelBuilder.Entity("AlbumApi.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Musica");
                });

            modelBuilder.Entity("AlbumApi.Models.Musica", b =>
                {
                    b.HasOne("AlbumApi.Models.Album", null)
                        .WithMany("Musicas")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlbumApi.Models.Album", b =>
                {
                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}