using MyDrawingJourney.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Seeding
{
    internal class PostSeeder
    {
         internal ForumPost[] GeneratePosts()
        {
            ICollection<ForumPost> posts = new HashSet<ForumPost>();
            ForumPost currentPost;

            currentPost = new ForumPost()
            {
                Title = "Drawing with watercolor",
                Content = "Drawing with watercolor has its challengeses, but there is nothing more pleasent..."

            };
            posts.Add(currentPost);
            currentPost = new ForumPost()
            {
                Title = "Drawing with gouache",
                Content = "Drawing with gouache is best suited for illustration work..."

            };
            posts.Add(currentPost);
            currentPost = new ForumPost()
            {
                Title = "Drawing with oil",
                Content = "Drawing with oil is so difficult..."

            };
            posts.Add(currentPost);
            return posts.ToArray();
        }
    }
}
