using Microsoft.AspNetCore.Mvc;

namespace POO_DirectorioMVC.Controllers
{
    public class personaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
