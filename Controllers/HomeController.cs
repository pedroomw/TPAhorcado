using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPAhorcado.Models;

namespace TPAhorcado.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
       if (Partido.palabraActual == null)
        Partido.InicializarPartido();
        
        ViewBag.LetrasAdivinadas = Partido.letrasAdivinadas;
        ViewBag.Palabra = Partido.palabra;
        ViewBag.IntentosLetra = Partido.intentosLetra;
        ViewBag.PalabraActual = Partido.palabraActual;
        ViewBag.PalabraActualVector = Partido.palabraActualVector;
        ViewBag.Intentos = Partido.intentos;

        return View();
    }
     [HttpPost]
    public IActionResult IntentarLetra(char letra)
    {
        Partido.ActualizarIntento(letra);
        ViewBag.PalabraActual = Partido.palabraActual;
         if (new string(Partido.palabraActualVector) == Partido.palabra)
    {
        return View("ganaste");
    }
    else
    {
        return RedirectToAction("Index");
    }
         
 
    }


    public IActionResult Privacy()
    {
        return View();
    }

     public void mostrarLetra (char letra)
    {
       
    }
    
     [HttpPost]
    public IActionResult IntentarPalabra(string palabra)
    {
        bool resultado = (Partido.ArriesgarPalabra(palabra));
        if (resultado == true)
        {
           return View("ganaste");
        } else {
           return View("perdiste");
        }
           

    }

}
