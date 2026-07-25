using EventEase;
using EventEase.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Services
builder.Services.AddScoped<EventService>();
builder.Services.AddScoped<RegistrationService>();
builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<AttendanceService>();

await builder.Build().RunAsync();
