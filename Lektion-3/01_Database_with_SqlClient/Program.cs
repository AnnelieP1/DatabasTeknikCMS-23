using _01_Database_with_SqlClient.Models;
using _01_Database_with_SqlClient.Services;

var product = new Product()
{
    Name = "Testar ny programmering",
    Description = "Svårt att lära nytt",
    Price = 900

};

var productService = new ProductService();
var productId = productService.Create(product);

foreach (var item in productService.GetAll())
    Console.WriteLine($"{item.Name}, {item.Description}, {item.Price} kr");

product.Id = (int)productId!;
product.Description = "Detta är Sql Programmering i databasteknik";
product.Price = 1000;
productService.Update(product);

Console.WriteLine(productId);
Console.ReadKey();
