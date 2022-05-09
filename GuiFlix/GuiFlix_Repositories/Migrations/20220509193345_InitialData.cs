using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_ProfileId",
                table: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Likes_ProfileId_MediaId",
                table: "Likes",
                columns: new[] { "ProfileId", "MediaId" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "FirstName", "IsBanned", "LastName", "Password", "Phone" },
                values: new object[] { 1, "guillaume@exemlpe.com", "Guillaume", false, "Mairesse", "PAss00++", "0607080910" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Animation" },
                    { 2, "Kids" }
                });

            migrationBuilder.InsertData(
                table: "CrewMembers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Sacha", "Goedegebure" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Duration", "Name", "Pegi", "RealeaseDate", "SourceLink", "ThumbnailLink", "Type" },
                values: new object[] { 1, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), "Big Buck Bunny", 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Big_buck_bunny_poster_big.jpg/220px-Big_buck_bunny_poster_big.jpg", "Film" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Name", "Pegi", "RealeaseDate", "ThumbnailLink", "Type" },
                values: new object[] { 2, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", "Big Buck Bunny Tv Show", 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtPQO_zVUkEEhnaW9sebyVmXW8-jGgjPh2Yw&usqp=CAU", "TVShow" });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Description", "Duration", "EpisodeNumber", "Name", "RealeaseDate", "Season", "SourceLink", "TVShowId", "ThumbnailLink" },
                values: new object[] { 1, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Part 1", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLR4POz5A0cyaupJwOVd7aLggs4GhP_qugkg&usqp=CAU" });

            migrationBuilder.InsertData(
                table: "MediaCrewMembers",
                columns: new[] { "Id", "CrewMemberId", "MediaId", "Role" },
                values: new object[,]
                {
                    { 1, 1, 1, "Realisator" },
                    { 2, 1, 2, "Realisator" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "AvatarLink", "UserName" },
                values: new object[] { 1, 1, "https://upload.wikimedia.org/wikipedia/commons/0/0b/Netflix-avatar.png?20201013161117", "Guigui" });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "MediaId", "ProfileId", "Type" },
                values: new object[] { 1, 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "MediaId", "ProfileId", "Type" },
                values: new object[] { 2, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "Name", "ProfileId" },
                values: new object[] { 1, "My List", 1 });

            migrationBuilder.InsertData(
                table: "ListMedia",
                columns: new[] { "ListsId", "MediasId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ListMedia",
                columns: new[] { "ListsId", "MediasId" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_MediaId",
                table: "Likes",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Medias_MediaId",
                table: "Likes",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Medias_MediaId",
                table: "Likes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Likes_ProfileId_MediaId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_MediaId",
                table: "Likes");

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ListMedia",
                keyColumns: new[] { "ListsId", "MediasId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ListMedia",
                keyColumns: new[] { "ListsId", "MediasId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MediaCrewMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Likes");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ProfileId",
                table: "Likes",
                column: "ProfileId");
        }
    }
}
