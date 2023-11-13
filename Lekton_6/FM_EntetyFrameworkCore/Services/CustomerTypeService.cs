using FM_EntetyFrameworkCore.Enteties;
using FM_EntetyFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFrameworkCore.Services;

internal class CustomerTypeService
{
    private readonly CustomerTypeRepository _customerTypeRepo;

    public CustomerTypeService(CustomerTypeRepository customerTypeRepo)
    {
        _customerTypeRepo = customerTypeRepo;
    }

    public async Task CreateCustomerTypeMenuAsync()
    {
        var customerTypeEntity = new CustomerTypeEntity();

        Console.Write("Enter Customer Type: ");
        customerTypeEntity.TypeName = Console.ReadLine()!;

        if (!await _customerTypeRepo.ExistsAsync(x => x.TypeName == customerTypeEntity.TypeName))
        {
            await _customerTypeRepo.CreateAsync(customerTypeEntity);
            Console.WriteLine($"Customer Type {customerTypeEntity.TypeName} was created.");
            
        }
        else
        {
            Console.WriteLine($"Customer Type {customerTypeEntity.TypeName} already exists.");
        }

        Console.ReadKey();
            
    }
}
