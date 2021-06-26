using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumehMaker.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Idiomas_NiveisIdiomas_NivelIdiomaId",
                table: "Idiomas");

            migrationBuilder.DropTable(
                name: "NiveisIdiomas");

            migrationBuilder.DropIndex(
                name: "IX_Idiomas_NivelIdiomaId",
                table: "Idiomas");

            migrationBuilder.DropColumn(
                name: "NivelIdiomaId",
                table: "Idiomas");

            migrationBuilder.AlterColumn<string>(
                name: "Nivel",
                table: "Idiomas",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nivel",
                table: "Idiomas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "NivelIdiomaId",
                table: "Idiomas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NiveisIdiomas",
                columns: table => new
                {
                    NivelIdiomaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveisIdiomas", x => x.NivelIdiomaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Idiomas_NivelIdiomaId",
                table: "Idiomas",
                column: "NivelIdiomaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Idiomas_NiveisIdiomas_NivelIdiomaId",
                table: "Idiomas",
                column: "NivelIdiomaId",
                principalTable: "NiveisIdiomas",
                principalColumn: "NivelIdiomaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
