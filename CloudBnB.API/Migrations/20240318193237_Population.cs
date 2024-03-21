using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudBnB.API.Migrations
{
    /// <inheritdoc />
    public partial class Population : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Roberta0@yahoo.com", "Roberta", "Wolff" },
                    { 2, "Leland_Denesik69@hotmail.com", "Leland", "Denesik" },
                    { 3, "Tina52@yahoo.com", "Tina", "Koelpin" },
                    { 4, "Kelley_OKon52@gmail.com", "Kelley", "O'Kon" },
                    { 5, "Bennie17@gmail.com", "Bennie", "Roberts" },
                    { 6, "Kim49@hotmail.com", "Kim", "Wyman" },
                    { 7, "Leah4@hotmail.com", "Leah", "Olson" },
                    { 8, "Marion_Effertz@hotmail.com", "Marion", "Effertz" },
                    { 9, "Cecil_Kuhic74@gmail.com", "Cecil", "Kuhic" },
                    { 10, "Kurt11@hotmail.com", "Kurt", "Hills" },
                    { 11, "Joshua.Berge21@gmail.com", "Joshua", "Berge" },
                    { 12, "Judy5@yahoo.com", "Judy", "Huels" },
                    { 13, "Kristopher_Hagenes86@gmail.com", "Kristopher", "Hagenes" },
                    { 14, "Donnie_Sawayn@yahoo.com", "Donnie", "Sawayn" },
                    { 15, "Patrick_Kerluke37@gmail.com", "Patrick", "Kerluke" },
                    { 16, "Laurie.Little9@yahoo.com", "Laurie", "Little" },
                    { 17, "Lionel_Rowe@yahoo.com", "Lionel", "Rowe" },
                    { 18, "Franklin_Hintz92@hotmail.com", "Franklin", "Hintz" },
                    { 19, "Julian.Keebler@gmail.com", "Julian", "Keebler" },
                    { 20, "Reginald.Hagenes59@gmail.com", "Reginald", "Hagenes" },
                    { 21, "Salvador_Turcotte@gmail.com", "Salvador", "Turcotte" },
                    { 22, "Cedric63@gmail.com", "Cedric", "Dickinson" },
                    { 23, "Billy46@hotmail.com", "Billy", "Hudson" },
                    { 24, "Jean_Hermann11@yahoo.com", "Jean", "Hermann" },
                    { 25, "Ricky_Pfannerstill84@hotmail.com", "Ricky", "Pfannerstill" },
                    { 26, "Jimmy_Muller40@gmail.com", "Jimmy", "Muller" },
                    { 27, "Luther79@yahoo.com", "Luther", "Fay" },
                    { 28, "Lila.Gislason@yahoo.com", "Lila", "Gislason" },
                    { 29, "Jane_Bruen@gmail.com", "Jane", "Bruen" },
                    { 30, "Francis_Gerlach11@hotmail.com", "Francis", "Gerlach" },
                    { 31, "Pam_King@gmail.com", "Pam", "King" },
                    { 32, "Lester.Thompson52@hotmail.com", "Lester", "Thompson" },
                    { 33, "Santiago.Johns@yahoo.com", "Santiago", "Johns" },
                    { 34, "Lynda.Turcotte@gmail.com", "Lynda", "Turcotte" },
                    { 35, "Josh_Cummerata@yahoo.com", "Josh", "Cummerata" },
                    { 36, "Gary41@gmail.com", "Gary", "Pacocha" },
                    { 37, "Chester66@gmail.com", "Chester", "Altenwerth" },
                    { 38, "Aaron.Jenkins@gmail.com", "Aaron", "Jenkins" },
                    { 39, "Ron46@yahoo.com", "Ron", "McKenzie" },
                    { 40, "Chad.King3@gmail.com", "Chad", "King" },
                    { 41, "Colleen98@gmail.com", "Colleen", "Mayer" },
                    { 42, "Lois_Russel@hotmail.com", "Lois", "Russel" },
                    { 43, "Woodrow.Yost@gmail.com", "Woodrow", "Yost" },
                    { 44, "Ted.Kihn@hotmail.com", "Ted", "Kihn" },
                    { 45, "Katrina.Batz@hotmail.com", "Katrina", "Batz" },
                    { 46, "Cindy82@gmail.com", "Cindy", "Dooley" },
                    { 47, "Faith89@yahoo.com", "Faith", "DuBuque" },
                    { 48, "Tyrone.Hills99@gmail.com", "Tyrone", "Hills" },
                    { 49, "Roy98@gmail.com", "Roy", "Waelchi" },
                    { 50, "Timothy_Yost76@gmail.com", "Timothy", "Yost" },
                    { 51, "Tomas.Stark@yahoo.com", "Tomas", "Stark" },
                    { 52, "Angela_Gleichner45@yahoo.com", "Angela", "Gleichner" },
                    { 53, "Jack.Hirthe41@gmail.com", "Jack", "Hirthe" },
                    { 54, "Pat80@yahoo.com", "Pat", "Schroeder" },
                    { 55, "Mabel38@hotmail.com", "Mabel", "Bergstrom" },
                    { 56, "Wilma.Armstrong90@yahoo.com", "Wilma", "Armstrong" },
                    { 57, "Eloise6@hotmail.com", "Eloise", "Beatty" },
                    { 58, "Boyd_Jenkins@yahoo.com", "Boyd", "Jenkins" },
                    { 59, "Jennifer10@gmail.com", "Jennifer", "Flatley" },
                    { 60, "Misty.Goldner71@hotmail.com", "Misty", "Goldner" },
                    { 61, "Brent47@gmail.com", "Brent", "Beier" },
                    { 62, "Sheryl52@gmail.com", "Sheryl", "Botsford" },
                    { 63, "Billie63@hotmail.com", "Billie", "Ryan" },
                    { 64, "Kelley27@yahoo.com", "Kelley", "Boyer" },
                    { 65, "Edmond87@gmail.com", "Edmond", "Glover" },
                    { 66, "Madeline.Carter49@hotmail.com", "Madeline", "Carter" },
                    { 67, "Connie_Kunze59@gmail.com", "Connie", "Kunze" },
                    { 68, "Preston.Runolfsson@gmail.com", "Preston", "Runolfsson" },
                    { 69, "Elijah.DAmore61@gmail.com", "Elijah", "D'Amore" },
                    { 70, "Melba57@yahoo.com", "Melba", "Gaylord" },
                    { 71, "Scott44@yahoo.com", "Scott", "Kerluke" },
                    { 72, "Kirk.Mosciski@yahoo.com", "Kirk", "Mosciski" },
                    { 73, "Marjorie83@gmail.com", "Marjorie", "Mueller" },
                    { 74, "Christine26@hotmail.com", "Christine", "Murphy" },
                    { 75, "Lowell46@hotmail.com", "Lowell", "Morar" },
                    { 76, "Amelia.Leffler73@hotmail.com", "Amelia", "Leffler" },
                    { 77, "Tracey1@gmail.com", "Tracey", "Boyle" },
                    { 78, "Rudy_Funk63@gmail.com", "Rudy", "Funk" },
                    { 79, "Vincent.Gibson26@gmail.com", "Vincent", "Gibson" },
                    { 80, "Clara.Grady13@hotmail.com", "Clara", "Grady" },
                    { 81, "Edna.Reichert@hotmail.com", "Edna", "Reichert" },
                    { 82, "Dallas.Hane89@gmail.com", "Dallas", "Hane" },
                    { 83, "Marcos66@gmail.com", "Marcos", "Von" },
                    { 84, "Eugene.Hoppe@hotmail.com", "Eugene", "Hoppe" },
                    { 85, "Mamie63@hotmail.com", "Mamie", "Larson" },
                    { 86, "Claire.Doyle@yahoo.com", "Claire", "Doyle" },
                    { 87, "Marty.Shanahan@gmail.com", "Marty", "Shanahan" },
                    { 88, "Zachary51@hotmail.com", "Zachary", "Corkery" },
                    { 89, "Annette_Ankunding@hotmail.com", "Annette", "Ankunding" },
                    { 90, "Brooke.Nader69@yahoo.com", "Brooke", "Nader" },
                    { 91, "Garrett.Hyatt@yahoo.com", "Garrett", "Hyatt" },
                    { 92, "Delbert_Mitchell14@hotmail.com", "Delbert", "Mitchell" },
                    { 93, "Betty_Hickle21@hotmail.com", "Betty", "Hickle" },
                    { 94, "Guillermo_Abernathy@hotmail.com", "Guillermo", "Abernathy" },
                    { 95, "Bessie.Kub67@hotmail.com", "Bessie", "Kub" },
                    { 96, "Carroll24@yahoo.com", "Carroll", "Medhurst" },
                    { 97, "Gregory.Hamill49@yahoo.com", "Gregory", "Hamill" },
                    { 98, "Doreen.Schoen12@yahoo.com", "Doreen", "Schoen" },
                    { 99, "Cristina_White@yahoo.com", "Cristina", "White" },
                    { 100, "Wanda60@hotmail.com", "Wanda", "Bartell" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "Url" },
                values: new object[,]
                {
                    { 1, false, "https://picsum.photos/40/40/?image=862" },
                    { 2, false, "https://picsum.photos/40/40/?image=45" },
                    { 3, false, "https://picsum.photos/40/40/?image=47" },
                    { 4, false, "https://picsum.photos/40/40/?image=41" },
                    { 5, false, "https://picsum.photos/40/40/?image=925" },
                    { 6, false, "https://picsum.photos/40/40/?image=386" },
                    { 7, false, "https://picsum.photos/40/40/?image=3" },
                    { 8, false, "https://picsum.photos/40/40/?image=1081" },
                    { 9, false, "https://picsum.photos/40/40/?image=1048" },
                    { 10, false, "https://picsum.photos/40/40/?image=678" },
                    { 11, false, "https://picsum.photos/40/40/?image=28" },
                    { 12, false, "https://picsum.photos/40/40/?image=701" },
                    { 13, false, "https://picsum.photos/40/40/?image=981" },
                    { 14, false, "https://picsum.photos/40/40/?image=858" },
                    { 15, false, "https://picsum.photos/40/40/?image=573" },
                    { 16, false, "https://picsum.photos/40/40/?image=778" },
                    { 17, false, "https://picsum.photos/40/40/?image=146" },
                    { 18, false, "https://picsum.photos/40/40/?image=902" },
                    { 19, false, "https://picsum.photos/40/40/?image=533" },
                    { 20, false, "https://picsum.photos/40/40/?image=1048" },
                    { 21, true, "https://picsum.photos/300/200/?image=2" },
                    { 22, false, "https://picsum.photos/300/200/?image=844" },
                    { 23, true, "https://picsum.photos/300/200/?image=457" },
                    { 24, false, "https://picsum.photos/300/200/?image=159" },
                    { 25, true, "https://picsum.photos/300/200/?image=1" },
                    { 26, false, "https://picsum.photos/300/200/?image=154" },
                    { 27, true, "https://picsum.photos/300/200/?image=781" },
                    { 28, false, "https://picsum.photos/300/200/?image=239" },
                    { 29, true, "https://picsum.photos/300/200/?image=864" },
                    { 30, false, "https://picsum.photos/300/200/?image=604" },
                    { 31, true, "https://picsum.photos/300/200/?image=831" },
                    { 32, false, "https://picsum.photos/300/200/?image=914" },
                    { 33, true, "https://picsum.photos/300/200/?image=904" },
                    { 34, false, "https://picsum.photos/300/200/?image=248" },
                    { 35, true, "https://picsum.photos/300/200/?image=461" },
                    { 36, false, "https://picsum.photos/300/200/?image=152" },
                    { 37, true, "https://picsum.photos/300/200/?image=7" },
                    { 38, false, "https://picsum.photos/300/200/?image=19" },
                    { 39, true, "https://picsum.photos/300/200/?image=439" },
                    { 40, false, "https://picsum.photos/300/200/?image=763" },
                    { 41, true, "https://picsum.photos/300/200/?image=308" },
                    { 42, false, "https://picsum.photos/300/200/?image=812" },
                    { 43, true, "https://picsum.photos/300/200/?image=242" },
                    { 44, false, "https://picsum.photos/300/200/?image=192" },
                    { 45, true, "https://picsum.photos/300/200/?image=681" },
                    { 46, false, "https://picsum.photos/300/200/?image=994" },
                    { 47, true, "https://picsum.photos/300/200/?image=975" },
                    { 48, false, "https://picsum.photos/300/200/?image=621" },
                    { 49, true, "https://picsum.photos/300/200/?image=929" },
                    { 50, false, "https://picsum.photos/300/200/?image=773" },
                    { 51, true, "https://picsum.photos/300/200/?image=1022" },
                    { 52, false, "https://picsum.photos/300/200/?image=376" },
                    { 53, true, "https://picsum.photos/300/200/?image=327" },
                    { 54, false, "https://picsum.photos/300/200/?image=928" },
                    { 55, true, "https://picsum.photos/300/200/?image=5" },
                    { 56, false, "https://picsum.photos/300/200/?image=52" },
                    { 57, true, "https://picsum.photos/300/200/?image=43" },
                    { 58, false, "https://picsum.photos/300/200/?image=182" },
                    { 59, true, "https://picsum.photos/300/200/?image=315" },
                    { 60, false, "https://picsum.photos/300/200/?image=216" },
                    { 61, true, "https://picsum.photos/300/200/?image=914" },
                    { 62, false, "https://picsum.photos/300/200/?image=637" },
                    { 63, true, "https://picsum.photos/300/200/?image=913" },
                    { 64, false, "https://picsum.photos/300/200/?image=998" },
                    { 65, true, "https://picsum.photos/300/200/?image=357" },
                    { 66, false, "https://picsum.photos/300/200/?image=512" },
                    { 67, true, "https://picsum.photos/300/200/?image=221" },
                    { 68, false, "https://picsum.photos/300/200/?image=325" },
                    { 69, true, "https://picsum.photos/300/200/?image=467" },
                    { 70, false, "https://picsum.photos/300/200/?image=566" },
                    { 71, true, "https://picsum.photos/300/200/?image=128" },
                    { 72, false, "https://picsum.photos/300/200/?image=314" },
                    { 73, true, "https://picsum.photos/300/200/?image=885" },
                    { 74, false, "https://picsum.photos/300/200/?image=419" },
                    { 75, true, "https://picsum.photos/300/200/?image=600" },
                    { 76, false, "https://picsum.photos/300/200/?image=1051" },
                    { 77, true, "https://picsum.photos/300/200/?image=95" },
                    { 78, false, "https://picsum.photos/300/200/?image=193" },
                    { 79, true, "https://picsum.photos/300/200/?image=555" },
                    { 80, false, "https://picsum.photos/300/200/?image=771" },
                    { 81, true, "https://picsum.photos/300/200/?image=652" },
                    { 82, false, "https://picsum.photos/300/200/?image=491" },
                    { 83, true, "https://picsum.photos/300/200/?image=220" },
                    { 84, false, "https://picsum.photos/300/200/?image=70" },
                    { 85, true, "https://picsum.photos/300/200/?image=18" },
                    { 86, false, "https://picsum.photos/300/200/?image=624" },
                    { 87, true, "https://picsum.photos/300/200/?image=962" },
                    { 88, false, "https://picsum.photos/300/200/?image=566" },
                    { 89, true, "https://picsum.photos/300/200/?image=469" },
                    { 90, false, "https://picsum.photos/300/200/?image=830" },
                    { 91, true, "https://picsum.photos/300/200/?image=339" },
                    { 92, false, "https://picsum.photos/300/200/?image=9" },
                    { 93, true, "https://picsum.photos/300/200/?image=702" },
                    { 94, false, "https://picsum.photos/300/200/?image=291" },
                    { 95, true, "https://picsum.photos/300/200/?image=978" },
                    { 96, false, "https://picsum.photos/300/200/?image=1006" },
                    { 97, true, "https://picsum.photos/300/200/?image=443" },
                    { 98, false, "https://picsum.photos/300/200/?image=14" },
                    { 99, true, "https://picsum.photos/300/200/?image=281" },
                    { 100, false, "https://picsum.photos/300/200/?image=319" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 66, 1, "Regina", "Schinner" },
                    { 2, 55, 2, "Marcia", "Schuppe" },
                    { 3, 57, 3, "Neil", "Feil" },
                    { 4, 22, 4, "Rudolph", "Trantow" },
                    { 5, 65, 5, "Derrick", "Mante" },
                    { 6, 24, 6, "Geneva", "Kunde" },
                    { 7, 59, 7, "Cecilia", "Hermiston" },
                    { 8, 42, 8, "Wesley", "O'Kon" },
                    { 9, 42, 9, "Jean", "Lockman" },
                    { 10, 68, 10, "Merle", "Durgan" },
                    { 11, 21, 11, "Wendy", "Olson" },
                    { 12, 32, 12, "Esther", "Spencer" },
                    { 13, 27, 13, "Guy", "Rosenbaum" },
                    { 14, 63, 14, "Pablo", "Willms" },
                    { 15, 58, 15, "Grant", "Jakubowski" },
                    { 16, 48, 16, "Lionel", "Hand" },
                    { 17, 46, 17, "Lindsay", "Macejkovic" },
                    { 18, 54, 18, "Theodore", "Hilll" },
                    { 19, 43, 19, "Javier", "Lehner" },
                    { 20, 19, 20, "Darlene", "Homenick" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "LocationType", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "architecto qui quia quo quo qui suscipit sit", 51, 1, 0, 19, 407.63974550485m, 9, "Laney Course", "Haneburgh" },
                    { 2, "illum iure perspiciatis natus voluptate quos autem ab", 22, 1, 5, 8, 774.004823316147m, 1, "Upton Forest", "Olsonland" },
                    { 3, "natus quas doloribus ipsum iure voluptatum soluta omnis", 8, 2, 2, 15, 126.527896425885m, 3, "Miller Walks", "Edwinaville" },
                    { 4, "et autem ea ut quam laboriosam eaque asperiores", 46, 2, 5, 18, 1089.93164824567m, 6, "Wyman Stravenue", "East Cruz" },
                    { 5, "in doloribus expedita dolore voluptatem earum et vero", 43, 3, 0, 20, 849.71446380666m, 7, "Steuber Mountain", "Crooksview" },
                    { 6, "velit sequi in corporis sunt est consequatur ab", 13, 3, 5, 16, 344.82809110196m, 5, "Kassulke Isle", "West Kaylah" },
                    { 7, "rerum sed quis fugit ipsa autem adipisci dolores", 15, 4, 0, 11, 439.458892659355m, 8, "Cristian Locks", "South Florence" },
                    { 8, "labore aut fugit rerum et consequuntur qui et", 63, 4, 1, 6, 441.582632836418m, 3, "Lexus Fall", "Labadieview" },
                    { 9, "velit qui soluta explicabo et non harum praesentium", 26, 5, 3, 3, 1101.34192613163m, 8, "Haley Ridge", "Nelsberg" },
                    { 10, "asperiores fugiat ut voluptatem minima id voluptatibus recusandae", 21, 5, 5, 10, 354.544241854281m, 7, "Jast Lake", "McGlynnbury" },
                    { 11, "quia sit sint sunt nisi quod tempore dolor", 23, 6, 1, 9, 1487.78077237317m, 10, "Torphy Heights", "Wymanchester" },
                    { 12, "molestiae fuga excepturi sint vero eum sit rerum", 32, 6, 4, 20, 1084.0667541571m, 8, "Schneider Field", "Rowehaven" },
                    { 13, "architecto aut soluta doloremque fugit fugiat mollitia autem", 23, 7, 1, 3, 1418.27103738964m, 5, "Garrison Villages", "West Terenceborough" },
                    { 14, "tempore rerum voluptate dolorum qui corrupti ipsam illum", 60, 7, 4, 14, 766.272557302626m, 4, "Abbott Alley", "New Stacy" },
                    { 15, "omnis accusantium consequuntur saepe aspernatur qui rerum omnis", 52, 8, 1, 2, 1306.29127944852m, 10, "Hilpert Rapids", "North Laurelmouth" },
                    { 16, "ab quidem sint et omnis culpa eveniet adipisci", 12, 8, 1, 19, 466.33255035904m, 7, "Nikolaus Oval", "Lake Jason" },
                    { 17, "eum voluptas sunt qui ut porro ab animi", 62, 9, 2, 10, 234.788729137635m, 10, "Rubie Falls", "Syblestad" },
                    { 18, "ut ea non ab voluptatibus alias voluptatem voluptas", 33, 9, 4, 18, 1025.16503271169m, 10, "Schmidt Keys", "Keatonberg" },
                    { 19, "iste velit sunt accusantium aperiam consequatur quos ratione", 48, 10, 5, 16, 688.966080548282m, 1, "Alison Flat", "New Darrick" },
                    { 20, "qui sit ad minima accusantium est quidem quis", 55, 10, 1, 9, 696.403804019714m, 3, "Nelson Garden", "Gwenstad" },
                    { 21, "et quas sequi voluptatum earum est magni ut", 7, 11, 5, 14, 127.562351557293m, 2, "Eloise Hill", "East Guiseppe" },
                    { 22, "non quod recusandae voluptatibus cum rerum sed doloribus", 14, 11, 4, 7, 984.650210414387m, 9, "Mayer Port", "North Makaylamouth" },
                    { 23, "deleniti enim mollitia veniam molestiae consectetur nam doloremque", 27, 12, 3, 15, 994.285223635712m, 8, "Ellis Lane", "Lake Granville" },
                    { 24, "aliquid id aspernatur quia aliquam debitis aliquam voluptatem", 41, 12, 3, 11, 480.822497779665m, 9, "Enola Heights", "Lamarview" },
                    { 25, "suscipit nihil laboriosam suscipit eum et voluptatibus impedit", 25, 13, 1, 12, 779.867988690848m, 7, "Lindsay Fork", "West Aubreyberg" },
                    { 26, "fugit suscipit iure porro vero aut maiores hic", 25, 13, 0, 9, 511.965879144229m, 7, "Amya Common", "Millshaven" },
                    { 27, "magnam ducimus consequatur repellat quaerat consequatur et animi", 17, 14, 3, 13, 942.434288269347m, 8, "Tyson Club", "Schillertown" },
                    { 28, "placeat voluptates exercitationem omnis incidunt ipsam saepe ab", 8, 14, 5, 19, 233.975271705347m, 4, "Rosina Pines", "Lake Halletown" },
                    { 29, "accusamus et quis aliquid et ipsum eligendi vitae", 40, 15, 2, 7, 1475.98098939306m, 4, "Skiles Terrace", "Florenceborough" },
                    { 30, "eum possimus accusamus accusamus aut natus quasi minus", 42, 15, 4, 5, 727.318457057764m, 5, "Weber Run", "Gardnerhaven" },
                    { 31, "in eos est dolor eum earum ut reiciendis", 38, 16, 0, 13, 1234.13307196882m, 1, "Prohaska Union", "Gisselleville" },
                    { 32, "nihil eos ab reprehenderit optio optio facilis molestias", 26, 16, 0, 4, 308.709303108956m, 7, "Kenny Walk", "East Kayli" },
                    { 33, "dignissimos velit illum distinctio voluptatibus consequuntur enim hic", 24, 17, 3, 19, 842.964607162481m, 8, "Koss Coves", "Kuhlmanshire" },
                    { 34, "velit eaque sunt maiores dolorem ut qui vel", 9, 17, 2, 20, 1247.50491647381m, 10, "Dario Crossing", "South Ednaburgh" },
                    { 35, "vitae rem rerum optio quis dolore iure aliquid", 51, 18, 3, 2, 1221.52529817147m, 8, "Leopold Mall", "Barrowsside" },
                    { 36, "accusamus ab excepturi ut et maxime perspiciatis et", 33, 18, 0, 19, 765.144322305006m, 5, "West Mount", "Lake Selinachester" },
                    { 37, "rerum et voluptatem eius enim molestias et commodi", 13, 19, 1, 13, 657.11347893627m, 10, "Haylee Pines", "West Alfredburgh" },
                    { 38, "labore dicta ipsa nihil eius sit et ut", 27, 19, 3, 15, 489.633886356161m, 5, "Yost Field", "East Sanford" },
                    { 39, "neque neque consequatur ab aut laudantium nam sed", 55, 20, 3, 6, 714.483001913333m, 8, "Santos Forges", "Harrismouth" },
                    { 40, "voluptatibus et aut non saepe iste sit doloribus", 23, 20, 5, 7, 488.549427547973m, 10, "Susie Ranch", "North Lavinia" }
                });

            migrationBuilder.InsertData(
                table: "LocationImages",
                columns: new[] { "ImageId", "LocationId" },
                values: new object[,]
                {
                    { 21, 40 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 3 },
                    { 27, 3 },
                    { 28, 4 },
                    { 29, 4 },
                    { 30, 5 },
                    { 31, 5 },
                    { 32, 6 },
                    { 33, 6 },
                    { 34, 7 },
                    { 35, 7 },
                    { 36, 8 },
                    { 37, 8 },
                    { 38, 9 },
                    { 39, 9 },
                    { 40, 10 },
                    { 41, 10 },
                    { 42, 11 },
                    { 43, 11 },
                    { 44, 12 },
                    { 45, 12 },
                    { 46, 13 },
                    { 47, 13 },
                    { 48, 14 },
                    { 49, 14 },
                    { 50, 15 },
                    { 51, 15 },
                    { 52, 16 },
                    { 53, 16 },
                    { 54, 17 },
                    { 55, 17 },
                    { 56, 18 },
                    { 57, 18 },
                    { 58, 19 },
                    { 59, 19 },
                    { 60, 20 },
                    { 61, 20 },
                    { 62, 21 },
                    { 63, 21 },
                    { 64, 22 },
                    { 65, 22 },
                    { 66, 23 },
                    { 67, 23 },
                    { 68, 24 },
                    { 69, 24 },
                    { 70, 25 },
                    { 71, 25 },
                    { 72, 26 },
                    { 73, 26 },
                    { 74, 27 },
                    { 75, 27 },
                    { 76, 28 },
                    { 77, 28 },
                    { 78, 29 },
                    { 79, 29 },
                    { 80, 30 },
                    { 81, 30 },
                    { 82, 31 },
                    { 83, 31 },
                    { 84, 32 },
                    { 85, 32 },
                    { 86, 33 },
                    { 87, 33 },
                    { 88, 34 },
                    { 89, 34 },
                    { 90, 35 },
                    { 91, 35 },
                    { 92, 36 },
                    { 93, 36 },
                    { 94, 37 },
                    { 95, 37 },
                    { 96, 38 },
                    { 97, 38 },
                    { 98, 39 },
                    { 99, 39 },
                    { 100, 40 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 65, 2.2003459687117397, new DateTime(2023, 12, 24, 1, 1, 5, 36, DateTimeKind.Local).AddTicks(1363), 40, new DateTime(2024, 1, 25, 20, 37, 29, 630, DateTimeKind.Local).AddTicks(4889) },
                    { 2, 77, 0.0, new DateTime(2024, 5, 29, 4, 24, 20, 552, DateTimeKind.Local).AddTicks(9318), 1, new DateTime(2024, 3, 29, 23, 25, 9, 660, DateTimeKind.Local).AddTicks(2418) },
                    { 3, 53, 0.0, new DateTime(2024, 3, 13, 20, 38, 17, 638, DateTimeKind.Local).AddTicks(4121), 1, new DateTime(2024, 1, 16, 2, 19, 48, 784, DateTimeKind.Local).AddTicks(8559) },
                    { 4, 80, 0.0, new DateTime(2024, 2, 5, 2, 49, 12, 102, DateTimeKind.Local).AddTicks(7601), 1, new DateTime(2024, 5, 21, 10, 39, 38, 297, DateTimeKind.Local).AddTicks(7013) },
                    { 5, 65, 0.0, new DateTime(2024, 5, 15, 9, 2, 19, 986, DateTimeKind.Local).AddTicks(254), 2, new DateTime(2024, 1, 14, 23, 44, 41, 580, DateTimeKind.Local).AddTicks(8413) },
                    { 6, 58, 0.0, new DateTime(2024, 2, 5, 19, 31, 34, 504, DateTimeKind.Local).AddTicks(803), 2, new DateTime(2024, 3, 26, 13, 40, 20, 13, DateTimeKind.Local).AddTicks(1869) },
                    { 7, 40, 0.0, new DateTime(2024, 4, 26, 17, 23, 14, 959, DateTimeKind.Local).AddTicks(5809), 2, new DateTime(2024, 3, 25, 23, 17, 25, 428, DateTimeKind.Local).AddTicks(1259) },
                    { 8, 64, 0.0, new DateTime(2024, 5, 11, 15, 27, 47, 10, DateTimeKind.Local).AddTicks(8402), 3, new DateTime(2024, 3, 12, 0, 33, 8, 14, DateTimeKind.Local).AddTicks(2842) },
                    { 9, 36, 0.0, new DateTime(2024, 1, 28, 17, 53, 0, 568, DateTimeKind.Local).AddTicks(1407), 3, new DateTime(2024, 1, 9, 1, 49, 2, 960, DateTimeKind.Local).AddTicks(8867) },
                    { 10, 84, 0.0, new DateTime(2024, 4, 28, 16, 41, 36, 683, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 3, 14, 13, 57, 43, 977, DateTimeKind.Local).AddTicks(5724) },
                    { 11, 73, 0.0, new DateTime(2024, 1, 21, 20, 43, 48, 358, DateTimeKind.Local).AddTicks(7873), 4, new DateTime(2024, 3, 11, 9, 44, 59, 926, DateTimeKind.Local).AddTicks(7547) },
                    { 12, 99, 0.0, new DateTime(2024, 3, 23, 5, 8, 33, 762, DateTimeKind.Local).AddTicks(6557), 4, new DateTime(2024, 6, 11, 23, 15, 46, 335, DateTimeKind.Local).AddTicks(4812) },
                    { 13, 46, 0.0, new DateTime(2024, 6, 17, 3, 1, 11, 919, DateTimeKind.Local).AddTicks(8800), 4, new DateTime(2023, 12, 31, 4, 2, 31, 622, DateTimeKind.Local).AddTicks(4852) },
                    { 14, 51, 0.0, new DateTime(2024, 1, 3, 18, 35, 42, 270, DateTimeKind.Local).AddTicks(3302), 5, new DateTime(2024, 6, 16, 6, 18, 22, 380, DateTimeKind.Local).AddTicks(5704) },
                    { 15, 56, 0.0, new DateTime(2024, 2, 29, 20, 51, 22, 437, DateTimeKind.Local).AddTicks(6472), 5, new DateTime(2024, 3, 20, 18, 35, 8, 603, DateTimeKind.Local).AddTicks(5265) },
                    { 16, 1, 0.0, new DateTime(2024, 3, 30, 23, 58, 24, 926, DateTimeKind.Local).AddTicks(3991), 5, new DateTime(2024, 5, 15, 13, 26, 5, 382, DateTimeKind.Local).AddTicks(5687) },
                    { 17, 75, 0.0, new DateTime(2024, 3, 11, 0, 14, 40, 767, DateTimeKind.Local).AddTicks(4797), 6, new DateTime(2024, 6, 17, 4, 38, 26, 881, DateTimeKind.Local).AddTicks(617) },
                    { 18, 11, 0.0, new DateTime(2024, 4, 9, 10, 24, 35, 578, DateTimeKind.Local).AddTicks(527), 6, new DateTime(2024, 4, 29, 11, 38, 1, 709, DateTimeKind.Local).AddTicks(3763) },
                    { 19, 9, 0.0, new DateTime(2024, 4, 19, 18, 42, 51, 249, DateTimeKind.Local).AddTicks(6411), 6, new DateTime(2024, 3, 13, 21, 37, 24, 543, DateTimeKind.Local).AddTicks(895) },
                    { 20, 91, 0.0, new DateTime(2024, 2, 23, 15, 46, 42, 421, DateTimeKind.Local).AddTicks(3315), 7, new DateTime(2024, 1, 4, 17, 31, 35, 558, DateTimeKind.Local).AddTicks(1220) },
                    { 21, 4, 0.0, new DateTime(2024, 3, 9, 16, 35, 17, 910, DateTimeKind.Local).AddTicks(123), 7, new DateTime(2024, 2, 26, 20, 49, 44, 732, DateTimeKind.Local).AddTicks(5583) },
                    { 22, 90, 1.1675958344168524, new DateTime(2024, 3, 9, 6, 48, 5, 354, DateTimeKind.Local).AddTicks(2968), 7, new DateTime(2024, 4, 29, 5, 13, 0, 739, DateTimeKind.Local).AddTicks(3021) },
                    { 23, 90, 0.0, new DateTime(2024, 3, 30, 18, 44, 51, 386, DateTimeKind.Local).AddTicks(3472), 8, new DateTime(2024, 3, 22, 16, 31, 11, 197, DateTimeKind.Local).AddTicks(9748) },
                    { 24, 36, 0.0, new DateTime(2024, 2, 22, 17, 54, 46, 656, DateTimeKind.Local).AddTicks(9416), 8, new DateTime(2023, 12, 25, 3, 9, 10, 299, DateTimeKind.Local).AddTicks(9568) },
                    { 25, 54, 0.0, new DateTime(2024, 2, 19, 14, 24, 10, 851, DateTimeKind.Local).AddTicks(7934), 8, new DateTime(2024, 1, 30, 7, 53, 59, 876, DateTimeKind.Local).AddTicks(7711) },
                    { 26, 29, 0.0, new DateTime(2024, 5, 26, 8, 6, 51, 107, DateTimeKind.Local).AddTicks(6707), 9, new DateTime(2024, 2, 11, 14, 16, 43, 172, DateTimeKind.Local).AddTicks(5715) },
                    { 27, 7, 0.0, new DateTime(2024, 5, 8, 21, 40, 15, 974, DateTimeKind.Local).AddTicks(8343), 9, new DateTime(2024, 1, 27, 20, 53, 0, 562, DateTimeKind.Local).AddTicks(9113) },
                    { 28, 26, 0.0, new DateTime(2024, 3, 6, 18, 33, 26, 193, DateTimeKind.Local).AddTicks(4718), 9, new DateTime(2024, 4, 21, 15, 53, 41, 229, DateTimeKind.Local).AddTicks(8103) },
                    { 29, 74, 0.0, new DateTime(2023, 12, 28, 23, 16, 28, 119, DateTimeKind.Local).AddTicks(6052), 10, new DateTime(2024, 2, 11, 15, 48, 22, 364, DateTimeKind.Local).AddTicks(563) },
                    { 30, 89, 0.0, new DateTime(2024, 2, 7, 21, 33, 52, 20, DateTimeKind.Local).AddTicks(9952), 10, new DateTime(2024, 1, 18, 9, 0, 48, 626, DateTimeKind.Local).AddTicks(2457) },
                    { 31, 76, 5.8329817826335075, new DateTime(2024, 6, 17, 21, 30, 26, 937, DateTimeKind.Local).AddTicks(1157), 10, new DateTime(2024, 2, 20, 17, 39, 17, 7, DateTimeKind.Local).AddTicks(8227) },
                    { 32, 66, 0.0, new DateTime(2024, 5, 20, 16, 42, 15, 972, DateTimeKind.Local).AddTicks(8630), 11, new DateTime(2024, 1, 22, 15, 30, 30, 490, DateTimeKind.Local).AddTicks(2112) },
                    { 33, 89, 0.0, new DateTime(2024, 6, 9, 10, 31, 39, 481, DateTimeKind.Local).AddTicks(642), 11, new DateTime(2024, 2, 29, 16, 10, 16, 271, DateTimeKind.Local).AddTicks(4144) },
                    { 34, 23, 0.0, new DateTime(2024, 5, 20, 14, 43, 18, 303, DateTimeKind.Local).AddTicks(5252), 11, new DateTime(2024, 4, 17, 16, 19, 57, 421, DateTimeKind.Local).AddTicks(2665) },
                    { 35, 23, 0.0, new DateTime(2024, 6, 16, 7, 36, 55, 3, DateTimeKind.Local).AddTicks(5484), 12, new DateTime(2024, 6, 10, 2, 4, 28, 417, DateTimeKind.Local).AddTicks(66) },
                    { 36, 55, 0.0, new DateTime(2024, 4, 8, 7, 20, 48, 611, DateTimeKind.Local).AddTicks(9218), 12, new DateTime(2024, 5, 9, 10, 30, 0, 414, DateTimeKind.Local).AddTicks(5108) },
                    { 37, 53, 6.2211423614460681, new DateTime(2024, 3, 13, 8, 45, 29, 967, DateTimeKind.Local).AddTicks(2495), 12, new DateTime(2024, 2, 7, 6, 7, 26, 889, DateTimeKind.Local).AddTicks(9441) },
                    { 38, 32, 0.0, new DateTime(2024, 3, 15, 9, 15, 29, 713, DateTimeKind.Local).AddTicks(2767), 13, new DateTime(2024, 3, 23, 14, 31, 10, 36, DateTimeKind.Local).AddTicks(3021) },
                    { 39, 22, 0.0, new DateTime(2024, 1, 25, 7, 24, 57, 920, DateTimeKind.Local).AddTicks(9163), 13, new DateTime(2024, 3, 24, 1, 42, 40, 799, DateTimeKind.Local).AddTicks(6528) },
                    { 40, 81, 7.6401945089470304, new DateTime(2024, 1, 31, 6, 16, 47, 185, DateTimeKind.Local).AddTicks(2383), 13, new DateTime(2024, 3, 6, 22, 27, 15, 757, DateTimeKind.Local).AddTicks(119) },
                    { 41, 30, 0.0, new DateTime(2024, 2, 4, 10, 34, 35, 903, DateTimeKind.Local).AddTicks(1692), 14, new DateTime(2024, 2, 5, 12, 57, 26, 903, DateTimeKind.Local).AddTicks(5294) },
                    { 42, 94, 0.0, new DateTime(2024, 1, 27, 2, 37, 42, 674, DateTimeKind.Local).AddTicks(3244), 14, new DateTime(2024, 1, 15, 15, 12, 45, 312, DateTimeKind.Local).AddTicks(6275) },
                    { 43, 68, 0.0, new DateTime(2024, 2, 3, 5, 48, 48, 878, DateTimeKind.Local).AddTicks(2343), 14, new DateTime(2024, 6, 14, 4, 37, 18, 432, DateTimeKind.Local).AddTicks(8772) },
                    { 44, 39, 0.0, new DateTime(2024, 4, 28, 1, 2, 9, 641, DateTimeKind.Local).AddTicks(869), 15, new DateTime(2024, 3, 18, 23, 26, 59, 830, DateTimeKind.Local).AddTicks(2387) },
                    { 45, 72, 0.0, new DateTime(2024, 4, 30, 11, 29, 9, 891, DateTimeKind.Local).AddTicks(1130), 15, new DateTime(2024, 3, 29, 15, 0, 30, 400, DateTimeKind.Local).AddTicks(3000) },
                    { 46, 66, 0.0, new DateTime(2024, 2, 22, 9, 29, 43, 494, DateTimeKind.Local).AddTicks(6037), 15, new DateTime(2024, 4, 24, 19, 37, 52, 135, DateTimeKind.Local).AddTicks(6974) },
                    { 47, 48, 0.0, new DateTime(2024, 1, 13, 16, 59, 32, 527, DateTimeKind.Local).AddTicks(6452), 16, new DateTime(2024, 1, 23, 5, 45, 19, 533, DateTimeKind.Local).AddTicks(2662) },
                    { 48, 82, 0.0, new DateTime(2024, 3, 6, 5, 39, 17, 541, DateTimeKind.Local).AddTicks(6944), 16, new DateTime(2024, 2, 26, 17, 19, 35, 92, DateTimeKind.Local).AddTicks(2293) },
                    { 49, 63, 0.0, new DateTime(2024, 5, 13, 1, 31, 49, 468, DateTimeKind.Local).AddTicks(5038), 16, new DateTime(2024, 2, 10, 23, 55, 29, 123, DateTimeKind.Local).AddTicks(6003) },
                    { 50, 65, 0.0, new DateTime(2024, 2, 8, 17, 50, 16, 188, DateTimeKind.Local).AddTicks(7172), 17, new DateTime(2024, 2, 5, 0, 13, 50, 165, DateTimeKind.Local).AddTicks(4177) },
                    { 51, 52, 0.0, new DateTime(2024, 2, 16, 3, 32, 35, 639, DateTimeKind.Local).AddTicks(5368), 17, new DateTime(2024, 1, 24, 1, 55, 49, 512, DateTimeKind.Local).AddTicks(1283) },
                    { 52, 51, 0.0, new DateTime(2024, 2, 27, 10, 51, 31, 989, DateTimeKind.Local).AddTicks(1713), 17, new DateTime(2024, 3, 20, 12, 49, 44, 799, DateTimeKind.Local).AddTicks(7383) },
                    { 53, 72, 0.0, new DateTime(2024, 1, 23, 13, 11, 49, 865, DateTimeKind.Local).AddTicks(7367), 18, new DateTime(2024, 1, 13, 11, 9, 58, 531, DateTimeKind.Local).AddTicks(871) },
                    { 54, 26, 0.0, new DateTime(2024, 3, 9, 20, 2, 18, 589, DateTimeKind.Local).AddTicks(3378), 18, new DateTime(2024, 6, 18, 9, 44, 35, 134, DateTimeKind.Local).AddTicks(1736) },
                    { 55, 31, 0.0, new DateTime(2024, 4, 30, 19, 11, 16, 368, DateTimeKind.Local).AddTicks(712), 18, new DateTime(2024, 2, 3, 3, 17, 22, 552, DateTimeKind.Local).AddTicks(4240) },
                    { 56, 8, 0.0, new DateTime(2024, 3, 12, 11, 35, 57, 384, DateTimeKind.Local).AddTicks(3688), 19, new DateTime(2024, 2, 9, 11, 2, 5, 174, DateTimeKind.Local).AddTicks(1068) },
                    { 57, 98, 0.0, new DateTime(2024, 3, 23, 15, 37, 20, 85, DateTimeKind.Local).AddTicks(9833), 19, new DateTime(2024, 6, 2, 22, 25, 17, 456, DateTimeKind.Local).AddTicks(5920) },
                    { 58, 96, 0.0, new DateTime(2024, 5, 5, 22, 43, 27, 286, DateTimeKind.Local).AddTicks(4532), 19, new DateTime(2024, 1, 20, 20, 15, 27, 887, DateTimeKind.Local).AddTicks(695) },
                    { 59, 46, 0.0, new DateTime(2024, 3, 12, 21, 5, 28, 588, DateTimeKind.Local).AddTicks(3610), 20, new DateTime(2024, 3, 12, 13, 31, 36, 624, DateTimeKind.Local).AddTicks(9589) },
                    { 60, 44, 0.0, new DateTime(2024, 4, 19, 16, 32, 24, 818, DateTimeKind.Local).AddTicks(7386), 20, new DateTime(2024, 4, 26, 13, 14, 23, 985, DateTimeKind.Local).AddTicks(4689) },
                    { 61, 45, 0.0, new DateTime(2024, 6, 3, 22, 20, 42, 827, DateTimeKind.Local).AddTicks(1576), 20, new DateTime(2024, 5, 1, 4, 52, 54, 607, DateTimeKind.Local).AddTicks(3066) },
                    { 62, 10, 0.0, new DateTime(2024, 3, 20, 1, 26, 5, 842, DateTimeKind.Local).AddTicks(1329), 21, new DateTime(2024, 1, 19, 13, 20, 37, 789, DateTimeKind.Local).AddTicks(2964) },
                    { 63, 14, 0.0, new DateTime(2024, 5, 22, 5, 30, 39, 297, DateTimeKind.Local).AddTicks(587), 21, new DateTime(2024, 1, 2, 23, 42, 50, 81, DateTimeKind.Local).AddTicks(2651) },
                    { 64, 9, 0.0, new DateTime(2023, 12, 29, 3, 9, 1, 396, DateTimeKind.Local).AddTicks(3780), 21, new DateTime(2023, 12, 20, 11, 31, 11, 38, DateTimeKind.Local).AddTicks(6760) },
                    { 65, 89, 4.4523728947041867, new DateTime(2024, 3, 13, 3, 44, 45, 586, DateTimeKind.Local).AddTicks(124), 22, new DateTime(2024, 6, 6, 14, 30, 8, 867, DateTimeKind.Local).AddTicks(5618) },
                    { 66, 68, 0.0, new DateTime(2024, 1, 2, 16, 35, 15, 233, DateTimeKind.Local).AddTicks(1762), 22, new DateTime(2024, 6, 16, 6, 25, 7, 120, DateTimeKind.Local).AddTicks(154) },
                    { 67, 80, 0.0, new DateTime(2024, 6, 9, 16, 38, 57, 965, DateTimeKind.Local).AddTicks(6643), 22, new DateTime(2023, 12, 24, 9, 46, 0, 202, DateTimeKind.Local).AddTicks(1441) },
                    { 68, 3, 0.0, new DateTime(2024, 1, 24, 20, 22, 39, 922, DateTimeKind.Local).AddTicks(5264), 23, new DateTime(2024, 6, 6, 8, 33, 21, 933, DateTimeKind.Local).AddTicks(4677) },
                    { 69, 100, 0.0, new DateTime(2024, 2, 2, 6, 10, 6, 260, DateTimeKind.Local).AddTicks(749), 23, new DateTime(2024, 5, 17, 13, 39, 50, 931, DateTimeKind.Local).AddTicks(1874) },
                    { 70, 99, 0.060453921128612587, new DateTime(2024, 5, 4, 16, 39, 24, 19, DateTimeKind.Local).AddTicks(9225), 23, new DateTime(2024, 5, 22, 15, 51, 24, 326, DateTimeKind.Local).AddTicks(8756) },
                    { 71, 68, 0.0, new DateTime(2024, 4, 16, 21, 47, 0, 289, DateTimeKind.Local).AddTicks(2437), 24, new DateTime(2024, 1, 26, 0, 1, 23, 214, DateTimeKind.Local).AddTicks(2257) },
                    { 72, 75, 0.0, new DateTime(2024, 1, 6, 19, 42, 6, 90, DateTimeKind.Local).AddTicks(3922), 24, new DateTime(2024, 5, 22, 13, 59, 45, 60, DateTimeKind.Local).AddTicks(4518) },
                    { 73, 90, 0.0, new DateTime(2024, 2, 24, 16, 20, 18, 653, DateTimeKind.Local).AddTicks(907), 24, new DateTime(2024, 1, 24, 23, 45, 35, 56, DateTimeKind.Local).AddTicks(441) },
                    { 74, 53, 0.0, new DateTime(2024, 6, 3, 7, 18, 50, 11, DateTimeKind.Local).AddTicks(8071), 25, new DateTime(2024, 4, 4, 20, 47, 15, 532, DateTimeKind.Local).AddTicks(1010) },
                    { 75, 75, 0.0, new DateTime(2024, 2, 2, 14, 23, 21, 454, DateTimeKind.Local).AddTicks(5418), 25, new DateTime(2024, 3, 25, 10, 28, 52, 716, DateTimeKind.Local).AddTicks(9823) },
                    { 76, 37, 0.0, new DateTime(2024, 1, 25, 9, 9, 44, 685, DateTimeKind.Local).AddTicks(9087), 25, new DateTime(2023, 12, 19, 22, 52, 3, 264, DateTimeKind.Local).AddTicks(2157) },
                    { 77, 82, 9.2012434268515815, new DateTime(2024, 5, 11, 0, 5, 0, 73, DateTimeKind.Local).AddTicks(1165), 26, new DateTime(2024, 2, 14, 13, 40, 41, 209, DateTimeKind.Local).AddTicks(1589) },
                    { 78, 28, 0.0, new DateTime(2024, 3, 22, 1, 50, 49, 400, DateTimeKind.Local).AddTicks(4856), 26, new DateTime(2024, 5, 6, 9, 18, 15, 661, DateTimeKind.Local).AddTicks(3906) },
                    { 79, 74, 0.0, new DateTime(2024, 3, 7, 3, 15, 5, 616, DateTimeKind.Local).AddTicks(4521), 26, new DateTime(2024, 4, 29, 21, 50, 4, 773, DateTimeKind.Local).AddTicks(1384) },
                    { 80, 59, 0.0, new DateTime(2024, 3, 18, 14, 11, 38, 821, DateTimeKind.Local).AddTicks(1018), 27, new DateTime(2024, 1, 11, 5, 5, 55, 278, DateTimeKind.Local).AddTicks(2521) },
                    { 81, 55, 0.0, new DateTime(2024, 4, 11, 13, 4, 37, 974, DateTimeKind.Local).AddTicks(4454), 27, new DateTime(2024, 3, 6, 20, 6, 34, 343, DateTimeKind.Local).AddTicks(2200) },
                    { 82, 99, 4.3987289202051709, new DateTime(2024, 1, 30, 16, 4, 46, 418, DateTimeKind.Local).AddTicks(8309), 27, new DateTime(2024, 1, 9, 2, 52, 20, 993, DateTimeKind.Local).AddTicks(9766) },
                    { 83, 32, 0.0, new DateTime(2024, 1, 15, 0, 2, 19, 86, DateTimeKind.Local).AddTicks(8066), 28, new DateTime(2024, 1, 20, 13, 19, 39, 196, DateTimeKind.Local).AddTicks(917) },
                    { 84, 34, 0.0, new DateTime(2024, 5, 30, 3, 37, 35, 763, DateTimeKind.Local).AddTicks(1453), 28, new DateTime(2024, 2, 11, 18, 33, 37, 865, DateTimeKind.Local).AddTicks(3284) },
                    { 85, 12, 0.0, new DateTime(2024, 1, 23, 2, 6, 57, 184, DateTimeKind.Local).AddTicks(3112), 28, new DateTime(2024, 4, 25, 7, 43, 7, 670, DateTimeKind.Local).AddTicks(7468) },
                    { 86, 27, 0.0, new DateTime(2024, 4, 25, 19, 44, 27, 997, DateTimeKind.Local).AddTicks(5190), 29, new DateTime(2024, 5, 9, 1, 17, 18, 349, DateTimeKind.Local).AddTicks(4334) },
                    { 87, 58, 0.0, new DateTime(2024, 4, 30, 2, 21, 16, 885, DateTimeKind.Local).AddTicks(2054), 29, new DateTime(2024, 1, 8, 11, 18, 48, 672, DateTimeKind.Local).AddTicks(9895) },
                    { 88, 30, 0.0, new DateTime(2024, 4, 22, 14, 37, 27, 225, DateTimeKind.Local).AddTicks(5830), 29, new DateTime(2024, 6, 18, 5, 53, 50, 168, DateTimeKind.Local).AddTicks(780) },
                    { 89, 74, 0.0, new DateTime(2024, 4, 3, 0, 38, 44, 562, DateTimeKind.Local).AddTicks(9081), 30, new DateTime(2023, 12, 22, 6, 15, 51, 446, DateTimeKind.Local).AddTicks(2376) },
                    { 90, 25, 0.0, new DateTime(2024, 1, 13, 3, 35, 53, 10, DateTimeKind.Local).AddTicks(7876), 30, new DateTime(2024, 5, 7, 4, 14, 56, 408, DateTimeKind.Local).AddTicks(7538) },
                    { 91, 45, 0.0, new DateTime(2024, 4, 18, 10, 18, 45, 288, DateTimeKind.Local).AddTicks(3688), 30, new DateTime(2024, 6, 18, 1, 29, 34, 640, DateTimeKind.Local).AddTicks(8871) },
                    { 92, 28, 0.0, new DateTime(2024, 4, 19, 13, 13, 55, 940, DateTimeKind.Local).AddTicks(8663), 31, new DateTime(2024, 5, 19, 23, 5, 46, 769, DateTimeKind.Local).AddTicks(2033) },
                    { 93, 35, 0.0, new DateTime(2024, 3, 24, 8, 17, 45, 300, DateTimeKind.Local).AddTicks(8861), 31, new DateTime(2024, 5, 3, 22, 7, 32, 272, DateTimeKind.Local).AddTicks(2754) },
                    { 94, 49, 0.0, new DateTime(2024, 3, 27, 10, 23, 18, 10, DateTimeKind.Local).AddTicks(9686), 31, new DateTime(2024, 5, 1, 10, 51, 18, 828, DateTimeKind.Local).AddTicks(2311) },
                    { 95, 81, 0.0, new DateTime(2024, 4, 20, 22, 28, 49, 801, DateTimeKind.Local).AddTicks(3843), 32, new DateTime(2024, 4, 19, 17, 20, 23, 214, DateTimeKind.Local).AddTicks(5319) },
                    { 96, 61, 0.0, new DateTime(2024, 2, 6, 7, 6, 40, 41, DateTimeKind.Local).AddTicks(5419), 32, new DateTime(2024, 2, 3, 15, 27, 8, 71, DateTimeKind.Local).AddTicks(6033) },
                    { 97, 24, 0.0, new DateTime(2024, 3, 20, 3, 54, 48, 130, DateTimeKind.Local).AddTicks(989), 32, new DateTime(2024, 4, 6, 11, 26, 22, 360, DateTimeKind.Local).AddTicks(2373) },
                    { 98, 76, 0.0, new DateTime(2024, 6, 8, 19, 16, 5, 56, DateTimeKind.Local).AddTicks(6177), 33, new DateTime(2024, 1, 23, 7, 35, 19, 678, DateTimeKind.Local).AddTicks(6994) },
                    { 99, 2, 0.0, new DateTime(2023, 12, 27, 22, 1, 33, 170, DateTimeKind.Local).AddTicks(2567), 33, new DateTime(2024, 2, 19, 2, 41, 33, 32, DateTimeKind.Local).AddTicks(6684) },
                    { 100, 13, 0.0, new DateTime(2024, 5, 25, 5, 43, 41, 180, DateTimeKind.Local).AddTicks(2546), 33, new DateTime(2024, 3, 16, 8, 1, 44, 69, DateTimeKind.Local).AddTicks(5866) },
                    { 101, 37, 0.0, new DateTime(2023, 12, 25, 20, 39, 39, 550, DateTimeKind.Local).AddTicks(6767), 34, new DateTime(2024, 5, 18, 14, 41, 37, 521, DateTimeKind.Local).AddTicks(3152) },
                    { 102, 65, 0.0, new DateTime(2024, 4, 5, 19, 34, 33, 378, DateTimeKind.Local).AddTicks(6264), 34, new DateTime(2024, 6, 2, 8, 55, 51, 828, DateTimeKind.Local).AddTicks(9170) },
                    { 103, 98, 0.0, new DateTime(2024, 5, 10, 10, 4, 24, 32, DateTimeKind.Local).AddTicks(3745), 34, new DateTime(2024, 6, 15, 20, 14, 49, 248, DateTimeKind.Local).AddTicks(4532) },
                    { 104, 84, 0.0, new DateTime(2024, 4, 6, 15, 44, 18, 651, DateTimeKind.Local).AddTicks(3452), 35, new DateTime(2024, 1, 18, 1, 34, 21, 393, DateTimeKind.Local).AddTicks(8956) },
                    { 105, 24, 0.0, new DateTime(2024, 2, 16, 17, 5, 29, 763, DateTimeKind.Local).AddTicks(6892), 35, new DateTime(2024, 2, 14, 23, 7, 32, 92, DateTimeKind.Local).AddTicks(14) },
                    { 106, 73, 0.0, new DateTime(2024, 1, 6, 21, 17, 7, 364, DateTimeKind.Local).AddTicks(5093), 35, new DateTime(2024, 6, 1, 2, 29, 6, 813, DateTimeKind.Local).AddTicks(8948) },
                    { 107, 36, 0.0, new DateTime(2024, 4, 18, 18, 28, 12, 209, DateTimeKind.Local).AddTicks(2121), 36, new DateTime(2024, 2, 7, 7, 2, 17, 164, DateTimeKind.Local).AddTicks(946) },
                    { 108, 69, 0.0, new DateTime(2024, 5, 21, 16, 52, 48, 471, DateTimeKind.Local).AddTicks(9840), 36, new DateTime(2024, 4, 2, 7, 1, 29, 495, DateTimeKind.Local).AddTicks(4380) },
                    { 109, 34, 0.0, new DateTime(2024, 1, 16, 16, 44, 11, 989, DateTimeKind.Local).AddTicks(3613), 36, new DateTime(2024, 2, 27, 11, 49, 54, 668, DateTimeKind.Local).AddTicks(4061) },
                    { 110, 94, 0.0, new DateTime(2024, 1, 15, 5, 13, 40, 406, DateTimeKind.Local).AddTicks(5245), 37, new DateTime(2024, 1, 31, 23, 36, 55, 146, DateTimeKind.Local).AddTicks(48) },
                    { 111, 51, 0.0, new DateTime(2024, 4, 28, 7, 8, 13, 465, DateTimeKind.Local).AddTicks(7040), 37, new DateTime(2024, 1, 24, 18, 22, 34, 534, DateTimeKind.Local).AddTicks(4715) },
                    { 112, 26, 0.0, new DateTime(2024, 1, 22, 20, 37, 32, 952, DateTimeKind.Local).AddTicks(9459), 37, new DateTime(2024, 6, 6, 8, 48, 1, 697, DateTimeKind.Local).AddTicks(9862) },
                    { 113, 88, 2.755473232153689, new DateTime(2024, 1, 1, 7, 49, 39, 311, DateTimeKind.Local).AddTicks(598), 38, new DateTime(2024, 1, 4, 22, 53, 11, 172, DateTimeKind.Local).AddTicks(4826) },
                    { 114, 83, 0.0, new DateTime(2024, 6, 17, 2, 54, 34, 630, DateTimeKind.Local).AddTicks(9331), 38, new DateTime(2024, 1, 18, 4, 29, 2, 737, DateTimeKind.Local).AddTicks(4773) },
                    { 115, 35, 0.0, new DateTime(2024, 5, 9, 2, 30, 18, 745, DateTimeKind.Local).AddTicks(9912), 38, new DateTime(2024, 3, 12, 2, 3, 17, 390, DateTimeKind.Local).AddTicks(1265) },
                    { 116, 25, 0.0, new DateTime(2024, 1, 2, 3, 19, 55, 518, DateTimeKind.Local).AddTicks(6929), 39, new DateTime(2024, 5, 3, 2, 15, 55, 273, DateTimeKind.Local).AddTicks(2548) },
                    { 117, 87, 0.0, new DateTime(2024, 3, 19, 2, 16, 44, 649, DateTimeKind.Local).AddTicks(8449), 39, new DateTime(2024, 1, 13, 3, 46, 16, 782, DateTimeKind.Local).AddTicks(2306) },
                    { 118, 68, 1.7129630171280497, new DateTime(2024, 3, 8, 5, 19, 11, 419, DateTimeKind.Local).AddTicks(8915), 39, new DateTime(2024, 5, 27, 22, 25, 23, 744, DateTimeKind.Local).AddTicks(162) },
                    { 119, 13, 0.0, new DateTime(2024, 4, 13, 1, 9, 18, 537, DateTimeKind.Local).AddTicks(6979), 40, new DateTime(2024, 6, 3, 21, 5, 38, 938, DateTimeKind.Local).AddTicks(2924) },
                    { 120, 29, 0.0, new DateTime(2024, 3, 10, 16, 32, 5, 452, DateTimeKind.Local).AddTicks(5584), 40, new DateTime(2024, 1, 23, 9, 44, 13, 230, DateTimeKind.Local).AddTicks(4221) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 21, 0 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 38, 9 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 40, 10 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 43, 11 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 46, 13 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 47, 13 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 48, 14 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 49, 14 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 50, 15 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 51, 15 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 53, 16 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 54, 17 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 55, 17 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 56, 18 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 57, 18 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 58, 19 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 59, 19 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 60, 20 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 61, 20 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 62, 21 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 63, 21 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 64, 22 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 65, 22 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 66, 23 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 67, 23 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 68, 24 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 69, 24 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 70, 25 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 71, 25 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 72, 26 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 73, 26 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 74, 27 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 75, 27 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 76, 28 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 77, 28 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 78, 29 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 79, 29 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 80, 30 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 81, 30 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 82, 31 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 83, 31 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 84, 32 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 85, 32 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 86, 33 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 87, 33 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 88, 34 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 89, 34 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 90, 35 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 91, 35 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 92, 36 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 93, 36 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 94, 37 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 95, 37 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 96, 38 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 97, 38 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 98, 39 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 99, 39 });

            migrationBuilder.DeleteData(
                table: "LocationImages",
                keyColumns: new[] { "ImageId", "LocationId" },
                keyValues: new object[] { 100, 40 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Locations");

            migrationBuilder.AlterColumn<double>(
                name: "PricePerDay",
                table: "Locations",
                type: "float(2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
