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

        public async Task EditByIdAsync(string id, ForumPostAddFormModel postEditedModel)
        {
            ForumPost postToEdit = await this.dbContext.ForumPosts.FirstAsync(fp => fp.Id.ToString().ToLower() == id.ToLower());

            postToEdit.Title = postEditedModel.Title;
            postToEdit.Content = postEditedModel.Content;

            await this.dbContext.SaveChangesAsync();

        }

        public async Task<ForumPostAddFormModel> GetForEditByIdAsync(string id)
        {
            ForumPost formModel = await this.dbContext
                .ForumPosts
                .FirstAsync(fp => fp.Id.ToString() == id);
            
            return new ForumPostAddFormModel()
            {
                Title = formModel.Title,
                Content = formModel.Content
            };
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
        public async Task DeleteByIdAsync(string id)
        {
            ForumPost postToDelete = await this.dbContext
                .ForumPosts
                .FirstAsync(p => p.Id.ToString() == id);

            this.dbContext.ForumPosts.Remove(postToDelete);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
