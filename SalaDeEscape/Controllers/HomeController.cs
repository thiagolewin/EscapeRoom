using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Habitacion1()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
    public IActionResult Comenzar()
    {
        int proxHabitacion = Escape.GetEstadoJuego();
        return View("Habitacion"+proxHabitacion);
    }
    public IActionResult Habitacion(int sala, string clave) {
        if(sala != Escape.GetEstadoJuego()) {
            return View("Habitacion"+Escape.GetEstadoJuego());
        } else {
            if(clave.ToLower() == Escape.incognitasSalas[Escape.GetEstadoJuego()-1]) {
            return View("Habitacion"+Escape.GetEstadoJuego());     
            }
        }
        return View("Habitacion");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
