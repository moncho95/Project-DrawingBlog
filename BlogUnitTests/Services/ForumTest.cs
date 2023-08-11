using Microsoft.EntityFrameworkCore;

using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Services;
using MyDrawingJourney.ViewModels.Home;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUnitTests
{
    [TestFixture]
    public class ForumTest
    {
        private ApplicationDbContext context;
        //private IPostService service;

        [SetUp]
        public void SetUp()
        {
            
            List<ForumPost> posts = new List<ForumPost>()
            {
                new ForumPost { Title = "Lorem ipsum", Content = "some content" },
                new ForumPost { Title = "Lorem ipsum dol", Content = "some content too" }

            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "ApplicationInMemoryDb")
                .Options;
            this.context = new ApplicationDbContext(options);
            this.context.AddRange(posts);
            this.context.SaveChanges();
        }
        [Test]
        public void Forum_Test_Get_All()
        {
            IPostService service = new PostService(context);
            var list = service.ListAllAsync();

            Assert.True(list != null);
           

        } 
        [Test]
        public async Task Forum_Test_AddsaPost()
        {
            IPostService service = new PostService(context);
            var post = new ForumPostAddFormModel()
            {
                Title = "Lorem ipsum dolorem ipsum",
                Content = "some content bla bla bla"
            };

            await service.AddPostAsync(post);
            
            Assert.That( await context.ForumPosts.CountAsync(), Is.EqualTo(3));
            Assert.That( await context.ForumPosts.AnyAsync(x => x.Title == "Lorem ipsum dolorem ipsum"));
        }

        [Test] 
        public async Task Forum_Test_Edits()
        {
            IPostService service = new PostService(context);
            var edited = new ForumPostAddFormModel()
            {
                Title = "Lorem ipsum dolorem",
                Content = "some content bla bla bla"
            };

            Guid id =  context.ForumPosts.FirstOrDefault(x => x.Title == "Lorem ipsum dol").Id;
            await service.EditByIdAsync(id.ToString(), edited);
            var editedPost =  context.ForumPosts.FirstOrDefault(x => x.Id == id);
            Assert.AreEqual(editedPost.Title, "Lorem ipsum dolorem");
            Assert.AreEqual(editedPost.Content, "some content bla bla bla");
        }

        [Test]
        public async Task Forum_Test_DeleteById()
        {
            IPostService service = new PostService(context);
            Guid id =  context.ForumPosts.FirstOrDefault(x => x.Title == "Lorem ipsum").Id;
            await service.DeleteByIdAsync(id.ToString());
           
            Assert.That(await context.ForumPosts.CountAsync(),Is.EqualTo(1));
            

        }
    }
}
