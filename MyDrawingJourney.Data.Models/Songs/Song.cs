using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDrawingJourney.Common.EntityValidationConstants.Song;
namespace MyDrawingJourney.Data.Models.Songs
{
    public class Song
    {
        public Song()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(GenreMaxLength)]        
        public string Genre { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]        
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(AuthorMaxLength)]
        public string Author { get; set; } = null!;

        [Required]        
        public DateTime CreatedOn { get; set; }

    }
}
