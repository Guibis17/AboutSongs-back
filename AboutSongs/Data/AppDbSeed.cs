using AboutSongs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AboutSongs.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Albuns
        List<Album> albuns = new()
        {
            new Album() {
                Id = 1,
                Título = "We Don't Trust You",
                Foto = "/img/Albuns/1.png",
                DataDeLancamento = DateTime.Parse ("22/03/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 2,
                Título = "HIT ME HARD AND SOFT",
                Foto = "/img/Albuns/2.jpg",
                DataDeLancamento = DateTime.Parse ("17/05/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 3,
                Título = "Short n'Sweet",
                Foto = "img/Albuns/3.png",
                DataDeLancamento = DateTime.Parse ("23/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 4,
                Título = "American Dream",
                Foto = "/img/Albuns/4.jpg",
                DataDeLancamento = DateTime.Parse ("12/01/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 5,
                Título = "Utopia",
                Foto = "/img/Albuns/5.png",
                DataDeLancamento = DateTime.Parse ("28/07/2023"),
            },
            new Album() {
                Id = 6,
                Título = "333",
                Foto = "/img/Albuns/6.jpg",
                DataDeLancamento = DateTime.Parse ("09/09/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 7,
                Título = "Vagabundo de Luxo",
                Foto = "img/Albuns/7.png",
                DataDeLancamento = DateTime.Parse ("10/07/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 8,
                Título = "Brat",
                Foto = "/img/Albuns/8.jpg",
                DataDeLancamento = DateTime.Parse ("07/06/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 9,
                Título = "Not Like Us",
                Foto = "/img/Albuns/9.png",
                DataDeLancamento = DateTime.Parse ("04/05/2024"),
            },
            new Album() {
                Id = 10,
                Título = "Die With A Smile",
                Foto = "/img/Albuns/10.jpeg",
                DataDeLancamento = DateTime.Parse ("16/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 11,
                Título = "WOKE UP",
                Foto = "/img/Albuns/11.png",
                DataDeLancamento = DateTime.Parse ("21/05/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 12,
                Título = "Family Matters",
                Foto = "/img/Albuns/12.png",
                DataDeLancamento = DateTime.Parse ("03/05/2024"),
            },
            
        };
        builder.Entity<Album>().HasData(albuns);
        #endregion

        #region Populate Musica 
        List<Musica> musicas = new(){
            new Musica() {
                Id = 1,
                Título = "We Don’t Trust You ",
                Compositores = "Barrett Strong, Christopher Townsend, Dwayne Richardson, Leland Wayne, Mejdi Rhars, Nayvadius Wilburn, Norman Whitfield e Paul Fishman",
                Duracao = TimeSpan.Parse ("3:46")
            },
            new Musica() {
                Id = 2,
                Título = "Young Metro",
                Compositores = "Abel Tesfaye, Eren Yüksel, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:25")
            },
            new Musica() {
                Id = 3,
                Título = "Ice Attack",
                Compositores = "Darnell Carlton, Jordan Houston, Leland Wayne, Nayvadius Wilburn, Nik Frascona, Paul Beauregard e Ricky Dunigan",
                Duracao = TimeSpan.Parse ("3:19")
            },
            new Musica() {
                Id = 4,
                Título = "Type Shit",
                Compositores = "Joe Cooley,Kendrick Lamar Duckworth, Kobe Hood, Leland Wayne, Nayvadius Wilburn e Rodney Oliver",
                Duracao = TimeSpan.Parse ("3:48")
            },
            new Musica() {
                Id = 5,
                Título = "Claustrophobic",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:42")
            },
            new Musica() {
                Id = 6,
                Título = "Like That",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:27")
            },
            new Musica() {
                Id = 7,
                Título = "Slimed In",
                Compositores = "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen",
                Duracao = TimeSpan.Parse ("3:14")
            },
            new Musica() {
                Id = 8,
                Título = "Magic Don Juan (Princess Diana)",
                Compositores = "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen",
                Duracao = TimeSpan.Parse ("3:40")
            },
            new Musica() {
                Id = 9,
                Título = "Cinderella",
                Compositores = "Allen Ritter, Andre Proctor, Ethan Stevens, Jacques Webster, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:49")
            },
            new Musica() {
                Id = 10,
                Título = "Runnin Outta Time",
                Compositores = "Bobby Raps, Leland Wayne, Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:25")
            },
            new Musica() {
                Id = 11,
                Título = "Fried (She a Vibe)",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:30")
            },
            new Musica() {
                Id = 12,
                Título = "Ain’t No Love",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 13,
                Título = "Everyday Hustle",
                Compositores = "Alfreda Brockington, Leland Wayne, Nayvadius Wilburn e William Leonard Roberts II",
                Duracao = TimeSpan.Parse ("3:46")
            },
            new Musica() {
                Id = 14,
                Título = "GTA",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("3:53")
            },
            new Musica() {
                Id = 15,
                Título = "Seen it All",
                Compositores = "Allen Ritter, Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:59")
            },
            new Musica() {
                Id = 16,
                Título = "WTFYM",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("4:52")
            },
            new Musica() {
                Id = 17,
                Título = "Where My Twin @ - Bonus",
                Compositores = "Leland Wayne e Nayvadius Wilburn",
                Duracao = TimeSpan.Parse ("2:02")
            },
            new Musica() {
                Id = 18,
                Título = "SKINNY",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("3:39")
            },
            new Musica() {
                Id = 19,
                Título = "LUNCH",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("2:59")
            },
            new Musica() {
                Id = 20,
                Título = "CHIHIRO",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("5:03")
            },
            new Musica() {
                Id = 21,
                Título = "BIRDS OF A FEATHER ",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("3:30")
            },
            new Musica() {
                Id = 22,
                Título = "WILDFLOWER",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:21")
            },
            new Musica() {
                Id = 23,
                Título = "THE GREATEST ",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:53")
            },
            new Musica() {
                Id = 24,
                Título = "L’AMOUR DE MA VIE ",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("5:33")
            },
            new Musica() {
                Id = 25,
                Título = "THE DINER",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("3:06")
            },
            new Musica() {
                Id = 26,
                Título = "BITTERSUITE",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:58")
            },
            new Musica() {
                Id = 27,
                Título = "BLUE",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("5:43")
            },
            new Musica() {
                Id = 28,
                Título = "Die With A Smile",
                Foto = "",
                Compositores = "Andrew Watt,Bruno Mars, Dernst Emile IIJames Faunt, leroy e Lady Gaga",
                Duracao = TimeSpan.Parse ("4:11")
            },
            new Musica() {
                Id = 29,
                Título = "Taste",
                Compositores = "Amy Allen, Ian Kirkpatrick, John Ryan, Julia Michaels e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:37")
            },
            new Musica() {
                Id = 30,
                Título = "Please Please Please",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:06")
            },
            new Musica() {
                Id = 31,
                Título = "Good Graces",
                Compositores = "Amy Allen, Julia Michaels, John Ryan, Julian Bunetta e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:05")
            },
            new Musica() {
                Id = 32,
                Título = "Sharpest Tool",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:38")
            },
            new Musica() {
                Id = 33,
                Título = "Coincidence",
                Compositores = "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:44")
            },
            new Musica() {
                Id = 34,
                Título = "Bed Chem",
                Compositores = "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:51")
            },
            new Musica() {
                Id = 35,
                Título = "Espresso",
                Compositores = "Amy Allen, Julian Bunetta, Steph Jones e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:55")
            },
            new Musica() {
                Id = 36,
                Título = "Dumb & Poetic",
                Compositores = "Amy Allen, John Ryan, Julia Michaels e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:13")
            },
            new Musica() {
                Id = 37,
                Título = "Slim Pickins",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("2:32")
            },
            new Musica() {
                Id = 38,
                Título = "Juno",
                Compositores = "Amy Allen, John Ryan e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("4:11")
            },
            new Musica() {
                Id = 39,
                Título = "Lie To Girls",
                Compositores = "Amy Allen, Jack Antonoff e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:22")
            },
            new Musica() {
                Id = 40,
                Título = "Don't Smile",
                Compositores = "Amy Allen, John Ryan, Julian Bunetta e Sabrina Carpenter",
                Duracao = TimeSpan.Parse ("3:26")
            },
            new Musica() {
                Id = 41,
                Título = "american dream",
                Compositores = "BK Rube, Isaiah Brown, James Owens, Sterling White",
                Duracao = TimeSpan.Parse ("1:03")
            },
            new Musica() {
                Id = 42,
                Título = "all of me",
                Compositores = "Billie Rae Calvin, Isaiah Brown, Jalen Jackson, Jared Brown, Khaya Gilika, Raphael Oliveira, Shéyaa Bin Abraham-Joseph, Sterling White Jr. e Yakki Davis",
                Duracao = TimeSpan.Parse ("3:18")
            },
            new Musica() {
                Id = 43,
                Título = "redrum",
                Compositores = "London Tyler Holmes, Mateen Kyle Niknam, Shéyaa Bin Abraham-Joseph e Vinícius de Moraes",
                Duracao = TimeSpan.Parse ("4:30")
            },
            new Musica() {
                Id = 44,
                Título = "n.h.i.e",
                Compositores = "Anthony Paul Jefferies, Amala Dlamini, Douglas Ford, Jonah Stevens, Kurtis McKenzie, Michael Orabiyi e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("2:23")
            },
            new Musica() {
                Id = 45,
                Título = "sneakey",
                Compositores = "Edward Maclin Cooper III e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:21")
            },
            new Musica() {
                Id = 46,
                Título = "Family Matters",
                Compositores = "A. Graham",
                Duracao = TimeSpan.Parse ("7:36")
            },
            new Musica() {
                Id = 47,
                Título = "pop ur shit",
                Compositores = "Allen Ritter, Jeffery Lamar Williams, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:13")
            },
            new Musica() {
                Id = 48,
                Título = "letter to my brudda",
                Compositores = "Kavi Lybarger, Paola Barba, Park Min Geon, Shéyaa Bin Abraham-Joseph, Tchakalla Anthony Romeo, Tyrese McGriff e William Boyette",
                Duracao = TimeSpan.Parse ("2:39")
            },
            new Musica() {
                Id = 49,
                Título = "dangerous",
                Compositores = "Durk Banks, Jahmal Gwin, Jahshua Brown, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("4:25")
            },
            new Musica() {
                Id = 50,
                Título = "née-nah",
                Compositores = "Douglas Ford, Jacques Webster, Leland Tyler Wayne, Malcolm McLaren, Rodney Argent, Shéyaa Bin Abraham-Joseph e William Handy",
                Duracao = TimeSpan.Parse ("3:40")
            },
            new Musica() {
                Id = 51,
                Título = "see the real",
                Compositores = "Dylan Cleary-Krell, Joshua Parker, Jason Cornet, Jocelyn Donald, Jordan Holt-May, Samuel David Jimenez e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 52,
                Título = "prove it",
                Compositores = "Carl Thompson, Edward Maclin Cooper III, Faith Evans, Isaiah Brown, James Owens,Keith Thomas, Shéyaa Bin Abraham-Joseph, Summer Walker, Tauren kngs Stovall e Tye Beats",
                Duracao = TimeSpan.Parse ("3:27")
            },
            new Musica() {
                Id = 53,
                Título = "should've wore a bonnet",
                Compositores = "Ronald LaTour, Christopher Wood, Darryl Pearson, Daveon Jackson, David Patino, Donald Earle De Grate Jr Francis Esteban, Joel Hailey, John Julian e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:06")
            },
            new Musica() {
                Id = 54,
                Título = "just like me",
                Compositores = "Isaac De Boni, Michael Mule, Akeel Henry, Damini Ebunoluwa Ogulu, Jahmal Gwin, Jordon Manswell, Kevin Ekofo, Khadijah Lopez, Kira Huszar, Leland Tyler Wayne, Nevon Sinclair e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:51")
            },
            new Musica() {
                Id = 55,
                Título = "red sky",
                Compositores = "4th Pyramid, Carlton Davis Mays, Jr.,Courtney Dwight, John Stephen Sudduth, Shaan Ramaprasad, Shéyaa Bin Abraham-Joseph e Tommy Newport",
                Duracao = TimeSpan.Parse ("2:56")
            },
            new Musica() {
                Id = 56,
                Título = "dark days",
                Compositores = "Ahmar Bailey, Atia Boggs, JONAS LEE, Kavi Lybarger,Mariah Buckles, Paola Madelaine Barba Amado, Shéyaa Bin Abraham-Joseph, Yakki Davis e Yousef Sameh",
                Duracao = TimeSpan.Parse ("4:55")
            },
            new Musica() {
                Id = 57,
                Título = "Not Like Us",
                Compositores = "Kendrick LamarRay Charles e Sean Momberger",
                Duracao = TimeSpan.Parse ("4:34")
            },
            new Musica() {
                Id = 58,
                Título = "HYAENA",
                Compositores = "Mike Dean, Noah Goldstein, Andy Votel, Derek Shulman, Ebony Oshunrinde, Edward Hazel, George Clinton, Jacques Webster, Jahaan Sweet, Kerry Minnear e Ray Shulman",
                Duracao = TimeSpan.Parse ("3:42")
            },
            new Musica() {
                Id = 59,
                Título = "THANK GOD",
                Compositores = "Allen Ritter, Ebony Oshunrinde, Finatik(of FNZ), Zac(of FNZ), Isaac Boni, Jacques Webster, Jahmal Gwin, Mark Mbogo, Micheal Mule, Stormi Webster e Ye",
                Duracao = TimeSpan.Parse ("3:04")
            },
            new Musica() {
                Id = 60,
                Título = "MODERN JAM (feat. Teezo Touchdown)",
                Compositores = "Mike Dean, Aaron Thomas, Guy-Manuel de Homem, Jacques Webster e Jahaan Sweet",
                Duracao = TimeSpan.Parse ("4:15")
            },
            new Musica() {
                Id = 61,
                Título = "MY EYES",
                Compositores = "Josiah Sherman, Wesley Glass,Dua Saleh, Ebony Oshunrinde, Jacques Webster, Joseph Thornalley, Justin Vernon, Phil Cook e Sampha Sisay ",
                Duracao = TimeSpan.Parse ("4:11")
            },
            new Musica() {
                Id = 62,
                Título = "GOD'S COUNTRY",
                Compositores = "Dez Wright, Samuel Gloade, Jacques Webster e Ye ",
                Duracao = TimeSpan.Parse ("2:07")
            },
            new Musica() {
                Id = 63,
                Título = "SIRENS",
                Compositores = "Josiah Sherman, Noah Goldstein, Psymun, Ebony Oshunrinde, Isaac Mpofu, Jacques Webster, Jahaan Sweet, John Fannon, Keith Kawbe e Evan mast",
                Duracao = TimeSpan.Parse ("3:24")
            },
            new Musica() {
                Id = 64,
                Título = "MELTDOWN (feat. Drake)",
                Compositores = "ANDERSON HERNANDEZ, Brytavious Chambers, Coleman, Matthew Samuels, A. Graham, Benjamin Saint Fort e Jacques Webster",
                Duracao = TimeSpan.Parse ("4:06")
            },
            new Musica() {
                Id = 65,
                Título = "FE!N (feat. Playboi Carti)",
                Compositores = "Jahaan Sweet, Jacques Webster, Jordan Carter e Khadimou Fall",
                Duracao = TimeSpan.Parse ("3:11")
            },
            new Musica() {
                Id = 66,
                Título = "DELRESTO (ECHOES) (feat. Beyoncé)",
                Compositores = "Allen Ritter, Chauncey Hollis, MIke Dean, Beyoncé, Jacques Webster, James Blake e Terius Gesteelde-Diamant",
                Duracao = TimeSpan.Parse ("4:34")
            },
            new Musica() {
                Id = 67,
                Título = "I KNOW ?",
                Compositores = "Josiah Sherman, Ozan Yildrim, Scotty Coleman, Jacques Webster, Kobe Hood e Terrance George",
                Duracao = TimeSpan.Parse ("3:31")
            },
            new Musica() {
                Id = 68,
                Título = "TOPIA TWINS (feat. Rob49 & 21 Savage)",
                Compositores = "Dez Wright, Wesley Glass, Cash Esmailian,Douglas Ford, Harry Edwards, Henri Velasco, Jacques Webster, Oliver Rodigan, Robert Thomas e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("3:43")
            },
            new Musica() {
                Id = 69,
                Título = "CIRCUS MAXIMUS (feat. The Weeknd & Swae Lee)",
                Compositores = "Noah Goldstein, Abel Tesfaye, Ebony Oshunrinde, Gary Klebe, Jacques Webster, Jahaan Sweet, Khalif Brown e Mike Dean",
                Duracao = TimeSpan.Parse ("4:18")
            },
            new Musica() {
                Id = 70,
                Título = "PARASAIL (feat. Yung Lean & Dave Chappelle)",
                Compositores = "Buddy Ross, Jahaan Sweet, Noah Goldstein, Anthony Ruiz, Dave Bixby, David Chappelle, Jacques Webster, Jonatan Håsted e Joseph Thornalley",
                Duracao = TimeSpan.Parse ("2:34")
            },
            new Musica() {
                Id = 71,
                Título = "SKITZO (feat. Young Thug)",
                Compositores = "Dylan Teixeira, Matthew Samuels, Scotty Coleman, Sevn Thomas, Blue Miller, Douglas Ford, Ebony Oshunrinde, India Simpson, Jacques Webster, Jahaan Sweet, Jeffrey Williams, Nami Ondas, Nik Dean, Slim Pharoah e Travis Sayles",
                Duracao = TimeSpan.Parse ("6:06")
            },
            new Musica() {
                Id = 72,
                Título = "LOST FOREVER (feat. Westside Gunn)",
                Compositores = "Alan Maman, Alvin Worthy, Dominic Maker, Douglas Ford, Elliott Baker, Jacques Webster e James Litherland",
                Duracao = TimeSpan.Parse ("2:43")
            },
            new Musica() {
                Id = 73,
                Título = "LOOOVE (feat. Kid Cudi)",
                Compositores = "Buddy Ross, Jacques Webster, Pharrell Williams e Scott Mescudi",
                Duracao = TimeSpan.Parse ("3:46")
            },
            new Musica() {
                Id = 74,
                Título = "K-POP (feat. Bad Bunny & The Weeknd)",
                Compositores = "Bigram John Zayas, Carlo Montagnese, Jahaan Sweet, Matthew Samuels, Abel Tesfaye, Benito Antonio Martínez Ocasio, Benjamin Saint Fort e Jacques Webster",
                Duracao = TimeSpan.Parse ("3:05")
            },
            new Musica() {
                Id = 75,
                Título = "TELEKINESIS (feat. SZA & Future)",
                Compositores = "Edgar Nabeyin Pandord, Jacques Webster, Jahaan Sweet, Jahmal Gwin, Nayvadius Wilburn, Nima Jahanbin, Paimon Jahanbin, Solana Rowe, Victory Boyd e Ye",
                Duracao = TimeSpan.Parse ("5:53")
            },
            new Musica() {
                Id = 76,
                Título = "TIL FURTHER NOTICE (feat. James Blake & 21 Savage)",
                Compositores = "Jacques Webster, James Litherland, Leland Wayne e Shéyaa Bin Abraham-Joseph",
                Duracao = TimeSpan.Parse ("5:14")
            },
            new Musica() {
                Id = 77,
                Título = "Crack com Mussilon",
                Compositores = "Citação: Oceano - Djavan, Djavan e Matuê",
                Duracao = TimeSpan.Parse ("2:34")
            },
            new Musica() {
                Id = 78,
                Título = "Imagina esse Cenário",
                Compositores = "Matuê e Veigh",
                Duracao = TimeSpan.Parse ("2:35")
            },

            new Musica() {
                Id = 79,
                Título = "Isso é Sério",
                Compositores = "Brandão85 e Matuê",
                Duracao = TimeSpan.Parse ("4:45")
            },
            new Musica() {
                Id = 80,
                Título = "1993",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("2:07")
            },
            new Musica() {
                Id = 81,
                Título = "4Tal",
                Compositores = "Matuê e Teto",
                Duracao = TimeSpan.Parse ("3:24")
            },
            new Musica() {
                Id = 82,
                Título = "O Som",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("5:12")
            },
            new Musica() {
                Id = 83,
                Título = "04AM",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:19")
            },
            new Musica() {
                Id = 84,
                Título = "Castlevania",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:50")
            },
            new Musica() {
                Id =  85,
                Título = "V de Vilão",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("2:26")
            },
            new Musica() {
                Id = 86,
                Título = "Maria",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:24")
            },
            new Musica() {
                Id = 87,
                Título = "333",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("5:24")
            },
            new Musica() {
                Id = 88,
                Título = "Like This!",
                Compositores = "Matuê",
                Duracao = TimeSpan.Parse ("3:28")
            },
            new Musica() {
                Id = 89,
                Título = "Medo de Quem?",
                Compositores = "msahlholdt, RUXN e WIU",
                Duracao = TimeSpan.Parse ("2:54")
            },
            new Musica() {
                Id = 90,
                Título = "Casa do Tio Wiu",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 91,
                Título = "Rainha da Finesse",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("2:46")
            },
            new Musica() {
                Id = 92,
                Título = "Vidigal",
                Compositores = "BlueFire, WIU e Yako",
                Duracao = TimeSpan.Parse ("3:17")
            },
            new Musica() {
                Id = 93,
                Título = "Amor de 1h",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:28")
            },
            new Musica() {
                Id = 94,
                Título = "Se eu ver sua mãe na rua",
                Compositores = "Saint Blunts e WIU",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 95,
                Título = "desgraçadagostosamaldita",
                Compositores = "Desro, Dragzi, Moras e WIU",
                Duracao = TimeSpan.Parse ("3:00")
            },
            new Musica() {
                Id = 96,
                Título = "Teimosa",
                Compositores = "AK On De Beat, Stoneraider e WIU",
                Duracao = TimeSpan.Parse ("3:03")
            },
            new Musica() {
                Id = 97,
                Título = "Olha oq ce fez comigo",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("3:28")
            },
            new Musica() {
                Id = 98,
                Título = "Guala",
                Compositores = "INQBOI BEATZ e WIU",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 99,
                Título = "Maria do Olho Verde",
                Compositores = "RRareBear e WIU",
                Duracao = TimeSpan.Parse ("3:24")
            },
            new Musica() {
                Id = 100,
                Título = "Eu Não Ouço Mais Trap",
                Compositores = "Cheek, Hulls e WIU",
                Duracao = TimeSpan.Parse ("3:16")
            },
            new Musica() {
                Id = 101,
                Título = "Rolê de Sempre",
                Compositores = "WIU",
                Duracao = TimeSpan.Parse ("5:32")
            },
            new Musica() {
                Id = 102,
                Título = "Euphoria",
                Compositores = "Cardo, Kenneth Gamble, Jordan Houston, Kendrick Lamar, Leon Huff e Paul Beauregard",
                Duracao = TimeSpan.Parse("6:23")
            },
            new Musica() {
                Id = 103,
                Título = "WOKE UP",
                Compositores = "Chancellor´, JAEYOUNG, JAKOPS, LYRICKS e Shintaro Yasuda",
                Duracao = TimeSpan.Parse ("3:08")
            },
            new Musica() {
                Id = 104,
                Título = "MTG QUERO VER SE VOCÊ TEM ATITUDE",
                Foto = "/img/Albuns/104.png",
                Compositores = "Luan Gabriel",
                Duracao = TimeSpan.Parse ("1:57")
            },
            new Musica() {
                Id = 105,
                Título = "PSYCHO",
                Compositores = "Michael Hardy, Tyler Hubbard, Jax e Zach Abend",
                Duracao = TimeSpan.Parse ("3:18")
            },
            new Musica() {
                Id = 106,
                Título = "360",
                Compositores = "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Finn Keane, Henry Walter e Omer Fedi",
                Duracao = TimeSpan.Parse ("2:13")
            },
            new Musica() {
                Id = 107,
                Título = "Club classics",
                Compositores = "A.G.Cook, Charlotte Aitchison e George Daniel",
                Duracao = TimeSpan.Parse ("2:33")
            },
            new Musica() {
                Id = 108,
                Título = "Sympathy is a knife",
                Compositores = "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("2:31")
            },
            new Musica() {
                Id = 109,
                Título = "I might isay something stupid",
                Compositores = "Charlotte Aitchison e Mike Levy",
                Duracao = TimeSpan.Parse ("1:49")
            },
            new Musica() {
                Id = 110,
                Título = "Talk talk",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard",
                Duracao = TimeSpan.Parse ("2:41")
            },
            new Musica() {
                Id = 111,
                Título = "Von dutch",
                Compositores = "Charlotte Aitchison e Finn Keane",
                Duracao = TimeSpan.Parse ("2:44")
            },
            new Musica() {
                Id = 112,
                Título = "Everything is romantic",
                Compositores = "A.G.Cook, Charlotte Aitchison, Jasper Harris, Jae Deal, Marlon Travis Barrow e Pablo Diaz-Reixa",
                Duracao = TimeSpan.Parse ("3:23")
            },
            new Musica() {
                Id = 113,
                Título = "Rewind",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, e Henry Walter",
                Duracao = TimeSpan.Parse ("2:48")
            },
            new Musica() {
                Id = 114,
                Título = "So I",
                Compositores = "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("3:31")
            },
            new Musica() {
                Id = 115,
                Título = "Girl, so confusing",
                Compositores = "Alexander Guy Cook e Charlotte Aitchison",
                Duracao = TimeSpan.Parse ("2:54")
            },
            new Musica() {
                Id = 116,
                Título = "Apple",
                Compositores = "Charlotte Aitchison, Linus Wiklund, Noonie Bao e George",
                Duracao = TimeSpan.Parse ("2:31")
            },
            new Musica() {
                Id = 117,
                Título = "B2b",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, Omer Fedi e Mike Levy",
                Duracao = TimeSpan.Parse ("2:58")
            },
            new Musica() {
                Id = 118,
                Título = "Mean girls",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard",
                Duracao = TimeSpan.Parse ("3:09")
            },
            new Musica() {
                Id = 119,
                Título = "I think about it all the time",
                Compositores = "Alexander Guy Cook, Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave",
                Duracao = TimeSpan.Parse ("2:15")
            },
            new Musica() {
                Id = 120,
                Título = "365",
                Compositores = "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Cirkut, Finn Keane (EasyFun) e Omer Fedi",
                Duracao = TimeSpan.Parse ("3:23")
            },
            new Musica() {
                Id = 121,
                Título = "The Emptiness Machine",
                Compositores = "Linkin Park",
                Duracao = TimeSpan.Parse ("3:10")
            },

        };
        builder.Entity<Musica>().HasData(musicas);
        #endregion

        #region Populate Artista
        List<Artista> artistas = new(){
            new Artista() {
                Id = 1,
                Nome = "Future,Metro Boomin"
            },
            new Artista() {
                Id = 2,
                Nome = "Billie Eilish"
            },
            new Artista() {
                Id = 3,
                Nome = "Lady Gaga, Bruno Mars"
            },
            new Artista() {
                Id = 4,
                Nome = "Sabrina Carpenter"
            },
            new Artista() {
                Id = 5,
                Nome = "21 Savage"
            },
            new Artista() {
                Id = 6,
                Nome = "Travis Scott"
            },
            new Artista() {
                Id = 7,
                Nome = "Kendrick Lamar"
            },
            new Artista() {
                Id = 8,
                Nome = "Matuê"
            },
            new Artista() {
                Id = 9,
                Nome = "Wiu"
            },
            new Artista() {
                Id = 10,
                Nome = "XG"
            },
            new Artista() {
                Id = 11,
                Nome = "HARDY"
            },
            new Artista() {
                Id = 12,
                Nome = "Linkin Park"
            },
            new Artista() {
                Id = 13,
                Nome = "Charli XCX "
            },
            new Artista() {
                Id = 14,
                Nome = "Dj Luan Gomes"
            },
        };
        builder.Entity<Artista>().HasData(artistas);
        #endregion

        #region Populate Generos
        List<Genero> generos = new() {
            new Genero() {
                Id = 1,
                Nome = "Pop"
            },
            new Genero() {
                Id = 2,
                Nome = "Rap/Hip-Hop"
            },
            new Genero() {
                Id = 3,
                Nome = "Rock"
            },
            new Genero() {
                Id = 4,
                Nome = "Funk"
            },
            new Genero() {
                Id = 5,
                Nome = "Eletrônica"
            },

        };
        builder.Entity<Genero>().HasData(generos);
        #endregion 

        #region Populate MusicaGenero
        List<MusicaGenero> musicaGeneros = new(){
            new MusicaGenero() {
                MusicaId = 1,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 2,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 3,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 4,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 5,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 6,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 7,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 8,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 9,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 10,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 11,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 12,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 13,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 14,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 15,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 16,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 17,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 18,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 19,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 20,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 21,
                GeneroId = 3,
            },
            new MusicaGenero() {
                MusicaId = 22,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 23,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 24,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 25,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 26,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 27,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 28,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 29,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 30,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 31,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 32,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 33,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 34,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 35,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 36,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 37,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 38,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 39,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 40,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 41,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 42,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 43,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 44,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 45,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 46,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 47,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 48,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 49,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 50,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 51,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 52,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 53,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 54,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 55,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 56,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 57,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 58,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 59,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 60,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 61,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 62,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 63,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 64,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 65,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 67,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 68,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 69,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 68,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 70,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 71,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 72,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 73,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 74,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 75,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 76,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 77,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 78,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 79,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 80,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 81,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 82,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 83,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 84,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 85,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 86,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 87,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 88,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 89,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 90,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 91,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 92,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 93,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 94,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 95,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 96,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 97,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 98,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 99,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 100,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 101,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 102,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 103,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 104,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 105,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 106,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 107,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 108,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 109,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 110,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 111,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 112,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 113,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 114,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 115,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 116,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 117,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 118,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 119,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 120,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 121,
                GeneroId = 3,
            },
        };
        builder.Entity<MusicaGenero>().HasData(musicaGeneros);
        #endregion


        #region Populate AlbumArtista
        List<AlbumArtista> albumArtistas = new() {
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 1,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 2,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 3,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 4,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 5,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 6,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 7,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 8,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 9,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 10,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 11,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 12,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 13,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 14,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 15,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 16,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 17,
            },
            new AlbumArtista() {
                AlbumId = 1,
                ArtistaId = 1,
                MusicaId = 18,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 19,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 20,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 21,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 22,
            },
            new AlbumArtista() {
                AlbumId = 2,
                ArtistaId = 2,
                MusicaId = 23,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 24,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 25,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 26,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 27,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 28,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 29,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 30,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 31,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 32,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 33,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 34,
            },
            new AlbumArtista() {
                AlbumId = 3,
                ArtistaId = 4,
                MusicaId = 35,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 36,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 36,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 37,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 38,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 39,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 4,
                MusicaId = 40,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 41,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 42,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 43,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 44,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 45,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 46,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 47,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 48,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 49,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 50,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 51,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 52,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 53,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 54,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 55,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 56,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 57,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 58,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 59,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 60,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 61,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 62,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 63,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 64,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 65,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 66,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 67,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 68,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 69,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 70,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 71,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 72,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 73,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 74,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 75,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 76,
            },
            new AlbumArtista() {
                AlbumId = 4,
                ArtistaId = 5,
                MusicaId = 77,
            },
            new AlbumArtista() {
                AlbumId = 5,
                ArtistaId = 5,
                MusicaId = 78,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 79,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 80,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 81,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 82,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 83,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 84,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 85,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 86,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 87,
            },
            new AlbumArtista() {
                AlbumId = 6,
                ArtistaId = 8,
                MusicaId = 88,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 89,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 90,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 91,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 92,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 93,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 93,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 94,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 95,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 96,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 97,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 98,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 99,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 100,
            },
            new AlbumArtista() {
                AlbumId = 7,
                ArtistaId = 9,
                MusicaId = 101,
            },
            new AlbumArtista() {
                ArtistaId = 7,
                MusicaId = 102,
            },
            new AlbumArtista() {
                ArtistaId = 10,
                MusicaId = 103,
            },
            new AlbumArtista() {
                ArtistaId = 14,
                MusicaId = 104,
            },
            new AlbumArtista() {
                ArtistaId = 11,
                MusicaId = 105,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 106,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 107,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 108,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 109,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 110,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 111,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 112,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 113,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 114,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 115,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 116,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 117,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 118,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 119,
            },
            new AlbumArtista() {
                AlbumId = 8,
                ArtistaId = 13,
                MusicaId = 120,
            },
            new AlbumArtista() {
                ArtistaId = 12,
                MusicaId = 121,
            },
        };
        builder.Entity<AlbumArtista>().HasData(albumArtistas);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Moderador",
               NormalizedName = "MODERADOR"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new() {
            new IdentityUser(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "admin@aboutsongs.com",
                NormalizedEmail = "ADMIN@ABOUTSONGS.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "zecapagodinho3");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Guilherme Bispo da Silva",
                Foto = ""
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion



    }
}