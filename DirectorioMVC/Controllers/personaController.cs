using Microsoft.AspNetCore.Mvc;
using POO_DirectorioMVC.Models;

namespace POO_DirectorioMVC.Controllers
{
    public class PersonaController : Controller
    {
       Persona myPersona = new Persona("Jose");




        public IActionResult Index()
        {
            return View();
        }
    }
}
