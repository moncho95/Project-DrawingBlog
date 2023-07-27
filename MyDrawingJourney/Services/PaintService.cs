using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models.Paintings;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Services
{
    public class PaintService : IPaintService
    {
        private readonly ApplicationDbContext dbContext;

        public PaintService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<FamousPaintingViewModel>> ListAllAsync()
        {

            IEnumerable<FamousPaintingViewModel> allPosts = await dbContext.Paintings
                 .Select(fp => new FamousPaintingViewModel()
                 {
                     Id = fp.Id.ToString(),
                     Name = fp.Name,
                     Description = fp.Description,
                     ImageUrl = fp.ImageUrl
                 })
                 .ToArrayAsync();
            return allPosts;
        }

        public async Task AddPostAsync(FamousPaintingAddViewModel postViewModel)
        {
            Painting newPost = new Painting()
            {
                Name = postViewModel.Name,
                Description = postViewModel.Description,
                ImageUrl = postViewModel.ImageUrl
            };
            await this.dbContext.Paintings.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(string id)
        {
            Painting postToDelete = await this.dbContext
                .Paintings
                .FirstAsync(p => p.Id.ToString() == id);

            this.dbContext.Paintings.Remove(postToDelete);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<FamousPaintingViewModel> SearchbyNameAsync(string name)
        {
            FamousPaintingViewModel model = await dbContext.Paintings
                .Select(fp => new FamousPaintingViewModel()
                {
                    Id = fp.Id.ToString(),
                    Name = fp.Name,
                    Description = fp.Description,
                    ImageUrl = fp.ImageUrl
                })
                .FirstAsync(p => p.Name == name);

            return model;
        }

        public async Task<IEnumerable<FamousPaintingViewModel>> SortAllAsync(int op)
        {
            IEnumerable<FamousPaintingViewModel> sortedPosts;
            if (op == 0)
            {
                sortedPosts = await dbContext.Paintings
                     .Select(fp => new FamousPaintingViewModel()
                     {
                         Id = fp.Id.ToString(),
                         Name = fp.Name,
                         Description = fp.Description,
                         ImageUrl = fp.ImageUrl
                     })
                     .ToArrayAsync();
                return sortedPosts.OrderByDescending(fp => fp.CreatedOn);

            }
            else
            {
                sortedPosts = await dbContext.Paintings
                     .Select(fp => new FamousPaintingViewModel()
                     {
                         Id = fp.Id.ToString(),
                         Name = fp.Name,
                         Description = fp.Description,
                         ImageUrl = fp.ImageUrl
                     })
                     .ToArrayAsync();

                return sortedPosts.OrderBy(fp => fp.CreatedOn);
            }
            
        }
    }
}
