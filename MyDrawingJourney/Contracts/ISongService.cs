using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface ISongService
    {
        Task DeleteByIdAsync(string id);
        Task<IEnumerable<MusicViewModel>> ListAllAsync();
        Task AddPostAsync(MusicAddViewModel postViewModel);
        
    }
}
