using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.ViewModels.Home
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The message is required")]
        public string Message { get; set; } = null!;
    }
}
