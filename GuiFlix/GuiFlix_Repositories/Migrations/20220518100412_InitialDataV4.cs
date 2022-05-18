using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiFlix_Repositories.Migrations
{
    public partial class InitialDataV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                    { 5, 36 },
                    { 3, 36 }
                });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EpisodeNumber", "ThumbnailLink" },
                values: new object[] { 2, "https://image.tmdb.org/t/p/original/bZxwNUANy2KAYBjM9UyUlqiCMI1.jpg" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EpisodeNumber", "ThumbnailLink" },
                values: new object[] { 3, "https://upload.wikimedia.org/wikipedia/commons/3/31/Big.Buck.Bunny.-.Frank.Bunny.png" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EpisodeNumber", "Name", "Season", "ThumbnailLink" },
                values: new object[] { 4, "Big Buck Bunny p1e4", "Part 1", "https://upload.wikimedia.org/wikipedia/commons/4/44/Big.Buck.Bunny.-.Bunny.with.Bow.png" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "ThumbnailLink" },
                values: new object[] { "Big Buck Bunny p2e1", "https://ddz4ak4pa3d19.cloudfront.net/cache/5e/e5/5ee50a089ff4e9d1593ad8b5278f2f48.jpg" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Description", "Duration", "EpisodeNumber", "Name", "RealeaseDate", "Season", "SourceLink", "TVShowId", "ThumbnailLink" },
                values: new object[,]
                {
                    { 10, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 2, "Big Buck Bunny p3e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 3!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://i.ytimg.com/vi/2tdp1FucyAk/maxresdefault.jpg" },
                    { 9, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 1, "Big Buck Bunny p3e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 3!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://cutewallpaper.org/21/big-buck-bunny-wallpapers/Big-Buck-BUNNY-by-Blender-Foundation-ALPdigest-CHANNEL.jpg" },
                    { 8, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 4, "Big Buck Bunny p2e4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://framalibre.org/sites/default/files/PeachBlender.jpg" },
                    { 7, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 3, "Big Buck Bunny p2e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://i.ytimg.com/vi/wWla97L1wng/maxresdefault.jpg" },
                    { 26, "Bart fails a test and is told he has one more chance to pass it or else he will be held back a year. Bart tries to get the class genius Martin Prince to help him, but after that fails, Bart prays for help. That night, Springfield is hit with a massive blizzard and the school is closed, giving Bart one more day to study. Despite his desperate attempts, Bart fails the test again. While crying, he mentions an obscure historical event and Mrs. Krabappel, noting that he applied practical knowledge, passes him.", new TimeSpan(0, 0, 10, 35, 0), 10, "Bart Gets an F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BNzQ3ZDJjMTUtOTllNi00ZmY4LWI2MjktOWJiNmM4ZjBmZDgxXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 25, "Marge, feeling unappreciated by Homer, makes a call to a radio therapist, which Homer overhears at work. Homer, wanting to make it up to Marge, decides to take her to dinner at a fancy restaurant and hires a babysitter to take care of Bart and Lisa. They are sent Ms. Botz, who Bart and Lisa soon discover is actually a burglar nicknamed The Babysitter Bandi. They are captured by Ms. Botz and tied up but eventually are freed by Maggie. Bart and Lisa capture Ms. Botz and call the police. Meanwhile, Marge and Homer return home and find Ms. Botz is tied up. Homer, unaware of her true identity, frees her and Ms. Botz makes a clean getaway just moments before the police arrive.", new TimeSpan(0, 0, 10, 35, 0), 9, "Some Enchanted Evening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BZmFkZDY3MjItMGY0NS00YTFkLWI1YjMtYzEwMTliYTFiMmFkXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 24, "While buying ice cream at the Kwik-E-Mart, Homer witnesses a robbery perpetrated by a man believed to be Krusty the Clown, host of Krusty the Clown Show, Bart's favorite program. Krusty is sent to jail and his show is taken over by his assistant, Sideshow Bob. Bart is certain Krusty is innocent, and gathers evidence to support his claim, which he takes to Krusty's bestest friend, Sideshow Bob. Bart realizes the robbery was actually committed by Bob, who was trying to frame Krusty. Bob is arrested and Krusty thanks Bart for saving him.", new TimeSpan(0, 0, 10, 35, 0), 8, "Krusty Gets Busted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BNDFhNjFkNzgtN2M4OC00YTg1LWI5NjEtZGIxNTUyNTMyNjg5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 23, "Principal Skinner finally becomes fed up with Bart's pranks and proposes that Bart be sent to France as part of the student exchange program. The family agrees and Bart is sent to the beautiful Château Maison, which is actually a dilapidated farmhouse on a neglected vineyard. Bart is treated like a slave by two unscrupulous winemakers, César and Ugolin, who eventually feed him wine tainted with antifreeze. Meanwhile, an Albanian boy named Adil starts to live with the Simpsons who, unbeknownst to Homer, is a spy sent by his country to obtain nuclear blueprints. Back in France, Bart learns French and reports the winemakers' crimes to the authorities.", new TimeSpan(0, 0, 10, 35, 0), 7, "The Crepes of Wrath", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BMDc0YzBhOWItYjk0OS00YTBiLWEwNDUtMzI2YzQ0NWM1YjNlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 22, "Bart purchases a mini spy camera and manages to take a picture of Homer dancing next to stripper named Princess Kashmir at a co-worker's strip club party. He gives copies of the picture to his friends, and eventually the picture starts to circulate around until eventually Marge sees it. She kicks Homer out of the house, but the next day explains that she is not upset about his dancing next to a woman, but rather that Bart saw it. She demands that he take Bart and go apologize to Princess Kashmir. Homer agrees and says he is ready to start respecting women.", new TimeSpan(0, 0, 10, 35, 0), 6, "Homer's Night Out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BMDFjMjQzYTMtMGM2YS00NjYyLTg3NzktMDAyZjJiY2E5MTcwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 21, "Having forgotten about Marge's birthday, Homer rushes to the Springfield mall and impulsively buys her a bowling ball. Marge is not impressed with the gift and after discovering that he intends to use it, she decides to spite him by going bowling herself. While at the alley, she meets Jacques, a charming French bowling instructor, who offers her lessons. Jacques begins to fall for Marge and invites her to his apartment. Although she agrees, Marge undergoes a moral dilemma. In the end, Marge visits Homer at the nuclear plant.", new TimeSpan(0, 0, 10, 35, 0), 5, "Life On The Fast Lane", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BNjY3NzExYWYtNGFlZC00NmJkLTlhZjQtN2RlYWIyMTYzYWYwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 6, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 2, "Big Buck Bunny p2e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://i.ytimg.com/vi/4-Ddumty4mk/maxresdefault.jpg" },
                    { 19, "Homer becomes envious of Flanders' new RV and goes to Bob's RV Round-up to buy one of his own. Settling on a dilapidated camper, he takes the family camping and in the process destroys the RV. Leaving Lisa and Marge behind, Bart and Homer try to find their way back to civilization, but have little luck. Later on, Homer is mistaken for Bigfoot and captured. Marge, Bart and Lisa are saved and Homer is released, although scientists say they can not determine which species he belongs to.", new TimeSpan(0, 0, 10, 35, 0), 3, "The Call of The Simpsons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BOTkxMzY3Y2QtMWMyMC00NDllLTkyMTctZTY4MDFjZGExYTc1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 18, "Lisa becomes depressed, which begins to affect her performance in school. Neither Marge nor Homer are able to make Lisa happier. One night, she hears distant Jazz music and sneaks out of her room to follow it. She meets Bleeding Gums Murphy, who teaches her how to express her music through the saxophone. When Marge drops Lisa off at school the next day, she suggests that Lisa smile no matter how she feels. However, Marge sees that Lisa is being denied her creativity and realizes that is what is disappointing her. Marge tells Lisa to just be herself, and the entire family go to see Murphy perform at a local Jazz club.", new TimeSpan(0, 0, 10, 35, 0), 2, "Moaning Lisa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BOWFlN2U2NWYtZWIyYy00YTY5LTlhMDAtZmQwMWZhM2I3MjQ4XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 17, "Bart runs afoul of Nelson Muntz, the school bully, who begins attacking Bart every day after school. Homer suggests fighting back, which does not work. Desperate for a solution, Bart visits Grampa for advice. Grampa takes Bart to meet Herman, who suggests that Bart rally all the school children and declare war on Nelson. Bart and his army attack Nelson and successfully manage to convince him to give up his bullying ways.", new TimeSpan(0, 0, 10, 35, 0), 1, "Bart The General", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BMzk4ZDU2OTMtZjM0NC00ZWIyLWFmNmQtMjcyZGQ1OWE0ZWMyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 16, "Homer takes his family to the company picnic at Mr. Burns's manor. Marge, Bart and Lisa embarrass Homer and he notices that Mr. Burns seems to favour a family who love and respect one another. Convinced that both he and his family are pathetic, he takes everyone to a family therapy center. When standard methods prove useless in civilizing them, the doctor resorts to shock therapy. Soon the Simpsons start shocking each other, causing the whole town to lose power.", new TimeSpan(0, 0, 10, 35, 0), 4, "There's no Disgrace Like Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 1!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BZTU3OTgxNjItMWQ2Mi00YjA4LWEwMzctNDYxNWRkYTY1NDYyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
                    { 15, "Bart's class visits the Springfield Nuclear Power Plant and Homer, anxious to look like he is working, accidentally crashes his cart into a radioactive pipe, causing him to be fired. Depressed and unable to find a new job, he decides to commit suicide by jumping off a bridge. His family discover his plan and try to stop him, but in the process they are almost run over by a truck. Discovering his new purpose, Homer embarks on a safety crusade and eventually decides to go after the Nuclear Plant and holds protest rallies. To end Homer's furor, Mr. Burns offers him a job as safety inspector, with increased salary, which Homer accepts.", new TimeSpan(0, 0, 10, 35, 0), 3, "Homer's Odyssey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 1!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BZTIxMDk3MTEtNDExYi00MDBhLTljMmMtZjI0Y2I1YTlkZGY1XkEyXkFqcGdeQXVyMjI4OTg3MTc@._V1_.jpg" },
                    { 14, "Bart has trouble on an intelligence test and sneakily switches tests with Martin Prince, the class genius. After the results are tabulated, the school psychiatrist labels Bart a genius and sends him to the Enriched Learning Center for Gifted Children. Homer starts treating Bart with respect, but Bart immediately feels out of place among his new classmates and alienated from his former peers. He confesses that he cheated on the test and is subsequently sent back to Springfield Elementary School.", new TimeSpan(0, 0, 10, 35, 0), 2, "Bart the genius", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 1!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://i.ytimg.com/vi/vTB26Fxp57Q/maxresdefault.jpg" },
                    { 13, "While the Simpsons are Christmas shopping, Bart sneaks off and gets a tattoo. Marge soon discovers this and uses the family's Christmas savings to get it removed. Meanwhile, Homer discovers that he will not be getting a Christmas bonus from Mr. Burns and thus the family has no money to buy Christmas presents. He decides to keep their financial troubles a secret and get a job as a department store Santa, but later discovers that the job does not pay enough. Desperate for a miracle, Homer and Bart go to the dog track on Christmas Eve in hopes of earning some money. He bets it all on a long shot named Santa's Little Helper, who loses. Angry that he lost, the dog's owner disowns him. Homer lets Bart keep him. Later, Homer attempts to come clean to everyone, but Bart exclaims that they have a dog and everyone happily welcomes the newest member of the Simpson family.", new TimeSpan(0, 0, 10, 35, 0), 1, "Simpsons Roasting on Open Fire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 1!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://static3.srcdn.com/wordpress/wp-content/uploads/2019/04/SIMPSONS-PETS-RANKED.jpg" },
                    { 20, "Bart becomes friends with Jimbo, Dolph, and Kearney, a group of local troublemakers. Trying to impress them, Bart decides to cut off and steal the head of the statue of Jebediah Springfield. The next day, the entire town grieves for the vandalized statue and Bart discovers that his new friends want to attack the vandal. Feeling remorse, Bart confesses to his family and Homer and Bart take the head back to the statue after passing through the furious people.", new TimeSpan(0, 0, 10, 35, 0), 4, "The Telltale Head", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 2!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 3, "https://m.media-amazon.com/images/M/MV5BNTFmZWU1YTAtOWIzMy00ZDY2LWFhNDktMjBmMjk5YmU5NmFiXkEyXkFqcGdeQXVyMjI4OTg3MTc@._V1_.jpg" },
                    { 12, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 4, "Big Buck Bunny p3e4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 3!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://flossmanuals.developpez.com/tutoriels/blender/jeu-video/images/yofrankie15.png" },
                    { 11, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", new TimeSpan(0, 0, 10, 35, 0), 3, "Big Buck Bunny p3e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partie 3!", "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm", 2, "https://i0.wp.com/thinkinganimation.com/wp-content/uploads/2008/06/evil-frank.png" }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "MediaId", "ProfileId", "Type" },
                values: new object[,]
                {
                    { 24, 24, 1, 1 },
                    { 25, 25, 1, 0 },
                    { 26, 26, 1, 2 },
                    { 27, 27, 1, 1 },
                    { 28, 28, 1, 0 },
                    { 29, 29, 1, 2 },
                    { 32, 32, 1, 2 },
                    { 31, 31, 1, 0 },
                    { 33, 33, 1, 1 },
                    { 34, 34, 1, 0 },
                    { 35, 35, 1, 2 },
                    { 36, 36, 1, 1 },
                    { 23, 23, 1, 2 },
                    { 30, 30, 1, 1 },
                    { 22, 22, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "MediaId", "ProfileId", "Type" },
                values: new object[,]
                {
                    { 13, 13, 1, 1 },
                    { 20, 20, 1, 0 },
                    { 3, 3, 1, 2 },
                    { 4, 4, 1, 1 },
                    { 5, 5, 1, 0 },
                    { 6, 6, 1, 2 },
                    { 7, 7, 1, 1 },
                    { 8, 8, 1, 0 },
                    { 21, 21, 1, 2 },
                    { 9, 9, 1, 2 },
                    { 12, 12, 1, 2 },
                    { 14, 14, 1, 0 },
                    { 15, 15, 1, 2 },
                    { 16, 16, 1, 1 },
                    { 17, 17, 1, 0 },
                    { 18, 18, 1, 2 },
                    { 19, 19, 1, 1 },
                    { 11, 11, 1, 0 },
                    { 10, 10, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Name", "Pegi", "RealeaseDate", "ThumbnailLink", "Type" },
                values: new object[] { 37, "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.", "The Simpson's Tv Show", 0, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img.betaseries.com/qWBzg3rSTSQk5IwvvKISgAa3i7Q=/500x282/smart/https%3A%2F%2Fwww.betaseries.com%2Fblog%2Fwp-content%2Fuploads%2F2021%2F07%2F12_62521772.jpeg", "TVShow" });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                    { 5, 37 },
                    { 3, 37 },
                    { 1, 37 }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "MediaId", "ProfileId", "Type" },
                values: new object[] { 37, 37, 1, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 36 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "CategoryMedia",
                keyColumns: new[] { "CategoriesId", "MediasId" },
                keyValues: new object[] { 5, 37 });

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EpisodeNumber", "ThumbnailLink" },
                values: new object[] { 1, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EpisodeNumber", "ThumbnailLink" },
                values: new object[] { 1, "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EpisodeNumber", "Name", "Season", "ThumbnailLink" },
                values: new object[] { 1, "Big Buck Bunny p2e1", "Partie 2!", "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "ThumbnailLink" },
                values: new object[] { "Big Buck Bunny p1e2", "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg" });
        }
    }
}
