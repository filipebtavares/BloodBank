using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank.infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SolvingProblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Donors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
