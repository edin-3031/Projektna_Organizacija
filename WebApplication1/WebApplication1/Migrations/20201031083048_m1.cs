using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace WebApplication1.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Drazava_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Drazava_ID);
                });

            migrationBuilder.CreateTable(
                name: "PTT",
                columns: table => new
                {
                    PTT_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTT", x => x.PTT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Resursi",
                columns: table => new
                {
                    Resursi_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resursi", x => x.Resursi_ID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Uloge_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Uloge_ID);
                });

            migrationBuilder.CreateTable(
                name: "Organizacija",
                columns: table => new
                {
                    Organizacija_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PTT_FK = table.Column<int>(nullable: false),
                    Drzava_FK = table.Column<int>(nullable: false),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizacija", x => x.Organizacija_ID);
                    table.ForeignKey(
                        name: "FK_Organizacija_Drzava_Drzava_FK",
                        column: x => x.Drzava_FK,
                        principalTable: "Drzava",
                        principalColumn: "Drazava_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organizacija_PTT_PTT_FK",
                        column: x => x.PTT_FK,
                        principalTable: "PTT",
                        principalColumn: "PTT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Korisnici_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uloge_FK = table.Column<int>(nullable: false),
                    Sifra = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Lozinka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Korisnici_ID);
                    table.ForeignKey(
                        name: "FK_Korisnici_Uloge_Uloge_FK",
                        column: x => x.Uloge_FK,
                        principalTable: "Uloge",
                        principalColumn: "Uloge_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizacionaJedinica",
                columns: table => new
                {
                    OrganizacionaJedinica_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Organizacija_FK = table.Column<int>(nullable: false),
                    PTT_FK = table.Column<int>(nullable: false),
                    Drzava_FK = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizacionaJedinica", x => x.OrganizacionaJedinica_ID);
                    table.ForeignKey(
                        name: "FK_OrganizacionaJedinica_Drzava_Drzava_FK",
                        column: x => x.Drzava_FK,
                        principalTable: "Drzava",
                        principalColumn: "Drazava_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizacionaJedinica_Organizacija_Organizacija_FK",
                        column: x => x.Organizacija_FK,
                        principalTable: "Organizacija",
                        principalColumn: "Organizacija_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizacionaJedinica_PTT_PTT_FK",
                        column: x => x.PTT_FK,
                        principalTable: "PTT",
                        principalColumn: "PTT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici_OrganizacionaJedinica",
                columns: table => new
                {
                    Korisnici_OrganizacionaJedinica_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Korisnici_FK = table.Column<int>(nullable: false),
                    OrganizacionaJedinica_ID = table.Column<int>(nullable: true),
                    OrganizacionaJedinica_FK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici_OrganizacionaJedinica", x => x.Korisnici_OrganizacionaJedinica_ID);
                    table.ForeignKey(
                        name: "FK_Korisnici_OrganizacionaJedinica_Korisnici_Korisnici_FK",
                        column: x => x.Korisnici_FK,
                        principalTable: "Korisnici",
                        principalColumn: "Korisnici_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_Organi~",
                        column: x => x.OrganizacionaJedinica_ID,
                        principalTable: "OrganizacionaJedinica",
                        principalColumn: "OrganizacionaJedinica_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjekatPlan",
                columns: table => new
                {
                    ProjekatPlan_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    OrganizacionaJedinica_FK = table.Column<int>(nullable: false),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    DatumOd = table.Column<DateTime>(nullable: false),
                    DatumDo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekatPlan", x => x.ProjekatPlan_ID);
                    table.ForeignKey(
                        name: "FK_ProjekatPlan_OrganizacionaJedinica_OrganizacionaJedinica_FK",
                        column: x => x.OrganizacionaJedinica_FK,
                        principalTable: "OrganizacionaJedinica",
                        principalColumn: "OrganizacionaJedinica_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjekatAktivnostPlan",
                columns: table => new
                {
                    ProjekatAktivnostPlan_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProjekatPlan_ID = table.Column<int>(nullable: true),
                    ProjekatPlan_FK = table.Column<int>(nullable: false),
                    Sifra = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    DatumOd = table.Column<DateTime>(nullable: false),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    JedinicaMjere = table.Column<string>(nullable: true),
                    Kolicina = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekatAktivnostPlan", x => x.ProjekatAktivnostPlan_ID);
                    table.ForeignKey(
                        name: "FK_ProjekatAktivnostPlan_ProjekatPlan_ProjekatPlan_ID",
                        column: x => x.ProjekatPlan_ID,
                        principalTable: "ProjekatPlan",
                        principalColumn: "ProjekatPlan_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjekatAktivnostRealizacija",
                columns: table => new
                {
                    ProjekatAktivnostRealizacija_ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProjekatAktivnostPlan_FK = table.Column<int>(nullable: false),
                    Korisnici_ID = table.Column<int>(nullable: true),
                    Korisnici_FK = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Kolicina = table.Column<float>(nullable: false),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekatAktivnostRealizacija", x => x.ProjekatAktivnostRealizacija_ID);
                    table.ForeignKey(
                        name: "FK_ProjekatAktivnostRealizacija_Korisnici_Korisnici_ID",
                        column: x => x.Korisnici_ID,
                        principalTable: "Korisnici",
                        principalColumn: "Korisnici_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_ProjekatA~",
                        column: x => x.ProjekatAktivnostPlan_FK,
                        principalTable: "ProjekatAktivnostPlan",
                        principalColumn: "ProjekatAktivnostPlan_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_Uloge_FK",
                table: "Korisnici",
                column: "Uloge_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_OrganizacionaJedinica_Korisnici_FK",
                table: "Korisnici_OrganizacionaJedinica",
                column: "Korisnici_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_OrganizacionaJedinica_OrganizacionaJedinica_ID",
                table: "Korisnici_OrganizacionaJedinica",
                column: "OrganizacionaJedinica_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizacija_Drzava_FK",
                table: "Organizacija",
                column: "Drzava_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Organizacija_PTT_FK",
                table: "Organizacija",
                column: "PTT_FK");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizacionaJedinica_Drzava_FK",
                table: "OrganizacionaJedinica",
                column: "Drzava_FK");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizacionaJedinica_Organizacija_FK",
                table: "OrganizacionaJedinica",
                column: "Organizacija_FK");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizacionaJedinica_PTT_FK",
                table: "OrganizacionaJedinica",
                column: "PTT_FK");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekatAktivnostPlan_ProjekatPlan_ID",
                table: "ProjekatAktivnostPlan",
                column: "ProjekatPlan_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekatAktivnostRealizacija_Korisnici_ID",
                table: "ProjekatAktivnostRealizacija",
                column: "Korisnici_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekatAktivnostRealizacija_ProjekatAktivnostPlan_FK",
                table: "ProjekatAktivnostRealizacija",
                column: "ProjekatAktivnostPlan_FK");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekatPlan_OrganizacionaJedinica_FK",
                table: "ProjekatPlan",
                column: "OrganizacionaJedinica_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnici_OrganizacionaJedinica");

            migrationBuilder.DropTable(
                name: "ProjekatAktivnostRealizacija");

            migrationBuilder.DropTable(
                name: "Resursi");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "ProjekatAktivnostPlan");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "ProjekatPlan");

            migrationBuilder.DropTable(
                name: "OrganizacionaJedinica");

            migrationBuilder.DropTable(
                name: "Organizacija");

            migrationBuilder.DropTable(
                name: "Drzava");

            migrationBuilder.DropTable(
                name: "PTT");
        }
    }
}
