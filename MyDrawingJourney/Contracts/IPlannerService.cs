using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Contracts
{
    public interface IPlannerService
    {
        Task<IEnumerable<PlannerViewModel>> ListAllAsync();
        Task AddPostAsync(PlannerAddViewModel postViewModel);
        Task DeleteByIdAsync(string id);
    }
}
