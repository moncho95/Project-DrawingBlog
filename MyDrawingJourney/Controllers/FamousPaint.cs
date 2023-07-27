using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Controllers
{
    public class FamousPaint : Controller
    {
        private readonly IPaintService postService;

        public FamousPaint(IPaintService postService)
        {
            this.postService = postService;
        }
        public async Task<IActionResult> Famous()
        {
            IEnumerable<FamousPaintingViewModel> allPosts =
                await this.postService.ListAllAsync();

            return View(allPosts);
        }

        public IActionResult AddPainting()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPainting(FamousPaintingAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await this.postService.AddPostAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(String.Empty, "Error occured while adding your post.");
                return View(model);
            }
            return RedirectToAction("Famous");
        }
       

        [HttpPost]
        public async Task<IActionResult> DeletePainting(string id)
        {
            try
            {
                await this.postService.DeleteByIdAsync(id);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Famous", "FamousPaint");

        }

        public async Task<IActionResult> Search(string mesg)

        {
            try
            {
               var model = await this.postService.SearchbyNameAsync(mesg);
                return View("Search", model);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Famous", "FamousPaint");
        }

        public async Task<IActionResult> Sort(int op)
        {
            try
            {
                var models = await this.postService.SortAllAsync(op);
                return View("Famous", models);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Famous", "FamousPaint");
        }
    }
}
