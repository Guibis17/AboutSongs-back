using AboutSongs.Models;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace AboutSongs.Data;
public class AppDbSeed
{
    public class AppDbSeed(ModelBuilder builder)
    {
        #region Populate Albuns 
        List<Album> albuns = new() 
        {
            new Album() {
                Id = 1,
                Nome = "My Beautiful Dark Twisted Fantasy",
                Capa = "",
                ExibirHome = true


            },
        };
        builder.Entity<Album>().HasData(albuns);
        #endregion



    }
}