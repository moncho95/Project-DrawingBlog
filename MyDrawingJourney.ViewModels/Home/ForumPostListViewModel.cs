

namespace MyDrawingJourney.ViewModels.Home
{
    public class ForumPostListViewModel
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
