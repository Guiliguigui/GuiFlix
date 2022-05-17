using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class AddSeedEpisodesAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Action" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Big Buck Bunny p1e1");

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Description", "Duration", "EpisodeNumber", "Name", "RealeaseDate", "Season", "SourceLink", "TVShowId", "ThumbnailLink" },
                values: new object[,]
                {
                    { 2, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny p1e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Part 1", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" },
                    { 3, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny p1e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Part 1", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" },
                    { 4, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny p2e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" },
                    { 5, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny p1e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Big Buck Bunny");
        }
    }
}
