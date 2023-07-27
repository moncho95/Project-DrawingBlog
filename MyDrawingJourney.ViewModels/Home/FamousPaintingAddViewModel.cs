using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDrawingJourney.Common.EntityValidationConstants.Painting;
namespace MyDrawingJourney.ViewModels.Home
{
    public class FamousPaintingAddViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DescriptionLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;
        [Required]
        [MaxLength(UrlLength)]
        public string ImageUrl { get; set; } = null!;
    }
}
