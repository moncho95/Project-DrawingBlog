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

        public static class Painting
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 70;

            public const int DescriptionMinLength = 10;
            public const int DescriptionLength = 400; 
            
            public const int UrlLength = 2048;           

        }
    }
}
