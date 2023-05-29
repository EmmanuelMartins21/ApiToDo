using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiToDo.Migrations
{
    /// <inheritdoc />
    public partial class Migracao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NívelUrgencia",
                table: "Tarefas",
                newName: "NivelUrgencia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NivelUrgencia",
                table: "Tarefas",
                newName: "NívelUrgencia");
        }
    }
}
