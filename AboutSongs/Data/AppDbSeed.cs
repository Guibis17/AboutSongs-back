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
                Nome = "My Beautiful Dark Twisted Fantasy",
                ArtistaId = 1,
                Genero = "Rap/Hip-Hop",
                Foto = "/img/Albuns/1.jpg",
                ExibirHome = true
            },
            new Album() {
                Id = 2,
                Nome = "HIT ME HARD AND SOFT",
                ArtistaId = 2,
                Genero = "Rap/Hip-Hop",
                Foto = "/img/Albuns/2.jpg",
                ExibirHome = true
            },
            new Album() {
                Id = 3,
                Nome = "ye",
                Genero = "Rap/Hip-Hop",
                ArtistaId = 1,
                Foto = "/img/Albuns/3.jpg",
                ExibirHome = true
            },
        };
        builder.Entity<Album>().HasData(albuns);
        #endregion

        #region Populate Musica 
        List<Musica> musicas = new(){
            new Musica() {
                Id = 1,
                Título = "Runaway",
                Compositores = "JEFF BHASKER, MALIK YUSEF JONES, EMILE HAYNIE, JOHN ROGER BRANCH, MIKE DEAN, TERRENCE THORNTON, KANYE WEST, PHILLIPS PETER",
                AlbumId = 
            }
        };
        builder.Entity<Musica>().HasData(musicas);
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