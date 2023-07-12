using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Controllers
{
    public class ForumController : Controller
    {
        private readonly IPostService postService;

        public ForumController(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<ForumPostListViewModel> allPosts =
                await this.postService.ListAllAsync();

            return View(allPosts);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ForumPostAddFormModel model)
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
            return RedirectToAction("All");
        }
    }
}
