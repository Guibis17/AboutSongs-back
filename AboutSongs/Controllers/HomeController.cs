using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Models;
using AboutSongs.Data;
using AboutSongs.ViewModels;
using Microsoft.EntityFrameworkCore;

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
        HomeVM home = new()
        {
        Albuns = _context.Albuns
            .Where(a => a.ExibirHome)

            .AsNoTracking()
            .ToList(),
        Musicas = _context.Musicas
            .Include(m => m.Album)
            .Include(m => m.Generos)
            .AsNoTracking()
            .ToList()


        };
        return View(home);
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
