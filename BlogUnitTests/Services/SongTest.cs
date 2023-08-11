using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models.Songs;
using MyDrawingJourney.Services;
using MyDrawingJourney.ViewModels.Home;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUnitTests.Services
{
    [TestFixture]
    public class SongTest
    {
        private ApplicationDbContext context;
        [SetUp]
        public void SetUp()
        {

            List<Song> songs = new List<Song>()
            {
                new Song { Name = "Some Name" , Genre ="Rap", Author = "Some author", CreatedOn = DateTime.Now},
                new Song { Name = "Name", Genre = "Pop", Author = "author", CreatedOn = DateTime.Now }

            };

            var options =  new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SongsInMemoryDb")
                .Options;
             this.context = new ApplicationDbContext(options);
             this.context.AddRange(songs);
             this.context.SaveChanges();
        }

        [Test]
        public async Task Song_Test_AddsaSong()
        {
            ISongService service = new SongService(context);

            var songmodel = new MusicAddViewModel() {
                Genre = "Classic",
                Name = "Sonata",
                Author = "Bethoven",
                CreatedOn = DateTime.Now
            };
            await service.AddPostAsync(songmodel);
            Assert.That(await context.Songs.CountAsync(), Is.EqualTo(3));
            Assert.That(await context.Songs.AnyAsync(x => x.Name == "Sonata"));
        }

        [Test]
        public async Task Song_Test_DeleteById()
        {
            ISongService service = new SongService(context);
            Guid id = context.Songs.FirstOrDefault(x => x.Name == "Name").Id;
            await service.DeleteByIdAsync(id.ToString());

            Assert.That(await context.Songs.CountAsync(), Is.EqualTo(1));


        }

    }
}
