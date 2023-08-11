using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Views.Planner
{
    public class PlannerController : Controller
    {
        private readonly IPlannerService postService;

        public PlannerController(IPlannerService postService)
        {
            this.postService = postService;
        }
        
        public async Task<IActionResult> AddedNotes()
        {
            IEnumerable<PlannerViewModel> allPosts =
				 await this.postService.ListAllAsync();
            return View("_AddedNotes", allPosts);
        }
        [HttpGet]
        public IActionResult Add()
		{
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PlannerAddViewModel note)
        {
            if (!ModelState.IsValid)
            {
                return View("_AddedNotes");
            }
            try
            {
                await this.postService.AddPostAsync(note);

               return View("_AddedNotes");
                

            }
            catch (Exception)
            {
                ModelState.AddModelError(String.Empty, "Error occured while adding your post.");
                return View("_AddedNotes");
            }
            
           
            
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await this.postService.DeleteByIdAsync(id);
            }
            catch (Exception)
            {

            }
            return View("_AddedNotes");

        }
    }
}
