using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class CreateAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a8cf403-a079-4e68-8b2c-21623f4e30dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaa80fd1-1c52-4e95-90b3-28ad8cf0f97d");

            migrationBuilder.CreateTable(
                name: "ForumPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7dbdaed6-2697-44d9-9345-93ff4dedb69a", "2", "User", "User" },
                    { "973e4617-87c7-46f3-8232-ce1fd2ca80ed", "1", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("4ff53231-13a9-41d2-a797-005d71955426"), "Drawing with oil is so difficult...", new DateTime(2023, 7, 12, 10, 46, 27, 749, DateTimeKind.Local).AddTicks(6324), "Drawing with oil" },
                    { new Guid("97cfb7a2-2048-4a2c-bc27-3da8b6182433"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 7, 12, 10, 46, 27, 749, DateTimeKind.Local).AddTicks(6165), "Drawing with watercolor" },
                    { new Guid("fddf9c3b-1f12-4d94-8526-94b295ee0937"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 7, 12, 10, 46, 27, 749, DateTimeKind.Local).AddTicks(6313), "Drawing with gouache" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumPosts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbdaed6-2697-44d9-9345-93ff4dedb69a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "973e4617-87c7-46f3-8232-ce1fd2ca80ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a8cf403-a079-4e68-8b2c-21623f4e30dc", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaa80fd1-1c52-4e95-90b3-28ad8cf0f97d", "1", "Admin", "Admin" });
        }
    }
}
