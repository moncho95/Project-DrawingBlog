﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDrawingJourney.Common.EntityValidationConstants.ForumPost;
namespace MyDrawingJourney.ViewModels.Home
{
    public class ForumPostAddFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength =TitleMinLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(ContentMaxLength, MinimumLength =ContentMinLength)]
        public string Content { get; set; } = null!;

        
    }
}