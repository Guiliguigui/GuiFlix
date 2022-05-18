using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class FixedThumbnailLinkV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "ThumbnailLink",
                value: "https://media.senscritique.com/media/000018453122/1200/Les_Chimpanzes_de_l_espace.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "ThumbnailLink",
                value: "https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52831542");
        }
    }
}
