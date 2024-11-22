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
                Titulo = "We Don't Trust You",
                Foto = "/img/Albuns/1.png",
                DataDeLancamento = DateTime.Parse ("22/03/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 2,
                Titulo = "HIT ME HARD AND SOFT",
                Foto = "/img/Albuns/2.jpg",
                DataDeLancamento = DateTime.Parse ("17/05/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 3,
                Titulo = "Short n'Sweet",
                Foto = "img/Albuns/3.png",
                DataDeLancamento = DateTime.Parse ("23/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 4,
                Titulo = "American Dream",
                Foto = "/img/Albuns/4.jpg",
                DataDeLancamento = DateTime.Parse ("12/01/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 5,
                Titulo = "Utopia",
                Foto = "/img/Albuns/5.png",
                DataDeLancamento = DateTime.Parse ("28/07/2023"),
            },
            new Album() {
                Id = 6,
                Titulo = "333",
                Foto = "/img/Albuns/6.jpg",
                DataDeLancamento = DateTime.Parse ("09/09/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 7,
                Titulo = "Vagabundo de Luxo",
                Foto = "img/Albuns/7.png",
                DataDeLancamento = DateTime.Parse ("10/07/2024"),
            },
            new Album() {
                Id = 8,
                Titulo = "Brat",
                Foto = "/img/Albuns/8.jpg",
                DataDeLancamento = DateTime.Parse ("07/06/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 9,
                Titulo = "Not Like Us",
                Foto = "/img/Albuns/9.png",
                DataDeLancamento = DateTime.Parse ("04/05/2024"),
            },
            new Album() {
                Id = 10,
                Titulo = "Die With A Smile",
                Foto = "/img/Albuns/10.jpeg",
                DataDeLancamento = DateTime.Parse ("16/08/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 11,
                Titulo = "WOKE UP",
                Foto = "/img/Albuns/11.png",
                DataDeLancamento = DateTime.Parse ("21/05/2024"),
            },
            new Album() {
                Id = 12,
                Titulo = "Family Matters",
                Foto = "/img/Albuns/12.png",
                DataDeLancamento = DateTime.Parse ("03/05/2024"),
            },
            new Album() {
                Id = 13,
                Titulo = "MTG QUERO VER SE VOCÊ TEM ATITUDE",
                Foto = "/img/Albuns/13.png",
                DataDeLancamento = DateTime.Parse ("02/07/2024"),
            },
            new Album() {
                Id = 14,
                Titulo = "Euphoria",
                Foto = "/img/Albuns/14.png",
                DataDeLancamento = DateTime.Parse ("30/04/2024"),
            },
            new Album() {
                Id = 15,
                Titulo = "Timeless (with Playboi Carti)",
                Foto = "/img/Albuns/15.png",
                DataDeLancamento = DateTime.Parse ("27/09/2024"),
            },
            new Album() {
                Id = 16,
                Titulo = "MILLION DOLLAR BABY",
                Foto = "/img/Albuns/16.png",
                DataDeLancamento = DateTime.Parse ("26/04/2024"),
            },
            new Album() {
                Id = 17,
                Titulo = "Feelslikeimfallinginlove",
                Foto = "/img/Albuns/17.png",
                DataDeLancamento = DateTime.Parse ("21/06/2024"),
            },
            new Album() {
                Id = 18,
                Titulo = "Eternal Sunshine",
                Foto = "/img/Albuns/18.png",
                DataDeLancamento = DateTime.Parse ("08/03/2024"),
            },
            new Album() {
                Id = 19,
                Titulo = "Vultures 1",
                Foto = "/img/Albuns/19.png",
                DataDeLancamento = DateTime.Parse ("09/02/2024"),
            },
            new Album() {
                Id = 20,
                Titulo = "THE BOX MEDLEY FUNK 2",
                Foto = "/img/Albuns/20.png",
                DataDeLancamento = DateTime.Parse ("18/04/2024"),
            },
            new Album() {
                Id = 21,
                Titulo = "2093",
                Foto = "/img/Albuns/21.png",
                DataDeLancamento = DateTime.Parse ("16/02/2024"),
            },
            new Album() {
                Id = 22,
                Titulo = "Chromakopia",
                Foto = "/img/Albuns/22.png",
                DataDeLancamento = DateTime.Parse ("28/10/2024"),
                ExibirHome = true
            },
            new Album() {
                Id = 23,
                Titulo = "Barbie",
                Foto = "/img/Albuns/23.png",
                DataDeLancamento = DateTime.Parse ("18/10/2024"),
            },
            new Album() {
                Id = 24,
                Titulo = "APT.",
                Foto = "/img/Albuns/24.png",
                DataDeLancamento = DateTime.Parse ("18/10/2024"),
            },
            new Album() {
                Id = 25,
                Titulo = "Nada Como um Dia Após o Outro Dia, Vol. 1 & 2",
                Foto = "/img/Albuns/25.png",
                DataDeLancamento = DateTime.Parse ("07/10/2007"),
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
                Compositores = "Luan Gabriel",
                Duracao = TimeSpan.Parse ("1:57")
            },
            new Musica() {
                Id = 105,
                Título = "Timeless (with Playboi Carti)",
                Compositores = "Abel Tesfaye, Blessed, Devon Chisolm (Lawson), Jarrod Morgan, Jordan Terrell Carter, Kobe Hood, Mark Williams (Oji), MIKE DEAN, Pharrell Williams, Raul Cubina (Volta) e Tariq Sharrieff",
                Duracao = TimeSpan.Parse ("4:16")
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
            new Musica() {
                Id = 122,
                Título = "MILLION DOLLAR BABY",
                Compositores = "Ava La'RaeTommy Richman",
                Duracao = TimeSpan.Parse ("2:35")
            },
            new Musica() {
                Id = 123,
                Título = "Feelslikeimfallinginlove",
                Compositores = "Max Martin, Apple Martin, Chris Martin, Guy Berryman, Jon Hopkins, Jonny Buckland, Oscar Holter, Tim Rutili e Will Champion",
                Duracao = TimeSpan.Parse ("3:57")
            },
            new Musica() {
                Id = 124,
                Título = "Intro (end of the world)",
                Compositores = "Ariana Grande, Nick Lee, Shintaro Yasuda e Aaron Cheung",
                Duracao = TimeSpan.Parse ("1:32")
            },
            new Musica() {
                Id = 125,
                Título = "bye",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("2:44")
            },
            new Musica() {
                Id = 126,
                Título = "don't wanna break up again",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("2:54")
            },
            new Musica() {
                Id = 127,
                Título = "Saturn Returns Interlude",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("0:42")
            },
            new Musica() {
                Id = 128,
                Título = "eternal sunshine",
                Compositores = "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior",
                Duracao = TimeSpan.Parse ("3:30")
            },
            new Musica() {
                Id = 129,
                Título = "supernatural",
                Compositores = "Ariana Grande, Max Martin e Oscar Görres",
                Duracao = TimeSpan.Parse ("2:43")
            },
            new Musica() {
                Id = 130,
                Título = "true story",
                Compositores = "Ariana Grande e Max Martin",
                Duracao = TimeSpan.Parse ("2:43")
            },
            new Musica() {
                Id = 131,
                Título = "the boy is mine",
                Compositores = "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior",
                Duracao = TimeSpan.Parse ("2:53")
            },
            new Musica() {
                Id = 132,
                Título = "yes, and?",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("3:34")
            },
            new Musica() {
                Id = 133,
                Título = "we can't be friends (wait for your love)",
                Compositores = "Ariana Grande, LLya Salamanzadeh e Max Martin",
                Duracao = TimeSpan.Parse ("3:48")
            },
            new Musica() {
                Id = 134,
                Título = "i wish i hated you",
                Compositores = "Ariana Grande e LLya Salamanzadeh",
                Duracao = TimeSpan.Parse ("2:33")
            },
            new Musica() {
                Id = 135,
                Título = "imperfect for you",
                Compositores = "Ariana Grande, LLya Salamanzadeh, Max Martin e Peter Kahm",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 136,
                Título = "ordinary things (feat. Nonna)",
                Compositores = "Ariana Grande, Nick Lee, Luka Kloser e Nonna",
                Duracao = TimeSpan.Parse ("2:48")
            },
            new Musica() {
                Id = 137,
                Título = "STARS",
                Compositores = "Lucien Parker,Barringington D. Hendricks, Billy Ray Schlag, Darhyl Camper Jr., Isaac De Boni, Michael Mule, Quentin Miller, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("1:55")
            },
            new Musica() {
                Id = 138,
                Título = "KEYS TO MY LIFE",
                Compositores = "Cydel C. Young, Hubert E. Polinski, Konrad Żyrek, Samuel C. Lindley, Tim Mosley, Ty Dolla $ign, Veyis-Can Urun, Vincent Vendi e Ye",
                Duracao = TimeSpan.Parse ("2:54")
            },
            new Musica() {
                Id = 139,
                Título = "PAID",
                Compositores = "Chrishan, Anthony Kilhoffer, Cedric R Hailey, Christopher C. Dotson, Hamid Bashir, Louis K. Celestin, Samuel C. LindleyTyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:15")
            },
            new Musica() {
                Id = 140,
                Título = "TALKING",
                Compositores = "Anthony Clemons Jr, Darhyl Camper Jr., Dominic Maker, Edward Davadi, James B. Litherland, Kasseem D. Dean, North West, Quentin Miller, Shawntoni A. Nichols, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:05")
            },
            new Musica() {
                Id = 141,
                Título = "BACK TO ME",
                Compositores = "Aswad Asif, Charles M. Njapa, Daniel Kin J. Chien, Frederick Tipton, James A. Hau, Nicholas M. Balding, Sasha Hashemi, Tyrone Griffin, Jr., Ye e Zachary R. Frenes",
                Duracao = TimeSpan.Parse ("4:55")
            },
            new Musica() {
                Id = 142,
                Título = "HOODRAT",
                Compositores = "Charles M. Njapa, Darhyl Camper Jr., Malik Y. Jones, Robert G. Booker, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:42")
            },
            new Musica() {
                Id = 143,
                Título = "DO IT",
                Compositores = "Chrishan, Alexander West, Billy Ray Schlag, Darhyl Camper Jr., Denis Raab, Dijon I. McFarlane, Ermias J. Asghedom, Keenon Dequan R. Jackson, Kevin Gomringer, Lukas Benjamin Leth Kroll, Samuel C. Lindley, Supreme Williams, Tim Gomringer, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:45")
            },
            new Musica() {
                Id = 144,
                Título = "PAPERWORK",
                Compositores = "ADERLI RAMIREZ OVIEDO, Bruno Gioia Martins Funke Da Costa, Charles M. Njapa, Kasseem D. Dean, Leonardo Felipe Yasmil Garces, Nasir H. Pemberton, Quavious Keyate Marshall, Samuel C. Lindley, Ty Dolla $ign, Tyrone Griffin, Jr. e Victor Hugo Maciel dos Santos",
                Duracao = TimeSpan.Parse ("2:25")
            },
            new Musica() {
                Id = 145,
                Título = "BURN",
                Compositores = "Amir Stivie B, Christopher C. Dotson, John Beck, Joseph Goddard, Leon Thomas, Morten Ristorp, Samuel C. Lindley, Tyrone Griffin, Jr., Tyshane Thompson, Valentina Pappalardo e Ye",
                Duracao = TimeSpan.Parse ("1:51")
            },
            new Musica() {
                Id = 146,
                Título = "FUK SUMN",
                Compositores = "Chrishan, Barringington D. Hendricks, Christopher C. Dotson, Evan K. Hood-Atlas, Jacques B. Webster II, Jordan T. Carter, Quavious Keyate Marshall, Quentin Miller, Samuel C. Lindley, Tim Mosley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:29")
            },
            new Musica() {
                Id = 147,
                Título = "VULTURES",
                Compositores = "Jasper Harris, Mark Williams, Cydel C. Young, Durk D. Banks, Gustave Rudman Rambali, Jason T. Harris, Jordan Houston, Marlon T. Barrow, Mathias D. Liyew, Paul Beauregard, Pharris Thomas, Raul I. Cubina, Terrace M. Boykin, Tyrone Griffin, Jr. e Ye ",
                Duracao = TimeSpan.Parse ("4:36")
            },
            new Musica() {
                Id = 148,
                Título = "CARNIVAL",
                Compositores = "Mark Williams, Raul Cubina(of Ojivolta), Dimitri Rogers, Grant Dickinson, Jordan T. Carter, Raul I. Cubina, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("4:24")
            },
            new Musica() {
                Id = 149,
                Título = "BEG FORGIVENESS",
                Compositores = "Barrington D. Hendricks, Faouzia Ouihya, John Beck, Joseph Goddard, Latia T. Lindley, London T. Holmes, Quentin Miller, Tyrone Griffin, Jr., Valentina Pappalardo e Ye",
                Duracao = TimeSpan.Parse ("6:08")
            },
            new Musica() {
                Id = 150,
                Título = "PROBLEMATIC",
                Compositores = "Camper, Amber D. Streeter, Charles E. Hugo, Charles M. Njapa, Denzel A. Charles, Melvin Moore, Tyrone Griffin, Jr. e Ye",
                Duracao = TimeSpan.Parse ("3:14")
            },
            new Musica() {
                Id = 151,
                Título = "KING",
                Compositores = "Arturo Fratini, Barringington D. Hendricks, Charles M. Njapa, Dylan T. Cleary-Krell, Frederick Tipton, Tyrone Griffin, Jr., Victor Mensah e Ye",
                Duracao = TimeSpan.Parse ("2:36")
            },
            new Musica() {
                Id = 152,
                Título = "THE BOX MEDLEY FUNK 2",
                Compositores = "Mc Brinquedo, MC Cebezinho, Mc Laranjinha e MC Tuto",
                Duracao = TimeSpan.Parse ("4:26")
            },
            new Musica() {
                Id = 153,
                Título = "Psycho CEO",
                Compositores = "Abdul Moiz, George Kala, Michael Ojha e Noah Smith",
                Duracao = TimeSpan.Parse ("3:45")
            },
            new Musica() {
                Id = 154,
                Título = "Power Trip",
                Compositores = "Aaron Shadrow, Jasper Harris, Tom Levesque, Anton Martin Mendo, Arman Andican, Donald Glover, Noah Smith, Oscar Adler e Thomas Levesque",
                Duracao = TimeSpan.Parse ("4:24")
            },
            new Musica() {
                Id = 155,
                Título = "Breathe",
                Compositores = "Anton Martin Mendo, Bart van Hoewijk e Noah Smith",
                Duracao = TimeSpan.Parse ("2:50")
            },
            new Musica() {
                Id = 156,
                Título = "Morë",
                Compositores = "Daniel Pérez, Javier Mercado e Noah Smith",
                Duracao = TimeSpan.Parse ("2:45")
            },
            new Musica() {
                Id = 157,
                Título = "Bought The Earth",
                Compositores = "Aaron Cheung, Carlton McDowell Jr, Charlie Coffeen, Noah Smith e Rex Masamune Kudo",
                Duracao = TimeSpan.Parse ("2:58")
            },
            new Musica() {
                Id = 158,
                Título = "Nothing Changë",
                Compositores = "Cooper Coad, George Kala e Noah Smith",
                Duracao = TimeSpan.Parse ("3:57")
            },
            new Musica() {
                Id = 159,
                Título = "U Should Know",
                Compositores = "Abdul Moiz, Neile Ode e Noah Smith",
                Duracao = TimeSpan.Parse ("3:06")
            },
            new Musica() {
                Id = 160,
                Título = "Lyfestylë (with Lil Wayne)",
                Compositores = "Javier Mercado, Joey Fenderson, Noah Smith e Salah Nizami",
                Duracao = TimeSpan.Parse ("3:56")
            },
            new Musica() {
                Id = 161,
                Título = "ILUV",
                Compositores = "Edith Frances, Ethan Kath, Javier Mercado, Noah Smith e Rio Leyva",
                Duracao = TimeSpan.Parse ("3:03")
            },
            new Musica() {
                Id = 162,
                Título = "Tell më",
                Compositores = "Cyrus Spurlock, Gabriel St-Onge, Javier Mercado, Louis Esposito, Noah Smith e Spencer Mott",
                Duracao = TimeSpan.Parse ("4:03")
            },
            new Musica() {
                Id = 163,
                Título = "Shade",
                Compositores = "Christian Boggs, Daniel Mohammadi, Francesca Boszormenyi, Javier Mercado, Joy Evangeline Moreno, Louis Esposito, Nathan Andrew Chen e Noah Smith",
                Duracao = TimeSpan.Parse ("4:02")
            },
            new Musica() {
                Id = 164,
                Título = "Keep Pushin",
                Compositores = "Abdul Moiz, Anton Martin Mendo, Neile Ode, Noah Smith e Tobias Dekker",
                Duracao = TimeSpan.Parse ("2:46")
            },
            new Musica() {
                Id = 165,
                Título = "Riot & Set it off",
                Compositores = "Anton Martin Mendo, Clint Mansell e Noah Smith",
                Duracao = TimeSpan.Parse ("2:38")
            },
            new Musica() {
                Id = 166,
                Título = "Team ceo",
                Compositores = "Anton Martin Mendo, Noah Smith, Sam Lawalata e Tobias Dekker",
                Duracao = TimeSpan.Parse ("3:17")
            },
            new Musica() {
                Id = 167,
                Título = "2093",
                Compositores = "Anton Martin Mendo, Arman Andican, Ethan Andrade, Noah Smith e Oscar Adler",
                Duracao = TimeSpan.Parse ("2:24")
            },
            new Musica() {
                Id = 168,
                Título = "Stand On It (with Future)",
                Compositores = "George Kala, Nayvadius Wilburn e Noah Smith",
                Duracao = TimeSpan.Parse ("3:00")
            },
            new Musica() {
                Id = 169,
                Título = "Familia",
                Compositores = "Benjamin Saint Fort, Abdul Moiz, Cyrus Spurlock e Noah Smith",
                Duracao = TimeSpan.Parse ("2:34")
            },
            new Musica() {
                Id = 170,
                Título = "Mr. Inbetweenit",
                Compositores = "Matthew Shalnev, Nikita Zvorygin e Noah Smith",
                Duracao = TimeSpan.Parse ("3:18")
            },
            new Musica() {
                Id = 171,
                Título = "Psychocainë",
                Compositores = "Abdul Moiz, Michael Ojha,Noah Smith e Oscar Vidal",
                Duracao = TimeSpan.Parse ("2:46")
            },
            new Musica() {
                Id = 172,
                Título = "Run Thëy Mouth",
                Compositores = "George Kala, Noah Smith e Oscar Vidal",
                Duracao = TimeSpan.Parse ("3:26")
            },
            new Musica() {
                Id = 173,
                Título = "If We Being Rëal",
                Compositores = "Eric Kjell Jowett, Gabriel St-Onge, Javier Mercado, Joey Fenderson, Louis Esposito, Noah Smith e Spencer Mott",
                Duracao = TimeSpan.Parse ("2:52")
            },
            new Musica() {
                Id = 174,
                Título = "1093",
                Compositores = "Aaron Shadrow, Benjamin Bock, Noah Smith e Rex Masamune Kudo",
                Duracao = TimeSpan.Parse ("2:36")
            },
            new Musica() {
                Id = 175,
                Título = "St. Chroma (feat. Daniel Caesar)",
                Compositores = "Ashton Dumar Simmonds e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:17")
            },
            new Musica() {
                Id = 176,
                Título = "Rah Tah Tah",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("2:45")
            },
            new Musica() {
                Id = 177,
                Título = "Noid",
                Compositores = "Paul Dobson Nyirongo e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:44")
            },
            new Musica() {
                Id = 178,
                Título = "Darling, I (feat. Teezo Touchdown)",
                Compositores = "Barry White, Kamaal Ibn John Fareed e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:13")
            },
            new Musica() {
                Id = 179,
                Título = "Hey Jane",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:00")
            },
            new Musica() {
                Id = 180,
                Título = "I Killed You",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("2:48")
            },
            new Musica() {
                Id = 181,
                Título = "Judge Judy",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:29")
            },
            new Musica() {
                Id = 182,
                Título = "Sticky (feat. GloRilla, Sexyy Red & Lil Wayne)",
                Compositores = "Aaron Bolton, David Darnell Brown, Dudley Alexander Duverne, Dwyane Carter, Jr., Elvis L. Jr. Williams, Gloria Woods, Jamal F Jones, Janae Wherry, Rex Zamor, Tim Mosley, Timothy clayton, Tyler Okonma e Zachary Anson Wallace",
                Duracao = TimeSpan.Parse ("4:15")
            },
            new Musica() {
                Id = 183,
                Título = "Take Your Mask Off (feat. Daniel Caesar & LaToiya Williams)",
                Compositores = "Greg Cook, K. Thomas e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:13")
            },
            new Musica() {
                Id = 184,
                Título = "Tomorrow",
                Compositores = "Ashton Dumar Simmonds e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:02")
            },
            new Musica() {
                Id = 185,
                Título = "Thought I Was Dead (feat. ScHoolboy Q & Santigold)",
                Compositores = "Quincy Hanley e Tyler Okonma",
                Duracao = TimeSpan.Parse ("3:27")
            },
            new Musica() {
                Id = 186,
                Título = "Like Him (feat. Lola Young)",
                Compositores = "Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:38")
            },
            new Musica() {
                Id = 187,
                Título = "Balloon (feat. Doechii)",
                Compositores = "Harry Wayne Casey, James Brown, Jaylah Hickmon, Luther Campbell, Rick Finch, Robert Ginyard e Tyler Okonma",
                Duracao = TimeSpan.Parse ("4:29")
            },
            new Musica() {
                Id = 188,
                Título = "Barbie",
                Compositores = "Emerson Teixeira Muniz e Glenner Robert Cândido",
                Duracao = TimeSpan.Parse ("3:12")
            },
            new Musica() {
                Id = 189,
                Título = "APT.",
                Compositores = "Amy Allen, Bruno Mars, Chae Young Park, Christopher Brody Brown, Henry Walter, Michael Chapman, Nicholas Chinn, Omer Fedi, Philip Lawrence, Rogét Chahayed e Theron Thomas",
                Duracao = TimeSpan.Parse ("2:49")
            },
            new Musica() {
                Id = 190,
                Título = "Sou + Você",
                Compositores = "Caetano Veloso e Mano Brown",
                Duracao = TimeSpan.Parse ("1:48")
            },
            new Musica() {
                Id = 191,
                Título = "Vivão e Vivendo",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("1:57")
            },
            new Musica() {
                Id = 192,
                Título = "Vida Loka (Intro)",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("0:24")
            },
            new Musica() {
                Id = 193,
                Título = "Vida Loka, Pt. 1",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:03")
            },
            new Musica() {
                Id = 194,
                Título = "Negro Drama",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:51")
            },
            new Musica() {
                Id = 195,
                Título = "A Vítima",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:20")
            },
            new Musica() {
                Id = 196,
                Título = "Na Fé Firmão",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:05")
            },
            new Musica() {
                Id = 197,
                Título = "12 de Outubro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("3:30")
            },
            new Musica() {
                Id = 198,
                Título = "Eu Sou 157",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("8:49")
            },
            new Musica() {
                Id = 199,
                Título = "A Vida É Desafio",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:13")
            },
            new Musica() {
                Id = 200,
                Título = "1 por Amor, 2 por Dinheiro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:58")
            },
            new Musica() {
                Id = 201,
                Título = "De Volta À Cena",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("2:01")
            },
            new Musica() {
                Id = 202,
                Título = "Otus 500",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("2:11")
            },
            new Musica() {
                Id = 203,
                Título = "Crime Vai e Vem",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:55")
            },
            new Musica() {
                Id = 204,
                Título = "Jesus Chorou",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("7:51")
            },
            new Musica() {
                Id = 205,
                Título = "Fone (Intro)",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("1:56")
            },
            new Musica() {
                Id = 206,
                Título = "Estilo Cachorro",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:17")
            },
            new Musica() {
                Id = 207,
                Título = "Vida Loka, Pt. 2",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:50")
            },
            new Musica() {
                Id = 208,
                Título = "Expresso da Meia-Noite",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("5:21")
            },
            new Musica() {
                Id = 209,
                Título = "Trutas e Quebradas",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("6:17")
            },
            new Musica() {
                Id = 210,
                Título = "Da Ponte pra Cá",
                Compositores = "Mano Brown",
                Duracao = TimeSpan.Parse ("8:47")
            },
        };
        builder.Entity<Musica>().HasData(musicas);
        #endregion

        #region Populate Artista
        List<Artista> artistas = new(){
            new Artista() {
                Id = 1,
                Nome = "Future, Metro Boomin"
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
            new Artista() {
                Id = 15,
                Nome = "Drake"
            },
            new Artista() {
                Id = 16,
                Nome = "Playboi Carti e The Weeknd"
            },
            new Artista() {
                Id = 17,
                Nome = "Tommy Richman"
            },
            new Artista() {
                Id = 18,
                Nome = "Coldplay"
            },
            new Artista() {
                Id = 19,
                Nome = "Ariana Grande"
            },
            new Artista() {
                Id = 20,
                Nome = "Kanye West"
            },
            new Artista() {
                Id = 21,
                Nome = "DJ Oreia, Mc Brinquedo, MC Cebezinho, Mc Laranjinha, MC Tuto e THE BOX"
            },
            new Artista() {
                Id = 22,
                Nome = "Yeat"
            },
            new Artista() {
                Id = 23,
                Nome = "Tyler, The Creator"
            },
            new Artista() {
                Id = 24,
                Nome = "DJ Glenner e MC Tuto"
            },
            new Artista() {
                Id = 25,
                Nome = "Bruno Mars e ROSÉ"
            },
            new Artista() {
                Id = 26,
                Nome = "Racionais MC's"
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
                MusicaId = 66,
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
                GeneroId = 2,
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
            new MusicaGenero() {
                MusicaId = 122,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 123,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 124,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 125,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 126,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 127,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 128,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 129,
                GeneroId = 5,
            },
            new MusicaGenero() {
                MusicaId = 130,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 131,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 132,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 133,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 134,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 135,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 136,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 137,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 138,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 139,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 140,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 141,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 142,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 143,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 144,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 145,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 146,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 147,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 148,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 149,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 150,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 151,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 152,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 153,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 154,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 155,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 156,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 157,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 158,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 159,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 160,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 161,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 162,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 163,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 164,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 165,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 166,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 167,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 168,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 169,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 170,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 171,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 172,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 173,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 174,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 175,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 176,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 177,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 178,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 179,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 180,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 181,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 182,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 183,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 184,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 185,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 186,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 187,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 188,
                GeneroId = 4,
            },
            new MusicaGenero() {
                MusicaId = 189,
                GeneroId = 1,
            },
            new MusicaGenero() {
                MusicaId = 190,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 191,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 192,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 193,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 194,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 195,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 196,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 197,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 198,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 199,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 200,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 201,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 202,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 203,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 204,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 205,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 206,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 207,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 208,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 209,
                GeneroId = 2,
            },
            new MusicaGenero() {
                MusicaId = 210,
                GeneroId = 2,
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
                AlbumId = 10,
                ArtistaId = 3,
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
                AlbumId = 12,
                ArtistaId = 15,
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
                AlbumId = 14,
                ArtistaId = 7,
                MusicaId = 102,
            },
            new AlbumArtista() {
                AlbumId = 11,
                ArtistaId = 10,
                MusicaId = 103,
            },
            new AlbumArtista() {
                AlbumId = 13,
                ArtistaId = 14,
                MusicaId = 104,
            },
            new AlbumArtista() {
                AlbumId = 15,
                ArtistaId = 16,
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
                AlbumId = 8,
                ArtistaId = 12,
                MusicaId = 121,
            },
            new AlbumArtista() {
                AlbumId = 16,
                ArtistaId = 17,
                MusicaId = 122,
            },
            new AlbumArtista() {
                AlbumId = 17,
                ArtistaId = 18,
                MusicaId = 123,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 124,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 125,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 126,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 127,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 128,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 129,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 130,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 131,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 132,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 133,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 134,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 135,
            },
            new AlbumArtista() {
                AlbumId = 18,
                ArtistaId = 19,
                MusicaId = 136,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 137,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 138,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 139,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 140,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 141,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 142,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 143,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 144,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 145,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 146,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 147,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 148,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 149,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 150,
            },
            new AlbumArtista() {
                AlbumId = 19,
                ArtistaId = 20,
                MusicaId = 151,
            },
            new AlbumArtista() {
                AlbumId = 20,
                ArtistaId = 21,
                MusicaId = 152,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 153,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 154,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 155,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 156,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 157,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 158,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 159,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 160,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 161,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 162,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 163,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 164,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 165,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 166,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 167,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 168,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 169,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 170,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 171,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 172,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 173,
            },
            new AlbumArtista() {
                AlbumId = 21,
                ArtistaId = 22,
                MusicaId = 174,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 175,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 176,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 177,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 178,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 179,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 180,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 181,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 182,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 183,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 184,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 185,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 186,
            },
            new AlbumArtista() {
                AlbumId = 22,
                ArtistaId = 23,
                MusicaId = 187,
            },
            new AlbumArtista() {
                AlbumId = 23,
                ArtistaId = 24,
                MusicaId = 188,
            },
            new AlbumArtista() {
                AlbumId = 24,
                ArtistaId = 25,
                MusicaId = 189,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 190,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 191,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 192,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 193,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 194,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 195,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 196,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 197,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 198,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 199,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 200,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 201,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 202,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 203,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 204,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 205,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 206,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 207,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 208,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 209,
            },
            new AlbumArtista() {
                AlbumId = 25,
                ArtistaId = 26,
                MusicaId = 210,
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