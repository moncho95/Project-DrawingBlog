using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDrawingJourney.Migrations
{
    public partial class AddedApplicationUserConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
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
                values: new object[] { "8777eea7-f3e9-4347-a6cb-f3c22c72fa89", "AQAAAAEAACcQAAAAELtuJ/C6JzNr+J2kGdfU3GZvORHA+CgDDgny2EZmSCRk9tJppKXVQCkJH9sbdNgEcg==", "ac37b554-91ff-468c-b846-83b7a0b597a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbaf674b-5ba0-4b25-98d7-cbfabe025f27", "AQAAAAEAACcQAAAAEJ/bcTZ8rCOLf9VRQchoswlqzFJ8ZMFRNM7i+pR/chrMLrpap0B6FzdGpOBBkZciFQ==", "6b8a453f-2d2a-4411-bb5c-80905bf36abe" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("171e56a3-3754-4fb6-9fd2-4c32027bc64e"), "Drawing with watercolor has its challengeses, but there is nothing more pleasent...", new DateTime(2023, 8, 9, 17, 23, 21, 139, DateTimeKind.Local).AddTicks(5860), "Drawing with watercolor" },
                    { new Guid("a0cf63ea-5e6c-4e43-b489-c457a6e966ac"), "Drawing with gouache is best suited for illustration work...", new DateTime(2023, 8, 9, 17, 23, 21, 139, DateTimeKind.Local).AddTicks(6101), "Drawing with gouache" },
                    { new Guid("df1b28f4-a3a4-44b7-8d1a-82129d05dc89"), "Drawing with oil is so difficult...", new DateTime(2023, 8, 9, 17, 23, 21, 139, DateTimeKind.Local).AddTicks(6133), "Drawing with oil" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("480fdc99-b676-4f1f-90f4-1ad4a063301a"), "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg", "Starry Night" },
                    { new Guid("641d8008-35f8-44d3-8bd8-d1d426bc5071"), "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.", "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg", "Mona Lisa" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Author", "CreatedOn", "Genre", "Name" },
                values: new object[,]
                {
                    { new Guid("3640f45d-48cd-457c-81b2-20bdfbfd653a"), "Michael Jackson", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "Smooth Criminal" },
                    { new Guid("83e07396-f587-4ec3-8e79-bcf3afe5c9d7"), "Queen", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Bohemian Rhapsody" },
                    { new Guid("91ebee35-34a7-4993-8156-91d18cb2bf51"), "Iggy Azalea", new DateTime(2010, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "Fancy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("171e56a3-3754-4fb6-9fd2-4c32027bc64e"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("a0cf63ea-5e6c-4e43-b489-c457a6e966ac"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("df1b28f4-a3a4-44b7-8d1a-82129d05dc89"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("480fdc99-b676-4f1f-90f4-1ad4a063301a"));

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "Id",
                keyValue: new Guid("641d8008-35f8-44d3-8bd8-d1d426bc5071"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("3640f45d-48cd-457c-81b2-20bdfbfd653a"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("83e07396-f587-4ec3-8e79-bcf3afe5c9d7"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: new Guid("91ebee35-34a7-4993-8156-91d18cb2bf51"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
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
    }
}
