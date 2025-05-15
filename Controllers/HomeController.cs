using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPAhorcado.Models;

namespace TPAhorcado.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Partido partido = new Partido();
        partido.InicializarPartido();
        ViewBag.Partido = partido;
        ViewBag.Palabra = partido.palabra;
        return View();
    }

    public IActionResult IntentarLetra(string letra)
    {
        ViewBag.Partido.actualizarIntento(letra);
    }


    public IActionResult Privacy()
    {
        return View();
    }

     public void mostrarLetra (char letra)
    {
       
    }

}
