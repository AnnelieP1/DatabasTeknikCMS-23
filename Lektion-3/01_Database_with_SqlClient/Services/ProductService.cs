using _01_Database_with_SqlClient.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Database_with_SqlClient.Services;

internal class ProductService
{
    private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-3\01_Database_with_SqlClient\local_database.mdf;Integrated Security=True;Connect Timeout=30";
    // Create
    // Vill Få ett värde tillbaka i form av ett int. 
    public int? Create(Product product) 
    {
        

        try
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("IF NOT EXISTS (SELECT Id FROM Products WHERE Name= @Name) INSERT INTO Products OUTPUT INSERTED.Id VALUES (@Name, @Description, @Price) ELSE SELECT Id FROM Products WHERE Name = @Name", conn);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Price", product.Price);

            conn.Open();

            var result = (int)cmd.ExecuteScalar();
            return result;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return null!;

        // cmd.ExecuteNonQuery(); sparar ner utan att få något svar tillbaka.
        //  cmd.ExecuteScalar(); Skicka förfrågan vill ha tillbaka 1 värde. 
        //  cmd.ExecuteReader(); Skicka förfrågan och vill ha tillbaka flera värden. 

    }

    // Read

    public IEnumerable<Product> GetAll()
    {
        var pruducts = new List<Product>();
        try
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("SELECT * FROM Products", conn);

            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var product = new Product()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.GetString(2),
                        Price = reader.GetDecimal(3)
                    };

                    pruducts.Add(product);
                }
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message) ; }

        return pruducts;
    }

    // Update

    public void Update(Product product)
    {
        try
        {
            using var conn =new SqlConnection(connectionString);
            using var cmd = new SqlCommand("UPDATE Products SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", product.Id);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Price", product.Price);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex){ Debug.WriteLine(ex.Message); }
    }

    // Delete
}
