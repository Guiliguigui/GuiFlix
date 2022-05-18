using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class FixedThumbnailLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "ThumbnailLink",
                value: "https://www.critikat.com/wp-content/uploads/fly-images/31797/arton32-1450x800-c.jpg");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27,
                column: "ThumbnailLink",
                value: "http://idata.over-blog.com/2/80/11/49/photos-films/autres-images-blog/article-freddy-les-griffes-de-la-nuit.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "ThumbnailLink",
                value: "https://thumb.canalplus.pro/http/unsafe/%7BresolutionXY%7D/filters:quality(%7BimageQualityPercentage%7D)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/98794877");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27,
                column: "ThumbnailLink",
                value: "https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52833622");
        }
    }
}
