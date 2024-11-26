using AboutSongs.Models;

namespace AboutSongs.ViewModels;

public class HomeVM
{
    public List<AlbumHome> AlbumHomes { get; set; } = [];
    public List<MusicaHome> MusicaHomes { get; set; } = [];

}

public class AlbumHome
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string FotoCapa { get; set; }
    public string Artistas { get; set; }
    public string Generos { get; set; }
}

public class MusicaHome
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string FotoAlbum { get; set; }
    public string Artistas { get; set; }
    public string Generos { get; set; }
}