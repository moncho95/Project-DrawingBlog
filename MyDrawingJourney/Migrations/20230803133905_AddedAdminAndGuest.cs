using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class AddedAdminAndGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "Testov",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "Test",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "4351de2a-376c-486b-bb7a-dc134e2718be", "admin@mail.com", false, "Great", "Admin", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEH4ZqD530mf0o/ua0hLlKsoawkOWg636qBETgQYfkYnD/56wzzi4dAaraHARRi6Vog==", null, false, "0abe6871-f356-4402-8125-b33735561207", false, "admin@mail.com" },
                    { "bcb4f072-ecca-43c9-ab26-c060c6f364e5", 0, "a3212cdd-8081-4762-98ba-69602bbdefbb", "guest@mail.com", false, "Teodor", "Lesly", false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEOzRhgin93Rdsm6ef88W/WTvK3a/GrWVM1vrk4CBdpRZmqfl9QkwJiz3cajBW4qlkA==", null, false, "056504e0-eb33-43c9-888d-23b2c9ef1b9d", false, "guest@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("1cef6772-92d4-4756-bfaa-31ac643855d6"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 3, 16, 39, 3, 948, DateTimeKind.Local).AddTicks(2990), "Drawing with watercolor" },
                    { new Guid("476e2bba-eef8-40f5-a68b-d62fc0288572"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 3, 16, 39, 3, 948, DateTimeKind.Local).AddTicks(3159), "Drawing with gouache" },
                    { new Guid("f5cc94a1-8cf6-40e4-9fda-a7a60dcc0486"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 3, 16, 39, 3, 948, DateTimeKind.Local).AddTicks(3182), "Drawing with oil" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("c1c877b3-673f-4f01-9064-70ea112ec6eb"), "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg", "Mona Lisa" },
                    { new Guid("d9965fb4-b9e6-476d-8bf3-8b4f05766bec"), "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg", "Starry Night" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Author", "CreatedOn", "Genre", "Name" },
                values: new object[,]
                {
                    { new Guid("16ca627a-fe1b-4031-ad50-e86930b5e861"), "Michael Jackson", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "Smooth Criminal" },
                    { new Guid("225ece59-6626-4289-88cd-51049321b37a"), "Queen", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Bohemian Rhapsody" },
                    { new Guid("5f31b4b1-ca57-42ed-afe6-bd070abe2989"), "Iggy Azalea", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "Fancy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("1cef6772-92d4-4756-bfaa-31ac643855d6"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("476e2bba-eef8-40f5-a68b-d62fc0288572"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("f5cc94a1-8cf6-40e4-9fda-a7a60dcc0486"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("c1c877b3-673f-4f01-9064-70ea112ec6eb"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("d9965fb4-b9e6-476d-8bf3-8b4f05766bec"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("16ca627a-fe1b-4031-ad50-e86930b5e861"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("225ece59-6626-4289-88cd-51049321b37a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("5f31b4b1-ca57-42ed-afe6-bd070abe2989"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldDefaultValue: "Testov");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldDefaultValue: "Test");

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
    }
}
