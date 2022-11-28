using MCV.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

builder.Services.AddDbContext<AppDbContext>(options=> 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "numbergame",
    pattern: "numbergame",
    defaults: new { controller = "NumberGame", action = "NumberGame" });
app.MapControllerRoute(
    name: "fevercheck",
    pattern: "fevercheck",
    defaults: new { controller = "Doctor", action = "CheckAge" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
