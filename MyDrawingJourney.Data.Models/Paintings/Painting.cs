using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Models.Paintings
{
    using static Common.EntityValidationConstants.Painting;
    public class Painting
    {
        public Painting()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionLength)]
        public string Description { get; set; } = null!;
        [Required]
        [MaxLength(UrlLength)]
        public string ImageUrl { get; set; } = null!;
    }
}
