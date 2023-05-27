using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_column_testimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClişentName",
                table: "testimonials",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "testimonials",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "testimonials");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "testimonials",
                newName: "ClişentName");
        }
    }
}
