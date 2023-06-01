using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migaddcolums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paltform",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "portfolios",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "portfolios",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Paltform",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "portfolios");
        }
    }
}
