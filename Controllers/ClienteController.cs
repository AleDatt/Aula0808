using Microsoft.AspNetCore.Mvc;

namespace ExercicioProfMarcosGit.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
