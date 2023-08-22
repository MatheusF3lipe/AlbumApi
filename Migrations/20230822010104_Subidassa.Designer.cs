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
    [Migration("20230822010104_Subidassa")]
    partial class Subidassa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("musica");
                });

            modelBuilder.Entity("AlbumApi.Models.Musica", b =>
                {
                    b.HasOne("AlbumApi.Models.Album", "Album")
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("AlbumApi.Models.Album", b =>
                {
                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}
