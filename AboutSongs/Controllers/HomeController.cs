using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Models;
using AboutSongs.Data;
using AboutSongs.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;


namespace AboutSongs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var albuns = _context.AlbumArtistas
            .AsNoTracking()
            .Include(aa => aa.Artista)
            .Include(aa => aa.Album)
            .Include(aa => aa.Musica)
            .ToList();

        HomeVM homeVM = new();
        int idAlbum = 0;
        foreach (var album in albuns)
        {
            if (album.AlbumId != idAlbum)
            {
                // Adiciona um album a Lista de Albuns
                AlbumHome albumHome = new()
                {
                    Id = album.AlbumId,
                    Nome = album.Album.Titulo,
                    FotoCapa = album.Album.Foto,
                };
                idAlbum = album.AlbumId;
                albumHome.Artistas = string.Join(", ", albuns.Where(a => a.AlbumId == idAlbum).Select(a => a.Artista.Nome).ToList());
                var ids = albuns.Where(a => a.AlbumId == idAlbum).Select(a => a.Musica.Id).ToList();
                var generos = _context.MusicaGeneros.Where(mg => ids.Contains(mg.MusicaId)).Select(mg => mg.Genero.Nome).Distinct().ToList();
                albumHome.Generos = string.Join(", ", generos);
                homeVM.AlbumHomes.Add(albumHome);

                if (idAlbum > 12)
                {
                    // Adiciona uma musica a lista de Musicas
                    MusicaHome musicaHome = new()
                    {
                        Id = album.AlbumId,
                        Nome = album.Musica.Título,
                        FotoAlbum = album.Album.Foto,
                    };
                    musicaHome.Artistas = albumHome.Artistas;
                    musicaHome.Generos = string.Join(", ", _context.MusicaGeneros.Where(mg => mg.MusicaId == musicaHome.Id).Select(mg => mg.Genero.Nome).Distinct().ToList());
                    homeVM.MusicaHomes.Add(musicaHome);
                }
            }
        }
        return View(homeVM);
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Entrar()
    {
        return View();
    }
    public IActionResult Música()
    {
        return View();
    }

    public IActionResult Album()
    {
        return View();
    }
    public IActionResult Favoritos()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}