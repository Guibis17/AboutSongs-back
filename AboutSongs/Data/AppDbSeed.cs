using AboutSongs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AboutSongs.Data;
public class AppDbSeed
{
    public class AppDbSeed(ModelBuilder builder)
    {
        #region Populate Album 
        List<Album> albums = new() {
            new Album(){
                Id = 1,
                
            }
        }
    }
}