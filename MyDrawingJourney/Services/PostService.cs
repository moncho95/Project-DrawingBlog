using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext dbContext;

        public PostService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPostAsync(ForumPostAddFormModel postViewModel)
        {
            ForumPost newPost = new ForumPost()
            {
                Title = postViewModel.Title,
                Content = postViewModel.Content
            };
            await this.dbContext.ForumPosts.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ForumPostListViewModel>> ListAllAsync()
        {
            IEnumerable<ForumPostListViewModel> allPosts =await dbContext.ForumPosts
                 .Select(fp => new ForumPostListViewModel() {
                     Id = fp.Id.ToString(),
                     Title = fp.Title,
                     Content = fp.Content
                 })
                 .ToArrayAsync();
            return allPosts;

        }
    }
}
