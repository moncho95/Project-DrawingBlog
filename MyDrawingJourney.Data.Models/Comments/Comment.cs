﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
