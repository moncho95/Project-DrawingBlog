using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Configuration
{
    public class ForumPostEntityConfiguration : IEntityTypeConfiguration<ForumPost>
    {
        private readonly PostSeeder postSeeder;
        public ForumPostEntityConfiguration()
        {
            this.postSeeder = new PostSeeder();

        }
        public void Configure(EntityTypeBuilder<ForumPost> builder)
        {

            builder.HasData(this.postSeeder.GeneratePosts().ToArray());
            
        }
    }
}
