using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDrawingJourney.Data.Configuration;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Data.Models.Comments;
using MyDrawingJourney.Data.Models.Paintings;
using MyDrawingJourney.Data.Models.Songs;


namespace MyDrawingJourney.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public const string AdminRoleName = "Administrator";
        public const string AdminEmail = "admin@mail.com";
        private ApplicationUser AdminUser { get; set; }
        private ApplicationUser GuestUser { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ForumPostEntityConfiguration());
            builder.ApplyConfiguration(new SongEntityConfiguration());
            builder.ApplyConfiguration(new PaintingEntityConfiguration());
            //builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

            base.OnModelCreating(builder);
            SeedUsers();
            builder.Entity<ApplicationUser>()
               .HasData(AdminUser, GuestUser);
            
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            AdminUser = new ApplicationUser()
            {
                Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                Email = AdminEmail,
                NormalizedEmail = AdminEmail,
                UserName = AdminEmail,
                NormalizedUserName = AdminEmail,
                FirstName = "Great",
                LastName = "Admin"
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "adminpass");

            GuestUser = new ApplicationUser()
            {
                Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e5",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                FirstName = "Teodor",
                LastName = "Lesly"
            };
            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest123");
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Song> Songs { get; set; }
    }

   
}