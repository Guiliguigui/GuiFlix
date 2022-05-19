using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class ChangedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvatarLink",
                value: "https://img.icons8.com/fluency-systems-regular/344/riverdale.png");
        }
    }
}
