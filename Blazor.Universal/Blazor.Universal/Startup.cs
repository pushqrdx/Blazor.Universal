using System;
using System.Threading.Tasks;
using Blazor.Universal.Services;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Universal
{
    public class Startup
    {
        public static event Action BlazorInitialized;

        public static void Main()
        {
            BlazorInitialized?.Invoke();
        }

        public void ConfigureServices(IServiceCollection _) => _.AddSingleton<WeatherForecastService>();

        public void Configure(IBlazorApplicationBuilder _) => _.AddComponent(typeof(Home), "app");
    }
}
