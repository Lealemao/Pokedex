using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula01.Models;
using POKES.Models;

namespace Aula01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Pokemon pikachu = new()
        {
            Numero = 25,
            Nome = "pikachu",
            Imagem = "img/pokemons/025.png",
            Tipo = ["Elétrico"],
        };
        return View(pikachu);
    }

    public IActionResult Xalrons()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
