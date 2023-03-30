using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

Console.WriteLine(builder.Configuration["WhosTheBest"]);

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


app.UseAuthorization();


app.MapControllerRoute(
    name: "user",
    pattern: "User/{action=Index}",
    defaults : new {Controller = "User"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
