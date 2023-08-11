using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.ViewModels.Home
{
    public class PlannerAddViewModel
    {

        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Content { get; set; } = null!;
    }
}
