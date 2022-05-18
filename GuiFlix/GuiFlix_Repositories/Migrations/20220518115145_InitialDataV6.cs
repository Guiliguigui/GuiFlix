using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "ThumbnailLink",
                value: "https://www.critikat.com/wp-content/uploads/fly-images/35368/arton1450-1450x800-c.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "ThumbnailLink",
                value: "https://media.gqmagazine.fr/photos/5eb165192bfbee9eb2f42e42/master/pass/los-simpson-cuarto-oculto.jpg");
        }
    }
}
