using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudBnB.API.Migrations
{
    /// <inheritdoc />
    public partial class population : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Mitchell_Herzog@gmail.com", "Mitchell", "Herzog" },
                    { 2, "Marco.Volkman18@yahoo.com", "Marco", "Volkman" },
                    { 3, "Ernestine_Pfannerstill@hotmail.com", "Ernestine", "Pfannerstill" },
                    { 4, "Dale_Huels@hotmail.com", "Dale", "Huels" },
                    { 5, "Anita.Gulgowski8@yahoo.com", "Anita", "Gulgowski" },
                    { 6, "Alfred_Kris@hotmail.com", "Alfred", "Kris" },
                    { 7, "Rogelio44@hotmail.com", "Rogelio", "Dicki" },
                    { 8, "Darlene14@yahoo.com", "Darlene", "Wyman" },
                    { 9, "Jordan_Ward67@hotmail.com", "Jordan", "Ward" },
                    { 10, "Saul.Harber11@yahoo.com", "Saul", "Harber" },
                    { 11, "Spencer_Kshlerin3@gmail.com", "Spencer", "Kshlerin" },
                    { 12, "Ryan_Wintheiser@gmail.com", "Ryan", "Wintheiser" },
                    { 13, "Van.Welch@gmail.com", "Van", "Welch" },
                    { 14, "Travis.Emmerich@hotmail.com", "Travis", "Emmerich" },
                    { 15, "Roger40@yahoo.com", "Roger", "Boehm" },
                    { 16, "Luke_Yost@hotmail.com", "Luke", "Yost" },
                    { 17, "Edwin.Ondricka@gmail.com", "Edwin", "Ondricka" },
                    { 18, "Rosemarie_Lowe1@hotmail.com", "Rosemarie", "Lowe" },
                    { 19, "Cory2@hotmail.com", "Cory", "Abbott" },
                    { 20, "Patricia16@yahoo.com", "Patricia", "Baumbach" },
                    { 21, "Juan_Borer@yahoo.com", "Juan", "Borer" },
                    { 22, "Roberta.Gerlach@yahoo.com", "Roberta", "Gerlach" },
                    { 23, "Byron96@hotmail.com", "Byron", "Fritsch" },
                    { 24, "Arthur.McDermott28@yahoo.com", "Arthur", "McDermott" },
                    { 25, "Vicki.Murazik@yahoo.com", "Vicki", "Murazik" },
                    { 26, "Clyde74@yahoo.com", "Clyde", "Reynolds" },
                    { 27, "Toni.Collins92@yahoo.com", "Toni", "Collins" },
                    { 28, "Nadine_White29@gmail.com", "Nadine", "White" },
                    { 29, "Kristi_Rutherford@gmail.com", "Kristi", "Rutherford" },
                    { 30, "Brittany_Collier@hotmail.com", "Brittany", "Collier" },
                    { 31, "Charlie.Greenholt45@gmail.com", "Charlie", "Greenholt" },
                    { 32, "Mamie.Lowe73@yahoo.com", "Mamie", "Lowe" },
                    { 33, "Irma.Torphy@gmail.com", "Irma", "Torphy" },
                    { 34, "Daisy.Kulas82@yahoo.com", "Daisy", "Kulas" },
                    { 35, "Bruce.Hahn26@gmail.com", "Bruce", "Hahn" },
                    { 36, "Trevor_OKon@gmail.com", "Trevor", "O'Kon" },
                    { 37, "Sabrina_Daugherty66@yahoo.com", "Sabrina", "Daugherty" },
                    { 38, "Grant.Langosh70@hotmail.com", "Grant", "Langosh" },
                    { 39, "Julio8@hotmail.com", "Julio", "Crist" },
                    { 40, "Kelley.Kreiger@yahoo.com", "Kelley", "Kreiger" },
                    { 41, "Nellie86@gmail.com", "Nellie", "Hickle" },
                    { 42, "Felipe.Hegmann@hotmail.com", "Felipe", "Hegmann" },
                    { 43, "Herman_Bahringer65@gmail.com", "Herman", "Bahringer" },
                    { 44, "Ernest_Shields@yahoo.com", "Ernest", "Shields" },
                    { 45, "Lena_Robel@hotmail.com", "Lena", "Robel" },
                    { 46, "Morris52@gmail.com", "Morris", "Heidenreich" },
                    { 47, "Irene_Lesch76@hotmail.com", "Irene", "Lesch" },
                    { 48, "Lori_Davis65@gmail.com", "Lori", "Davis" },
                    { 49, "Beulah_Runolfsson99@hotmail.com", "Beulah", "Runolfsson" },
                    { 50, "Jeff_Paucek15@gmail.com", "Jeff", "Paucek" },
                    { 51, "Edna29@yahoo.com", "Edna", "Roob" },
                    { 52, "Dwight.Heaney@yahoo.com", "Dwight", "Heaney" },
                    { 53, "Sidney_Kovacek55@hotmail.com", "Sidney", "Kovacek" },
                    { 54, "Kelly54@gmail.com", "Kelly", "Gleichner" },
                    { 55, "Steve_Sawayn@hotmail.com", "Steve", "Sawayn" },
                    { 56, "Bonnie41@gmail.com", "Bonnie", "Williamson" },
                    { 57, "Cameron50@hotmail.com", "Cameron", "Denesik" },
                    { 58, "Wayne66@gmail.com", "Wayne", "Christiansen" },
                    { 59, "Greg95@yahoo.com", "Greg", "Aufderhar" },
                    { 60, "Naomi75@gmail.com", "Naomi", "McKenzie" },
                    { 61, "Jenny_Dibbert@hotmail.com", "Jenny", "Dibbert" },
                    { 62, "Arlene93@yahoo.com", "Arlene", "Hintz" },
                    { 63, "Derek_Konopelski80@hotmail.com", "Derek", "Konopelski" },
                    { 64, "Edmund_Kiehn16@gmail.com", "Edmund", "Kiehn" },
                    { 65, "Mamie.Tremblay@gmail.com", "Mamie", "Tremblay" },
                    { 66, "Angelica_Gaylord@gmail.com", "Angelica", "Gaylord" },
                    { 67, "Nichole.Weber42@hotmail.com", "Nichole", "Weber" },
                    { 68, "Ismael18@hotmail.com", "Ismael", "Hessel" },
                    { 69, "Maureen_Stark43@hotmail.com", "Maureen", "Stark" },
                    { 70, "Allison_Dach@hotmail.com", "Allison", "Dach" },
                    { 71, "Lori.Kunze47@yahoo.com", "Lori", "Kunze" },
                    { 72, "Wade.Armstrong@yahoo.com", "Wade", "Armstrong" },
                    { 73, "Josefina47@yahoo.com", "Josefina", "Christiansen" },
                    { 74, "Charlie61@yahoo.com", "Charlie", "Mraz" },
                    { 75, "Judy99@gmail.com", "Judy", "Langosh" },
                    { 76, "Javier_Kunde45@hotmail.com", "Javier", "Kunde" },
                    { 77, "Kevin_Kassulke62@yahoo.com", "Kevin", "Kassulke" },
                    { 78, "Jackie.Casper@yahoo.com", "Jackie", "Casper" },
                    { 79, "Roland_Dicki@yahoo.com", "Roland", "Dicki" },
                    { 80, "Maryann_Bayer64@hotmail.com", "Maryann", "Bayer" },
                    { 81, "Cecilia.Mann1@hotmail.com", "Cecilia", "Mann" },
                    { 82, "Hugo_Feeney@hotmail.com", "Hugo", "Feeney" },
                    { 83, "Darla_Ernser@gmail.com", "Darla", "Ernser" },
                    { 84, "Julio.Dibbert20@gmail.com", "Julio", "Dibbert" },
                    { 85, "Felicia_Lubowitz@hotmail.com", "Felicia", "Lubowitz" },
                    { 86, "Alfredo74@hotmail.com", "Alfredo", "Feil" },
                    { 87, "Jerald18@gmail.com", "Jerald", "Altenwerth" },
                    { 88, "Naomi.West48@hotmail.com", "Naomi", "West" },
                    { 89, "Douglas59@hotmail.com", "Douglas", "Marks" },
                    { 90, "Larry20@hotmail.com", "Larry", "Dare" },
                    { 91, "Johanna92@yahoo.com", "Johanna", "Wintheiser" },
                    { 92, "Lindsay_Schuppe@gmail.com", "Lindsay", "Schuppe" },
                    { 93, "Patricia_Crooks8@yahoo.com", "Patricia", "Crooks" },
                    { 94, "Sidney22@yahoo.com", "Sidney", "Abshire" },
                    { 95, "Elsie85@yahoo.com", "Elsie", "Balistreri" },
                    { 96, "Camille24@gmail.com", "Camille", "Nienow" },
                    { 97, "Theresa.Roob@yahoo.com", "Theresa", "Roob" },
                    { 98, "Tomas46@hotmail.com", "Tomas", "Pfeffer" },
                    { 99, "Ramona.Gleason65@yahoo.com", "Ramona", "Gleason" },
                    { 100, "Sylvia.Price@gmail.com", "Sylvia", "Price" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "Url" },
                values: new object[,]
                {
                    { 1, false, "https://picsum.photos/640/480/?image=927" },
                    { 2, false, "https://picsum.photos/640/480/?image=132" },
                    { 3, false, "https://picsum.photos/640/480/?image=484" },
                    { 4, false, "https://picsum.photos/640/480/?image=953" },
                    { 5, false, "https://picsum.photos/640/480/?image=417" },
                    { 6, false, "https://picsum.photos/640/480/?image=156" },
                    { 7, false, "https://picsum.photos/640/480/?image=957" },
                    { 8, false, "https://picsum.photos/640/480/?image=299" },
                    { 9, false, "https://picsum.photos/640/480/?image=337" },
                    { 10, false, "https://picsum.photos/640/480/?image=1038" },
                    { 11, false, "https://picsum.photos/640/480/?image=830" },
                    { 12, false, "https://picsum.photos/640/480/?image=632" },
                    { 13, false, "https://picsum.photos/640/480/?image=912" },
                    { 14, false, "https://picsum.photos/640/480/?image=254" },
                    { 15, false, "https://picsum.photos/640/480/?image=146" },
                    { 16, false, "https://picsum.photos/640/480/?image=851" },
                    { 17, false, "https://picsum.photos/640/480/?image=676" },
                    { 18, false, "https://picsum.photos/640/480/?image=404" },
                    { 19, false, "https://picsum.photos/640/480/?image=662" },
                    { 20, false, "https://picsum.photos/640/480/?image=761" },
                    { 21, true, "https://picsum.photos/640/480/?image=796" },
                    { 22, true, "https://picsum.photos/640/480/?image=615" },
                    { 23, true, "https://picsum.photos/640/480/?image=709" },
                    { 24, true, "https://picsum.photos/640/480/?image=677" },
                    { 25, true, "https://picsum.photos/640/480/?image=240" },
                    { 26, true, "https://picsum.photos/640/480/?image=408" },
                    { 27, true, "https://picsum.photos/640/480/?image=421" },
                    { 28, true, "https://picsum.photos/640/480/?image=348" },
                    { 29, true, "https://picsum.photos/640/480/?image=583" },
                    { 30, true, "https://picsum.photos/640/480/?image=447" },
                    { 31, true, "https://picsum.photos/640/480/?image=468" },
                    { 32, true, "https://picsum.photos/640/480/?image=222" },
                    { 33, true, "https://picsum.photos/640/480/?image=781" },
                    { 34, true, "https://picsum.photos/640/480/?image=123" },
                    { 35, true, "https://picsum.photos/640/480/?image=195" },
                    { 36, true, "https://picsum.photos/640/480/?image=278" },
                    { 37, true, "https://picsum.photos/640/480/?image=272" },
                    { 38, true, "https://picsum.photos/640/480/?image=399" },
                    { 39, true, "https://picsum.photos/640/480/?image=108" },
                    { 40, true, "https://picsum.photos/640/480/?image=277" },
                    { 41, true, "https://picsum.photos/640/480/?image=528" },
                    { 42, true, "https://picsum.photos/640/480/?image=343" },
                    { 43, true, "https://picsum.photos/640/480/?image=1050" },
                    { 44, true, "https://picsum.photos/640/480/?image=544" },
                    { 45, true, "https://picsum.photos/640/480/?image=115" },
                    { 46, true, "https://picsum.photos/640/480/?image=156" },
                    { 47, true, "https://picsum.photos/640/480/?image=771" },
                    { 48, true, "https://picsum.photos/640/480/?image=347" },
                    { 49, true, "https://picsum.photos/640/480/?image=342" },
                    { 50, true, "https://picsum.photos/640/480/?image=100" },
                    { 51, true, "https://picsum.photos/640/480/?image=144" },
                    { 52, true, "https://picsum.photos/640/480/?image=221" },
                    { 53, true, "https://picsum.photos/640/480/?image=785" },
                    { 54, true, "https://picsum.photos/640/480/?image=1048" },
                    { 55, true, "https://picsum.photos/640/480/?image=32" },
                    { 56, true, "https://picsum.photos/640/480/?image=196" },
                    { 57, true, "https://picsum.photos/640/480/?image=208" },
                    { 58, true, "https://picsum.photos/640/480/?image=237" },
                    { 59, true, "https://picsum.photos/640/480/?image=960" },
                    { 60, true, "https://picsum.photos/640/480/?image=515" },
                    { 61, true, "https://picsum.photos/640/480/?image=407" },
                    { 62, true, "https://picsum.photos/640/480/?image=90" },
                    { 63, true, "https://picsum.photos/640/480/?image=284" },
                    { 64, true, "https://picsum.photos/640/480/?image=584" },
                    { 65, true, "https://picsum.photos/640/480/?image=886" },
                    { 66, true, "https://picsum.photos/640/480/?image=883" },
                    { 67, true, "https://picsum.photos/640/480/?image=323" },
                    { 68, true, "https://picsum.photos/640/480/?image=327" },
                    { 69, true, "https://picsum.photos/640/480/?image=612" },
                    { 70, true, "https://picsum.photos/640/480/?image=1043" },
                    { 71, true, "https://picsum.photos/640/480/?image=266" },
                    { 72, true, "https://picsum.photos/640/480/?image=160" },
                    { 73, true, "https://picsum.photos/640/480/?image=61" },
                    { 74, true, "https://picsum.photos/640/480/?image=711" },
                    { 75, true, "https://picsum.photos/640/480/?image=316" },
                    { 76, true, "https://picsum.photos/640/480/?image=194" },
                    { 77, true, "https://picsum.photos/640/480/?image=217" },
                    { 78, true, "https://picsum.photos/640/480/?image=381" },
                    { 79, true, "https://picsum.photos/640/480/?image=377" },
                    { 80, true, "https://picsum.photos/640/480/?image=84" },
                    { 81, true, "https://picsum.photos/640/480/?image=197" },
                    { 82, true, "https://picsum.photos/640/480/?image=63" },
                    { 83, true, "https://picsum.photos/640/480/?image=274" },
                    { 84, true, "https://picsum.photos/640/480/?image=1041" },
                    { 85, true, "https://picsum.photos/640/480/?image=394" },
                    { 86, true, "https://picsum.photos/640/480/?image=842" },
                    { 87, true, "https://picsum.photos/640/480/?image=982" },
                    { 88, true, "https://picsum.photos/640/480/?image=257" },
                    { 89, true, "https://picsum.photos/640/480/?image=553" },
                    { 90, true, "https://picsum.photos/640/480/?image=813" },
                    { 91, true, "https://picsum.photos/640/480/?image=140" },
                    { 92, true, "https://picsum.photos/640/480/?image=117" },
                    { 93, true, "https://picsum.photos/640/480/?image=988" },
                    { 94, true, "https://picsum.photos/640/480/?image=331" },
                    { 95, true, "https://picsum.photos/640/480/?image=370" },
                    { 96, true, "https://picsum.photos/640/480/?image=480" },
                    { 97, true, "https://picsum.photos/640/480/?image=456" },
                    { 98, true, "https://picsum.photos/640/480/?image=293" },
                    { 99, true, "https://picsum.photos/640/480/?image=246" },
                    { 100, true, "https://picsum.photos/640/480/?image=580" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 55, 1, "Darla", "Parker" },
                    { 2, 45, 2, "Anna", "Pfannerstill" },
                    { 3, 18, 3, "Kate", "Nader" },
                    { 4, 25, 4, "Joanne", "Davis" },
                    { 5, 70, 5, "Tabitha", "Morar" },
                    { 6, 23, 6, "Joan", "Schaefer" },
                    { 7, 32, 7, "Kathleen", "Koepp" },
                    { 8, 31, 8, "Cecelia", "Jones" },
                    { 9, 44, 9, "Kari", "Rutherford" },
                    { 10, 43, 10, "Jackie", "Raynor" },
                    { 11, 20, 11, "Benny", "Kuphal" },
                    { 12, 43, 12, "Katherine", "Schuppe" },
                    { 13, 39, 13, "Larry", "Kulas" },
                    { 14, 59, 14, "Ray", "Heller" },
                    { 15, 27, 15, "Valerie", "Johns" },
                    { 16, 52, 16, "Jennifer", "Strosin" },
                    { 17, 43, 17, "Enrique", "Conn" },
                    { 18, 67, 18, "Franklin", "Schneider" },
                    { 19, 20, 19, "Lynn", "Schuppe" },
                    { 20, 73, 20, "Otis", "Gorczany" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "LandlordId", "LocationType", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "porro optio quia deserunt porro sed odit laborum", 1, 4, 4, 688.81326058343211, 3, "Cruickshank Lodge", "West Westonberg" },
                    { 2, "dignissimos ea facere fugiat totam fugiat eum libero", 1, 4, 7, 540.46690601041939, 10, "Lyric Rest", "Sengerside" },
                    { 3, "sit magni pariatur repellendus labore aperiam nam voluptatem", 2, 1, 2, 1215.5995501927507, 3, "Sunny Center", "Lake Alfonzomouth" },
                    { 4, "autem dicta voluptatem est in similique quos animi", 2, 3, 14, 292.21623255569637, 5, "Parisian Mall", "Rivermouth" },
                    { 5, "dolorem consequatur laborum eum repellat et dicta vel", 3, 2, 15, 1005.6394234383463, 9, "Blanda Crossing", "Port Julianaville" },
                    { 6, "sed necessitatibus impedit architecto nam repellendus autem neque", 3, 5, 1, 616.02693196266489, 6, "Gayle Hollow", "Krystalburgh" },
                    { 7, "non ad est labore quia recusandae iusto veritatis", 4, 2, 5, 519.67631730751987, 7, "Schmitt Fork", "Casimerside" },
                    { 8, "est velit sit mollitia omnis omnis ea odio", 4, 1, 2, 1296.2725377296724, 6, "Fay Island", "Sipeschester" },
                    { 9, "eos distinctio vel dolorum harum rerum earum aliquam", 5, 5, 8, 1186.4010547500529, 10, "Mikayla Flats", "West Jamalfort" },
                    { 10, "accusantium laboriosam consequuntur tenetur excepturi voluptate ratione ut", 5, 1, 17, 1061.4133431287023, 6, "Thiel Pike", "West Stanfurt" },
                    { 11, "vitae in earum est impedit ut enim eum", 6, 1, 7, 188.33717756307385, 2, "Gorczany Inlet", "Ceceliaberg" },
                    { 12, "quibusdam reprehenderit natus sunt fugit maiores iste velit", 6, 3, 3, 556.95967586884024, 3, "Easter Ranch", "Mireillemouth" },
                    { 13, "non eaque repudiandae iure veritatis eveniet eveniet perferendis", 7, 1, 13, 108.20201360011501, 9, "Thiel Roads", "Caylafurt" },
                    { 14, "tenetur est sed ex numquam laudantium eveniet impedit", 7, 0, 4, 1322.3785187808301, 7, "Heaney Squares", "Ziemannside" },
                    { 15, "repudiandae et aliquid cum doloremque inventore suscipit sed", 8, 4, 3, 756.2491005862795, 1, "Alize Drive", "Brentton" },
                    { 16, "quidem ratione cumque beatae consequatur iusto saepe qui", 8, 3, 13, 1205.4969258887181, 8, "Collier Flats", "Port Brookland" },
                    { 17, "non id maiores aut consequatur ut eum et", 9, 2, 6, 1384.9149230812939, 10, "Wyman Keys", "Port Ransom" },
                    { 18, "quidem est repudiandae ipsum ipsam cumque cupiditate ipsa", 9, 3, 14, 1023.3725982086745, 3, "Pfeffer Village", "Balistreriberg" },
                    { 19, "ullam magnam saepe nihil quod aspernatur ipsam quia", 10, 0, 2, 921.11669722873432, 1, "Marcelino Cove", "Alessiachester" },
                    { 20, "et temporibus aut voluptas laboriosam dolores sit ut", 10, 0, 16, 835.7921476873255, 7, "Katarina Cape", "Lake Gillianbury" },
                    { 21, "mollitia sint excepturi ut qui et aliquam voluptas", 11, 4, 18, 229.43048196140614, 7, "Alvis Trace", "New Taureanchester" },
                    { 22, "eos autem laborum doloribus suscipit quos magni quo", 11, 4, 11, 663.29466029388891, 6, "Mitchel Lock", "Danemouth" },
                    { 23, "et optio dolorem quae rerum ea deleniti atque", 12, 5, 4, 1326.475190701417, 9, "Cummings Dam", "Colbymouth" },
                    { 24, "rem corrupti ipsam consequatur eligendi minima inventore vero", 12, 3, 16, 423.31454474637809, 8, "Barton Shoals", "East Raul" },
                    { 25, "quisquam optio consequatur ea rem necessitatibus deserunt libero", 13, 3, 20, 798.82332006683441, 6, "Nolan Drive", "Lake Jerome" },
                    { 26, "possimus delectus neque magnam tenetur est ut totam", 13, 4, 1, 382.9996511598718, 6, "Jensen Station", "New Dexter" },
                    { 27, "hic voluptas quia aut a velit placeat est", 14, 3, 4, 797.18926215801514, 7, "Weber Estate", "West Ralph" },
                    { 28, "aut error maiores aliquid tenetur qui placeat incidunt", 14, 4, 18, 1119.8472757316961, 2, "Anahi Ferry", "North Juvenalhaven" },
                    { 29, "consequatur perspiciatis sed necessitatibus eum autem est sapiente", 15, 4, 9, 1495.0115803213987, 2, "Littel Fields", "Rennerbury" },
                    { 30, "velit et necessitatibus culpa ex ut mollitia cum", 15, 1, 18, 356.31958376553337, 8, "Ansley Forges", "South Lindsey" },
                    { 31, "rem qui enim sed illo perferendis quae est", 16, 2, 10, 1205.1189599084275, 2, "Lemke Pines", "Jaysonside" },
                    { 32, "ut voluptatem sed dolor quas fuga quo et", 16, 0, 6, 945.91813686847559, 10, "Daron Courts", "North Joel" },
                    { 33, "numquam eaque soluta sit similique ducimus numquam sint", 17, 3, 2, 660.78870105529279, 2, "Itzel Crossing", "Cordiashire" },
                    { 34, "autem velit laudantium aut voluptatem magnam pariatur velit", 17, 2, 8, 1400.7136543002255, 7, "Tillman Greens", "North Dustin" },
                    { 35, "sit voluptas esse quia omnis sed amet aut", 18, 1, 16, 546.47021439594744, 4, "Jaskolski Run", "Balistrerishire" },
                    { 36, "sint asperiores recusandae excepturi eligendi dolorem non laboriosam", 18, 0, 20, 611.8989192527639, 9, "Misael Drive", "New Lizethland" },
                    { 37, "non aut accusamus illo possimus quia similique voluptas", 19, 1, 13, 486.47949160482057, 10, "Dickens Terrace", "Magnoliatown" },
                    { 38, "et iusto labore inventore est dolor accusamus quaerat", 19, 5, 6, 1459.6755625046776, 7, "MacGyver Pass", "North Clintfurt" },
                    { 39, "amet aspernatur reprehenderit voluptas suscipit ab quis rem", 20, 5, 13, 465.35949174985404, 2, "Kaden Way", "Lueilwitzview" },
                    { 40, "dicta corporis repudiandae minus est nam labore animi", 20, 2, 9, 268.03660534373319, 8, "Carolyne Locks", "Vivienneburgh" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[] { 1, 51, 0.0, new DateTime(2024, 2, 25, 20, 39, 26, 473, DateTimeKind.Local).AddTicks(6871), 40, new DateTime(2024, 1, 1, 3, 50, 35, 914, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 2, 35, 0.0, new DateTime(2024, 1, 17, 11, 11, 12, 985, DateTimeKind.Local).AddTicks(8364), 1, new DateTime(2023, 12, 9, 2, 46, 45, 567, DateTimeKind.Local).AddTicks(8442) },
                    { 3, 73, 0.0, new DateTime(2023, 12, 10, 10, 9, 50, 522, DateTimeKind.Local).AddTicks(7051), 1, new DateTime(2024, 2, 9, 6, 19, 26, 124, DateTimeKind.Local).AddTicks(1232) },
                    { 4, 98, 0.0, new DateTime(2024, 1, 1, 3, 22, 50, 538, DateTimeKind.Local).AddTicks(3653), 1, new DateTime(2024, 2, 24, 23, 25, 25, 312, DateTimeKind.Local).AddTicks(7462) },
                    { 5, 5, 0.0, new DateTime(2024, 4, 16, 20, 34, 49, 545, DateTimeKind.Local).AddTicks(7028), 2, new DateTime(2024, 2, 20, 13, 30, 0, 918, DateTimeKind.Local).AddTicks(7370) },
                    { 6, 5, 0.0, new DateTime(2024, 2, 23, 2, 53, 16, 359, DateTimeKind.Local).AddTicks(7476), 2, new DateTime(2024, 4, 6, 1, 2, 45, 236, DateTimeKind.Local).AddTicks(6190) },
                    { 7, 52, 0.0, new DateTime(2024, 4, 2, 22, 1, 27, 838, DateTimeKind.Local).AddTicks(4840), 2, new DateTime(2024, 1, 8, 0, 55, 31, 786, DateTimeKind.Local).AddTicks(6507) },
                    { 8, 5, 0.43289093132315659, new DateTime(2024, 4, 9, 20, 31, 18, 582, DateTimeKind.Local).AddTicks(4570), 3, new DateTime(2024, 4, 14, 17, 35, 30, 171, DateTimeKind.Local).AddTicks(2151) },
                    { 9, 90, 0.0, new DateTime(2023, 12, 28, 17, 3, 13, 799, DateTimeKind.Local).AddTicks(9410), 3, new DateTime(2024, 3, 8, 8, 22, 53, 296, DateTimeKind.Local).AddTicks(8749) },
                    { 10, 32, 0.0, new DateTime(2023, 12, 15, 23, 24, 1, 756, DateTimeKind.Local).AddTicks(2067), 3, new DateTime(2024, 5, 2, 9, 26, 49, 7, DateTimeKind.Local).AddTicks(6668) },
                    { 11, 52, 0.0, new DateTime(2024, 4, 16, 13, 30, 46, 810, DateTimeKind.Local).AddTicks(1424), 4, new DateTime(2023, 12, 21, 11, 34, 44, 999, DateTimeKind.Local).AddTicks(9046) },
                    { 12, 12, 0.0, new DateTime(2023, 12, 10, 14, 33, 41, 298, DateTimeKind.Local).AddTicks(3218), 4, new DateTime(2023, 11, 14, 13, 48, 35, 720, DateTimeKind.Local).AddTicks(5243) },
                    { 13, 1, 0.0, new DateTime(2024, 2, 12, 11, 15, 40, 607, DateTimeKind.Local).AddTicks(6679), 4, new DateTime(2023, 12, 29, 12, 44, 20, 574, DateTimeKind.Local).AddTicks(4790) },
                    { 14, 56, 0.0, new DateTime(2024, 3, 16, 15, 24, 2, 589, DateTimeKind.Local).AddTicks(7667), 5, new DateTime(2023, 12, 15, 16, 11, 51, 233, DateTimeKind.Local).AddTicks(8379) },
                    { 15, 38, 0.0, new DateTime(2023, 12, 30, 17, 56, 41, 57, DateTimeKind.Local).AddTicks(7761), 5, new DateTime(2023, 12, 13, 19, 13, 6, 370, DateTimeKind.Local).AddTicks(2824) },
                    { 16, 95, 0.0, new DateTime(2024, 4, 24, 6, 56, 46, 976, DateTimeKind.Local).AddTicks(1426), 5, new DateTime(2024, 5, 3, 5, 44, 32, 973, DateTimeKind.Local).AddTicks(9741) },
                    { 17, 85, 0.0, new DateTime(2024, 5, 11, 2, 37, 50, 662, DateTimeKind.Local).AddTicks(7621), 6, new DateTime(2024, 4, 16, 15, 43, 41, 638, DateTimeKind.Local).AddTicks(9636) },
                    { 18, 71, 0.0, new DateTime(2024, 3, 7, 3, 43, 0, 55, DateTimeKind.Local).AddTicks(3576), 6, new DateTime(2024, 1, 22, 17, 1, 12, 781, DateTimeKind.Local).AddTicks(92) },
                    { 19, 41, 0.0, new DateTime(2024, 4, 28, 1, 12, 59, 288, DateTimeKind.Local).AddTicks(252), 6, new DateTime(2023, 12, 15, 14, 13, 17, 138, DateTimeKind.Local).AddTicks(8176) },
                    { 20, 89, 0.0, new DateTime(2023, 11, 28, 17, 51, 2, 546, DateTimeKind.Local).AddTicks(6827), 7, new DateTime(2024, 3, 4, 11, 55, 4, 374, DateTimeKind.Local).AddTicks(415) },
                    { 21, 44, 0.0, new DateTime(2024, 4, 27, 9, 17, 4, 308, DateTimeKind.Local).AddTicks(7936), 7, new DateTime(2024, 3, 21, 20, 44, 9, 165, DateTimeKind.Local).AddTicks(6425) },
                    { 22, 25, 0.0, new DateTime(2024, 1, 4, 18, 37, 58, 976, DateTimeKind.Local).AddTicks(8816), 7, new DateTime(2024, 4, 8, 4, 41, 15, 102, DateTimeKind.Local).AddTicks(3254) },
                    { 23, 46, 0.0, new DateTime(2024, 2, 18, 19, 43, 23, 928, DateTimeKind.Local).AddTicks(2946), 8, new DateTime(2024, 1, 20, 2, 11, 51, 261, DateTimeKind.Local).AddTicks(6025) },
                    { 24, 73, 0.0, new DateTime(2024, 1, 31, 12, 54, 22, 565, DateTimeKind.Local).AddTicks(465), 8, new DateTime(2024, 3, 25, 3, 21, 4, 735, DateTimeKind.Local).AddTicks(2592) },
                    { 25, 16, 0.0, new DateTime(2024, 4, 20, 3, 3, 48, 529, DateTimeKind.Local).AddTicks(398), 8, new DateTime(2023, 12, 2, 14, 25, 59, 608, DateTimeKind.Local).AddTicks(542) },
                    { 26, 6, 0.0, new DateTime(2024, 4, 25, 0, 38, 14, 742, DateTimeKind.Local).AddTicks(9087), 9, new DateTime(2023, 12, 23, 1, 13, 40, 562, DateTimeKind.Local).AddTicks(9658) },
                    { 27, 42, 0.0, new DateTime(2024, 2, 20, 19, 34, 27, 104, DateTimeKind.Local).AddTicks(3067), 9, new DateTime(2024, 2, 21, 10, 31, 6, 44, DateTimeKind.Local).AddTicks(6615) },
                    { 28, 49, 0.0, new DateTime(2024, 3, 24, 12, 54, 42, 238, DateTimeKind.Local).AddTicks(236), 9, new DateTime(2024, 2, 13, 6, 40, 49, 849, DateTimeKind.Local).AddTicks(7327) },
                    { 29, 2, 0.0, new DateTime(2023, 11, 15, 21, 10, 41, 356, DateTimeKind.Local).AddTicks(3441), 10, new DateTime(2024, 5, 3, 13, 36, 51, 788, DateTimeKind.Local).AddTicks(3058) },
                    { 30, 12, 0.0, new DateTime(2023, 12, 26, 6, 35, 21, 484, DateTimeKind.Local).AddTicks(2117), 10, new DateTime(2024, 4, 13, 5, 3, 48, 114, DateTimeKind.Local).AddTicks(1492) },
                    { 31, 1, 0.0, new DateTime(2024, 1, 14, 10, 56, 0, 769, DateTimeKind.Local).AddTicks(7521), 10, new DateTime(2024, 3, 24, 19, 9, 6, 170, DateTimeKind.Local).AddTicks(9365) },
                    { 32, 25, 0.0, new DateTime(2024, 1, 21, 13, 22, 6, 702, DateTimeKind.Local).AddTicks(658), 11, new DateTime(2024, 3, 26, 9, 45, 23, 751, DateTimeKind.Local).AddTicks(300) },
                    { 33, 57, 0.0, new DateTime(2024, 1, 22, 2, 19, 48, 562, DateTimeKind.Local).AddTicks(6790), 11, new DateTime(2024, 4, 16, 5, 1, 14, 694, DateTimeKind.Local).AddTicks(5764) },
                    { 34, 20, 0.0, new DateTime(2024, 1, 31, 1, 46, 56, 442, DateTimeKind.Local).AddTicks(1922), 11, new DateTime(2024, 2, 22, 12, 38, 30, 367, DateTimeKind.Local).AddTicks(5985) },
                    { 35, 69, 0.0, new DateTime(2024, 2, 6, 7, 26, 57, 680, DateTimeKind.Local).AddTicks(4600), 12, new DateTime(2024, 3, 11, 23, 17, 43, 876, DateTimeKind.Local).AddTicks(9351) },
                    { 36, 83, 0.0, new DateTime(2023, 12, 29, 6, 56, 6, 101, DateTimeKind.Local).AddTicks(6893), 12, new DateTime(2024, 2, 6, 17, 25, 1, 498, DateTimeKind.Local).AddTicks(3589) },
                    { 37, 26, 0.0, new DateTime(2024, 3, 18, 2, 25, 56, 704, DateTimeKind.Local).AddTicks(369), 12, new DateTime(2024, 5, 4, 17, 32, 35, 467, DateTimeKind.Local).AddTicks(1110) },
                    { 38, 89, 0.0, new DateTime(2024, 4, 12, 19, 3, 34, 928, DateTimeKind.Local).AddTicks(6130), 13, new DateTime(2024, 1, 20, 17, 41, 39, 937, DateTimeKind.Local).AddTicks(3386) },
                    { 39, 84, 0.0, new DateTime(2024, 1, 27, 7, 13, 11, 850, DateTimeKind.Local).AddTicks(20), 13, new DateTime(2024, 1, 5, 18, 12, 38, 792, DateTimeKind.Local).AddTicks(6600) },
                    { 40, 63, 0.0, new DateTime(2024, 4, 14, 5, 27, 13, 592, DateTimeKind.Local).AddTicks(1510), 13, new DateTime(2023, 11, 17, 5, 19, 16, 403, DateTimeKind.Local).AddTicks(9131) },
                    { 41, 44, 0.0, new DateTime(2023, 11, 26, 13, 2, 26, 177, DateTimeKind.Local).AddTicks(6899), 14, new DateTime(2024, 5, 4, 22, 11, 24, 578, DateTimeKind.Local).AddTicks(7163) },
                    { 42, 95, 0.0, new DateTime(2024, 1, 14, 8, 53, 40, 850, DateTimeKind.Local).AddTicks(3190), 14, new DateTime(2024, 2, 25, 12, 22, 54, 765, DateTimeKind.Local).AddTicks(322) },
                    { 43, 14, 0.0, new DateTime(2024, 2, 29, 18, 2, 56, 485, DateTimeKind.Local).AddTicks(2331), 14, new DateTime(2023, 11, 13, 4, 43, 34, 342, DateTimeKind.Local).AddTicks(9976) },
                    { 44, 98, 0.0, new DateTime(2023, 12, 20, 3, 13, 55, 673, DateTimeKind.Local).AddTicks(6113), 15, new DateTime(2023, 11, 28, 5, 33, 2, 375, DateTimeKind.Local).AddTicks(6485) },
                    { 45, 38, 0.0, new DateTime(2024, 4, 18, 21, 4, 43, 985, DateTimeKind.Local).AddTicks(3702), 15, new DateTime(2023, 11, 20, 22, 20, 40, 52, DateTimeKind.Local).AddTicks(88) },
                    { 46, 70, 0.0, new DateTime(2023, 12, 25, 11, 34, 12, 17, DateTimeKind.Local).AddTicks(4281), 15, new DateTime(2024, 4, 2, 0, 18, 47, 595, DateTimeKind.Local).AddTicks(9446) },
                    { 47, 28, 0.0, new DateTime(2024, 4, 10, 13, 51, 15, 35, DateTimeKind.Local).AddTicks(3829), 16, new DateTime(2024, 3, 26, 5, 20, 57, 91, DateTimeKind.Local).AddTicks(2205) },
                    { 48, 27, 0.0, new DateTime(2024, 1, 23, 23, 17, 38, 889, DateTimeKind.Local).AddTicks(2484), 16, new DateTime(2023, 11, 23, 20, 34, 31, 165, DateTimeKind.Local).AddTicks(9425) },
                    { 49, 89, 5.501281242417047, new DateTime(2024, 2, 29, 14, 34, 51, 140, DateTimeKind.Local).AddTicks(3922), 16, new DateTime(2024, 4, 25, 6, 55, 25, 933, DateTimeKind.Local).AddTicks(1085) },
                    { 50, 75, 0.0, new DateTime(2024, 1, 25, 16, 44, 44, 551, DateTimeKind.Local).AddTicks(5893), 17, new DateTime(2024, 1, 15, 4, 13, 5, 806, DateTimeKind.Local).AddTicks(9127) },
                    { 51, 11, 0.0, new DateTime(2024, 1, 1, 20, 39, 24, 879, DateTimeKind.Local).AddTicks(3296), 17, new DateTime(2024, 3, 9, 9, 2, 57, 786, DateTimeKind.Local).AddTicks(8473) },
                    { 52, 79, 0.0, new DateTime(2024, 1, 30, 21, 37, 49, 601, DateTimeKind.Local).AddTicks(1518), 17, new DateTime(2024, 3, 23, 5, 38, 5, 680, DateTimeKind.Local).AddTicks(2263) },
                    { 53, 7, 0.41449252196420483, new DateTime(2024, 5, 12, 3, 43, 33, 833, DateTimeKind.Local).AddTicks(9266), 18, new DateTime(2024, 3, 27, 9, 19, 12, 736, DateTimeKind.Local).AddTicks(7162) },
                    { 54, 56, 0.0, new DateTime(2024, 4, 27, 16, 23, 1, 68, DateTimeKind.Local).AddTicks(9935), 18, new DateTime(2024, 1, 31, 14, 3, 36, 589, DateTimeKind.Local).AddTicks(930) },
                    { 55, 35, 0.0, new DateTime(2023, 12, 4, 22, 50, 7, 40, DateTimeKind.Local).AddTicks(4728), 18, new DateTime(2023, 12, 8, 15, 22, 49, 686, DateTimeKind.Local).AddTicks(4228) },
                    { 56, 88, 0.0, new DateTime(2023, 12, 16, 16, 33, 21, 935, DateTimeKind.Local).AddTicks(7490), 19, new DateTime(2024, 2, 17, 2, 58, 39, 224, DateTimeKind.Local).AddTicks(8040) },
                    { 57, 96, 0.0, new DateTime(2024, 3, 12, 6, 10, 2, 859, DateTimeKind.Local).AddTicks(3783), 19, new DateTime(2023, 12, 27, 17, 39, 23, 640, DateTimeKind.Local).AddTicks(8283) },
                    { 58, 59, 0.0, new DateTime(2024, 1, 8, 12, 8, 17, 140, DateTimeKind.Local).AddTicks(589), 19, new DateTime(2023, 12, 24, 2, 8, 41, 583, DateTimeKind.Local).AddTicks(2624) },
                    { 59, 94, 0.0, new DateTime(2023, 12, 27, 6, 49, 18, 998, DateTimeKind.Local).AddTicks(2006), 20, new DateTime(2024, 1, 19, 10, 37, 34, 600, DateTimeKind.Local).AddTicks(4225) },
                    { 60, 6, 0.0, new DateTime(2024, 2, 22, 19, 32, 27, 740, DateTimeKind.Local).AddTicks(9127), 20, new DateTime(2024, 4, 17, 6, 32, 7, 443, DateTimeKind.Local).AddTicks(3261) },
                    { 61, 91, 0.0, new DateTime(2024, 3, 28, 23, 19, 12, 86, DateTimeKind.Local).AddTicks(5579), 20, new DateTime(2023, 11, 30, 11, 19, 41, 870, DateTimeKind.Local).AddTicks(5755) },
                    { 62, 21, 0.0, new DateTime(2024, 4, 28, 5, 32, 21, 922, DateTimeKind.Local).AddTicks(9632), 21, new DateTime(2024, 2, 7, 19, 56, 11, 421, DateTimeKind.Local).AddTicks(3912) },
                    { 63, 91, 0.0, new DateTime(2024, 1, 9, 19, 15, 55, 961, DateTimeKind.Local).AddTicks(9153), 21, new DateTime(2023, 12, 31, 11, 3, 14, 854, DateTimeKind.Local).AddTicks(4821) },
                    { 64, 20, 0.0, new DateTime(2024, 3, 30, 9, 2, 59, 216, DateTimeKind.Local).AddTicks(3080), 21, new DateTime(2024, 2, 23, 9, 27, 55, 626, DateTimeKind.Local).AddTicks(7662) },
                    { 65, 49, 0.0, new DateTime(2024, 1, 28, 9, 56, 30, 436, DateTimeKind.Local).AddTicks(989), 22, new DateTime(2023, 12, 13, 6, 27, 19, 978, DateTimeKind.Local).AddTicks(1814) },
                    { 66, 46, 0.0, new DateTime(2023, 12, 31, 19, 28, 49, 0, DateTimeKind.Local).AddTicks(9589), 22, new DateTime(2023, 11, 24, 5, 59, 6, 864, DateTimeKind.Local).AddTicks(7621) },
                    { 67, 87, 0.0, new DateTime(2024, 3, 17, 22, 31, 3, 389, DateTimeKind.Local).AddTicks(523), 22, new DateTime(2023, 11, 21, 19, 50, 49, 818, DateTimeKind.Local).AddTicks(571) },
                    { 68, 23, 4.2363826198031349, new DateTime(2023, 11, 22, 3, 29, 28, 891, DateTimeKind.Local).AddTicks(7442), 23, new DateTime(2024, 3, 3, 15, 27, 35, 180, DateTimeKind.Local).AddTicks(808) },
                    { 69, 81, 0.0, new DateTime(2024, 3, 1, 1, 37, 28, 10, DateTimeKind.Local).AddTicks(1916), 23, new DateTime(2024, 2, 3, 21, 19, 6, 414, DateTimeKind.Local).AddTicks(3433) },
                    { 70, 10, 0.0, new DateTime(2024, 1, 8, 0, 55, 1, 373, DateTimeKind.Local).AddTicks(7725), 23, new DateTime(2024, 1, 31, 9, 9, 17, 174, DateTimeKind.Local).AddTicks(3483) },
                    { 71, 84, 0.0, new DateTime(2024, 4, 15, 21, 16, 6, 269, DateTimeKind.Local).AddTicks(3447), 24, new DateTime(2024, 2, 19, 6, 0, 22, 635, DateTimeKind.Local).AddTicks(5644) },
                    { 72, 11, 0.0, new DateTime(2023, 12, 4, 5, 58, 18, 951, DateTimeKind.Local).AddTicks(2988), 24, new DateTime(2024, 1, 2, 11, 32, 14, 238, DateTimeKind.Local).AddTicks(4267) },
                    { 73, 34, 0.0, new DateTime(2024, 4, 27, 4, 44, 59, 827, DateTimeKind.Local).AddTicks(8632), 24, new DateTime(2024, 1, 17, 11, 2, 25, 412, DateTimeKind.Local).AddTicks(3220) },
                    { 74, 42, 0.0, new DateTime(2024, 4, 23, 9, 12, 33, 177, DateTimeKind.Local).AddTicks(589), 25, new DateTime(2023, 12, 27, 23, 21, 36, 374, DateTimeKind.Local).AddTicks(7190) },
                    { 75, 57, 8.7889648444881985, new DateTime(2024, 4, 26, 11, 38, 12, 315, DateTimeKind.Local).AddTicks(5124), 25, new DateTime(2024, 1, 27, 14, 31, 31, 761, DateTimeKind.Local).AddTicks(2655) },
                    { 76, 33, 0.0, new DateTime(2024, 1, 8, 7, 48, 29, 155, DateTimeKind.Local).AddTicks(7534), 25, new DateTime(2024, 4, 5, 9, 52, 56, 53, DateTimeKind.Local).AddTicks(5420) },
                    { 77, 16, 0.0, new DateTime(2024, 4, 15, 3, 14, 52, 322, DateTimeKind.Local).AddTicks(4822), 26, new DateTime(2024, 4, 29, 5, 10, 41, 297, DateTimeKind.Local).AddTicks(1580) },
                    { 78, 62, 5.5388763899237192, new DateTime(2024, 3, 16, 17, 47, 50, 657, DateTimeKind.Local).AddTicks(8), 26, new DateTime(2024, 4, 16, 10, 2, 16, 142, DateTimeKind.Local).AddTicks(9036) },
                    { 79, 35, 0.0, new DateTime(2024, 1, 9, 18, 54, 47, 735, DateTimeKind.Local).AddTicks(930), 26, new DateTime(2024, 4, 16, 20, 31, 28, 856, DateTimeKind.Local).AddTicks(6837) },
                    { 80, 54, 8.8214868863554088, new DateTime(2024, 2, 12, 8, 57, 26, 78, DateTimeKind.Local).AddTicks(1483), 27, new DateTime(2024, 1, 22, 0, 57, 44, 912, DateTimeKind.Local).AddTicks(7170) },
                    { 81, 80, 0.0, new DateTime(2024, 3, 19, 19, 31, 3, 747, DateTimeKind.Local).AddTicks(7821), 27, new DateTime(2023, 12, 14, 0, 27, 48, 35, DateTimeKind.Local).AddTicks(491) },
                    { 82, 5, 0.0, new DateTime(2024, 3, 1, 9, 47, 27, 177, DateTimeKind.Local).AddTicks(7739), 27, new DateTime(2024, 3, 28, 21, 18, 38, 263, DateTimeKind.Local).AddTicks(7802) },
                    { 83, 97, 0.0, new DateTime(2023, 12, 2, 14, 59, 53, 87, DateTimeKind.Local).AddTicks(1625), 28, new DateTime(2024, 2, 6, 14, 10, 1, 611, DateTimeKind.Local).AddTicks(3974) },
                    { 84, 23, 0.0, new DateTime(2023, 12, 29, 4, 8, 12, 330, DateTimeKind.Local).AddTicks(2893), 28, new DateTime(2024, 4, 24, 14, 10, 16, 959, DateTimeKind.Local).AddTicks(5832) },
                    { 85, 68, 2.490103233146753, new DateTime(2024, 3, 20, 17, 42, 6, 603, DateTimeKind.Local).AddTicks(3627), 28, new DateTime(2024, 2, 19, 22, 48, 28, 747, DateTimeKind.Local).AddTicks(8714) },
                    { 86, 80, 0.0, new DateTime(2024, 1, 12, 0, 38, 19, 298, DateTimeKind.Local).AddTicks(8199), 29, new DateTime(2024, 4, 17, 23, 3, 54, 333, DateTimeKind.Local).AddTicks(7676) },
                    { 87, 5, 0.0, new DateTime(2024, 3, 12, 20, 18, 3, 758, DateTimeKind.Local).AddTicks(1897), 29, new DateTime(2024, 3, 13, 4, 52, 24, 142, DateTimeKind.Local).AddTicks(2680) },
                    { 88, 91, 0.0, new DateTime(2024, 3, 28, 6, 3, 15, 667, DateTimeKind.Local).AddTicks(2240), 29, new DateTime(2024, 1, 18, 10, 34, 48, 703, DateTimeKind.Local).AddTicks(8573) },
                    { 89, 75, 0.0, new DateTime(2024, 3, 17, 16, 39, 51, 159, DateTimeKind.Local).AddTicks(3937), 30, new DateTime(2023, 11, 30, 1, 19, 14, 61, DateTimeKind.Local).AddTicks(4555) },
                    { 90, 60, 0.0, new DateTime(2023, 11, 23, 16, 21, 17, 861, DateTimeKind.Local).AddTicks(294), 30, new DateTime(2024, 3, 24, 1, 14, 47, 179, DateTimeKind.Local).AddTicks(8010) },
                    { 91, 73, 0.84114813358133755, new DateTime(2023, 11, 24, 21, 39, 16, 416, DateTimeKind.Local).AddTicks(847), 30, new DateTime(2024, 4, 28, 5, 50, 3, 517, DateTimeKind.Local).AddTicks(95) },
                    { 92, 55, 0.0, new DateTime(2023, 11, 25, 13, 41, 8, 652, DateTimeKind.Local).AddTicks(9889), 31, new DateTime(2024, 4, 29, 12, 43, 9, 957, DateTimeKind.Local).AddTicks(1428) },
                    { 93, 23, 0.0, new DateTime(2024, 4, 9, 17, 4, 3, 737, DateTimeKind.Local).AddTicks(7585), 31, new DateTime(2024, 4, 19, 15, 4, 28, 62, DateTimeKind.Local).AddTicks(7675) },
                    { 94, 10, 2.1089041579438375, new DateTime(2024, 1, 28, 17, 5, 0, 945, DateTimeKind.Local).AddTicks(817), 31, new DateTime(2023, 11, 26, 11, 37, 31, 670, DateTimeKind.Local).AddTicks(9394) },
                    { 95, 16, 0.0, new DateTime(2024, 4, 5, 14, 43, 37, 530, DateTimeKind.Local).AddTicks(8310), 32, new DateTime(2023, 12, 22, 23, 17, 0, 685, DateTimeKind.Local).AddTicks(5082) },
                    { 96, 16, 4.0544500371930621, new DateTime(2024, 1, 4, 5, 19, 50, 549, DateTimeKind.Local).AddTicks(6841), 32, new DateTime(2024, 1, 4, 17, 28, 9, 891, DateTimeKind.Local).AddTicks(5250) },
                    { 97, 53, 0.0, new DateTime(2024, 2, 19, 0, 26, 2, 952, DateTimeKind.Local).AddTicks(5573), 32, new DateTime(2024, 2, 16, 22, 14, 6, 897, DateTimeKind.Local).AddTicks(456) },
                    { 98, 74, 0.0, new DateTime(2024, 3, 18, 19, 33, 8, 71, DateTimeKind.Local).AddTicks(8518), 33, new DateTime(2023, 12, 31, 7, 27, 14, 755, DateTimeKind.Local).AddTicks(7317) },
                    { 99, 91, 0.0, new DateTime(2024, 4, 10, 18, 46, 17, 935, DateTimeKind.Local).AddTicks(2027), 33, new DateTime(2024, 1, 2, 10, 56, 31, 952, DateTimeKind.Local).AddTicks(7963) },
                    { 100, 47, 0.0, new DateTime(2023, 12, 8, 22, 40, 51, 986, DateTimeKind.Local).AddTicks(116), 33, new DateTime(2023, 12, 15, 8, 33, 16, 55, DateTimeKind.Local).AddTicks(1980) },
                    { 101, 60, 2.9334297182873268, new DateTime(2024, 2, 8, 6, 25, 49, 280, DateTimeKind.Local).AddTicks(9214), 34, new DateTime(2024, 5, 9, 16, 42, 36, 693, DateTimeKind.Local).AddTicks(4834) },
                    { 102, 48, 0.0, new DateTime(2023, 11, 18, 4, 21, 53, 46, DateTimeKind.Local).AddTicks(6677), 34, new DateTime(2024, 3, 31, 18, 3, 56, 887, DateTimeKind.Local).AddTicks(8383) },
                    { 103, 99, 0.0, new DateTime(2023, 12, 4, 13, 24, 25, 95, DateTimeKind.Local).AddTicks(4785), 34, new DateTime(2024, 3, 2, 6, 54, 41, 282, DateTimeKind.Local).AddTicks(5866) },
                    { 104, 82, 7.3993836227775294, new DateTime(2024, 1, 3, 15, 12, 13, 327, DateTimeKind.Local).AddTicks(540), 35, new DateTime(2023, 12, 18, 19, 58, 37, 37, DateTimeKind.Local).AddTicks(9587) },
                    { 105, 69, 8.5498393077172157, new DateTime(2024, 2, 9, 22, 26, 46, 131, DateTimeKind.Local).AddTicks(6796), 35, new DateTime(2024, 4, 15, 18, 19, 55, 349, DateTimeKind.Local).AddTicks(4355) },
                    { 106, 77, 0.0, new DateTime(2024, 1, 2, 23, 22, 15, 159, DateTimeKind.Local).AddTicks(5206), 35, new DateTime(2024, 1, 21, 13, 31, 49, 348, DateTimeKind.Local).AddTicks(3934) },
                    { 107, 70, 0.0, new DateTime(2024, 1, 11, 14, 47, 16, 205, DateTimeKind.Local).AddTicks(8226), 36, new DateTime(2024, 2, 12, 16, 19, 20, 359, DateTimeKind.Local).AddTicks(8568) },
                    { 108, 47, 0.0, new DateTime(2024, 4, 25, 12, 1, 14, 93, DateTimeKind.Local).AddTicks(6661), 36, new DateTime(2024, 2, 24, 22, 36, 16, 793, DateTimeKind.Local).AddTicks(4133) },
                    { 109, 13, 0.0, new DateTime(2023, 11, 20, 1, 22, 33, 905, DateTimeKind.Local).AddTicks(5942), 36, new DateTime(2024, 4, 7, 11, 3, 28, 418, DateTimeKind.Local).AddTicks(2033) },
                    { 110, 82, 0.0, new DateTime(2023, 12, 24, 16, 52, 0, 722, DateTimeKind.Local).AddTicks(668), 37, new DateTime(2023, 11, 13, 19, 37, 42, 736, DateTimeKind.Local).AddTicks(7925) },
                    { 111, 93, 0.0, new DateTime(2023, 12, 24, 19, 44, 21, 58, DateTimeKind.Local).AddTicks(6663), 37, new DateTime(2023, 12, 14, 12, 55, 39, 334, DateTimeKind.Local).AddTicks(9457) },
                    { 112, 90, 0.0, new DateTime(2024, 1, 7, 18, 59, 49, 711, DateTimeKind.Local).AddTicks(7483), 37, new DateTime(2024, 2, 22, 18, 41, 10, 412, DateTimeKind.Local).AddTicks(6705) },
                    { 113, 76, 0.0, new DateTime(2024, 1, 13, 7, 3, 35, 110, DateTimeKind.Local).AddTicks(3308), 38, new DateTime(2024, 1, 12, 19, 2, 45, 586, DateTimeKind.Local).AddTicks(3178) },
                    { 114, 76, 0.0, new DateTime(2024, 2, 10, 2, 56, 12, 726, DateTimeKind.Local).AddTicks(5590), 38, new DateTime(2023, 12, 28, 15, 8, 57, 106, DateTimeKind.Local).AddTicks(5417) },
                    { 115, 73, 0.0, new DateTime(2023, 11, 22, 11, 32, 54, 337, DateTimeKind.Local).AddTicks(9613), 38, new DateTime(2023, 12, 1, 0, 51, 12, 114, DateTimeKind.Local).AddTicks(3309) },
                    { 116, 27, 0.0, new DateTime(2023, 12, 21, 12, 45, 38, 579, DateTimeKind.Local).AddTicks(274), 39, new DateTime(2023, 12, 6, 0, 55, 59, 214, DateTimeKind.Local).AddTicks(8941) },
                    { 117, 76, 0.0, new DateTime(2024, 3, 11, 4, 52, 44, 543, DateTimeKind.Local).AddTicks(5631), 39, new DateTime(2024, 2, 24, 2, 52, 41, 66, DateTimeKind.Local).AddTicks(3571) },
                    { 118, 50, 0.0, new DateTime(2024, 4, 8, 16, 6, 46, 456, DateTimeKind.Local).AddTicks(8957), 39, new DateTime(2024, 5, 5, 6, 28, 56, 54, DateTimeKind.Local).AddTicks(5378) },
                    { 119, 73, 0.0, new DateTime(2024, 5, 5, 7, 26, 5, 314, DateTimeKind.Local).AddTicks(9688), 40, new DateTime(2024, 3, 18, 12, 19, 1, 917, DateTimeKind.Local).AddTicks(7909) },
                    { 120, 56, 0.77895450398401511, new DateTime(2024, 3, 18, 21, 10, 19, 192, DateTimeKind.Local).AddTicks(1744), 40, new DateTime(2023, 11, 16, 4, 46, 59, 806, DateTimeKind.Local).AddTicks(7802) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

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
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

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
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 61);

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
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 78);

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
                keyValue: 16);

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
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

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
                keyValue: 44);

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
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 63);

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
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71);

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
                keyValue: 79);

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
                keyValue: 85);

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
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 95);

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
        }
    }
}
