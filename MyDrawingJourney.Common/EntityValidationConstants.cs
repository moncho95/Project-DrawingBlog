using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Common
{
    public static class EntityValidationConstants
    {
        public static class ForumPost
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int ContentMinLength = 30;
            public const int ContentMaxLength = 1500;


        }
    }
}
