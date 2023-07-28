using MyDrawingJourney.Data.Models.Songs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Seeding
{
    internal class SongSeeder
    {
        internal Song[] GenerateSongs()
        {
            ICollection<Song> songs = new HashSet<Song>();
            Song currentSong;

            currentSong = new Song()
            {
                Genre = "Rap",
                Name = "Fancy",
                Author = "Iggy Azalea",
                CreatedOn = DateTime.ParseExact("2010-01-03", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            };
            songs.Add(currentSong);

            currentSong = new Song()
            {
                Genre = "Pop",
                Name = "Smooth Criminal",
                Author = "Michael Jackson",
                CreatedOn = DateTime.ParseExact("2010-01-03", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            };
            songs.Add(currentSong);
            
            currentSong = new Song()
            {
                Genre = "Rock",
                Name = "Bohemian Rhapsody",
                Author = "Queen",
                CreatedOn = DateTime.ParseExact("2010-01-03", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            };
            songs.Add(currentSong);

            return songs.ToArray();
        }
    }
}
