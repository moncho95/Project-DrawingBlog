using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Data.Models.Comments;

namespace MyDrawingJourney.Contracts
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);
        void AddSubComment(SubComment comment);
        Task<bool> SaveChangesAsync();
    }
}
