// See https://aka.ms/new-console-template for more information
using _01_G_EntetyFrameWorkCore.Enteties;
using _01_G_EntetyFrameWorkCore.Services;

Console.WriteLine("");

/* Steg 1 
 
 * Installera NuGet Paket
 * Microsoft.EntetyFrameworkCore.sqlServer
 * Microsoft.EntetyFrameworkCore.Tools
 
Steg 2 Göra entiteter (Klasser/Modeller/Objekt/TAbeller)
        UserEntety                      = Tabell för att lagra användarinfo
        AddressEntity                   = Tabell för att lagra addressinfo
        RoleEntety                      = Tabell för att lagra användarroller

Steg 3 Skapa en databas och hämta connectionstring för den databasen
        g_database    Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-4\01_G_EntetyFrameWorkCore\Contexts\g_database.mdf;Integrated Security=True;Connect Timeout=30  

Steg 4 Skapa en Contaxt som ärver ifrån DbContext och lagt in våra entiteter
        DataContext             = en Context som hanterar kopplingen till databasen
 

Steg 5 Göra en Add-Migration för att kontrollera alla kopplingar (måste göras i Package Manager Console)
        Add-Migration"Ange ett lämpligt migreringsnamn, börja på stor bokstav"

Steg 6 Kontrollera att vår Migration stämmer, om den stämmer gör en Update-Database annars
        Remove- 

Update-Database                 = sparar och skapar alla tabeller i databasen. 

Steg 7 Skapa en Service som ska hantera CRUD till och från databasen
        UserService         = hanterar CRUD för användare
        AddressService      = hanterar CRUD för Addresser
        RoleService         = hanterar CRUD för roller

Steg 8 Testa programmet!

 */

var userEntity = new UserEntety
{
    FirstName = "Annelie",
    LastName = "Pettersson",
    Email = "annelie@domain.com",
    Password = "BytMig123!",

    Address = new AddressEntety
    {
        StreetName = "Rimbo Skolväg",
        PostalCode = "12345",
        City = "Rimbo"
    },

    Role = new RoleEntety
    {
        RoleName = "Administratör"
    }
};

var userService = new UserService();
var user = await userService.CreateAsync(userEntity);

Console.WriteLine($"UserId: {user.Id}");
Console.WriteLine($"Name: {user.FirstName} {user.LastName}");
Console.ReadKey();


