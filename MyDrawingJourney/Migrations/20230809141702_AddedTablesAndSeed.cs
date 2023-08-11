using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class AddedTablesAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "72b404f0-d726-4a4e-b6a1-f4d45c1778fc", "AQAAAAEAACcQAAAAEHifVeuF3emTuDANh+ymGYRSsnh4PbFTZgcJrf1LRRdukE5Wx3nEk3OlEhQF3BvVAA==", "1ee65001-49f7-4879-9de0-6502f6237047" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0131b4-4f5c-44ad-8e08-752caf2ef8d4", "AQAAAAEAACcQAAAAEG2c4fcWF9l2gHMobFwZSLqRaZ4Q0Gvq63laTZ4Jd8bVX152i+UrU7GoSynhbtv2AA==", "b88ad061-2e37-4161-b511-76b5311f9bdc" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("5eeb8383-ca00-4b6f-8518-c28b851ea156"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 9, 17, 17, 1, 750, DateTimeKind.Local).AddTicks(5341), "Drawing with watercolor" },
                    { new Guid("a90c5ea8-c7f5-4265-ad77-f08698a59127"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 9, 17, 17, 1, 750, DateTimeKind.Local).AddTicks(5538), "Drawing with oil" },
                    { new Guid("bf33d617-f4e0-46d9-8730-a3ae37419454"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 9, 17, 17, 1, 750, DateTimeKind.Local).AddTicks(5516), "Drawing with gouache" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("9a036ab2-f0f4-4c5d-8697-05decd690210"), "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg", "Starry Night" },
                    { new Guid("cd2ad4fb-5d05-4319-b4d7-9c52641b9d21"), "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg", "Mona Lisa" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Author", "CreatedOn", "Genre", "Name" },
                values: new object[,]
                {
                    { new Guid("38371da3-6e52-4030-969f-0ec0a9431831"), "Michael Jackson", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "Smooth Criminal" },
                    { new Guid("8c3a7bf0-77b8-497b-8253-eff65d8b956a"), "Queen", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Bohemian Rhapsody" },
                    { new Guid("b8297f56-85ba-45b4-b6fa-904651cf198c"), "Iggy Azalea", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "Fancy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("5eeb8383-ca00-4b6f-8518-c28b851ea156"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("a90c5ea8-c7f5-4265-ad77-f08698a59127"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("bf33d617-f4e0-46d9-8730-a3ae37419454"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("9a036ab2-f0f4-4c5d-8697-05decd690210"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("cd2ad4fb-5d05-4319-b4d7-9c52641b9d21"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("38371da3-6e52-4030-969f-0ec0a9431831"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("8c3a7bf0-77b8-497b-8253-eff65d8b956a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("b8297f56-85ba-45b4-b6fa-904651cf198c"));

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
    }
}
