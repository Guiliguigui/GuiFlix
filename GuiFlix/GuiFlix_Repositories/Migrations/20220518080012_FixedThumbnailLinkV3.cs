using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class FixedThumbnailLinkV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "ThumbnailLink",
                value: "http://www.coupleofpixels.be/wp-content/uploads/2018/12/intothespiderverse1.jpg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "ThumbnailLink",
                value: "https://i.ytimg.com/vi/5Z123CARsTs/maxresdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 34,
                column: "ThumbnailLink",
                value: "https://www.premiere.fr/sites/default/files/styles/scale_crop_1280x720/public/2022-02/Megamind.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "ThumbnailLink",
                value: "https://medias.3dvf.com/news/sitegrab/persichetti_spiderman_02.jpg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "ThumbnailLink",
                value: "https://www.onnetflix.com.au/media/bgimages/70108989/0464ca78ce9d5d5918886f8a5b7eafbecdb72611.webp");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 34,
                column: "ThumbnailLink",
                value: "http://ekladata.com/sxd6A2dJIqb4TEr9wSVudl9dupw.jpg");
        }
    }
}
