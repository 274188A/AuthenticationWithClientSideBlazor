using System.Threading.Tasks;
using AuthenticationWithClientSideBlazor.Client.Services;
using AuthenticationWithClientSideBlazor.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationWithClientSideBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddAuthorizationCore(config =>
            {
                config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
                config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
            });

            builder.Services.AddOptions();

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
