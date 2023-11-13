using FM_EntetyFrameworkCore.Contexts;
using FM_EntetyFrameworkCore.Repositories;
using FM_EntetyFrameworkCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;
using System.Xml.Schema;

namespace FM_EntetyFrameworkCore
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-5\FM_EntetyFramework\database.mdf;Integrated Security=True;Connect Timeout=30"));
            services.AddScoped<CustomerRepository>();
            services.AddScoped<CustomerTypeRepository>();
            services.AddScoped<CustomerTypeService>();

            using (var sp = services.BuildServiceProvider())
            {
              var customerTypeService = sp.GetRequiredService<CustomerTypeService>();
              await customerTypeService!.CreateCustomerTypeMenuAsync();
            }
        }

    }
}