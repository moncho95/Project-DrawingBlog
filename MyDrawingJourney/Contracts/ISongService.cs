using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface ISongService
    {
        Task<IEnumerable<MusicAddViewModel>> ListAllAsync();
        Task AddPostAsync(MusicAddViewModel postViewModel);
        Task DeleteByIdAsync(string id);
    }
}
