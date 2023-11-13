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

internal class AddressService
{
    private readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-3\01_Database_with_SqlClient\local_database.mdf;Integrated Security=True;Connect Timeout=30";

    public int CreateAddress(Address address)
    {
        try
        {
            using var conn = new SqlConnection(connectionstring);
            var result = conn.ExecuteScalar<int>("IF NOT EXISTS (SELECT Id FROM Addresses WHERE StreetName = @StreetName AND PostalCode = @PostalCode) INSERT INTO Addresses OUTPUT INSERTED.Id VALUES (@StreetName, @PostalCode, @City) ELSE SELECT Id FROM Addresses WHERE StreetName = @StreetName And PostalCode = @PostalCode", address);
            return result;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return 0;
       
    }
}
