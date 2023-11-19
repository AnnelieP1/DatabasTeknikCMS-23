using Assignment.Contexts;
using Assignment.Menus;
using Assignment.Repositories;
using Assignment.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Assignment
{
    
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DataContext>(x => x.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gydan\\OneDrive\\Dokument\\Database.mdf;Integrated Security=True;Connect Timeout=30"));

                    services.AddScoped<CustomerRepository>();
                    services.AddScoped<AddressRepository>();
                    services.AddScoped<InvoiceRepository>();
                    services.AddScoped<OrderRepository>();
                    services.AddScoped<InvoiceLineRepository>();
                    services.AddScoped<OrderRowRepository>();
                    services.AddScoped<QuantityUnitRepository>();
                    services.AddScoped<ProductRepository>();
                    services.AddScoped<CategoryRepository>();
                    services.AddScoped<SubCategoryRepository>();

                    services.AddScoped<CustomerService>();
                    

                    services.AddScoped<CustomerMenu>();
                    services.AddScoped<MainMenu>();

                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
            }

           
            var mainMenu = host.Services.GetRequiredService<MainMenu>();
           
            await mainMenu.StartAsync();
           

            await host.RunAsync();
            
        }
    }
}

        