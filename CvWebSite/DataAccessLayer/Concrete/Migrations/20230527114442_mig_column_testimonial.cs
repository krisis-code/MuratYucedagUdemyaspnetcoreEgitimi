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
            migrationBuilder.AddColumn<string>(
                name: "Image1Temp",
                table: "portfolios",
                nullable: true);

            migrationBuilder.Sql("UPDATE [portfolios] SET [Image1Temp] = [Image1];");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "portfolios",
                nullable: true);

            migrationBuilder.Sql("UPDATE [portfolios] SET [Image1] = [Image1Temp];");

            migrationBuilder.DropColumn(
                name: "Image1Temp",
                table: "portfolios");
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1Temp",
                table: "portfolios",
                nullable: true);

            migrationBuilder.Sql("UPDATE [portfolios] SET [Image1Temp] = [Image1];");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "portfolios",
                nullable: true);

            migrationBuilder.Sql("UPDATE [portfolios] SET [Image1] = [Image1Temp];");

            migrationBuilder.DropColumn(
                name: "Image1Temp",
                table: "portfolios");
        }


    }
}
