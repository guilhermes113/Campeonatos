using Microsoft.EntityFrameworkCore;
using Campeonatos.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Camp>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Camp")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Camp>();
builder.Services.AddRazorPages();

var app = builder.Build();

/*
void configureservices(iservicecollection services, iconfiguration configuration)
{
    services.adddbcontext<campdbcontext>(options =>
        options.usesqlserver(configuration.getconnectionstring("sqlserver")));

    services.addcontrollerswithviews();
}
*/


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
