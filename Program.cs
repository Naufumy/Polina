var builder = WebApplication.CreateBuilder(args);

// Добавляем Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();      
app.UseAuthorization();

app.MapRazorPages();       

app.Run();
