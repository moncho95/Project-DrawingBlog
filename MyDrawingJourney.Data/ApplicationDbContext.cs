using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDrawingJourney.Data.Configuration;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Data.Models.Comments;
using MyDrawingJourney.Data.Models.Paintings;

namespace MyDrawingJourney.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ForumPostEntityConfiguration());
            base.OnModelCreating(builder);
            //SeedRoles(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
            
        }
        //private static void SeedRoles(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityRole>().HasData(
        //        new IdentityRole()
        //        {
        //            Name = "Admin",
        //            ConcurrencyStamp = "1",
        //            NormalizedName = "Admin"
        //        },
        //        new IdentityRole()
        //        {
        //            Name = "User",
        //            ConcurrencyStamp = "2",
        //            NormalizedName = "User"
        //        }
        //        );
        //}
        public DbSet<Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Painting> Paintings { get; set; }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }
}