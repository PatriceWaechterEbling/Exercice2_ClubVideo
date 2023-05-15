using Microsoft.AspNetCore.Mvc;

namespace Exercice2_ClubVideo.Controllers
{
    public class ControlleurClients : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
