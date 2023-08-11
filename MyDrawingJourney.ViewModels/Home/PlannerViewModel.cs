using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.ViewModels.Home
{
    public class PlannerViewModel
    {
        
        public string Id { get; set; } = null!;
       
        public string Content { get; set; } = null!;
    }
}
