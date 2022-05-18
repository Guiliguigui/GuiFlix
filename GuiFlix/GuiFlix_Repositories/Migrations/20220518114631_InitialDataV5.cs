using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Matt", "Groening" });

            migrationBuilder.InsertData(
                table: "CrewMembers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, "Dan", "Castellaneta" },
                    { 15, "Russi", "Taylor" },
                    { 14, "Tress", "MacNeille" },
                    { 13, "Jan", "Hooks" },
                    { 12, "Hank", "Azaria" },
                    { 10, "Marcia", "Mitzman Gaven" },
                    { 11, "Pamela", "Hayden" },
                    { 8, "Maggie", "Roswell" },
                    { 7, "Glenn", "Close" },
                    { 6, "James", "Earl Jones" },
                    { 5, "Yeardley", "Smith" },
                    { 4, "Nancy", "CartWright" },
                    { 3, "Julie", "Kavner" },
                    { 9, "Harry", "Shearer" }
                });

            migrationBuilder.InsertData(
                table: "ListMedia",
                columns: new[] { "ListsId", "MediasId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 }
                });

            migrationBuilder.UpdateData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaId",
                value: 37);

            migrationBuilder.InsertData(
                table: "MediaCrewMembers",
                columns: new[] { "Id", "CrewMemberId", "MediaId", "Role" },
                values: new object[] { 16, 1, 12, "Realisator" });

            migrationBuilder.UpdateData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CrewMemberId", "MediaId", "Role" },
                values: new object[] { 2, 37, "Voice Actor" });

            migrationBuilder.InsertData(
                table: "MediaCrewMembers",
                columns: new[] { "Id", "CrewMemberId", "MediaId", "Role" },
                values: new object[,]
                {
                    { 17, 2, 12, "Voice Actor" },
                    { 29, 14, 12, "Voice Actor" },
                    { 14, 14, 37, "Voice Actor" },
                    { 28, 13, 12, "Voice Actor" },
                    { 13, 13, 37, "Voice Actor" },
                    { 27, 12, 12, "Voice Actor" },
                    { 12, 12, 37, "Voice Actor" },
                    { 26, 11, 12, "Voice Actor" },
                    { 11, 11, 37, "Voice Actor" },
                    { 25, 10, 12, "Voice Actor" },
                    { 10, 10, 37, "Voice Actor" },
                    { 24, 9, 12, "Voice Actor" },
                    { 9, 9, 37, "Voice Actor" },
                    { 23, 8, 12, "Voice Actor" },
                    { 8, 8, 37, "Voice Actor" },
                    { 22, 7, 12, "Voice Actor" },
                    { 7, 7, 37, "Voice Actor" },
                    { 21, 6, 12, "Voice Actor" },
                    { 6, 6, 37, "Voice Actor" },
                    { 20, 5, 12, "Voice Actor" },
                    { 5, 5, 37, "Voice Actor" },
                    { 19, 4, 12, "Voice Actor" },
                    { 4, 4, 37, "Voice Actor" },
                    { 18, 3, 12, "Voice Actor" },
                    { 3, 3, 37, "Voice Actor" },
                    { 15, 15, 37, "Voice Actor" },
                    { 30, 15, 12, "Voice Actor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ListMedia",
                keyColumns: new[] { "ListsId", "MediasId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ListMedia",
                keyColumns: new[] { "ListsId", "MediasId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ListMedia",
                keyColumns: new[] { "ListsId", "MediasId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sacha", "Goedegebure" });

            migrationBuilder.UpdateData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CrewMemberId", "MediaId", "Role" },
                values: new object[] { 1, 2, "Realisator" });
        }
    }
}
