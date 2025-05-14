using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPAhorcado.Models;

namespace TPAhorcado.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Partido.InicializarPartido();
        ViewBag.Palabra = Partido.Palabra;

        return View();
    }

    public IActionResult GuardarCambios(char letra)
    {
        int i = 0;
        int pos = null;
        while (pos == null && i < Palabra.letras.Count)
        {
            if(letra = Palabra.letras[i])
            {
                pos = i;
            }
        }
    }

    public IActionResult GuardarPalabra(string letra)
    {

    }

    public IActionResult Privacy()
    {
        return View();
    }

}
