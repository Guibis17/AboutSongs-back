using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Models;
using AboutSongs.Data;
using AboutSongs.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using AboutSongs.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace AboutSongs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    private readonly IMusicService _musicService;
    private readonly IUsuarioService _usuarioService;

    public HomeController(ILogger<HomeController> logger, AppDbContext context, IMusicService musicService, IUsuarioService usuarioService)
    {
        _logger = logger;
        _context = context;
        _musicService = musicService;
        _usuarioService = usuarioService;
    }

    public IActionResult Index()
    {
        var musicas = _musicService.GetMusicas();
        var musicasFiltradas = musicas.GroupBy(musica => musica.Albuns.FirstOrDefault()?.Id).Select(grupo => grupo.First());
        HomeVM homeVM = new()
        {
            Albuns = _musicService.GetAlbuns(),
            Musicas = musicasFiltradas.ToList()
        };
        return View(homeVM);
    }

    public IActionResult Albuns()
    {
        var albuns = _musicService.GetAlbuns();
        return View(albuns);
    }

    public IActionResult Album(int id)
    {
        AlbumVM album = _musicService.GetAlbum(id);
        return View(album);
    }

    public IActionResult Musica(int id)
    {
        MusicaVM musica = _musicService.GetMusica(id);
        return View(musica);
    }

    public IActionResult Musicas()
    {
        var musicas = _musicService.GetMusicas();
        return View(musicas);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ComentarMusica(ComentarioVM comenta)
    {
        if (ModelState.IsValid)
        {
            var usuario = await _usuarioService.GetUsuarioLogado();
            ComentarioMusica comentarioMusica = new()
            {
                MusicaId = comenta.Id,
                DataDePublicacao = DateTime.Now,
                UsuarioId = usuario.UsuarioId,
                Comentario = comenta.Comentario
            };
            await _context.ComentarioMusicas.AddAsync(comentarioMusica);
            await _context.SaveChangesAsync();
            return RedirectToAction("Musica", "Home", new { comenta.Id });
        }
        return RedirectToAction("Musicas");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ComentarAlbum(ComentarioVM comenta)
    {
        if (ModelState.IsValid)
        {
            var usuario = await _usuarioService.GetUsuarioLogado();
            ComentarioAlbum comentarioAlbum = new()
            {
                AlbumId = comenta.Id,
                DataDePublicacao = DateTime.Now,
                UsuarioId = usuario.UsuarioId,
                Comentario = comenta.Comentario
            };
            await _context.ComentarioAlbuns.AddAsync(comentarioAlbum);
            await _context.SaveChangesAsync();
            return RedirectToAction("Album", "Home", new { comenta.Id });
        }
        return RedirectToAction("Albuns");
    }

    public IActionResult Sobre()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}