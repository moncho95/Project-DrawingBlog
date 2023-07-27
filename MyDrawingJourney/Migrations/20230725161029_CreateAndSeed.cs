using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class CreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbdaed6-2697-44d9-9345-93ff4dedb69a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "973e4617-87c7-46f3-8232-ce1fd2ca80ed");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("4ff53231-13a9-41d2-a797-005d71955426"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("97cfb7a2-2048-4a2c-bc27-3da8b6182433"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("fddf9c3b-1f12-4d94-8526-94b295ee0937"));

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78af6cd3-0255-4961-8e46-fb03e7bc553c", "1", "Admin", "Admin" },
                    { "f82ced1d-5f58-444d-b6be-123d80689280", "2", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("6a4120ed-dab9-4f6e-9b22-7f5ca42ddd51"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 7, 25, 19, 10, 29, 48, DateTimeKind.Local).AddTicks(5667), "Drawing with watercolor" },
                    { new Guid("86fd6e5c-40ce-481a-bd41-c5196ef30a33"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 7, 25, 19, 10, 29, 48, DateTimeKind.Local).AddTicks(5903), "Drawing with gouache" },
                    { new Guid("b3fec0e6-f5b7-4f5f-b288-6b1ded9bd369"), "Drawing with oil is so difficult...", new DateTime(2023, 7, 25, 19, 10, 29, 48, DateTimeKind.Local).AddTicks(5922), "Drawing with oil" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78af6cd3-0255-4961-8e46-fb03e7bc553c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f82ced1d-5f58-444d-b6be-123d80689280");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a4120ed-dab9-4f6e-9b22-7f5ca42ddd51"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("86fd6e5c-40ce-481a-bd41-c5196ef30a33"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("b3fec0e6-f5b7-4f5f-b288-6b1ded9bd369"));

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
    }
}
