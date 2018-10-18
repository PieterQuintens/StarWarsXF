using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class RatingToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "Movies",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/1/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 46, 52, 774, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/2/",
                column: "Edited",
                value: new DateTime(2017, 4, 19, 10, 57, 29, 544, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/3/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 46, 5, 220, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/4/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 18, 689, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/5/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 1, 623, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/6/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 44, 862, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/7/",
                columns: new[] { "Created", "Edited" },
                values: new object[] { new DateTime(2015, 4, 17, 6, 51, 30, 504, DateTimeKind.Utc), new DateTime(2015, 12, 17, 14, 31, 47, 617, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/planets/1/",
                column: "Edited",
                value: new DateTime(2014, 12, 21, 20, 48, 4, 175, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/planets/61/",
                columns: new[] { "Created", "Edited" },
                values: new object[] { new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc), new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/1/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 46, 52, 774, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/2/",
                column: "Edited",
                value: new DateTime(2017, 4, 19, 10, 57, 29, 544, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/3/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 46, 5, 220, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/4/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 18, 689, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/5/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 1, 623, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/6/",
                column: "Edited",
                value: new DateTime(2015, 4, 11, 9, 45, 44, 862, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/films/7/",
                columns: new[] { "Created", "Edited" },
                values: new object[] { new DateTime(2015, 4, 17, 6, 51, 30, 504, DateTimeKind.Utc), new DateTime(2015, 12, 17, 14, 31, 47, 617, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/planets/1/",
                column: "Edited",
                value: new DateTime(2014, 12, 21, 20, 48, 4, 175, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Uri",
                keyValue: "https://swapi.co/api/planets/61/",
                columns: new[] { "Created", "Edited" },
                values: new object[] { new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc), new DateTime(2015, 4, 17, 6, 55, 57, 556, DateTimeKind.Utc) });
        }
    }
}
