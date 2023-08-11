using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Services
{
    public class PlannerService:IPlannerService
    {
        private readonly ApplicationDbContext dbContext;

        public PlannerService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPostAsync(PlannerAddViewModel postViewModel)
        {
            Note newPost = new Note()
            {                
                Content = postViewModel.Content
            };
            await this.dbContext.Notes.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<PlannerViewModel>> ListAllAsync()
        {
            IEnumerable<PlannerViewModel> allPosts = await dbContext.Notes
                 .Select(n => new PlannerViewModel()
                 {
                     Content = n.Content
                 })
                 .ToArrayAsync();
            return allPosts;

        }
        public async Task DeleteByIdAsync(string id)
        {
            Note postToDelete = await this.dbContext
                .Notes
                .FirstAsync(p => p.Id.ToString() == id);

            this.dbContext.Notes.Remove(postToDelete);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
