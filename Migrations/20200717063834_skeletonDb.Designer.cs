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
    [Migration("20200717063834_skeletonDb")]
    partial class skeletonDb
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Etkiket");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("SelenYapayZekaGit.DAL.Classes.Urun", b =>
                {
                    b.HasOne("SelenYapayZekaGit.DAL.Classes.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId");
                });
#pragma warning restore 612, 618
        }
    }
}
