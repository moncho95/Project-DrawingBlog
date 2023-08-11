using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models.Paintings;
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
    public class PaintingTest
    {
        private ApplicationDbContext context;

        [SetUp]
        public void SetUp()
        {

            List<Painting> paints = new List<Painting>()
            {
                new Painting { Name = "Some name" , Description ="some description" , ImageUrl = "https://i.pinimg.com/originals/b2/8a/97/b28a979d0b187588ccf98bfe1ba7b892.jpg"},
                new Painting {Name = "name" , Description ="description" , ImageUrl = "https://i.pinimg.com/originals/b2/8a/97/b28a979d0b187588ccf98bfe1ba7b892.jpg" }

            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "PaintingInMemoryDb")
                .Options;
            this.context = new ApplicationDbContext(options);
            this.context.AddRange(paints);
            this.context.SaveChanges();
        }
        [Test]
        public void Painting_Test_Get_All()
        {
            IPaintService service = new PaintService(context);
            var list = service.ListAllAsync();

            Assert.True(list != null);


        }
        [Test]

        public async Task Paint_Test_AddsPainting()
        {
            IPaintService service = new PaintService(context);
            var paintmodel = new FamousPaintingAddViewModel()
            {
                Name = "some name of a painting",
                Description = "some description of a painting",
                ImageUrl = "https://i.pinimg.com/originals/b2/8a/97/b28a979d0b187588ccf98bfe1ba7b892.jpg"
            };
            await service.AddPostAsync(paintmodel);

            Assert.That(await context.Paintings.CountAsync(), Is.EqualTo(3));
            Assert.That(await context.Paintings.AnyAsync(x => x.Name == "some name of a painting"));
        }
        [Test]
        public async Task Paint_Test_DeleteById()
        {
            IPaintService service = new PaintService(context);
            Guid id = context.Paintings.FirstOrDefault(x => x.Name == "Some name").Id;
            await service.DeleteByIdAsync(id.ToString());

            Assert.That(await context.Paintings.CountAsync(), Is.EqualTo(1));


        }
        [Test]
        public async Task Paint_Test_SearchesByName()
        {
            IPaintService service = new PaintService(context);
            var paintName = context.Paintings.FirstOrDefault(x => x.Name == "Some name").Name;
            var result = await service.SearchbyNameAsync(paintName);

            Assert.True(result != null);
        }
    }
}
