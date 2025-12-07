using Grp19OnlineBookStorePE03.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Grp19OnlineBookStorePE03.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<Grp19OnlineBookStorePE03Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Grp19OnlineBookStorePE03Context") ?? throw new InvalidOperationException("Connection string 'Grp19OnlineBookStorePE03Context' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
