using GEMS;
using GEMS.Models;
using GEMS.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ProfilePictureService>();
builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped<FunctionalityGroupService>();
builder.Services.AddScoped<UserRolesService>();
builder.Services.AddScoped<IVaultService, VaultService>();
builder.Services.AddScoped<NotificationService>();


await builder.Build().RunAsync();
