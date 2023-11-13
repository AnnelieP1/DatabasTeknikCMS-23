using FM_EntetyFramework.Context;
using FM_EntetyFramework.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FM_EntetyFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DataContext>(x => x.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DataBasTeknik\\Lektion-5\\FM_EntetyFramework\\database.mdf;Integrated Security=True;Connect Timeout=30"));
                    services.AddScoped<CategoryService>();
                    services.AddScoped<ProductService>();
                    services.AddScoped<MenuService>();
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var menuService = services.GetRequiredService<MenuService>();

                await menuService.AddProduct();
                await menuService.ListAllProducts();
            }

            await host.RunAsync();

            
        }
    }
}
