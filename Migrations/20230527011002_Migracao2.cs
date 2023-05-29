using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiToDo.Migrations
{
    /// <inheritdoc />
    public partial class Migracao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "NívelUrgencia",
                table: "Tarefas",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "NívelUrgencia",
                table: "Tarefas");
        }
    }
}
