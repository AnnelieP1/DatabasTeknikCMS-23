using Aspose.Pdf;
using Assignment.Entities;
using Assignment.Menus;
using Assignment.Models;
using Assignment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services;

internal class CustomerService
{
    private readonly AddressRepository _addressRepository;
    private readonly CustomerRepository _customerRepository;

    public CustomerService(AddressRepository addressRepository, CustomerRepository customerRepository)
    {
        _addressRepository = addressRepository;
        _customerRepository = customerRepository;
    }

    public async Task<bool> CreateCustomerAsync(CustomerRegistrationForm form)
    {
        if (!await _customerRepository.ExistsAsync(x => x.Email == form.Email))
        {
            AddressEntity addressEntity = await _addressRepository.GetAsync(x => x.StreetName == form.StreetName && x.StreetNumber == form.StreetNumber && x.PostalCode == form.PostalCode);
            addressEntity = await _addressRepository.CreateAsync(new AddressEntity { StreetName = form.StreetName, StreetNumber = form.StreetNumber, PostalCode = form.PostalCode, City = form.City });
            if (addressEntity  == null) 
                return true;

            CustomerEntity customerEntity = await _customerRepository.CreateAsync(new CustomerEntity { FirstName = form.FirstName, LastName = form.LastName, Email = form.Email, Phonenumber = form.PhoneNumber, AddressId = addressEntity.Id });
            if (customerEntity != null)
                return true;


        }
        return false;

    }


    public async Task<IEnumerable<CustomerEntity>> GetAllAsync()
    {
        var customers = await _customerRepository.GetAllAsync();
        return customers;

    }

}


