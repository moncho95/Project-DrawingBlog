using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface IPostService
    {
        Task<IEnumerable<ForumPostListViewModel>> ListAllAsync();
        Task AddPostAsync(ForumPostAddFormModel postViewModel);
    }
}
