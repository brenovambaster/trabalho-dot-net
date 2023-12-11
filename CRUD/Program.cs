
using Microsoft.EntityFrameworkCore;
using CRUD.Data;
using CRUD.Shared;
using CRUD.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProdutoServices>();
builder.Services.AddScoped<VeiculoService>();
builder.Services.AddSingleton<StateContainer>();

builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddSingleton<UserAccountService>();

builder.Services.AddDbContext<ProdutoDbContext>(options =>
{
    options.UseSqlite("Data Source=Produtos.db");
});


builder.Services.AddDbContext<VeiculoDbContext>
(options =>
{
    options.UseSqlite("Data Source=Veiculo.db");
});


var app = builder.Build();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
