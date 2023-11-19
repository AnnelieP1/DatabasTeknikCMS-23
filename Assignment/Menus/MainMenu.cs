using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Menus;

internal class MainMenu
{
    private readonly CustomerMenu _customerMenu;

    public MainMenu(CustomerMenu customerMenu) 
    { 
        _customerMenu = customerMenu;
    
    }

    public async Task StartAsync()
    {
        
        do
        {
            Console.Clear();
            Console.WriteLine("HuvudMeny");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Skapa ny kund");
            Console.WriteLine("2. Visa alla kunder");
            Console.Write("Välj menyval 1 för att komma till skapa kund: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await _customerMenu.CreateAsync();
                    break;
                    case "2":
                    await _customerMenu.GetAllAsync();
                    break;
            }

        }
        while (true);
    }
}
