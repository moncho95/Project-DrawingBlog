using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;
using MyDrawingJourney.Data.Models;
using MyDrawingJourney.Services;
using Microsoft.AspNetCore.SignalR;
using MyDrawingJourney.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("MyDrawingJourney")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSignalR();

//builder.Services.AddDefaultIdentity<IdentityUser>()
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddDefaultIdentity<IdentityUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddTransient<IEmailSender, SendMail>();
builder.Services.AddScoped<IPostService, PostService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.MapHub<ChatHub>("/chat");
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
    pattern: "{controller=Blog}/{action=Index}");
app.MapRazorPages();

app.Run();
