using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank.infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Donors_IdAddress",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "IdDonor",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Donors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_AddressId",
                table: "Donors",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_IdAddress",
                table: "Donors",
                column: "IdAddress",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Addresses_AddressId",
                table: "Donors",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Addresses_AddressId",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Donors_AddressId",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Donors_IdAddress",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Donors");

            migrationBuilder.AddColumn<int>(
                name: "IdDonor",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donors_IdAddress",
                table: "Donors",
                column: "IdAddress");
        }
    }
}
