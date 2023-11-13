using Project.Models;
using Project.Services;

var userService = new UserService();
var user = new User() { 
    Address = new Address() 
};

Console.Write("Ange Förnamn: ");
user.FirstName = Console.ReadLine()!;

Console.Write("Ange Efternamn: ");
user.LastName = Console.ReadLine()!;

Console.Write("Ange E- postadress: ");
user.Email = Console.ReadLine()!;

Console.Write("Ange gatunamn: ");
user.Address.StreetName = Console.ReadLine()!;

Console.Write("Ange postnummer: ");
user.Address.postalCode = Console.ReadLine()!;

Console.Write("Ange Ort/Stad: ");
user.Address.City = Console.ReadLine()!;

var result = userService.CreateUser(user);

if (result)
    Console.WriteLine("Användaren Skapades");
else
    Console.WriteLine("Något gick fel");
Console.ReadKey();







