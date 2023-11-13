using Assignment.Contexts;
using Assignment.Repositories;
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

                })
                .Build();
            await host.RunAsync();
        }
    }
}