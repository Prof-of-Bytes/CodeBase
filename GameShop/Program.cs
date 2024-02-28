using GameShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GameStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameStoreContext")));
builder.Services.AddDbContext<GameStoreIdentityContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameStoreIdentityContext")));
builder.Services.AddIdentity<GameShopUser, IdentityRole>().AddEntityFrameworkStores<GameStoreContext>().AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "paging_sorting",
    pattern: "{controller}/{action}/page-{PageNumber}/page-size-{PageSize}/{SortDirection}/sorted-on-{SortField}");

app.MapControllerRoute(
    name: "game_details",
    pattern: "{controller=Games}/{action=Detials}/{id?}/{slug?}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");



app.Run();
