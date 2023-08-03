using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class AddedAdminAndGuestUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                type: "nvarchar(30)",
                maxLength: 30,
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54df9673-4371-4b9f-8ab5-76893941a2fb", "AQAAAAEAACcQAAAAENenyb4x/s3TJDcleXFyeMJIwoFfx2+p+i1yohA3UAhloSa5gYNyX6FPQu0MQs2dCQ==", "8100ccf8-2aee-4ad1-a3c9-fbc3dd4412cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec32f05-f5ca-4ca9-a201-9d89b60e2778", "AQAAAAEAACcQAAAAEDaKt9qzM/fgy+2oQtibF8hteMpSeSxjqephWCpC1f976rH3Kn+0QfQMB4qoMwAtsA==", "5cdd41c1-7a3e-4d2f-bbb2-7cfafb4f49ab" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("039c6458-bf64-440f-a51c-99badfdc8ed8"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 3, 17, 29, 18, 871, DateTimeKind.Local).AddTicks(3314), "Drawing with watercolor" },
                    { new Guid("1d72940f-677f-4b63-9521-8b1e721144a4"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 3, 17, 29, 18, 871, DateTimeKind.Local).AddTicks(3515), "Drawing with oil" },
                    { new Guid("ad9d89c3-f0b5-4af8-afda-49f60d8fb253"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 3, 17, 29, 18, 871, DateTimeKind.Local).AddTicks(3494), "Drawing with gouache" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("c237d8e8-a953-45cc-8fe6-b63628c4dc50"), "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg", "Starry Night" },
                    { new Guid("e4ce5875-4d08-4e0a-9f6b-0b40643a6e78"), "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg", "Mona Lisa" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Author", "CreatedOn", "Genre", "Name" },
                values: new object[,]
                {
                    { new Guid("60a4cd3c-0005-4aff-a6f9-533719667e2e"), "Michael Jackson", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "Smooth Criminal" },
                    { new Guid("78219cde-68e8-4198-827b-2a60f3841c94"), "Iggy Azalea", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "Fancy" },
                    { new Guid("bcbd857b-be6d-442b-b1b1-5d84c5a18f8b"), "Queen", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Bohemian Rhapsody" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("039c6458-bf64-440f-a51c-99badfdc8ed8"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("1d72940f-677f-4b63-9521-8b1e721144a4"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("ad9d89c3-f0b5-4af8-afda-49f60d8fb253"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("c237d8e8-a953-45cc-8fe6-b63628c4dc50"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("e4ce5875-4d08-4e0a-9f6b-0b40643a6e78"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("60a4cd3c-0005-4aff-a6f9-533719667e2e"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("78219cde-68e8-4198-827b-2a60f3841c94"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("bcbd857b-be6d-442b-b1b1-5d84c5a18f8b"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "Testov",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4351de2a-376c-486b-bb7a-dc134e2718be", "AQAAAAEAACcQAAAAEH4ZqD530mf0o/ua0hLlKsoawkOWg636qBETgQYfkYnD/56wzzi4dAaraHARRi6Vog==", "0abe6871-f356-4402-8125-b33735561207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3212cdd-8081-4762-98ba-69602bbdefbb", "AQAAAAEAACcQAAAAEOzRhgin93Rdsm6ef88W/WTvK3a/GrWVM1vrk4CBdpRZmqfl9QkwJiz3cajBW4qlkA==", "056504e0-eb33-43c9-888d-23b2c9ef1b9d" });

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
    }
}
