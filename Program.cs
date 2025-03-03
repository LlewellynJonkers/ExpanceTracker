using Expance_Tracker.Data;
using Expance_Tracker.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Register MVC services

// Example: Registering a custom service (optional)
// builder.Services.AddTransient<IMyService, MyService>();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnectionString")))
    ;
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

// Configure the rest of your application services
builder.Services.AddAuthentication()
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";  // Custom login path
        options.LogoutPath = "/Account/Logout"; // Custom logout path
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Use custom error page in production
    app.UseHsts(); // Enable HTTP Strict Transport Security (HSTS)
}
else
{
    app.UseDeveloperExceptionPage(); // Show detailed errors in development
}


app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files (CSS, JS, images, etc.)

app.UseRouting(); // Enable routing

app.UseAuthorization(); // Enable authorization (if needed)

// Configure default route for MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Start the application