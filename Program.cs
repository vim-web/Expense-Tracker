using Expence_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DependencyInjection
builder.Services.AddDbContext<ApplicationDBcontext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("https://communitylicense.syncfusion.com/support/tickets/666169?sso=LoginwithSyncfusion202301030649318&_gl=1*ilz72u*_gcl_au*ODg4MzYwODYwLjE3MzQwODA1MTE.*_ga*MTUxOTA2NDQ1MC4xNzM0MDc3OTYx*_ga_41J4HFMX1J*MTczNDA3Nzk2MS4xLjEuMTczNDA4Mzc5Mi4wLjAuMA..");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
