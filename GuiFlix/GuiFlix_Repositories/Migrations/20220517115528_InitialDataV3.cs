using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "The Simpson's: The Movies");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26,
                column: "ThumbnailLink",
                value: "https://catholicgirlbloggin.files.wordpress.com/2015/07/23babadook2-articlelarge.jpg");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatarLink",
                value: "https://archive.org/download/profiles_202104/hero.png");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvatarLink",
                value: "https://mir-s3-cdn-cf.behance.net/project_modules/disp/bf6e4a33850498.56ba69ac3064f.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "The Simpson's");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26,
                column: "ThumbnailLink",
                value: "https://www.filmmusicsite.com/fr/images/covers/xlarge/58175-inlay.jpg");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatarLink",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fpeople%2Fnorbert-sloth%2Fworks%2F33251083-2018-netflix-chicken-profile-icon&psig=AOvVaw2idUgiqVT6YI-P2Y6CSH1t&ust=1652860050220000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIDl1dOF5vcCFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvatarLink",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fpeople%2Fnorbert-sloth%2Fworks%2F33250853-netflix-2018-superhero-profile-ion&psig=AOvVaw2idUgiqVT6YI-P2Y6CSH1t&ust=1652860050220000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIDl1dOF5vcCFQAAAAAdAAAAABAJ");
        }
    }
}
