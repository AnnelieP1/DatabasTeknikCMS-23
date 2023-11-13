using Dapper;
using Microsoft.Data.SqlClient;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services;

internal class UserService
{
    private readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-3\01_Database_with_SqlClient\local_database.mdf;Integrated Security=True;Connect Timeout=30";
    public bool CreateUser(User user)
    {
        try
        {
            var addressService = new AddressService();
            var addressId = addressService.CreateAddress(user.Address);
            if (addressId > 0)
            {
                user.AddressId = addressId;

                using var conn = new SqlConnection(connectionstring);
                var result = conn.ExecuteScalar<int>("IF NOT EXISTS (SELECT Id FROM Users WHERE Email = @Email) INSERT INTO Users OUTPUT INSERTED.Id VALUES (@FirstName, @LastName, @Email, @AddressId)", user);
                return true;


            }
        }
        catch(Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

}
