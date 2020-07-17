﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelenYapayZekaGit.DAL;

namespace SelenYapayZekaGit.Migrations
{
    [DbContext(typeof(SelenDB))]
    [Migration("20200717183503_resimUrl2")]
    partial class resimUrl2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Etiket", b =>
                {
                    b.Property<int>("EtiketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EtiketId");

                    b.ToTable("Etkiket");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IncelemeAdet")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.UrunEtkiket", b =>
                {
                    b.Property<int>("EtkiketId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("EtkiketId", "UrunId");

                    b.HasIndex("UrunId");

                    b.ToTable("UrunEtiket");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Urun", b =>
                {
                    b.HasOne("SelenYapayZekaGit.DAL.Classes.Kategori", "Kategori")
                        .WithMany("Urun")
                        .HasForeignKey("KategoriId");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.UrunEtkiket", b =>
                {
                    b.HasOne("SelenYapayZekaGit.DAL.Classes.Etiket", "Etiket")
                        .WithMany("UrunEtiket")
                        .HasForeignKey("EtkiketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SelenYapayZekaGit.DAL.Classes.Urun", "Urun")
                        .WithMany("UrunEtiket")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
