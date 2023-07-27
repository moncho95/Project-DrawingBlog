using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Paintings",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paintings",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("25c0217e-1b90-4626-ac2b-63ce3e6f4b33"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 7, 25, 23, 53, 50, 336, DateTimeKind.Local).AddTicks(504), "Drawing with watercolor" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("6a44422b-a3b8-45dd-94fc-68c573559f8a"), "Drawing with oil is so difficult...", new DateTime(2023, 7, 25, 23, 53, 50, 336, DateTimeKind.Local).AddTicks(698), "Drawing with oil" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("ec00827c-59cc-4e83-90b9-e1223df41754"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 7, 25, 23, 53, 50, 336, DateTimeKind.Local).AddTicks(677), "Drawing with gouache" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("25c0217e-1b90-4626-ac2b-63ce3e6f4b33"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a44422b-a3b8-45dd-94fc-68c573559f8a"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("ec00827c-59cc-4e83-90b9-e1223df41754"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Paintings",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paintings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

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
    }
}
