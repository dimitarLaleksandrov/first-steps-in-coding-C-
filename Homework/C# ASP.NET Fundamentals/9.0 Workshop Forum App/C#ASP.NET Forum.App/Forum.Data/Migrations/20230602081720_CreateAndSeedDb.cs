using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.App.Data.Migrations
{
    public partial class CreateAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("01c2e06c-7517-4602-af1f-c126ae606521"), "Second Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare turpis ornare purus laoreet porta. Donec semper nibh maximus mauris eleifend, quis mattis nunc rutrum.", "My second post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("382f43cd-995b-45fd-ac76-2ef809fb555b"), "Third Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent feugiat, nunc sit amet sagittis vestibulum, sem dolor lacinia leo.", "My third post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("eb500bc5-504a-4370-ab51-402d8591ec47"), "First Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin dictum metus nec magna auctor tincidunt. Fusce et dolor quis nunc.", "My first post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
