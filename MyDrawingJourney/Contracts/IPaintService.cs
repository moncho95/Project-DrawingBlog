using MyDrawingJourney.Data.Models.Paintings;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface IPaintService
    {
        Task<IEnumerable<FamousPaintingViewModel>> ListAllAsync();
        Task AddPostAsync(FamousPaintingAddViewModel postViewModel);
        Task DeleteByIdAsync(string id);
        Task<FamousPaintingViewModel> SearchbyNameAsync(string name);
        Task<IEnumerable<FamousPaintingViewModel>> SortAllAsync(int op);
    }
}
