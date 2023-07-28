using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Controllers
{
    public class MusicController : Controller
    {
        private readonly ISongService songService;

        public MusicController(ISongService songService)
        {
            this.songService = songService;
        }
        public async Task<IActionResult> Music()
        {
            IEnumerable<MusicAddViewModel> allSongs =
               await this.songService.ListAllAsync();

            return View(allSongs);
            
        }
        public IActionResult AddSong()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSong(MusicAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await this.songService.AddPostAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(String.Empty, "Error occured while adding your post.");
                return View(model);
            }
            return RedirectToAction("Music");
        }

        [HttpPost]
       
        public async Task<IActionResult> DeleteSong(string id)
        {
            try
            {
                await this.songService.DeleteByIdAsync(id);
                return RedirectToAction("Music", "Music");
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Home", "Blog");

        }
    }
}
