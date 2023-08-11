using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Models
{
    public class Note
    {
        public Note()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Content { get; set; } = null!;
    }
}
