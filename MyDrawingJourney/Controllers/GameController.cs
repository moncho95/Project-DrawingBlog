using Microsoft.AspNetCore.Mvc;

namespace MyDrawingJourney.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Games()
        {
            return View();
        }
        public IActionResult Tictac()
        {
            return PartialView("Tic-tac-toe");
        } public IActionResult Paint()
        {
            return PartialView("_PaintApp");
        }
    }
}
