var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files from wwwroot
app.UseStaticFiles();

// Redirect the root URL to index.html
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
