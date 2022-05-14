using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class FixSeedPasswordsAndThumbnails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "UEFzczAwKysyZWVjNmYyNC0yMDQwLTQzYTEtYTVmNC01YTczMDFkYTczMTQ=");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "YWRtaW4yZWVjNmYyNC0yMDQwLTQzYTEtYTVmNC01YTczMDFkYTczMTQ=");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailLink",
                value: "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailLink",
                value: "https://peach.blender.org/wp-content/uploads/bbb-splash.png");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThumbnailLink",
                value: "https://www.embedded-france.org/wp-content/uploads/2013/04/big_buck_bunny_2008_11.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "PAss00++");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailLink",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLR4POz5A0cyaupJwOVd7aLggs4GhP_qugkg&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailLink",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Big_buck_bunny_poster_big.jpg/220px-Big_buck_bunny_poster_big.jpg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThumbnailLink",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtPQO_zVUkEEhnaW9sebyVmXW8-jGgjPh2Yw&usqp=CAU");
        }
    }
}
