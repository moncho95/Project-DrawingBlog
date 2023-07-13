using System.ComponentModel.DataAnnotations;

using static MyDrawingJourney.Common.EntityValidationConstants.ForumPost;

namespace MyDrawingJourney.ViewModels.Home
{
    public class ForumPostAddFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength =TitleMinLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(ContentMaxLength, MinimumLength =ContentMinLength)]
        public string Content { get; set; } = null!;

        
    }
}
