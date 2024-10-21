﻿// <auto-generated />
using System;
using M2DB_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M2DB_WebApp.Migrations
{
    [DbContext(typeof(AlkoholContext))]
    partial class AlkoholContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("M2DB_WebApp.Models.Alkohol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AlkoholFok")
                        .HasColumnType("double");

                    b.Property<int?>("AlkoholID")
                        .HasColumnType("int");

                    b.Property<int>("Ar")
                        .HasColumnType("int");

                    b.Property<int>("GyartoId")
                        .HasColumnType("int");

                    b.Property<int>("KategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Urtartalom")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.HasIndex("AlkoholID");

                    b.HasIndex("GyartoId");

                    b.HasIndex("KategoriaID");

                    b.ToTable("Alkohols");
                });

            modelBuilder.Entity("M2DB_WebApp.Models.Gyarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cim")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("SzarmazasiHely")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Gyartos");
                });

            modelBuilder.Entity("M2DB_WebApp.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Leiras")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Kategorias");
                });

            modelBuilder.Entity("M2DB_WebApp.Models.Alkohol", b =>
                {
                    b.HasOne("M2DB_WebApp.Models.Alkohol", null)
                        .WithMany("Alkohols")
                        .HasForeignKey("AlkoholID");

                    b.HasOne("M2DB_WebApp.Models.Gyarto", "Gyarto")
                        .WithMany()
                        .HasForeignKey("GyartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M2DB_WebApp.Models.Kategoria", "Kategoria")
                        .WithMany()
                        .HasForeignKey("KategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gyarto");

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("M2DB_WebApp.Models.Alkohol", b =>
                {
                    b.Navigation("Alkohols");
                });
#pragma warning restore 612, 618
        }
    }
}
