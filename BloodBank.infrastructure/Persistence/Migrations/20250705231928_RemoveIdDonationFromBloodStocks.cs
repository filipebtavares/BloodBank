using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank.infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdDonationFromBloodStocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDonation",
                table: "BloodStocks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDonation",
                table: "BloodStocks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
