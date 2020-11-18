using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
               name: "Slika",
               table: "Organizacija",
               nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Organizacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "Slika",
               table: "Organizacija");
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Organizacija");
        }
    }
}
