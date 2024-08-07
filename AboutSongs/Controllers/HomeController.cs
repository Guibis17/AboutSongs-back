using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Models;

namespace AboutSongs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
