using Customer_Embroidery_DataBase.Enteties;
using Customer_Embroidery_DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Services;

internal class CustomerService
{
    private readonly CustomerRepository _customerRepo;

    public CustomerService(CustomerRepository customerRepo)
    {
        _customerRepo = customerRepo;
    }

    public async Task CreateCustomerMenuAsync()
    {
        var customerEntity = new CustomerEntity();
        Console.Write("Välj ett av följande alternativ: ");
        Console.Write("_________________________________");
        Console.Write("1. Skapa ny kund: ");
        Console.Write("2. Hitta existerande kund: ");
        Console.Write("");
        Console.ReadKey();
    }
}
