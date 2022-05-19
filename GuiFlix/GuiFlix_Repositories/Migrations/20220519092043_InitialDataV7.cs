using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "SourceLink",
                value: "https://rr6---sn-ab5l6nzy.googlevideo.com/videoplayback?expire=1652966835&ei=U_GFYo-WFKmP_9EPgMKksAk&ip=23.254.90.22&id=o-AAEDR0qq3f-wiGGo2eHMCJnk7OWcLLZQTBv82908wTy0&itag=22&source=youtube&requiressl=yes&mh=Mk&mm=31%2C29&mn=sn-ab5l6nzy%2Csn-ab5sznld&ms=au%2Crdu&mv=m&mvi=6&pl=23&initcwndbps=847500&vprv=1&mime=video%2Fmp4&cnr=14&ratebypass=yes&dur=112.454&lmt=1507360403968615&mt=1652944861&fvip=5&fexp=24001373%2C24007246&c=ANDROID&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAPmV_DxIkD4fgsSkaVpDO4XORnrFk8HO2H1tPxOieT1jAiEAg57qbL08dz4j7Dr3tU54suyAqlvL0zVBP8ZZumpEsA4%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRgIhAKWUIXdsKK_4UqYo6xfUEHvxcgeToxdproXXhbIRFC-wAiEA5jHofMGzaCD3WNFkr3fjriz9-kzO1z9tO3iYR7ohBrg%3D&title=Simpsons%20Intro%20HD");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "SourceLink",
                value: "https://dl2.iyoutubetomp4.com/file/youtubeQTm8Vqra7bE134.mp4?fn=G%C3%A9n%C3%A9rique%20des%20Simpson%20-%202%C3%A8me.mp4");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatarLink",
                value: "https://mir-s3-cdn-cf.behance.net/project_modules/disp/bf6e4a33850498.56ba69ac3064f.png");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvatarLink",
                value: "https://ih0.redbubble.net/image.618379802.1473/flat,1000x1000,075,f.u2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "SourceLink",
                value: "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "SourceLink",
                value: "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm");

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
    }
}
