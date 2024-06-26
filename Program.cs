using Microsoft.EntityFrameworkCore;
using Ocean.Components;
using Ocean.Data;
using Ocean.Data.Login;
using Ocean.Services;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new NullReferenceException("No connection string in config");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<DataContext>((DbContextOptionsBuilder options) => options.UseSqlServer(connection));
builder.Services.AddTransient<OceanService>();
builder.Services.AddSingleton<LogedInUser>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
