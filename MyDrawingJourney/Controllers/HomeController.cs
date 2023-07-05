using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.ViewModels;
using MyDrawingJourney.ViewModels.Home;
using System.Diagnostics;

namespace MyDrawingJourney.Controllers
{
    public class HomeController : BaseController
    {


        //public HomeController(ILogger<HomeController> logger)
        //{

        //} 

        //[AllowAnonymous]
        //public IActionResult Index()
        //{
        //    if (User?.Identity?.IsAuthenticated ?? false)
        //    {
        //        return RedirectToAction("Index", "Blog");
        //    }

        //    return View();
        //}

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}