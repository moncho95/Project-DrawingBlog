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

        public async Task<IActionResult> Editt(string id)
        {
            try
            {
                ForumPostAddFormModel postforEdit = await this.postService.GetForEditByIdAsync(id);
                return View(postforEdit);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Forum");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Editt(string id, ForumPostAddFormModel postforEdit)
        {
            if (!ModelState.IsValid)
            {
                return this.View(postforEdit);
            }

            try
            {
                await this.postService.EditByIdAsync(id, postforEdit);
            }
            catch (Exception)
            {
                ModelState.AddModelError(String.Empty, "Error occured while updating your post.");
                return View(postforEdit);

            }
            return RedirectToAction("All", "Forum");
        }

        public async Task<IActionResult> Preview(string id)
        {
            try
            {
                ForumPostAddFormModel postModel =
                    await this.postService.GetForEditByIdAsync(id);

                return View(postModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Forum");
            }
        }


        public async Task<IActionResult> DeleteWithView(string id)
        {
            try
            {
                ForumPostAddFormModel postModel =
                    await this.postService.GetForEditByIdAsync(id);

                return View(postModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Forum");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteWithView(string id, ForumPostAddFormModel postModel)
        {
            try
            {
                await this.postService.DeleteByIdAsync(id);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while deleting your post!");
                return this.View(postModel);
            }

            return RedirectToAction("All", "Forum");
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

            return RedirectToAction("All", "Forum");
        }
    }
}
