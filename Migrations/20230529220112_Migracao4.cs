using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiToDo.Migrations
{
    /// <inheritdoc />
    public partial class Migracao4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NivelUrgencia",
                table: "Tarefas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "NivelUrgencia",
                table: "Tarefas",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
