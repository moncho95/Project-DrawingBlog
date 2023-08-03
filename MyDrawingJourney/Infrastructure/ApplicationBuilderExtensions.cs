using Microsoft.AspNetCore.Identity;
using MyDrawingJourney.Data.Models;

namespace MyDrawingJourney.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public const string AdminRoleName = "Administrator";
        public const string AdminEmail = "admin@maill.com";
        public const string AdminPassword = "admin123";
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var services = scopedServices.ServiceProvider;
            UserManager<ApplicationUser> userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    //if (await roleManager.RoleExistsAsync(AdminRoleName))
                    //{
                    //    return;
                    //}
                    
                        var role = new IdentityRole{ Name = AdminRoleName };
                    await roleManager.CreateAsync(role);
                    var admin = await userManager.FindByNameAsync(AdminEmail);
                    if (admin == null)
                    {
                        var user = new ApplicationUser();
                        
                            user.Id = Guid.NewGuid().ToString();
                        user.Email = AdminEmail;
                        user.NormalizedEmail = AdminEmail;
                        user.UserName = AdminEmail;
                        user.NormalizedUserName = AdminEmail;
                        user.FirstName = "Great";
                        user.LastName = "Admin";
                        
                         await userManager.CreateAsync(user, AdminPassword);
                         await userManager.AddToRoleAsync(user, AdminRoleName);
                        
                    }
                    //await userManager.AddToRoleAsync(admin, AdminRoleName);
                })
                .GetAwaiter()
                .GetResult();
            return app;
        }
    }
}
