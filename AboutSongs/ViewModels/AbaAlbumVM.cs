using AboutSongs.Models;

namespace AboutSongs.ViewModels;

public class AbaAlbumVM
{
    public List<Album> Albuns { get; set; } = [];
    public List<Artista> Artistas { get; set; } = [];
    public List<string> Generos { get; set; } = [];


}