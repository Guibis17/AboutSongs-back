using System.Net.Mail;
using System.Security.Claims;
using System.Security.Policy;
using AboutSongs.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Services;


namespace AboutSongs.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userInManager;
    private readonly IUsuarioService _usuarioService;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager
        )
    {
        _logger = logger;
        _signInManager = signInManager;
        _userInManager = userManager;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM login)
    {
        if (ModelState.IsValid)
        {
            string userName = login.Email;
            if (IsValidEmail(userName))
            {
                var user = await _userInManager.FindByEmailAsync(userName);
                if (user != null)
                    userName = user.UserName;
            }

            var result = await _signInManager.PasswordSignInAsync(
                userName, login.Senha, login.Lembrar, lockoutOnFailure: true
            );

            if (result.Succeeded)
            {
                _logger.LogInformation($"Usuário {userName} acessou o sistema!");
                return LocalRedirect(login.UrlRetorno);
            }

            if (result.IsLockedOut)
            {
                _logger.LogWarning($"Usuário {userName} está bloqueado");
                ModelState.AddModelError(string.Empty, "Conta Bloqueado! Aguarde alguns minutos para continuar!");
            }

            ModelState.AddModelError(string.Empty, "Usuário e/ou Senha Inválidos!!!");
        }
        return View(login);
    }

    [HttpGet]
    public IActionResult Registro()
    {
        RegistroVM register = new();
        return View(register);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Registro(RegistroVM register)
    {
        register.Enviado = false;
        if (ModelState.IsValid)
        {
            var result = await _usuarioService.RegistrarUsuario(register);
            if (result != null)
                foreach (var error in result)
                {
                    ModelState.AddModelError(string.Empty, error);
                }
            register.Enviado = result == null;
        }
        return View(register);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        _logger.LogInformation($"Usuário {ClaimTypes.Email} saiu do sistema!");
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    public IActionResult AcessDenied()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
    private static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress mail = new(email);
            return true;
        }
        catch
        {
            return false;
        }
    }
}