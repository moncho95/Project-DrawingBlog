using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class CreateAndSedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("190ef1a5-cdc5-49f2-9458-85b90b1d47ef"), "Drawing with oil is so difficult...", new DateTime(2023, 7, 28, 0, 19, 55, 294, DateTimeKind.Local).AddTicks(7676), "Drawing with oil" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("2ebd205b-c1a5-4db1-af1f-1155e646a886"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 7, 28, 0, 19, 55, 294, DateTimeKind.Local).AddTicks(7540), "Drawing with watercolor" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("84767075-6e9f-4389-8073-6d30d257770f"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 7, 28, 0, 19, 55, 294, DateTimeKind.Local).AddTicks(7666), "Drawing with gouache" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("190ef1a5-cdc5-49f2-9458-85b90b1d47ef"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("2ebd205b-c1a5-4db1-af1f-1155e646a886"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("84767075-6e9f-4389-8073-6d30d257770f"));

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
    }
}
