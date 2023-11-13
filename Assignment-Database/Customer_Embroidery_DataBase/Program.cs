using Customer_Embroidery_DataBase.Context;
using Customer_Embroidery_DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Customer_Embroidery_DataBase;

class Program
{
    static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => {

                services.AddDbContext<DataBase>(x => x.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DataBasTeknik\\Assignment-Database\\Customer_Embroidery_DataBase\\Contexts\\Database_Assignment_DatabasTeknik.mdf;Integrated Security=True;Connect Timeout=30"));
                services.AddScoped<AddressRepository>();
                services.AddScoped<CustomerRepository>();
                services.AddScoped<AdminRepository>();
                services.AddScoped<CategoryRepository>();
                services.AddScoped<InvoiceRepository>();
                services.AddScoped<InvoiceLineRepository>();
                services.AddScoped<OrderProductRepository>();
                services.AddScoped<ProductRepository>();
                services.AddScoped<OrderRepository>();
                services.AddScoped<SubCategoryRepository>();
                services.AddScoped<UserRepository>();
                services.AddScoped<CustomerTypeRepository>();

            
            })
            .Build();

        await host.RunAsync();
    }
}
