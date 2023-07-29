using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDrawingJourney.Common.EntityValidationConstants.Song;
namespace MyDrawingJourney.ViewModels.Home
{
    public class MusicAddViewModel
    {
        [Required]
        [StringLength(GenreMaxLength, MinimumLength = GenreMinLength)]
        [RegularExpression(RegEx)]
        public string Genre { get; set; } = null!;
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        [RegularExpression(RegEx)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        [RegularExpression(RegEx)]
        public string Author { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
