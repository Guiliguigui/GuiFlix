using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Horror" },
                    { 5, "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Duration", "Name", "Pegi", "RealeaseDate", "SourceLink", "ThumbnailLink", "Type" },
                values: new object[,]
                {
                    { 21, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Astro Boy", 0, new DateTime(2011, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.onnetflix.com.au/media/bgimages/70108989/0464ca78ce9d5d5918886f8a5b7eafbecdb72611.webp", "Film" },
                    { 22, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Mitchell VS The Machines", 0, new DateTime(2011, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://premiere.fr/sites/default/files/styles/scale_crop_1280x720/public/2020-03/de%CC%81connecte%CC%81s_0.jpg", "Film" },
                    { 23, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Flushed Away", 0, new DateTime(2006, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABe4Y3SGjIsx2bZXiRz2mxBwEmYP06MocUxTtTT_iYnkF7tRQV8IFKnNV17A950-x4xWeUUQ95y0DdFAbS3CftLIU6JE6KvEEWWcb.jpg?r=e38", "Film" },
                    { 24, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Shining", 3, new DateTime(1980, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://i0.wp.com/halacine.com/wp-content/uploads/2022/03/The-Shining-de-Stephen-King-devient-une-piece-de-theatre.jpg", "Film" },
                    { 25, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Sinister", 3, new DateTime(2012, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://i.ytimg.com/vi/4sfzhzRAceE/maxresdefault.jpg", "Film" },
                    { 26, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Mister Babaddook", 3, new DateTime(2014, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.filmmusicsite.com/fr/images/covers/xlarge/58175-inlay.jpg", "Film" },
                    { 27, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "A NightMare On Elm Street", 3, new DateTime(2012, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52833622", "Film" },
                    { 29, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Death At a Funeral", 0, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://a.ltrbxd.com/resized/sm/upload/96/1r/hy/ic/death-at-a-funeral-1200-1200-675-675-crop-000000.jpg?k=c96960e4b1", "Film" },
                    { 20, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Rain Children", 0, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://imgsrc.cineserie.com/2020/04/136584.jpg", "Film" },
                    { 30, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Let's Be Cops", 2, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.gannett-cdn.com/-mm-/862d45e47a2718a9e56ef6e47538ecb266665222/c=0-297-5760-3537/local/-/media/LafayetteIN/2014/08/20/filmreviewletsbeccarr.jpg?width=3200&height=1800&fit=crop&format=pjpg&auto=webp", "Film" },
                    { 31, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Interview", 3, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://i.blogs.es/62ac2a/650_1000_cartel-the-interview/1366_2000.jpg", "Film" },
                    { 32, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Bruce AlMighty", 0, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.cinematheque.fr/cache/media/programmation/films/bruce-tout-puissant/s,725-549cdf.jpg", "Film" },
                    { 33, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Evan AlMighty", 0, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://productplacementblog.com/wp-content/uploads/2018/01/Century-21-Real-Estate-Company-in-Evan-Almighty-3.jpg", "Film" },
                    { 34, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Megamind", 0, new DateTime(2009, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "http://ekladata.com/sxd6A2dJIqb4TEr9wSVudl9dupw.jpg", "Film" },
                    { 35, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Iron Man 3", 0, new DateTime(2014, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://img-31.ccm2.net/VXvUmaJweeWRShVXxn2cwrskiY8=/1240x/smart/8effb5b443a6483eaed2a8f886b037e3/ccmcms-hugo/10759516.jpg", "Film" },
                    { 28, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "It", 3, new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.noovomoi.ca/content/dam/style-de-vie/migrated/images/2019/05/09/it-chapter-two.jpg", "Film" },
                    { 19, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Spider-Man: Into the SpiderVerse", 0, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://medias.3dvf.com/news/sitegrab/persichetti_spiderman_02.jpg", "Film" },
                    { 18, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Flavor Of Youth", 0, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABaKGGyhZTOvyji9QRhhVZG4Ldy0Dpk53Wr2YVtcthf8S9TgockeX1WoxYt9dpmO6802FZ2pWPBrblpfzPBesYooyF58RIWV_fvyN.jpg?r=7d2", "Film" },
                    { 17, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Space Chimps", 0, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52831542", "Film" },
                    { 36, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Avengers", 2, new DateTime(2012, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.telez.fr/content/uploads/2019/04/avengers-1-1280x720.jpg", "Film" },
                    { 3, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Rampage: Out of Control", 3, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.francetvinfo.fr/pictures/f9wGZUBj31FFuL6kQvKFkPtHCu0/752x423/2019/04/11/rampage_a.jpg", "Film" },
                    { 4, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The NorthMan", 4, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://media2.ledevoir.com/images_galerie/nwd_1205172_954681/image.jpg", "Film" },
                    { 5, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Pilgrim's Progress", 0, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://i.ytimg.com/vi/ksu-zTG9HHg/maxresdefault.jpg", "Film" },
                    { 6, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "New Gods: Nezha Reborn", 0, new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.flixwatch.co/wp-content/uploads/81418302.jpg", "Film" },
                    { 7, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Avatar: The Shape of Water", 0, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://images.bfmtv.com/vFdrtem8xl6HgTlN3LL5a1s7hLM=/3x2:1363x767/1360x0/images/-206289.jpg", "Film" },
                    { 8, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "LightYear", 0, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://static1.srcdn.com/wordpress/wp-content/uploads/2021/10/Lightyear-trailer-teases-the-origins-of-evil-emperor-zurg.jpeg", "Film" },
                    { 9, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Spies In Disguise", 0, new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://www.comingsoon.net/assets/uploads/2018/10/SpiesF.jpg", "Film" },
                    { 10, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Howl's Moving Castle", 0, new DateTime(2004, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://thumb.canalplus.pro/http/unsafe/%7BresolutionXY%7D/filters:quality(%7BimageQualityPercentage%7D)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/98794877", "Film" },
                    { 11, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Princess Mononoké", 0, new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://static.hitek.fr/img/actualite/ill_m/623669905/princessemononoke.jpg", "Film" },
                    { 12, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "The Simpson's", 0, new DateTime(2010, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://media.gqmagazine.fr/photos/5eb165192bfbee9eb2f42e42/master/pass/los-simpson-cuarto-oculto.jpg", "Film" },
                    { 13, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "OnWard", 0, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://lumiere-a.akamaihd.net/v1/images/onward_unauthenticateddetailhero_1_62adaf28.png", "Film" },
                    { 14, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Soul", 0, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://3238leblogdemarvelll-1278.kxcdn.com/wp-content/uploads/2020/12/soul-pixar-disneyplus-banniere-scaled.jpg", "Film" },
                    { 15, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Big Hero 6", 0, new DateTime(2016, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "http://www.jmlalonde.com/wp-content/uploads/2014/11/big-hero-6-character-promo-image-550x302.png", "Film" },
                    { 16, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", new TimeSpan(0, 0, 10, 35, 0), "Over The Moon", 0, new DateTime(2016, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", "https://news.dayfr.com/divertissement/content/uploads/2022/04/17/332059afdb.jpg", "Film" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "AvatarLink", "UserName" },
                values: new object[,]
                {
                    { 2, 1, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fpeople%2Fnorbert-sloth%2Fworks%2F33251083-2018-netflix-chicken-profile-icon&psig=AOvVaw2idUgiqVT6YI-P2Y6CSH1t&ust=1652860050220000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIDl1dOF5vcCFQAAAAAdAAAAABAD", "YoYo" },
                    { 3, 1, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fpeople%2Fnorbert-sloth%2Fworks%2F33250853-netflix-2018-superhero-profile-ion&psig=AOvVaw2idUgiqVT6YI-P2Y6CSH1t&ust=1652860050220000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIDl1dOF5vcCFQAAAAAdAAAAABAJ", "RoRo" }
                });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 3, 23 },
                    { 2, 22 },
                    { 1, 22 },
                    { 3, 22 },
                    { 2, 21 },
                    { 1, 21 },
                    { 3, 21 },
                    { 2, 20 },
                    { 1, 20 },
                    { 3, 20 },
                    { 2, 19 },
                    { 1, 19 },
                    { 3, 19 },
                    { 2, 18 },
                    { 1, 18 },
                    { 1, 23 },
                    { 2, 23 },
                    { 4, 24 },
                    { 4, 25 },
                    { 1, 34 },
                    { 2, 34 },
                    { 3, 34 },
                    { 5, 34 },
                    { 3, 33 },
                    { 5, 33 },
                    { 3, 32 },
                    { 3, 18 },
                    { 5, 32 },
                    { 5, 31 },
                    { 3, 30 },
                    { 5, 30 },
                    { 5, 29 },
                    { 4, 28 },
                    { 4, 27 },
                    { 4, 26 },
                    { 3, 31 },
                    { 5, 35 },
                    { 2, 17 },
                    { 3, 17 },
                    { 3, 10 },
                    { 2, 9 }
                });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 3, 9 },
                    { 2, 8 },
                    { 1, 8 },
                    { 3, 8 },
                    { 3, 7 },
                    { 2, 6 },
                    { 1, 6 },
                    { 3, 6 },
                    { 2, 5 },
                    { 1, 5 },
                    { 3, 5 },
                    { 3, 4 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 11 },
                    { 1, 11 },
                    { 2, 16 },
                    { 1, 16 },
                    { 3, 16 },
                    { 2, 15 },
                    { 1, 15 },
                    { 3, 15 },
                    { 2, 14 },
                    { 1, 17 },
                    { 1, 14 },
                    { 2, 13 },
                    { 1, 13 },
                    { 3, 13 },
                    { 2, 12 },
                    { 1, 12 },
                    { 3, 12 },
                    { 2, 11 },
                    { 3, 14 },
                    { 3, 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 35 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 4, 28 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
