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
                Foto = "/img/Albuns/1.jpg",
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
                Título = "ye",
                Foto = "/img/Albuns/3.jpg",
                DataDeLancamento = DateTime.Parse ("1/06/2018"),
                ExibirHome = true
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
                Id = 22,
                Título = "THE GREATEST ",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:53")
            },
            new Musica() {
                Id = 22,
                Título = "L’AMOUR DE MA VIE ",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("5:33")
            },
            new Musica() {
                Id = 22,
                Título = "THE DINER",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("3:06")
            },
            new Musica() {
                Id = 22,
                Título = "BITTERSUITE",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("4:58")
            },
            new Musica() {
                Id = 22,
                Título = "BLUE",
                Compositores = "Billie Eilish e Finneas O'Connell",
                Duracao = TimeSpan.Parse ("5:43")
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
                Nome = ""
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