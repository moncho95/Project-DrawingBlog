using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class UserFirstNameAndLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("2501e6ad-b221-414a-9014-ddf7080039e8"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 3, 14, 11, 28, 864, DateTimeKind.Local).AddTicks(9040), "Drawing with watercolor" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("3dea293e-8656-4d7c-9ea6-666a43386203"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 3, 14, 11, 28, 864, DateTimeKind.Local).AddTicks(9481), "Drawing with oil" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[] { new Guid("641f23a9-387b-4c3c-a120-a3f5e7bd97a5"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 3, 14, 11, 28, 864, DateTimeKind.Local).AddTicks(9464), "Drawing with gouache" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("2501e6ad-b221-414a-9014-ddf7080039e8"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("3dea293e-8656-4d7c-9ea6-666a43386203"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("641f23a9-387b-4c3c-a120-a3f5e7bd97a5"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
