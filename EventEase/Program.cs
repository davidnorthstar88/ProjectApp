var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // if you still need APIs
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); // required for hosted WASM

var app = builder.Build();

app.UseBlazorFrameworkFiles();   // <-- critical
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html"); // <-- SPA routing

app.Run();
