using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models.Songs;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Services
{
    public class SongService:ISongService
    {
        private readonly ApplicationDbContext dbContext;

        public SongService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<MusicAddViewModel>> ListAllAsync()
        {
            IEnumerable<MusicAddViewModel> allSongs = await dbContext.Songs
                 .Select(fp => new MusicAddViewModel()
                 {
                     Genre = fp.Genre,
                     Name = fp.Name,
                     Author = fp.Author,
                     CreatedOn = fp.CreatedOn
                 })
                 .ToArrayAsync();
            return allSongs;
        }

        public async Task AddPostAsync(MusicAddViewModel songViewModel)
        {
            Song newSong = new Song()
            {
                Genre = songViewModel.Genre,
                Name = songViewModel.Name,
                Author = songViewModel.Author,
                CreatedOn = songViewModel.CreatedOn
            };
            await this.dbContext.Songs.AddAsync(newSong);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(string id)
        {
            Song songToDelete = await this.dbContext
                .Songs
                .FirstAsync(p => p.Id.ToString() == id);

            this.dbContext.Songs.Remove(songToDelete);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
