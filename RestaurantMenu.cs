using System;
using System.Collections.Generic;
using System.Text;

namespace StudioRestaurantMenu
{
    class RestaurantMenu
    {
        private static string isNew;

        public static void PrintFullMenu(Menu menu)
        {
           

            Console.WriteLine("Our Menu");
            Console.WriteLine($"Updated: {menu.updated}");
            Console.WriteLine("Appetisers\n");
            foreach (string key in menu.appetizers.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu.appetizers[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu.appetizers[key].name} \t {isNew} \t\t\t\t {menu.appetizers[key].price} \n {menu.appetizers[key].description}");
                Console.WriteLine("*****\n");
            }
            Console.WriteLine("Main Courses\n");
            foreach (string key in menu.entrees.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu.entrees[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu.entrees[key].name} \t {isNew} \t\t\t\t {menu.entrees[key].price} \n {menu.entrees[key].description}");
                Console.WriteLine("*****\n");
            }
            Console.WriteLine("Deserts\n");
            foreach (string key in menu.deserts.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu.deserts[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu.deserts[key].name} \t {isNew} \t\t\t\t {menu.deserts[key].price} \n {menu.deserts[key].description}");
                Console.WriteLine("*****\n");
            }
        }

        public static void PrintSingleMenu (Dictionary<string, MenuItem> menuCat, string key)
        {
            Console.WriteLine("*****");
            isNew = (DateTime.Now - menuCat[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
            Console.WriteLine($"{menuCat[key].name} \t {isNew} \t\t\t\t {menuCat[key].price} \n {menuCat[key].description}");
            Console.WriteLine("*****\n");
        }

        


    }
}
