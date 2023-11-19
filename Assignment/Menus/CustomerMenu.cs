using Aspose.Pdf;
using Assignment.Entities;
using Assignment.Models;
using Assignment.Repositories;
using Assignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Menus
{
    internal class CustomerMenu
    {
        private readonly CustomerService _customerService;
       
        public CustomerMenu(CustomerService customerService)
        {
            _customerService = customerService;
            
        }

        public async Task CreateCustomersAsync() 
        {
            Console.Clear();
            Console.WriteLine("Hantera Kunder");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Visa alla kunder");
            Console.WriteLine("2. Lägg till kunder");
            Console.Write("Välj ett av alternativen ovan: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1.":
                    await ListAllAsync();
                    break;

                case "2.":
                    await CreateAsync();
                    break;
            }
        }



        public async Task ListAllAsync()
        {
            Console.Clear();

            var customers = await _customerService.GetAllAsync();
            


            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Email} {customer.Phonenumber}");
                Console.WriteLine($"{customer.Address.StreetName} {customer.Address.StreetNumber} {customer.Address.PostalCode} {customer.Address.City}");
                Console.WriteLine("");
            }

            Console.ReadKey();

        }

        public async Task CreateAsync()
        {  
        
            var form = new CustomerRegistrationForm();

            Console.Clear();
            Console.Write("Ange förnamn: ");
            form.FirstName = Console.ReadLine()!;

            Console.Write("Ange efternamn: ");
            form.LastName = Console.ReadLine()!;

            Console.Write("Ange email: ");
            form.Email = Console.ReadLine()!;

            Console.Write("Ange telefonnummer: ");
            form.PhoneNumber = Console.ReadLine()!;

            Console.Write("Ange Gatunamn: ");
            form.StreetName = Console.ReadLine()!;

            Console.Write("Ange gatunummer: ");
            form.StreetNumber = Console.ReadLine()!;

            Console.Write("Postal Code (xxx xx): ");
            form.PostalCode = Console.ReadLine()!;

            Console.Write("City: ");
            form.City = Console.ReadLine()!;

            var result = await _customerService.CreateCustomerAsync(form);
            if (result)
                Console.WriteLine("Kunden skapades.");
            else
                Console.WriteLine("Kunde inte skapa kunden");
            

            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadLine();
            Console.Clear() ;
            
        }
        

        public async Task GetAllAsync()
        {
             await _customerService.GetAllAsync();
            
        }
        
    }
}
