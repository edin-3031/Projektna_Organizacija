﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201130101544_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.Drzava", b =>
                {
                    b.Property<int>("Drzava_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("Drzava_ID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("WebApplication1.Models.Korisnici", b =>
                {
                    b.Property<int>("Korisnici_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("text");

                    b.Property<string>("Korisnicko_Ime")
                        .HasColumnType("text");

                    b.Property<string>("Lozinka")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Prezime")
                        .HasColumnType("text");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.Property<int>("Uloge_FK")
                        .HasColumnType("int");

                    b.HasKey("Korisnici_ID");

                    b.HasIndex("Uloge_FK");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("WebApplication1.Models.Korisnici_OrganizacionaJedinica", b =>
                {
                    b.Property<int>("Korisnici_OrganizacionaJedinica_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Korisnici_FK")
                        .HasColumnType("int");

                    b.Property<int>("OrganizacionaJedinica_FK")
                        .HasColumnType("int");

                    b.Property<int?>("OrganizacionaJedinica_ID")
                        .HasColumnType("int");

                    b.HasKey("Korisnici_OrganizacionaJedinica_ID");

                    b.HasIndex("Korisnici_FK");

                    b.HasIndex("OrganizacionaJedinica_ID");

                    b.ToTable("Korisnici_OrganizacionaJedinica");
                });

            modelBuilder.Entity("WebApplication1.Models.Organizacija", b =>
                {
                    b.Property<int>("Organizacija_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .HasColumnType("text");

                    b.Property<int>("Drzava_FK")
                        .HasColumnType("int");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("PTT_FK")
                        .HasColumnType("int");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(4000)");

                    b.HasKey("Organizacija_ID");

                    b.HasIndex("Drzava_FK");

                    b.HasIndex("PTT_FK");

                    b.ToTable("Organizacija");
                });

            modelBuilder.Entity("WebApplication1.Models.OrganizacionaJedinica", b =>
                {
                    b.Property<int>("OrganizacionaJedinica_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .HasColumnType("text");

                    b.Property<int>("Drzava_FK")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("Organizacija_FK")
                        .HasColumnType("int");

                    b.Property<int>("PTT_FK")
                        .HasColumnType("int");

                    b.HasKey("OrganizacionaJedinica_ID");

                    b.HasIndex("Drzava_FK");

                    b.HasIndex("Organizacija_FK");

                    b.HasIndex("PTT_FK");

                    b.ToTable("OrganizacionaJedinica");
                });

            modelBuilder.Entity("WebApplication1.Models.PTT", b =>
                {
                    b.Property<int>("PTT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("PTT_ID");

                    b.ToTable("PTT");
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatAktivnostPlan", b =>
                {
                    b.Property<int>("ProjekatAktivnostPlan_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnType("datetime");

                    b.Property<string>("JedinicaMjere")
                        .HasColumnType("text");

                    b.Property<float>("Kolicina")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("ProjekatPlan_FK")
                        .HasColumnType("int");

                    b.Property<int?>("ProjekatPlan_ID")
                        .HasColumnType("int");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("ProjekatAktivnostPlan_ID");

                    b.HasIndex("ProjekatPlan_ID");

                    b.ToTable("ProjekatAktivnostPlan");
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatAktivnostRealizacija", b =>
                {
                    b.Property<int>("ProjekatAktivnostRealizacija_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<float>("Kolicina")
                        .HasColumnType("float");

                    b.Property<int>("Korisnici_FK")
                        .HasColumnType("int");

                    b.Property<int?>("Korisnici_ID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("text");

                    b.Property<int>("ProjekatAktivnostPlan_FK")
                        .HasColumnType("int");

                    b.HasKey("ProjekatAktivnostRealizacija_ID");

                    b.HasIndex("Korisnici_ID");

                    b.HasIndex("ProjekatAktivnostPlan_FK");

                    b.ToTable("ProjekatAktivnostRealizacija");
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatPlan", b =>
                {
                    b.Property<int>("ProjekatPlan_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnType("datetime");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("OrganizacionaJedinica_FK")
                        .HasColumnType("int");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.Property<int>("Status_FK")
                        .HasColumnType("int");

                    b.HasKey("ProjekatPlan_ID");

                    b.HasIndex("OrganizacionaJedinica_FK");

                    b.HasIndex("Status_FK");

                    b.ToTable("ProjekatPlan");
                });

            modelBuilder.Entity("WebApplication1.Models.Resursi", b =>
                {
                    b.Property<int>("Resursi_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.HasKey("Resursi_ID");

                    b.ToTable("Resursi");
                });

            modelBuilder.Entity("WebApplication1.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("WebApplication1.Models.Uloge", b =>
                {
                    b.Property<int>("Uloge_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("text");

                    b.Property<string>("Opis")
                        .HasColumnType("text");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("Uloge_ID");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("WebApplication1.Models.Korisnici", b =>
                {
                    b.HasOne("WebApplication1.Models.Uloge", "uloge")
                        .WithMany()
                        .HasForeignKey("Uloge_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Korisnici_OrganizacionaJedinica", b =>
                {
                    b.HasOne("WebApplication1.Models.Korisnici", "korisnici")
                        .WithMany()
                        .HasForeignKey("Korisnici_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.OrganizacionaJedinica", "organizacionaJedinica")
                        .WithMany()
                        .HasForeignKey("OrganizacionaJedinica_ID");
                });

            modelBuilder.Entity("WebApplication1.Models.Organizacija", b =>
                {
                    b.HasOne("WebApplication1.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("Drzava_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.PTT", "ptt")
                        .WithMany()
                        .HasForeignKey("PTT_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.OrganizacionaJedinica", b =>
                {
                    b.HasOne("WebApplication1.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("Drzava_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Organizacija", "organizacija")
                        .WithMany()
                        .HasForeignKey("Organizacija_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.PTT", "ptt")
                        .WithMany()
                        .HasForeignKey("PTT_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatAktivnostPlan", b =>
                {
                    b.HasOne("WebApplication1.Models.ProjekatPlan", "projekatPlan")
                        .WithMany()
                        .HasForeignKey("ProjekatPlan_ID");
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatAktivnostRealizacija", b =>
                {
                    b.HasOne("WebApplication1.Models.Korisnici", "korisnici")
                        .WithMany()
                        .HasForeignKey("Korisnici_ID");

                    b.HasOne("WebApplication1.Models.ProjekatAktivnostPlan", "projekatAktivnostPlan")
                        .WithMany()
                        .HasForeignKey("ProjekatAktivnostPlan_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.ProjekatPlan", b =>
                {
                    b.HasOne("WebApplication1.Models.OrganizacionaJedinica", "organizacionaJedinica")
                        .WithMany()
                        .HasForeignKey("OrganizacionaJedinica_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Status", "status")
                        .WithMany()
                        .HasForeignKey("Status_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
