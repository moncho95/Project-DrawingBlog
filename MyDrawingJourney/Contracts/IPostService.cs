
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface IPostService
    {
        Task<IEnumerable<ForumPostListViewModel>> ListAllAsync();

        Task AddPostAsync(ForumPostAddFormModel postViewModel);

        Task<ForumPostAddFormModel> GetForEditByIdAsync(string id);
        Task EditByIdAsync(string id, ForumPostAddFormModel postEditedModel);
        Task DeleteByIdAsync(string id);
        
    }
}
