using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesBlog.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorToBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blog",
                type: "TEXT",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blog");
        }
    }
}
