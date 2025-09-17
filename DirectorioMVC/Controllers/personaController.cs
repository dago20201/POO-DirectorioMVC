using Microsoft.AspNetCore.Mvc;
using POO_DirectorioMVC.Models;
namespace POO_DirectorioMVC.Controllers
{
    public class Personacontroller : Controller
    {
        Persona myPersona = new Persona ("José","Morazan");
        public IActionResult Index()
        {
            return View(myPersona);
        }
    }
}
