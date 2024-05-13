using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ColumsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox1",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox2",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox3",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox4",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox5",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewsletterCheckbox6",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox1",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox2",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox3",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox4",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox5",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NewsletterCheckbox6",
                table: "Subscribers");
        }
    }
}
