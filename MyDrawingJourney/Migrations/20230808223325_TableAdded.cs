using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class TableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efe6245d-a162-4fbb-89ba-bb081d177f2d", "AQAAAAEAACcQAAAAEAb5olzBRw3nkPbh88hBBCwoLrBnybrIGyZHmDLoZg2SlA88a1mfyqZ2Ftvyg78Ddw==", "d648ab4d-3f4d-44ef-8337-86d05cacc0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1e4643-d869-400b-9b56-cd80cf67554d", "AQAAAAEAACcQAAAAEH4IgtIeW0olgsEL+7oQq2pU5zfMnFZUiT1M52cWhvlzGSfxYrJwxXYfC7lgrmjOqQ==", "d9e409fb-aa8d-4703-8715-18b82ebd5ab3" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("84488f18-1ea6-4870-b4a0-12d1bc788dd1"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 9, 1, 33, 24, 959, DateTimeKind.Local).AddTicks(6617), "Drawing with gouache" },
                    { new Guid("c39b7739-682a-4f61-8012-664c2e0adac1"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 9, 1, 33, 24, 959, DateTimeKind.Local).AddTicks(6676), "Drawing with oil" },
                    { new Guid("d92fb644-0179-44fc-9e59-8db2f33b8054"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 9, 1, 33, 24, 959, DateTimeKind.Local).AddTicks(6498), "Drawing with watercolor" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("6cf8b0b8-21af-4e8e-b6c3-54cde4273f6a"), "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg", "Mona Lisa" },
                    { new Guid("fbbf7285-f5eb-4888-bb7c-f88cf7c3fb97"), "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg", "Starry Night" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Author", "CreatedOn", "Genre", "Name" },
                values: new object[,]
                {
                    { new Guid("08cb53d0-de4b-4723-8e7f-19d41bf2e111"), "Michael Jackson", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "Smooth Criminal" },
                    { new Guid("59ce62d2-a8e2-4faa-b496-efa0a9908b51"), "Queen", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Bohemian Rhapsody" },
                    { new Guid("7133901a-ba49-44ca-8892-f1bf4a24b9e7"), "Iggy Azalea", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "Fancy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("84488f18-1ea6-4870-b4a0-12d1bc788dd1"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("c39b7739-682a-4f61-8012-664c2e0adac1"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("d92fb644-0179-44fc-9e59-8db2f33b8054"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("6cf8b0b8-21af-4e8e-b6c3-54cde4273f6a"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("fbbf7285-f5eb-4888-bb7c-f88cf7c3fb97"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("08cb53d0-de4b-4723-8e7f-19d41bf2e111"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("59ce62d2-a8e2-4faa-b496-efa0a9908b51"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("7133901a-ba49-44ca-8892-f1bf4a24b9e7"));

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
    }
}
