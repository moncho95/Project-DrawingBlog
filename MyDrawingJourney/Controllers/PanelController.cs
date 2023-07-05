using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyDrawingJourney.Controllers
{
    [Authorize]
    public class PanelController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
