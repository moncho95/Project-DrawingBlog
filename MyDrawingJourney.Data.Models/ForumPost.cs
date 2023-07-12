using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDrawingJourney.Common.EntityValidationConstants.ForumPost;

namespace MyDrawingJourney.Data.Models
{
    public class ForumPost
    {
        public ForumPost()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
