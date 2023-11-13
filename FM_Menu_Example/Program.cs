using FM_Menu_Example.Menus;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

namespace FM_Menu_Example
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainMenu>();

            using var sp = services.BuildServiceProvider();
            var menu = sp.GetRequiredService<MainMenu>();

            await menu.ShowAsync();
        }
    }
}