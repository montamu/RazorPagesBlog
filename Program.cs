using Microsoft.EntityFrameworkCore;
using RazorPagesBlog.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// dbコンテキスト設定
builder.Services.AddDbContext<RazorPagesBlogContext>(Options =>
    Options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesBlogContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesBlogContext' not found.")));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
