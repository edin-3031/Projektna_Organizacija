using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjekatPlan_Status_Status_FK",
                table: "ProjekatPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statusi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statusi",
                table: "Statusi",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjekatPlan_Statusi_Status_FK",
                table: "ProjekatPlan",
                column: "Status_FK",
                principalTable: "Statusi",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjekatPlan_Statusi_Status_FK",
                table: "ProjekatPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statusi",
                table: "Statusi");

            migrationBuilder.RenameTable(
                name: "Statusi",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjekatPlan_Status_Status_FK",
                table: "ProjekatPlan",
                column: "Status_FK",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
