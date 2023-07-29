using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.ViewModels.Home
{
    public class MusicViewModel
    {
        public string Id { get; set; } = null!;
       
        public string Genre { get; set; } = null!;
        
        public string Name { get; set; } = null!;
        
        public string Author { get; set; } = null!;

        
        public DateTime CreatedOn { get; set; }
    }
}
