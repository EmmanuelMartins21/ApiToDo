using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiToDo.Migrations
{
    /// <inheritdoc />
    public partial class Migracao5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NivelUrgencia",
                table: "Tarefas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NivelUrgencia",
                table: "Tarefas");
        }
    }
}
