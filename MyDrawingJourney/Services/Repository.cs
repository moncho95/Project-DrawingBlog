using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.ViewModels.Home;
using MyDrawingJourney.Data.Models;
using Post = MyDrawingJourney.Data.Models.Post;
using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Data.Models.Comments;

namespace MyDrawingJourney.Services
{
    public class Repository: IRepository
    {
        private ApplicationDbContext _dbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddPost(Post post)
        {
             _dbContext.Posts.Add(post);
        }

        public void AddSubComment(SubComment comment)
        {
            _dbContext.SubComments.Add(comment);
        }

        public List<Post> GetAllPosts()
        {
            return _dbContext.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return _dbContext.Posts
                .Include(p=>p.MainComments)
                .ThenInclude(mc=>mc.SubComments)
                .FirstOrDefault(p => p.Id == id);
        }

        public void RemovePost(int id)
        {
            _dbContext.Posts.Remove(GetPost(id));
        }

        public async Task<bool> SaveChangesAsync()
        {
           if(await _dbContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void UpdatePost(Post post)
        {
            _dbContext.Posts.Update(post);
        }
    }
}
