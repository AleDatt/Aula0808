using Microsoft.AspNetCore.Mvc;

namespace ExercicioProfMarcosGit.Controllers
{
    public class NossaHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
