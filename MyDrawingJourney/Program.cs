using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Services;
using Microsoft.AspNetCore.SignalR;
using MyDrawingJourney.Hubs;
using MyDrawingJourney.Infrastructure;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("MyDrawingJourney")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//builder.Services.AddSignalR();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
//builder.Services.AddControllersWithViews(options=>
//{
//    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
//});
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddTransient<IEmailSender, SendMail>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddTransient<IPaintService, PaintService>();
builder.Services.AddTransient<ISongService, SongService>();
builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
    app.SeedAdmin();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



////adding roles
//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var roles = new[] { "Admin", "Manager", "User" };
//    foreach (var role in roles)
//    {
//        if (!await roleManager.RoleExistsAsync(role))
//            await roleManager.CreateAsync(new IdentityRole(role));

//    }
//}
//// Admin role
//using (var scope = app.Services.CreateScope())
//{
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

//    string email = "admin@localhost.email";
//    string password = "adminpass";

//    if (await userManager.FindByEmailAsync(email) == null)
//    {
//        var user = new IdentityUser();
//        user.UserName = email;
//        user.Email = email;
//        await userManager.CreateAsync(user, password);
//        await userManager.AddToRoleAsync(user, "Admin");
//    }

//}

app.UseHttpsRedirection();
//app.MapHub<ChatHub>("/chat");
app.UseStaticFiles();

app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapHub<ChatHub>("/chat");
//});
app.UseAuthentication();
app.UseAuthorization();

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Home}");
app.MapRazorPages();



app.Run();
