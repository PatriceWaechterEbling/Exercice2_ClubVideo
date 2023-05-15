using Microsoft.AspNetCore.Mvc;

namespace Exercice2_ClubVideo.Controllers
{
    public class ControllerFilm : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
