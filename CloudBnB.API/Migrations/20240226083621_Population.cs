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
                    { 1, "Teresa.Rowe@hotmail.com", "Teresa", "Rowe" },
                    { 2, "Steven.Collier5@hotmail.com", "Steven", "Collier" },
                    { 3, "Ronald_Donnelly@hotmail.com", "Ronald", "Donnelly" },
                    { 4, "Shaun.Bogan98@gmail.com", "Shaun", "Bogan" },
                    { 5, "Sherri22@hotmail.com", "Sherri", "Kihn" },
                    { 6, "Geoffrey_Terry@gmail.com", "Geoffrey", "Terry" },
                    { 7, "Nichole.Hackett21@hotmail.com", "Nichole", "Hackett" },
                    { 8, "Ruth_Hackett@yahoo.com", "Ruth", "Hackett" },
                    { 9, "Johnnie.Ritchie14@hotmail.com", "Johnnie", "Ritchie" },
                    { 10, "Juana.Gleichner81@gmail.com", "Juana", "Gleichner" },
                    { 11, "Sally_Weber@gmail.com", "Sally", "Weber" },
                    { 12, "Darryl.Nitzsche@hotmail.com", "Darryl", "Nitzsche" },
                    { 13, "Steven.Labadie20@hotmail.com", "Steven", "Labadie" },
                    { 14, "Dolores_Kulas24@gmail.com", "Dolores", "Kulas" },
                    { 15, "Edwin_Bogisich89@hotmail.com", "Edwin", "Bogisich" },
                    { 16, "Felicia.Abbott49@hotmail.com", "Felicia", "Abbott" },
                    { 17, "Patsy.Friesen10@yahoo.com", "Patsy", "Friesen" },
                    { 18, "Oliver_Bartell22@gmail.com", "Oliver", "Bartell" },
                    { 19, "Gladys.Bergnaum@hotmail.com", "Gladys", "Bergnaum" },
                    { 20, "Rochelle.Bruen@yahoo.com", "Rochelle", "Bruen" },
                    { 21, "Dana_Hackett20@yahoo.com", "Dana", "Hackett" },
                    { 22, "Mandy_Erdman@yahoo.com", "Mandy", "Erdman" },
                    { 23, "Darren.Bogisich93@yahoo.com", "Darren", "Bogisich" },
                    { 24, "Vernon.Herzog@yahoo.com", "Vernon", "Herzog" },
                    { 25, "Shane27@gmail.com", "Shane", "Feeney" },
                    { 26, "Manuel_Gerhold51@yahoo.com", "Manuel", "Gerhold" },
                    { 27, "William35@yahoo.com", "William", "Bins" },
                    { 28, "Morris8@gmail.com", "Morris", "Jakubowski" },
                    { 29, "Sara_Rosenbaum@hotmail.com", "Sara", "Rosenbaum" },
                    { 30, "Verna.Bernhard53@yahoo.com", "Verna", "Bernhard" },
                    { 31, "Amber8@hotmail.com", "Amber", "Batz" },
                    { 32, "Homer_Herzog81@yahoo.com", "Homer", "Herzog" },
                    { 33, "Elsie33@hotmail.com", "Elsie", "Gleichner" },
                    { 34, "Michele.Hansen44@gmail.com", "Michele", "Hansen" },
                    { 35, "Amber_Stamm68@hotmail.com", "Amber", "Stamm" },
                    { 36, "Kenny_Lockman51@gmail.com", "Kenny", "Lockman" },
                    { 37, "Raymond_Greenholt67@hotmail.com", "Raymond", "Greenholt" },
                    { 38, "Kristina_Rogahn@gmail.com", "Kristina", "Rogahn" },
                    { 39, "Heather15@yahoo.com", "Heather", "Jast" },
                    { 40, "Amos_Rowe@gmail.com", "Amos", "Rowe" },
                    { 41, "Mona.Streich2@yahoo.com", "Mona", "Streich" },
                    { 42, "Leah22@hotmail.com", "Leah", "Quigley" },
                    { 43, "Brooke75@gmail.com", "Brooke", "Durgan" },
                    { 44, "Jared.Grant27@gmail.com", "Jared", "Grant" },
                    { 45, "Marcia.Fadel27@gmail.com", "Marcia", "Fadel" },
                    { 46, "Debra60@yahoo.com", "Debra", "Murray" },
                    { 47, "Darla95@gmail.com", "Darla", "Bayer" },
                    { 48, "Kelly.Armstrong@hotmail.com", "Kelly", "Armstrong" },
                    { 49, "Mercedes.Dach@yahoo.com", "Mercedes", "Dach" },
                    { 50, "Sharon66@gmail.com", "Sharon", "Miller" },
                    { 51, "Dianne96@hotmail.com", "Dianne", "Mayert" },
                    { 52, "Jacob13@yahoo.com", "Jacob", "Monahan" },
                    { 53, "Shelly_Wolff@yahoo.com", "Shelly", "Wolff" },
                    { 54, "Ernest54@hotmail.com", "Ernest", "Maggio" },
                    { 55, "Angel_Aufderhar78@yahoo.com", "Angel", "Aufderhar" },
                    { 56, "Ignacio_Stracke@hotmail.com", "Ignacio", "Stracke" },
                    { 57, "Catherine15@gmail.com", "Catherine", "Jenkins" },
                    { 58, "Malcolm61@yahoo.com", "Malcolm", "Bruen" },
                    { 59, "Yvette.Konopelski@gmail.com", "Yvette", "Konopelski" },
                    { 60, "Isaac_Murazik@gmail.com", "Isaac", "Murazik" },
                    { 61, "Boyd_Kirlin78@hotmail.com", "Boyd", "Kirlin" },
                    { 62, "Brooke_Mayer@yahoo.com", "Brooke", "Mayer" },
                    { 63, "Travis9@hotmail.com", "Travis", "Fay" },
                    { 64, "Lewis3@gmail.com", "Lewis", "Zulauf" },
                    { 65, "Betty.Gutmann33@hotmail.com", "Betty", "Gutmann" },
                    { 66, "Colleen_Wyman@gmail.com", "Colleen", "Wyman" },
                    { 67, "Clark.Lowe33@yahoo.com", "Clark", "Lowe" },
                    { 68, "Lois.Gerlach33@gmail.com", "Lois", "Gerlach" },
                    { 69, "Franklin.Pfannerstill@hotmail.com", "Franklin", "Pfannerstill" },
                    { 70, "Toni.Lynch56@gmail.com", "Toni", "Lynch" },
                    { 71, "Jesus.Huels9@hotmail.com", "Jesus", "Huels" },
                    { 72, "Christie_Mraz@gmail.com", "Christie", "Mraz" },
                    { 73, "Dora38@gmail.com", "Dora", "Hodkiewicz" },
                    { 74, "Amos.Smitham@hotmail.com", "Amos", "Smitham" },
                    { 75, "Pauline.Collins17@yahoo.com", "Pauline", "Collins" },
                    { 76, "Matthew.Herzog50@hotmail.com", "Matthew", "Herzog" },
                    { 77, "Ernestine_Schmeler@gmail.com", "Ernestine", "Schmeler" },
                    { 78, "Rodney_Lind@yahoo.com", "Rodney", "Lind" },
                    { 79, "Elmer.Bruen@hotmail.com", "Elmer", "Bruen" },
                    { 80, "Otis.Haag@yahoo.com", "Otis", "Haag" },
                    { 81, "Lindsey86@yahoo.com", "Lindsey", "Treutel" },
                    { 82, "Joy36@yahoo.com", "Joy", "Heaney" },
                    { 83, "Bobby23@yahoo.com", "Bobby", "West" },
                    { 84, "Florence_Bernhard32@hotmail.com", "Florence", "Bernhard" },
                    { 85, "Tricia.Walker@yahoo.com", "Tricia", "Walker" },
                    { 86, "Josh_Kuphal29@yahoo.com", "Josh", "Kuphal" },
                    { 87, "Julie.Pacocha25@yahoo.com", "Julie", "Pacocha" },
                    { 88, "Rick90@hotmail.com", "Rick", "Walter" },
                    { 89, "Lucy_Bergstrom40@hotmail.com", "Lucy", "Bergstrom" },
                    { 90, "Diana_Roberts@hotmail.com", "Diana", "Roberts" },
                    { 91, "Clifford.Klocko6@yahoo.com", "Clifford", "Klocko" },
                    { 92, "Lyle_Mosciski@gmail.com", "Lyle", "Mosciski" },
                    { 93, "Herman.Kovacek@hotmail.com", "Herman", "Kovacek" },
                    { 94, "Damon.Hills94@yahoo.com", "Damon", "Hills" },
                    { 95, "Alfonso.Bogan@gmail.com", "Alfonso", "Bogan" },
                    { 96, "Kendra31@hotmail.com", "Kendra", "Krajcik" },
                    { 97, "Jack_West5@yahoo.com", "Jack", "West" },
                    { 98, "Lawrence_Huels@yahoo.com", "Lawrence", "Huels" },
                    { 99, "Byron77@gmail.com", "Byron", "Hayes" },
                    { 100, "Georgia.Gislason@gmail.com", "Georgia", "Gislason" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "Url" },
                values: new object[,]
                {
                    { 1, false, "https://picsum.photos/640/480/?image=274" },
                    { 2, false, "https://picsum.photos/640/480/?image=176" },
                    { 3, false, "https://picsum.photos/640/480/?image=679" },
                    { 4, false, "https://picsum.photos/640/480/?image=460" },
                    { 5, false, "https://picsum.photos/640/480/?image=121" },
                    { 6, false, "https://picsum.photos/640/480/?image=1056" },
                    { 7, false, "https://picsum.photos/640/480/?image=433" },
                    { 8, false, "https://picsum.photos/640/480/?image=1044" },
                    { 9, false, "https://picsum.photos/640/480/?image=770" },
                    { 10, false, "https://picsum.photos/640/480/?image=1054" },
                    { 11, false, "https://picsum.photos/640/480/?image=360" },
                    { 12, false, "https://picsum.photos/640/480/?image=330" },
                    { 13, false, "https://picsum.photos/640/480/?image=459" },
                    { 14, false, "https://picsum.photos/640/480/?image=732" },
                    { 15, false, "https://picsum.photos/640/480/?image=25" },
                    { 16, false, "https://picsum.photos/640/480/?image=7" },
                    { 17, false, "https://picsum.photos/640/480/?image=783" },
                    { 18, false, "https://picsum.photos/640/480/?image=417" },
                    { 19, false, "https://picsum.photos/640/480/?image=476" },
                    { 20, false, "https://picsum.photos/640/480/?image=58" },
                    { 21, true, "https://picsum.photos/640/480/?image=268" },
                    { 22, true, "https://picsum.photos/640/480/?image=554" },
                    { 23, true, "https://picsum.photos/640/480/?image=126" },
                    { 24, true, "https://picsum.photos/640/480/?image=572" },
                    { 25, true, "https://picsum.photos/640/480/?image=876" },
                    { 26, true, "https://picsum.photos/640/480/?image=1084" },
                    { 27, true, "https://picsum.photos/640/480/?image=9" },
                    { 28, true, "https://picsum.photos/640/480/?image=876" },
                    { 29, true, "https://picsum.photos/640/480/?image=288" },
                    { 30, true, "https://picsum.photos/640/480/?image=437" },
                    { 31, true, "https://picsum.photos/640/480/?image=119" },
                    { 32, true, "https://picsum.photos/640/480/?image=472" },
                    { 33, true, "https://picsum.photos/640/480/?image=97" },
                    { 34, true, "https://picsum.photos/640/480/?image=862" },
                    { 35, true, "https://picsum.photos/640/480/?image=673" },
                    { 36, true, "https://picsum.photos/640/480/?image=933" },
                    { 37, true, "https://picsum.photos/640/480/?image=263" },
                    { 38, true, "https://picsum.photos/640/480/?image=712" },
                    { 39, true, "https://picsum.photos/640/480/?image=1006" },
                    { 40, true, "https://picsum.photos/640/480/?image=595" },
                    { 41, true, "https://picsum.photos/640/480/?image=1" },
                    { 42, true, "https://picsum.photos/640/480/?image=716" },
                    { 43, true, "https://picsum.photos/640/480/?image=345" },
                    { 44, true, "https://picsum.photos/640/480/?image=733" },
                    { 45, true, "https://picsum.photos/640/480/?image=104" },
                    { 46, true, "https://picsum.photos/640/480/?image=825" },
                    { 47, true, "https://picsum.photos/640/480/?image=246" },
                    { 48, true, "https://picsum.photos/640/480/?image=339" },
                    { 49, true, "https://picsum.photos/640/480/?image=669" },
                    { 50, true, "https://picsum.photos/640/480/?image=103" },
                    { 51, true, "https://picsum.photos/640/480/?image=22" },
                    { 52, true, "https://picsum.photos/640/480/?image=253" },
                    { 53, true, "https://picsum.photos/640/480/?image=602" },
                    { 54, true, "https://picsum.photos/640/480/?image=842" },
                    { 55, true, "https://picsum.photos/640/480/?image=345" },
                    { 56, true, "https://picsum.photos/640/480/?image=669" },
                    { 57, true, "https://picsum.photos/640/480/?image=28" },
                    { 58, true, "https://picsum.photos/640/480/?image=271" },
                    { 59, true, "https://picsum.photos/640/480/?image=595" },
                    { 60, true, "https://picsum.photos/640/480/?image=1070" },
                    { 61, true, "https://picsum.photos/640/480/?image=770" },
                    { 62, true, "https://picsum.photos/640/480/?image=17" },
                    { 63, true, "https://picsum.photos/640/480/?image=712" },
                    { 64, true, "https://picsum.photos/640/480/?image=885" },
                    { 65, true, "https://picsum.photos/640/480/?image=1049" },
                    { 66, true, "https://picsum.photos/640/480/?image=548" },
                    { 67, true, "https://picsum.photos/640/480/?image=239" },
                    { 68, true, "https://picsum.photos/640/480/?image=481" },
                    { 69, true, "https://picsum.photos/640/480/?image=805" },
                    { 70, true, "https://picsum.photos/640/480/?image=646" },
                    { 71, true, "https://picsum.photos/640/480/?image=518" },
                    { 72, true, "https://picsum.photos/640/480/?image=583" },
                    { 73, true, "https://picsum.photos/640/480/?image=434" },
                    { 74, true, "https://picsum.photos/640/480/?image=1070" },
                    { 75, true, "https://picsum.photos/640/480/?image=927" },
                    { 76, true, "https://picsum.photos/640/480/?image=448" },
                    { 77, true, "https://picsum.photos/640/480/?image=1036" },
                    { 78, true, "https://picsum.photos/640/480/?image=248" },
                    { 79, true, "https://picsum.photos/640/480/?image=717" },
                    { 80, true, "https://picsum.photos/640/480/?image=187" },
                    { 81, true, "https://picsum.photos/640/480/?image=844" },
                    { 82, true, "https://picsum.photos/640/480/?image=798" },
                    { 83, true, "https://picsum.photos/640/480/?image=442" },
                    { 84, true, "https://picsum.photos/640/480/?image=704" },
                    { 85, true, "https://picsum.photos/640/480/?image=706" },
                    { 86, true, "https://picsum.photos/640/480/?image=950" },
                    { 87, true, "https://picsum.photos/640/480/?image=95" },
                    { 88, true, "https://picsum.photos/640/480/?image=873" },
                    { 89, true, "https://picsum.photos/640/480/?image=537" },
                    { 90, true, "https://picsum.photos/640/480/?image=246" },
                    { 91, true, "https://picsum.photos/640/480/?image=132" },
                    { 92, true, "https://picsum.photos/640/480/?image=31" },
                    { 93, true, "https://picsum.photos/640/480/?image=355" },
                    { 94, true, "https://picsum.photos/640/480/?image=345" },
                    { 95, true, "https://picsum.photos/640/480/?image=15" },
                    { 96, true, "https://picsum.photos/640/480/?image=158" },
                    { 97, true, "https://picsum.photos/640/480/?image=875" },
                    { 98, true, "https://picsum.photos/640/480/?image=1076" },
                    { 99, true, "https://picsum.photos/640/480/?image=42" },
                    { 100, true, "https://picsum.photos/640/480/?image=220" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 49, 1, "Curtis", "Cassin" },
                    { 2, 54, 2, "Winston", "Schimmel" },
                    { 3, 79, 3, "Mark", "Jakubowski" },
                    { 4, 32, 4, "Darnell", "Becker" },
                    { 5, 42, 5, "Elizabeth", "Gutkowski" },
                    { 6, 29, 6, "Terrance", "Brekke" },
                    { 7, 80, 7, "Lillie", "Muller" },
                    { 8, 70, 8, "Eduardo", "Rippin" },
                    { 9, 42, 9, "Marianne", "Weber" },
                    { 10, 43, 10, "Mona", "Altenwerth" },
                    { 11, 34, 11, "Terri", "Stanton" },
                    { 12, 60, 12, "Joy", "Zieme" },
                    { 13, 30, 13, "Jacob", "Johnson" },
                    { 14, 48, 14, "Andre", "Towne" },
                    { 15, 78, 15, "Jake", "VonRueden" },
                    { 16, 59, 16, "Karl", "Fay" },
                    { 17, 63, 17, "Benny", "Hettinger" },
                    { 18, 29, 18, "Perry", "Bogisich" },
                    { 19, 35, 19, "Tasha", "Flatley" },
                    { 20, 57, 20, "Amy", "Brakus" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "LocationType", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "aut ut quibusdam veniam in distinctio culpa et", 51, 1, 2, 11, 1306.3572559570871, 5, "Toby Inlet", "West Letaland" },
                    { 2, "eveniet rerum unde pariatur quo odit vero quaerat", 27, 1, 3, 9, 1187.4332755487781, 3, "Ashleigh Key", "West Kayley" },
                    { 3, "aliquid sed fuga illum aut fugit maxime molestias", 42, 2, 1, 16, 276.58342965099337, 8, "Russel Islands", "Mariamberg" },
                    { 4, "doloremque eveniet id odio est nihil in laudantium", 25, 2, 5, 13, 564.25168112355448, 9, "Blaise Ramp", "Martinefort" },
                    { 5, "magni voluptas ipsam quia est nemo sit suscipit", 14, 3, 0, 4, 1427.5784601673254, 8, "Casimer Burg", "Gleasonton" },
                    { 6, "dolores est voluptate eligendi ut voluptates numquam possimus", 27, 3, 2, 17, 1053.6430223462728, 8, "Gay Ridges", "Lake Edwardoville" },
                    { 7, "reprehenderit illo libero voluptatum nisi at dolor ratione", 9, 4, 4, 20, 101.94843266265565, 3, "Daryl River", "Waelchiport" },
                    { 8, "eum dolores a totam inventore soluta omnis culpa", 51, 4, 5, 9, 849.23000770899296, 6, "Waylon Loop", "Tillmanport" },
                    { 9, "et similique porro ducimus blanditiis eligendi quis animi", 60, 5, 0, 15, 1417.773028866058, 7, "Willy Ways", "Tyshawnfurt" },
                    { 10, "ut quibusdam aliquid officia voluptas assumenda consequatur autem", 4, 5, 1, 11, 1489.9877575696753, 4, "Zachariah Plain", "South Malika" },
                    { 11, "illum repudiandae ipsa omnis cum rerum voluptatem occaecati", 7, 6, 3, 10, 292.00534970801993, 5, "Shanelle Groves", "New Casimirmouth" },
                    { 12, "consequuntur qui dicta earum quaerat culpa rerum consequatur", 5, 6, 3, 1, 1171.8357108572409, 4, "Ed Key", "East Ahmad" },
                    { 13, "et quia minus nobis quisquam qui facilis ipsum", 15, 7, 4, 5, 208.08751255623892, 6, "Karley Curve", "Craighaven" },
                    { 14, "alias ea voluptatem tenetur consectetur eos alias voluptate", 16, 7, 3, 11, 780.34984901291557, 5, "Turcotte Islands", "Port Isabella" },
                    { 15, "ipsam laudantium maiores sit voluptatem et ea aliquid", 19, 8, 3, 16, 1243.9726587386203, 10, "Shields Forges", "Port Sydneyland" },
                    { 16, "minima porro nam atque molestiae commodi assumenda reprehenderit", 53, 8, 3, 7, 606.69823001255884, 6, "Pollich Roads", "North Esta" },
                    { 17, "unde omnis numquam aut quidem sed molestias exercitationem", 10, 9, 5, 7, 144.26586529374794, 8, "Jairo Isle", "Port Jaquelin" },
                    { 18, "ea aperiam fuga qui rerum temporibus itaque quidem", 52, 9, 3, 20, 130.2500636228431, 9, "Berneice Trail", "East Jeanneview" },
                    { 19, "illum consequatur sit laboriosam culpa adipisci cum veniam", 22, 10, 5, 5, 1142.9258947021622, 2, "Jalen Viaduct", "Thielview" },
                    { 20, "quaerat voluptatum nihil explicabo dolores ipsum adipisci in", 41, 10, 3, 7, 344.46375513485242, 1, "Hermiston Village", "New Loismouth" },
                    { 21, "laudantium aut numquam velit ut laboriosam aspernatur praesentium", 12, 11, 3, 5, 213.44849444599598, 6, "Katelin Manor", "Raynorton" },
                    { 22, "sed laboriosam iste aut adipisci eos atque corporis", 36, 11, 5, 12, 628.3959880018125, 4, "Spencer Forest", "Sallyborough" },
                    { 23, "laborum aliquam sit nihil quam et nihil numquam", 51, 12, 2, 14, 1249.377302402022, 2, "Kuhic Port", "North Janelle" },
                    { 24, "sit enim commodi totam sunt tempore aut dolor", 25, 12, 0, 5, 208.64762397267413, 9, "Braulio Unions", "New Cale" },
                    { 25, "eos et enim hic necessitatibus et architecto fugit", 63, 13, 4, 19, 958.19062924118668, 4, "Libbie Orchard", "Laurentown" },
                    { 26, "aut sunt in sint rem nostrum voluptatem iste", 8, 13, 4, 12, 663.3109869088828, 3, "Santos Knolls", "Port Dejah" },
                    { 27, "aut eaque fuga voluptatem atque nesciunt aut impedit", 25, 14, 1, 10, 307.12967294476397, 6, "Rowe Expressway", "Jimmiestad" },
                    { 28, "non at veniam facilis quisquam ut unde ducimus", 16, 14, 1, 9, 166.88435981083023, 5, "Camron Island", "New Cordia" },
                    { 29, "maiores vero error asperiores repellat recusandae qui quaerat", 55, 15, 0, 10, 1384.4233066925067, 4, "Gusikowski Road", "North Arjunhaven" },
                    { 30, "sequi ipsa nisi minima ducimus quisquam adipisci recusandae", 40, 15, 1, 12, 434.94242645952454, 10, "Gislason Expressway", "New Magalichester" },
                    { 31, "harum natus velit libero voluptatibus iste ipsa suscipit", 44, 16, 4, 7, 299.500658875054, 1, "Aurore Passage", "West Jocelynbury" },
                    { 32, "quisquam veritatis animi molestiae omnis quia laboriosam natus", 35, 16, 3, 10, 914.19273465334015, 10, "Rice Light", "Magdalenton" },
                    { 33, "repellat rerum omnis omnis vel et at atque", 49, 17, 5, 13, 1424.3515030825117, 3, "Armani Rapids", "North Clayfurt" },
                    { 34, "itaque odio blanditiis distinctio earum corporis fugiat architecto", 37, 17, 3, 3, 821.34342414779599, 2, "Rowe Lane", "East Jamar" },
                    { 35, "possimus quis consectetur omnis veniam aut voluptas reprehenderit", 7, 18, 3, 14, 601.54488824105579, 2, "Parker Rapid", "Robeltown" },
                    { 36, "delectus iste quasi esse iusto voluptas quia expedita", 39, 18, 4, 13, 836.70586472495927, 2, "Bayer Way", "Port Ivah" },
                    { 37, "ut ea molestiae harum perspiciatis magni rem ipsa", 59, 19, 2, 8, 241.48886361816875, 1, "Hal Cape", "North Katelynnchester" },
                    { 38, "rerum quisquam voluptatem vero aut ab ullam ipsa", 9, 19, 0, 4, 1044.8593298741098, 5, "Denis Loop", "Auerfurt" },
                    { 39, "voluptas provident veniam est necessitatibus laboriosam illum occaecati", 34, 20, 2, 6, 1471.3919594063411, 7, "Moen Lakes", "Brandimouth" },
                    { 40, "aperiam qui blanditiis voluptatem excepturi assumenda ut dolorem", 22, 20, 0, 8, 815.17844892053472, 2, "Prince Cape", "Aidanton" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 85, 0.0, new DateTime(2024, 3, 4, 3, 40, 46, 664, DateTimeKind.Local).AddTicks(4189), 40, new DateTime(2023, 12, 15, 22, 49, 39, 367, DateTimeKind.Local).AddTicks(3993) },
                    { 2, 50, 0.0, new DateTime(2023, 11, 28, 13, 0, 45, 540, DateTimeKind.Local).AddTicks(5199), 1, new DateTime(2024, 2, 20, 0, 46, 14, 206, DateTimeKind.Local).AddTicks(4740) },
                    { 3, 5, 0.0, new DateTime(2024, 2, 22, 7, 14, 59, 963, DateTimeKind.Local).AddTicks(254), 1, new DateTime(2024, 3, 12, 16, 58, 50, 917, DateTimeKind.Local).AddTicks(4949) },
                    { 4, 85, 0.0, new DateTime(2024, 3, 30, 23, 23, 47, 741, DateTimeKind.Local).AddTicks(6558), 1, new DateTime(2024, 5, 17, 23, 2, 11, 929, DateTimeKind.Local).AddTicks(7228) },
                    { 5, 8, 0.0, new DateTime(2023, 12, 5, 11, 23, 49, 743, DateTimeKind.Local).AddTicks(1133), 2, new DateTime(2024, 4, 8, 10, 29, 58, 84, DateTimeKind.Local).AddTicks(8443) },
                    { 6, 49, 0.0, new DateTime(2024, 1, 26, 18, 15, 44, 588, DateTimeKind.Local).AddTicks(6483), 2, new DateTime(2024, 3, 2, 2, 14, 49, 404, DateTimeKind.Local).AddTicks(2347) },
                    { 7, 55, 0.0, new DateTime(2024, 1, 17, 5, 35, 26, 936, DateTimeKind.Local).AddTicks(5437), 2, new DateTime(2024, 5, 9, 12, 41, 34, 541, DateTimeKind.Local).AddTicks(4646) },
                    { 8, 57, 0.0, new DateTime(2024, 1, 10, 7, 14, 7, 915, DateTimeKind.Local).AddTicks(222), 3, new DateTime(2024, 3, 4, 1, 56, 1, 313, DateTimeKind.Local).AddTicks(3279) },
                    { 9, 39, 0.0, new DateTime(2023, 12, 6, 7, 29, 58, 697, DateTimeKind.Local).AddTicks(1144), 3, new DateTime(2024, 4, 9, 20, 28, 22, 935, DateTimeKind.Local).AddTicks(1239) },
                    { 10, 89, 0.0, new DateTime(2024, 3, 5, 9, 31, 15, 560, DateTimeKind.Local).AddTicks(4371), 3, new DateTime(2024, 1, 30, 3, 30, 25, 494, DateTimeKind.Local).AddTicks(1531) },
                    { 11, 29, 0.0, new DateTime(2024, 3, 13, 9, 17, 13, 169, DateTimeKind.Local).AddTicks(382), 4, new DateTime(2023, 12, 12, 7, 44, 45, 998, DateTimeKind.Local).AddTicks(2069) },
                    { 12, 48, 0.0, new DateTime(2024, 1, 23, 8, 44, 31, 435, DateTimeKind.Local).AddTicks(3400), 4, new DateTime(2024, 2, 10, 0, 41, 18, 554, DateTimeKind.Local).AddTicks(1404) },
                    { 13, 9, 0.0, new DateTime(2024, 3, 5, 4, 54, 35, 456, DateTimeKind.Local).AddTicks(4880), 4, new DateTime(2024, 2, 12, 22, 35, 27, 979, DateTimeKind.Local).AddTicks(3993) },
                    { 14, 28, 0.0, new DateTime(2023, 12, 11, 18, 54, 17, 880, DateTimeKind.Local).AddTicks(829), 5, new DateTime(2024, 4, 19, 21, 52, 53, 663, DateTimeKind.Local).AddTicks(5014) },
                    { 15, 29, 0.0, new DateTime(2023, 12, 27, 6, 49, 33, 415, DateTimeKind.Local).AddTicks(2239), 5, new DateTime(2024, 4, 11, 1, 58, 31, 100, DateTimeKind.Local).AddTicks(3154) },
                    { 16, 13, 0.0, new DateTime(2024, 3, 3, 7, 55, 50, 306, DateTimeKind.Local).AddTicks(4090), 5, new DateTime(2024, 1, 21, 11, 42, 31, 188, DateTimeKind.Local).AddTicks(7407) },
                    { 17, 23, 2.5039768439339936, new DateTime(2024, 5, 19, 15, 21, 10, 671, DateTimeKind.Local).AddTicks(6890), 6, new DateTime(2024, 4, 22, 0, 55, 10, 178, DateTimeKind.Local).AddTicks(9015) },
                    { 18, 8, 0.0, new DateTime(2024, 2, 17, 3, 31, 42, 914, DateTimeKind.Local).AddTicks(8276), 6, new DateTime(2023, 12, 7, 17, 15, 59, 756, DateTimeKind.Local).AddTicks(1033) },
                    { 19, 23, 0.0, new DateTime(2024, 1, 26, 9, 26, 27, 646, DateTimeKind.Local).AddTicks(3084), 6, new DateTime(2023, 11, 28, 17, 6, 34, 265, DateTimeKind.Local).AddTicks(7465) },
                    { 20, 54, 0.0, new DateTime(2024, 1, 17, 10, 33, 0, 512, DateTimeKind.Local).AddTicks(8647), 7, new DateTime(2024, 2, 20, 0, 42, 3, 715, DateTimeKind.Local).AddTicks(6672) },
                    { 21, 3, 0.0, new DateTime(2023, 12, 27, 11, 47, 2, 308, DateTimeKind.Local).AddTicks(2100), 7, new DateTime(2023, 12, 19, 5, 25, 10, 563, DateTimeKind.Local).AddTicks(3976) },
                    { 22, 17, 0.0, new DateTime(2023, 12, 16, 15, 53, 27, 740, DateTimeKind.Local).AddTicks(6417), 7, new DateTime(2024, 5, 9, 1, 26, 15, 984, DateTimeKind.Local).AddTicks(7439) },
                    { 23, 24, 0.0, new DateTime(2023, 12, 30, 17, 46, 17, 225, DateTimeKind.Local).AddTicks(4227), 8, new DateTime(2024, 4, 30, 1, 19, 33, 782, DateTimeKind.Local).AddTicks(5653) },
                    { 24, 9, 0.0, new DateTime(2024, 4, 29, 23, 3, 21, 351, DateTimeKind.Local).AddTicks(7583), 8, new DateTime(2024, 2, 20, 23, 34, 26, 371, DateTimeKind.Local).AddTicks(8508) },
                    { 25, 27, 0.0, new DateTime(2024, 3, 10, 19, 56, 26, 418, DateTimeKind.Local).AddTicks(6681), 8, new DateTime(2024, 4, 26, 10, 22, 14, 229, DateTimeKind.Local).AddTicks(7691) },
                    { 26, 59, 0.0, new DateTime(2024, 4, 18, 0, 20, 57, 399, DateTimeKind.Local).AddTicks(5265), 9, new DateTime(2024, 5, 11, 21, 42, 24, 851, DateTimeKind.Local).AddTicks(6551) },
                    { 27, 19, 0.0, new DateTime(2024, 3, 31, 9, 6, 31, 787, DateTimeKind.Local).AddTicks(6368), 9, new DateTime(2023, 12, 17, 12, 12, 36, 64, DateTimeKind.Local).AddTicks(8767) },
                    { 28, 26, 0.0, new DateTime(2024, 4, 15, 14, 4, 59, 275, DateTimeKind.Local).AddTicks(1952), 9, new DateTime(2023, 12, 27, 15, 25, 17, 740, DateTimeKind.Local).AddTicks(4089) },
                    { 29, 41, 0.0, new DateTime(2024, 1, 18, 0, 17, 41, 68, DateTimeKind.Local).AddTicks(7213), 10, new DateTime(2023, 12, 31, 15, 53, 27, 1, DateTimeKind.Local).AddTicks(4765) },
                    { 30, 28, 0.0, new DateTime(2024, 1, 5, 20, 25, 51, 637, DateTimeKind.Local).AddTicks(3323), 10, new DateTime(2024, 3, 4, 6, 2, 58, 358, DateTimeKind.Local).AddTicks(1436) },
                    { 31, 46, 0.0, new DateTime(2024, 5, 4, 22, 50, 45, 463, DateTimeKind.Local).AddTicks(2190), 10, new DateTime(2024, 5, 2, 2, 39, 36, 139, DateTimeKind.Local).AddTicks(830) },
                    { 32, 33, 0.0, new DateTime(2024, 1, 8, 6, 30, 19, 80, DateTimeKind.Local).AddTicks(288), 11, new DateTime(2024, 5, 4, 6, 59, 33, 229, DateTimeKind.Local).AddTicks(969) },
                    { 33, 20, 6.7835394348451628, new DateTime(2024, 5, 20, 10, 58, 30, 130, DateTimeKind.Local).AddTicks(4848), 11, new DateTime(2024, 2, 8, 10, 24, 2, 292, DateTimeKind.Local).AddTicks(4860) },
                    { 34, 31, 0.0, new DateTime(2024, 2, 6, 3, 56, 43, 326, DateTimeKind.Local).AddTicks(1910), 11, new DateTime(2024, 1, 6, 1, 50, 53, 473, DateTimeKind.Local).AddTicks(2680) },
                    { 35, 89, 0.0, new DateTime(2024, 3, 8, 13, 41, 5, 756, DateTimeKind.Local).AddTicks(7306), 12, new DateTime(2024, 4, 7, 10, 58, 4, 367, DateTimeKind.Local).AddTicks(5399) },
                    { 36, 36, 0.0, new DateTime(2024, 1, 30, 12, 22, 50, 901, DateTimeKind.Local).AddTicks(8869), 12, new DateTime(2024, 1, 4, 0, 31, 9, 164, DateTimeKind.Local).AddTicks(4119) },
                    { 37, 65, 0.0, new DateTime(2023, 12, 11, 20, 6, 54, 792, DateTimeKind.Local).AddTicks(9305), 12, new DateTime(2023, 12, 3, 0, 8, 2, 164, DateTimeKind.Local).AddTicks(3407) },
                    { 38, 68, 0.0, new DateTime(2023, 12, 12, 19, 31, 51, 501, DateTimeKind.Local).AddTicks(306), 13, new DateTime(2024, 4, 16, 15, 35, 23, 807, DateTimeKind.Local).AddTicks(8663) },
                    { 39, 87, 0.0, new DateTime(2024, 3, 3, 23, 56, 27, 222, DateTimeKind.Local).AddTicks(6188), 13, new DateTime(2024, 3, 13, 0, 6, 4, 695, DateTimeKind.Local).AddTicks(4122) },
                    { 40, 12, 0.0, new DateTime(2024, 5, 21, 4, 19, 48, 780, DateTimeKind.Local).AddTicks(5599), 13, new DateTime(2024, 2, 11, 10, 39, 43, 484, DateTimeKind.Local).AddTicks(8520) },
                    { 41, 90, 0.0, new DateTime(2024, 4, 21, 6, 14, 45, 230, DateTimeKind.Local).AddTicks(1525), 14, new DateTime(2024, 1, 29, 3, 46, 31, 5, DateTimeKind.Local).AddTicks(1459) },
                    { 42, 17, 0.50046270462767883, new DateTime(2023, 11, 30, 19, 5, 18, 900, DateTimeKind.Local).AddTicks(6827), 14, new DateTime(2024, 1, 22, 5, 54, 58, 240, DateTimeKind.Local).AddTicks(5019) },
                    { 43, 55, 0.0, new DateTime(2024, 1, 6, 19, 27, 5, 286, DateTimeKind.Local).AddTicks(3510), 14, new DateTime(2024, 2, 23, 7, 13, 43, 230, DateTimeKind.Local).AddTicks(8473) },
                    { 44, 28, 0.0, new DateTime(2023, 12, 13, 14, 19, 20, 605, DateTimeKind.Local).AddTicks(7686), 15, new DateTime(2024, 1, 5, 17, 47, 28, 96, DateTimeKind.Local).AddTicks(2381) },
                    { 45, 80, 0.0, new DateTime(2024, 5, 10, 19, 35, 44, 363, DateTimeKind.Local).AddTicks(1019), 15, new DateTime(2023, 12, 5, 17, 57, 15, 753, DateTimeKind.Local).AddTicks(9859) },
                    { 46, 50, 0.0, new DateTime(2024, 4, 29, 4, 25, 11, 842, DateTimeKind.Local).AddTicks(3823), 15, new DateTime(2024, 2, 23, 5, 53, 16, 17, DateTimeKind.Local).AddTicks(2765) },
                    { 47, 20, 8.3108059716000486, new DateTime(2024, 1, 25, 18, 4, 39, 466, DateTimeKind.Local).AddTicks(5962), 16, new DateTime(2024, 2, 10, 18, 58, 33, 659, DateTimeKind.Local).AddTicks(5402) },
                    { 48, 83, 0.0, new DateTime(2024, 5, 4, 16, 13, 40, 907, DateTimeKind.Local).AddTicks(7747), 16, new DateTime(2024, 2, 5, 1, 38, 29, 270, DateTimeKind.Local).AddTicks(4791) },
                    { 49, 92, 0.0, new DateTime(2024, 1, 18, 5, 30, 48, 780, DateTimeKind.Local).AddTicks(5910), 16, new DateTime(2024, 1, 17, 0, 33, 45, 521, DateTimeKind.Local).AddTicks(2182) },
                    { 50, 3, 0.0, new DateTime(2023, 12, 25, 14, 24, 57, 506, DateTimeKind.Local).AddTicks(871), 17, new DateTime(2024, 3, 30, 18, 45, 21, 167, DateTimeKind.Local).AddTicks(7435) },
                    { 51, 18, 0.0, new DateTime(2024, 1, 10, 2, 12, 59, 673, DateTimeKind.Local).AddTicks(6879), 17, new DateTime(2024, 4, 1, 15, 30, 6, 116, DateTimeKind.Local).AddTicks(2520) },
                    { 52, 78, 0.0, new DateTime(2024, 5, 12, 8, 19, 47, 465, DateTimeKind.Local).AddTicks(7411), 17, new DateTime(2024, 4, 24, 7, 17, 23, 58, DateTimeKind.Local).AddTicks(177) },
                    { 53, 74, 0.0, new DateTime(2024, 5, 25, 17, 29, 36, 723, DateTimeKind.Local).AddTicks(6453), 18, new DateTime(2024, 3, 13, 5, 22, 46, 657, DateTimeKind.Local).AddTicks(2076) },
                    { 54, 47, 0.0, new DateTime(2024, 4, 27, 2, 21, 22, 0, DateTimeKind.Local).AddTicks(352), 18, new DateTime(2024, 1, 18, 8, 20, 18, 552, DateTimeKind.Local).AddTicks(5119) },
                    { 55, 93, 0.0, new DateTime(2024, 2, 10, 19, 41, 20, 484, DateTimeKind.Local).AddTicks(3077), 18, new DateTime(2024, 1, 28, 22, 34, 26, 770, DateTimeKind.Local).AddTicks(5605) },
                    { 56, 24, 0.0, new DateTime(2024, 2, 24, 19, 51, 30, 127, DateTimeKind.Local).AddTicks(134), 19, new DateTime(2024, 3, 30, 15, 39, 19, 289, DateTimeKind.Local).AddTicks(9872) },
                    { 57, 72, 0.0, new DateTime(2024, 2, 8, 1, 59, 21, 75, DateTimeKind.Local).AddTicks(374), 19, new DateTime(2024, 3, 24, 10, 31, 26, 765, DateTimeKind.Local).AddTicks(6984) },
                    { 58, 59, 0.0, new DateTime(2024, 1, 12, 4, 41, 26, 203, DateTimeKind.Local).AddTicks(482), 19, new DateTime(2024, 5, 20, 19, 46, 54, 286, DateTimeKind.Local).AddTicks(7191) },
                    { 59, 14, 0.0, new DateTime(2024, 3, 6, 2, 2, 53, 552, DateTimeKind.Local).AddTicks(5610), 20, new DateTime(2024, 3, 14, 3, 31, 10, 928, DateTimeKind.Local).AddTicks(7378) },
                    { 60, 91, 0.0, new DateTime(2024, 3, 16, 16, 1, 21, 497, DateTimeKind.Local).AddTicks(3204), 20, new DateTime(2024, 5, 13, 18, 53, 20, 509, DateTimeKind.Local).AddTicks(1873) },
                    { 61, 95, 0.0, new DateTime(2024, 4, 4, 16, 54, 1, 910, DateTimeKind.Local).AddTicks(963), 20, new DateTime(2024, 2, 17, 22, 38, 19, 545, DateTimeKind.Local).AddTicks(9569) },
                    { 62, 51, 0.0, new DateTime(2024, 2, 23, 22, 57, 28, 543, DateTimeKind.Local).AddTicks(1361), 21, new DateTime(2024, 3, 24, 1, 52, 7, 948, DateTimeKind.Local).AddTicks(2591) },
                    { 63, 57, 0.0, new DateTime(2023, 11, 28, 20, 23, 41, 951, DateTimeKind.Local).AddTicks(4653), 21, new DateTime(2024, 3, 22, 8, 16, 2, 167, DateTimeKind.Local).AddTicks(9840) },
                    { 64, 56, 0.0, new DateTime(2024, 3, 25, 18, 21, 1, 623, DateTimeKind.Local).AddTicks(2161), 21, new DateTime(2023, 12, 10, 18, 55, 53, 729, DateTimeKind.Local).AddTicks(8796) },
                    { 65, 91, 0.0, new DateTime(2023, 12, 22, 2, 50, 9, 767, DateTimeKind.Local).AddTicks(1956), 22, new DateTime(2023, 12, 14, 10, 6, 0, 550, DateTimeKind.Local).AddTicks(7515) },
                    { 66, 6, 0.0, new DateTime(2024, 1, 17, 12, 59, 19, 235, DateTimeKind.Local).AddTicks(6276), 22, new DateTime(2024, 1, 9, 7, 1, 19, 100, DateTimeKind.Local).AddTicks(8118) },
                    { 67, 36, 0.0, new DateTime(2024, 1, 24, 9, 51, 4, 34, DateTimeKind.Local).AddTicks(5536), 22, new DateTime(2024, 1, 31, 5, 23, 40, 848, DateTimeKind.Local).AddTicks(6854) },
                    { 68, 80, 0.0, new DateTime(2024, 1, 28, 18, 10, 3, 669, DateTimeKind.Local).AddTicks(5883), 23, new DateTime(2024, 5, 4, 2, 34, 1, 570, DateTimeKind.Local).AddTicks(6360) },
                    { 69, 1, 0.0, new DateTime(2024, 4, 19, 13, 13, 12, 15, DateTimeKind.Local).AddTicks(3859), 23, new DateTime(2024, 3, 11, 1, 19, 36, 43, DateTimeKind.Local).AddTicks(3201) },
                    { 70, 83, 0.0, new DateTime(2024, 3, 3, 16, 56, 1, 538, DateTimeKind.Local).AddTicks(8852), 23, new DateTime(2024, 4, 7, 5, 23, 58, 262, DateTimeKind.Local).AddTicks(2449) },
                    { 71, 90, 0.0, new DateTime(2024, 1, 25, 2, 34, 31, 598, DateTimeKind.Local).AddTicks(9352), 24, new DateTime(2024, 2, 18, 3, 9, 29, 245, DateTimeKind.Local).AddTicks(1162) },
                    { 72, 95, 0.0, new DateTime(2023, 12, 29, 8, 19, 1, 970, DateTimeKind.Local).AddTicks(9795), 24, new DateTime(2023, 12, 27, 10, 10, 33, 289, DateTimeKind.Local).AddTicks(3412) },
                    { 73, 28, 0.0, new DateTime(2024, 2, 21, 11, 25, 26, 775, DateTimeKind.Local).AddTicks(4803), 24, new DateTime(2024, 2, 10, 12, 58, 4, 854, DateTimeKind.Local).AddTicks(7585) },
                    { 74, 78, 0.0, new DateTime(2023, 12, 17, 13, 4, 40, 236, DateTimeKind.Local).AddTicks(5641), 25, new DateTime(2024, 3, 26, 19, 43, 0, 205, DateTimeKind.Local).AddTicks(6462) },
                    { 75, 2, 0.0, new DateTime(2024, 4, 24, 2, 13, 36, 649, DateTimeKind.Local).AddTicks(5456), 25, new DateTime(2024, 1, 25, 3, 6, 8, 940, DateTimeKind.Local).AddTicks(2680) },
                    { 76, 23, 0.0, new DateTime(2024, 1, 26, 7, 29, 8, 355, DateTimeKind.Local).AddTicks(1477), 25, new DateTime(2024, 5, 17, 6, 18, 59, 871, DateTimeKind.Local).AddTicks(6605) },
                    { 77, 73, 0.0, new DateTime(2023, 12, 20, 14, 10, 13, 789, DateTimeKind.Local).AddTicks(4450), 26, new DateTime(2024, 5, 8, 20, 7, 21, 828, DateTimeKind.Local).AddTicks(8396) },
                    { 78, 2, 0.0, new DateTime(2024, 4, 24, 22, 49, 20, 703, DateTimeKind.Local).AddTicks(9530), 26, new DateTime(2024, 5, 11, 9, 53, 47, 542, DateTimeKind.Local).AddTicks(8996) },
                    { 79, 4, 0.0, new DateTime(2024, 3, 15, 8, 31, 52, 390, DateTimeKind.Local).AddTicks(3021), 26, new DateTime(2024, 4, 17, 20, 22, 26, 782, DateTimeKind.Local).AddTicks(1565) },
                    { 80, 40, 0.0, new DateTime(2024, 3, 8, 21, 21, 21, 952, DateTimeKind.Local).AddTicks(6010), 27, new DateTime(2024, 3, 27, 16, 5, 23, 694, DateTimeKind.Local).AddTicks(5320) },
                    { 81, 5, 0.0, new DateTime(2024, 5, 15, 4, 10, 50, 327, DateTimeKind.Local).AddTicks(8143), 27, new DateTime(2024, 1, 1, 6, 13, 13, 330, DateTimeKind.Local).AddTicks(1292) },
                    { 82, 5, 0.0, new DateTime(2023, 11, 29, 2, 49, 0, 557, DateTimeKind.Local).AddTicks(898), 27, new DateTime(2024, 3, 19, 12, 21, 20, 674, DateTimeKind.Local).AddTicks(8620) },
                    { 83, 17, 0.0, new DateTime(2024, 1, 29, 4, 4, 44, 501, DateTimeKind.Local).AddTicks(8772), 28, new DateTime(2024, 3, 14, 2, 26, 10, 141, DateTimeKind.Local).AddTicks(1556) },
                    { 84, 71, 1.4901695019883532, new DateTime(2024, 4, 4, 15, 28, 59, 210, DateTimeKind.Local).AddTicks(8154), 28, new DateTime(2023, 12, 2, 3, 55, 16, 733, DateTimeKind.Local).AddTicks(1209) },
                    { 85, 83, 0.0, new DateTime(2024, 4, 12, 16, 58, 19, 279, DateTimeKind.Local).AddTicks(5696), 28, new DateTime(2024, 5, 18, 4, 16, 10, 905, DateTimeKind.Local).AddTicks(2063) },
                    { 86, 44, 0.0, new DateTime(2024, 5, 6, 10, 16, 44, 307, DateTimeKind.Local).AddTicks(8111), 29, new DateTime(2024, 3, 25, 5, 56, 51, 163, DateTimeKind.Local).AddTicks(37) },
                    { 87, 26, 0.0, new DateTime(2024, 2, 5, 23, 23, 5, 485, DateTimeKind.Local).AddTicks(9667), 29, new DateTime(2024, 3, 1, 3, 6, 19, 710, DateTimeKind.Local).AddTicks(4422) },
                    { 88, 8, 0.0, new DateTime(2024, 2, 16, 19, 39, 37, 249, DateTimeKind.Local).AddTicks(920), 29, new DateTime(2024, 3, 1, 20, 38, 25, 150, DateTimeKind.Local).AddTicks(3458) },
                    { 89, 67, 0.0, new DateTime(2024, 5, 20, 8, 20, 2, 950, DateTimeKind.Local).AddTicks(7725), 30, new DateTime(2024, 3, 2, 7, 9, 18, 680, DateTimeKind.Local).AddTicks(1605) },
                    { 90, 39, 0.0, new DateTime(2023, 12, 9, 19, 10, 41, 688, DateTimeKind.Local).AddTicks(7285), 30, new DateTime(2024, 3, 29, 0, 17, 22, 993, DateTimeKind.Local).AddTicks(7766) },
                    { 91, 78, 0.0, new DateTime(2024, 1, 31, 19, 38, 23, 198, DateTimeKind.Local).AddTicks(2177), 30, new DateTime(2024, 2, 28, 22, 32, 42, 284, DateTimeKind.Local).AddTicks(1213) },
                    { 92, 45, 9.8430595979503419, new DateTime(2023, 12, 25, 9, 9, 42, 725, DateTimeKind.Local).AddTicks(1277), 31, new DateTime(2024, 5, 10, 0, 29, 13, 817, DateTimeKind.Local).AddTicks(2480) },
                    { 93, 21, 0.0, new DateTime(2024, 2, 6, 1, 3, 37, 198, DateTimeKind.Local).AddTicks(6465), 31, new DateTime(2024, 1, 19, 12, 58, 31, 223, DateTimeKind.Local).AddTicks(2363) },
                    { 94, 76, 0.0, new DateTime(2024, 3, 2, 7, 18, 3, 816, DateTimeKind.Local).AddTicks(340), 31, new DateTime(2024, 3, 6, 2, 18, 55, 430, DateTimeKind.Local).AddTicks(6850) },
                    { 95, 7, 0.0, new DateTime(2024, 5, 20, 6, 23, 21, 982, DateTimeKind.Local).AddTicks(3792), 32, new DateTime(2023, 12, 20, 9, 17, 40, 777, DateTimeKind.Local).AddTicks(9956) },
                    { 96, 84, 0.0, new DateTime(2024, 1, 10, 9, 14, 44, 532, DateTimeKind.Local).AddTicks(5397), 32, new DateTime(2024, 3, 13, 22, 56, 5, 795, DateTimeKind.Local).AddTicks(4481) },
                    { 97, 45, 0.0, new DateTime(2024, 4, 4, 10, 28, 53, 628, DateTimeKind.Local).AddTicks(2736), 32, new DateTime(2024, 2, 21, 11, 45, 32, 163, DateTimeKind.Local).AddTicks(3321) },
                    { 98, 39, 0.0, new DateTime(2023, 12, 7, 11, 7, 14, 911, DateTimeKind.Local).AddTicks(1104), 33, new DateTime(2023, 12, 7, 8, 22, 38, 452, DateTimeKind.Local).AddTicks(1239) },
                    { 99, 61, 0.0, new DateTime(2024, 4, 22, 2, 49, 42, 527, DateTimeKind.Local).AddTicks(6210), 33, new DateTime(2024, 4, 19, 18, 51, 8, 377, DateTimeKind.Local).AddTicks(3016) },
                    { 100, 78, 0.0, new DateTime(2024, 4, 20, 5, 0, 0, 931, DateTimeKind.Local).AddTicks(5430), 33, new DateTime(2024, 3, 31, 7, 30, 50, 877, DateTimeKind.Local).AddTicks(886) },
                    { 101, 46, 0.0, new DateTime(2024, 5, 24, 12, 17, 59, 412, DateTimeKind.Local).AddTicks(4387), 34, new DateTime(2023, 12, 16, 0, 5, 19, 165, DateTimeKind.Local).AddTicks(5734) },
                    { 102, 73, 9.9883343269167977, new DateTime(2024, 3, 27, 0, 29, 34, 941, DateTimeKind.Local).AddTicks(897), 34, new DateTime(2024, 4, 26, 19, 34, 36, 387, DateTimeKind.Local).AddTicks(619) },
                    { 103, 32, 0.0, new DateTime(2024, 3, 6, 8, 13, 48, 850, DateTimeKind.Local).AddTicks(6086), 34, new DateTime(2024, 2, 7, 1, 58, 26, 820, DateTimeKind.Local).AddTicks(1228) },
                    { 104, 53, 0.0, new DateTime(2023, 12, 14, 22, 28, 3, 526, DateTimeKind.Local).AddTicks(5717), 35, new DateTime(2024, 1, 5, 14, 54, 32, 62, DateTimeKind.Local).AddTicks(996) },
                    { 105, 75, 5.8881958390832789, new DateTime(2024, 2, 9, 21, 31, 21, 768, DateTimeKind.Local).AddTicks(7697), 35, new DateTime(2024, 2, 20, 11, 28, 44, 762, DateTimeKind.Local).AddTicks(9538) },
                    { 106, 3, 0.0, new DateTime(2024, 4, 15, 12, 1, 8, 303, DateTimeKind.Local).AddTicks(795), 35, new DateTime(2023, 12, 23, 13, 44, 28, 204, DateTimeKind.Local).AddTicks(7559) },
                    { 107, 77, 0.0, new DateTime(2024, 1, 23, 2, 12, 24, 967, DateTimeKind.Local).AddTicks(8829), 36, new DateTime(2024, 1, 27, 22, 11, 30, 786, DateTimeKind.Local).AddTicks(1489) },
                    { 108, 11, 0.0, new DateTime(2023, 12, 19, 1, 5, 9, 781, DateTimeKind.Local).AddTicks(8419), 36, new DateTime(2024, 5, 14, 23, 31, 52, 994, DateTimeKind.Local).AddTicks(5753) },
                    { 109, 42, 0.0, new DateTime(2024, 1, 31, 23, 49, 49, 829, DateTimeKind.Local).AddTicks(7285), 36, new DateTime(2024, 5, 14, 16, 22, 31, 956, DateTimeKind.Local).AddTicks(186) },
                    { 110, 91, 0.0, new DateTime(2024, 1, 8, 6, 7, 0, 982, DateTimeKind.Local).AddTicks(4827), 37, new DateTime(2024, 1, 22, 17, 29, 51, 70, DateTimeKind.Local).AddTicks(8815) },
                    { 111, 45, 0.0, new DateTime(2024, 2, 1, 5, 19, 2, 699, DateTimeKind.Local).AddTicks(4465), 37, new DateTime(2024, 2, 5, 9, 11, 40, 252, DateTimeKind.Local).AddTicks(8692) },
                    { 112, 52, 0.0, new DateTime(2024, 3, 23, 20, 50, 49, 711, DateTimeKind.Local).AddTicks(9052), 37, new DateTime(2024, 2, 8, 7, 18, 56, 915, DateTimeKind.Local).AddTicks(9456) },
                    { 113, 59, 0.0, new DateTime(2024, 3, 17, 11, 47, 10, 737, DateTimeKind.Local).AddTicks(4160), 38, new DateTime(2024, 3, 17, 1, 12, 28, 845, DateTimeKind.Local).AddTicks(5705) },
                    { 114, 85, 0.0, new DateTime(2024, 1, 6, 15, 19, 41, 725, DateTimeKind.Local).AddTicks(6808), 38, new DateTime(2024, 1, 19, 5, 26, 37, 381, DateTimeKind.Local).AddTicks(5239) },
                    { 115, 5, 2.9056273425129908, new DateTime(2024, 4, 19, 7, 10, 17, 346, DateTimeKind.Local).AddTicks(4040), 38, new DateTime(2024, 1, 18, 9, 5, 24, 937, DateTimeKind.Local).AddTicks(7632) },
                    { 116, 61, 0.0, new DateTime(2024, 4, 25, 19, 25, 43, 803, DateTimeKind.Local).AddTicks(6716), 39, new DateTime(2024, 1, 25, 2, 31, 53, 336, DateTimeKind.Local).AddTicks(1062) },
                    { 117, 52, 0.0, new DateTime(2024, 2, 25, 9, 3, 47, 478, DateTimeKind.Local).AddTicks(9827), 39, new DateTime(2024, 4, 30, 6, 29, 17, 44, DateTimeKind.Local).AddTicks(3138) },
                    { 118, 77, 0.0, new DateTime(2024, 5, 25, 16, 14, 31, 460, DateTimeKind.Local).AddTicks(5113), 39, new DateTime(2023, 12, 31, 1, 59, 0, 982, DateTimeKind.Local).AddTicks(3350) },
                    { 119, 63, 0.0, new DateTime(2023, 12, 8, 3, 52, 17, 362, DateTimeKind.Local).AddTicks(3970), 40, new DateTime(2024, 3, 11, 14, 19, 49, 551, DateTimeKind.Local).AddTicks(7909) },
                    { 120, 54, 0.0, new DateTime(2023, 12, 8, 11, 0, 3, 836, DateTimeKind.Local).AddTicks(2948), 40, new DateTime(2024, 2, 10, 11, 27, 1, 102, DateTimeKind.Local).AddTicks(3634) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

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
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58);

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
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 79);

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
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 88);

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
                keyValue: 97);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

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
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

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
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

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
                keyValue: 47);

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
                keyValue: 50);

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
                keyValue: 57);

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
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71);

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
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 80);

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
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 87);

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
        }
    }
}
