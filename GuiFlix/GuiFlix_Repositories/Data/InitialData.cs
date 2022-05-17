using GuiFlix_Models.Models;
using GuiFlix_Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Data
{
    public class InitialData
    {
        public CryptPasswordService _cryptPasswordService;
        public InitialData(string secretKey)
        {
            _cryptPasswordService = new CryptPasswordService(secretKey);
        }
        public Admin[] Admins => new Admin[]
        {
            new Admin
            {
                Id = 1,
                UserName = "admin",
                Password = _cryptPasswordService.EncryptPassword("admin")
            }
        };
        public Question[] Questions => new Question[]
        {
            new Question
            {
                Id = 1,
                Title = "What is Guiflix ?",
                Answer = "It's a Netflix-like streaming platform."
            },
            new Question
            {
                Id = 2,
                Title = "How much does Guiflix cost ?",
                Answer = "It cost nothing."
            },
            new Question
            {
                Id = 3,
                Title = "Where can I watch ?",
                Answer = "You have to register to watch anything."
            },
            new Question
            {
                Id = 4,
                Title = "How do I cancel ?",
                Answer = "You can delete your account at any moment in your account settings."
            },
            new Question
            {
                Id = 5,
                Title = "What can I watch on Netflix ?",
                Answer = "Principaly, you can watch Films and Tv Shows."
            }
        };
        public Account[] Accounts => new Account[]
        {
            new Account
            {
                Id= 1,
                FirstName="Guillaume",
                LastName="Mairesse",
                Email="guillaume@exemlpe.com",
                Phone="0607080910",
                IsBanned=false,
                Password=_cryptPasswordService.EncryptPassword("PAss00++")
            }
        };
        public Profile[] Profiles => new Profile[]
        {
            new Profile
            {
                Id=1,
                UserName="Guigui",
                AccountId=1,
                AvatarLink="https://upload.wikimedia.org/wikipedia/commons/0/0b/Netflix-avatar.png?20201013161117"
            }
            ,new Profile
            {
                Id=2,
                UserName="YoYo",
                AccountId=1,
                AvatarLink="https://archive.org/download/profiles_202104/hero.png"
            },new Profile
            {
                Id=3,
                UserName="RoRo",
                AccountId=1,
                AvatarLink="https://mir-s3-cdn-cf.behance.net/project_modules/disp/bf6e4a33850498.56ba69ac3064f.png"
            }
        };
        public Film[] Films => new Film[]
        {
            new Film
            {
                Id=1,
                Name="Big Buck Bunny",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,1,1),
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://peach.blender.org/wp-content/uploads/bbb-splash.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },

            new Film
            {
                Id=3,
                Name="Rampage: Out of Control",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.francetvinfo.fr/pictures/f9wGZUBj31FFuL6kQvKFkPtHCu0/752x423/2019/04/11/rampage_a.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=4,
                Name="The NorthMan",
                Pegi=Media.PegiTypes.Pegi18,
                RealeaseDate=new DateTime(2022,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://media2.ledevoir.com/images_galerie/nwd_1205172_954681/image.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=5,
                Name="The Pilgrim's Progress",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.ytimg.com/vi/ksu-zTG9HHg/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=6,
                Name="New Gods: Nezha Reborn",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2022,05,13),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.flixwatch.co/wp-content/uploads/81418302.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=7,
                Name="Avatar: The Shape of Water",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2022,12,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://images.bfmtv.com/vFdrtem8xl6HgTlN3LL5a1s7hLM=/3x2:1363x767/1360x0/images/-206289.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=8,
                Name="LightYear",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2023,04,24),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://static1.srcdn.com/wordpress/wp-content/uploads/2021/10/Lightyear-trailer-teases-the-origins-of-evil-emperor-zurg.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=9,
                Name="Spies In Disguise",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,12,7),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.comingsoon.net/assets/uploads/2018/10/SpiesF.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=10,
                Name="Howl's Moving Castle",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2004,09,5),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://thumb.canalplus.pro/http/unsafe/%7BresolutionXY%7D/filters:quality(%7BimageQualityPercentage%7D)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/98794877",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=11,
                Name="Princess Mononoké",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(1997,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://static.hitek.fr/img/actualite/ill_m/623669905/princessemononoke.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=12,
                Name="The Simpson's: The Movies",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2010,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://media.gqmagazine.fr/photos/5eb165192bfbee9eb2f42e42/master/pass/los-simpson-cuarto-oculto.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=13,
                Name="OnWard",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://lumiere-a.akamaihd.net/v1/images/onward_unauthenticateddetailhero_1_62adaf28.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=14,
                Name="Soul",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2021,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://3238leblogdemarvelll-1278.kxcdn.com/wp-content/uploads/2020/12/soul-pixar-disneyplus-banniere-scaled.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=15,
                Name="Big Hero 6",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2016,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="http://www.jmlalonde.com/wp-content/uploads/2014/11/big-hero-6-character-promo-image-550x302.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=16,
                Name="Over The Moon",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2016,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://news.dayfr.com/divertissement/content/uploads/2022/04/17/332059afdb.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=17,
                Name="Space Chimps",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52831542",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=18,
                Name="Flavor Of Youth",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABaKGGyhZTOvyji9QRhhVZG4Ldy0Dpk53Wr2YVtcthf8S9TgockeX1WoxYt9dpmO6802FZ2pWPBrblpfzPBesYooyF58RIWV_fvyN.jpg?r=7d2",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=19,
                Name="Spider-Man: Into the SpiderVerse",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2020,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://medias.3dvf.com/news/sitegrab/persichetti_spiderman_02.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=20,
                Name="The Rain Children",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2020,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://imgsrc.cineserie.com/2020/04/136584.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=21,
                Name="Astro Boy",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2011,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.onnetflix.com.au/media/bgimages/70108989/0464ca78ce9d5d5918886f8a5b7eafbecdb72611.webp",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=22,
                Name="The Mitchell VS The Machines",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2011,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://premiere.fr/sites/default/files/styles/scale_crop_1280x720/public/2020-03/de%CC%81connecte%CC%81s_0.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=23,
                Name="Flushed Away",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2006,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABe4Y3SGjIsx2bZXiRz2mxBwEmYP06MocUxTtTT_iYnkF7tRQV8IFKnNV17A950-x4xWeUUQ95y0DdFAbS3CftLIU6JE6KvEEWWcb.jpg?r=e38",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=24,
                Name="The Shining",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(1980,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i0.wp.com/halacine.com/wp-content/uploads/2022/03/The-Shining-de-Stephen-King-devient-une-piece-de-theatre.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=25,
                Name="Sinister",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2012,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.ytimg.com/vi/4sfzhzRAceE/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=26,
                Name="Mister Babaddook",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2014,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://catholicgirlbloggin.files.wordpress.com/2015/07/23babadook2-articlelarge.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=27,
                Name="A NightMare On Elm Street",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2012,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://thumb.canalplus.pro/http/unsafe/1280x720/filters:quality(80)/img-hapi.canalplus.pro:80/ServiceImage/ImageID/52833622",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=28,
                Name="It",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.noovomoi.ca/content/dam/style-de-vie/migrated/images/2019/05/09/it-chapter-two.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=29,
                Name="Death At a Funeral",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://a.ltrbxd.com/resized/sm/upload/96/1r/hy/ic/death-at-a-funeral-1200-1200-675-675-crop-000000.jpg?k=c96960e4b1",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=30,
                Name="Let's Be Cops",
                Pegi=Media.PegiTypes.Pegi13,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.gannett-cdn.com/-mm-/862d45e47a2718a9e56ef6e47538ecb266665222/c=0-297-5760-3537/local/-/media/LafayetteIN/2014/08/20/filmreviewletsbeccarr.jpg?width=3200&height=1800&fit=crop&format=pjpg&auto=webp",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=31,
                Name="The Interview",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.blogs.es/62ac2a/650_1000_cartel-the-interview/1366_2000.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=32,
                Name="Bruce AlMighty",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.cinematheque.fr/cache/media/programmation/films/bruce-tout-puissant/s,725-549cdf.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=33,
                Name="Evan AlMighty",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://productplacementblog.com/wp-content/uploads/2018/01/Century-21-Real-Estate-Company-in-Evan-Almighty-3.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=34,
                Name="Megamind",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2009,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="http://ekladata.com/sxd6A2dJIqb4TEr9wSVudl9dupw.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=35,
                Name="Iron Man 3",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2014,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://img-31.ccm2.net/VXvUmaJweeWRShVXxn2cwrskiY8=/1240x/smart/8effb5b443a6483eaed2a8f886b037e3/ccmcms-hugo/10759516.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=36,
                Name="Avengers",
                Pegi=Media.PegiTypes.Pegi13,
                RealeaseDate=new DateTime(2012,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.telez.fr/content/uploads/2019/04/avengers-1-1280x720.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            }
        };
        public TVShow[] TVShows => new TVShow[]
        {
            new TVShow
            {
                Id=2,
                Name="Big Buck Bunny Tv Show",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,1,1),
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://www.embedded-france.org/wp-content/uploads/2013/04/big_buck_bunny_2008_11.jpg"
            }
        };
        public Episode[] Episodes => new Episode[]
        {
            new Episode
            {
                Id = 1,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 2,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 3,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e3",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 4,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p2e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 5,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            }
        };
        public Category[] Categories => new Category[]
        {
            new Category
            {
                Id=1,
                Name="Animation"
            },
            new Category
            {
                Id=2,
                Name="Kids"
            },
            new Category
            {
                Id=3,
                Name="Action"
            },
            new Category
            {
                Id=4,
                Name="Horror"
            },
            new Category
            {
                Id=5,
                Name="Comedy"
            }
        };
        public object[] CategoryMedia => new object[]
        {
            new
            {
                CategoriesId = 1,
                MediasId = 1,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 2,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 1,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 2,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 2,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 3,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 4,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 7,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 24,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 25,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 26,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 27,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 28,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 29,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 30,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 30,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 31,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 31,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 32,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 32,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 33,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 33,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 35,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 35,
            }
        };
        public CrewMember[] CrewMembers => new CrewMember[]
        {
            new CrewMember
            {
                Id=1,
                FirstName="Sacha",
                LastName="Goedegebure"
            }
        };
        public MediaCrewMember[] MediaCrewMember => new MediaCrewMember[]
        {
            new MediaCrewMember
            {
                Id = 1,
                CrewMemberId=1,
                MediaId=1,
                Role="Realisator"
            },
            new MediaCrewMember
            {
                Id = 2,
                CrewMemberId=1,
                MediaId=2,
                Role="Realisator"
            }
        };
        public List[] Lists => new List[]
        {
            new List
            {
                Id =1,
                Name="My List",
                ProfileId=1,
            }
        };
        public object[] ListMedia => new object[]
        {
            new
            {
                ListsId = 1,
                MediasId = 1
            },
            new
            {
                ListsId = 1,
                MediasId = 2
            }
        };
        public Like[] Likes => new Like[]
        {
            new Like
            {
                Id=1,
                ProfileId = 1,
                MediaId = 1,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=2,
                ProfileId = 1,
                MediaId = 2,
                Type = Like.LikeTypes.Dislike
            }
        };
    }
}
