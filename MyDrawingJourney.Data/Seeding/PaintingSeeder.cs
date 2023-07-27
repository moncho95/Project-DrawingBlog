using MyDrawingJourney.Data.Models.Paintings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Seeding
{
    internal class PaintingSeeder
    {
        internal Painting[] GeneratePaintings()
        {
            ICollection<Painting> paintings = new HashSet<Painting>();

            Painting painting;

            painting = new Painting()
            {
                Name = "Mona Lisa",
                Description = "Leonardo Da Vinci's most nobulous work of art.Mona Lisa needs no introduction.",
                ImageUrl = "https://i.pinimg.com/736x/26/8a/2d/268a2d9ef975ca928909e912bb58dfd9.jpg"

            };
            paintings.Add(painting);


            painting = new Painting()
            {
                Name = "Starry Night",
                Description = "Van Gogue's most nobulous work of art.Mona Lisa needs no introduction.",
                ImageUrl = "https://i.pinimg.com/originals/e9/ac/63/e9ac631dbfb4f4608217bd86bd0b2a4e.jpg"

            };
            paintings.Add(painting);


            return paintings.ToArray();
        }
    }
}
