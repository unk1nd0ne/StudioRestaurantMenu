using System;
using System.Collections.Generic;
using System.Text;

namespace StudioRestaurantMenu
{
    class RestaurantMenu
    {
        //bool running = true;

        public static void DisplayMenu()
        {
            Menu menu1 = new Menu();
            menu1.AddItem(new MenuItem("Fries", 1.99, "From Idaho", "appetizers"));
            menu1.AddItem(new MenuItem("Cheese Curds", 1.89, "From Wisconsin", "appetizers"));
            menu1.AddItem(new MenuItem("Fish", 2.99, "Cold Fish", "main"));
            menu1.AddItem(new MenuItem("Beef", 3.89, "It's what's for dinner", "main"));
            menu1.AddItem(new MenuItem("Ice Cream", 3.99, "It's Cold", "deserts"));
            menu1.AddItem(new MenuItem("Pie", 4.89, "It's got fruit in it", "deserts"));
            string isNew;

            Console.WriteLine("Our Menu");
            Console.WriteLine($"Updated: {menu1.updated}");
            Console.WriteLine("Appetisers\n");
            foreach (string key in menu1.appetizers.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu1.appetizers[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu1.appetizers[key].name} \t {isNew} \t\t\t\t {menu1.appetizers[key].price} \n {menu1.appetizers[key].description}");
                Console.WriteLine("*****\n");
            }
            Console.WriteLine("Main Courses\n");
            foreach (string key in menu1.entrees.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu1.entrees[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu1.entrees[key].name} \t {isNew} \t\t\t\t {menu1.entrees[key].price} \n {menu1.entrees[key].description}");
                Console.WriteLine("*****\n");
            }
            Console.WriteLine("Deserts\n");
            foreach (string key in menu1.deserts.Keys)
            {
                Console.WriteLine("*****");
                isNew = (DateTime.Now - menu1.deserts[key].dateAdded).TotalDays < 14 ? "**NEW**" : "";
                Console.WriteLine($"{menu1.deserts[key].name} \t {isNew} \t\t\t\t {menu1.deserts[key].price} \n {menu1.deserts[key].description}");
                Console.WriteLine("*****\n");
            }
        }

        


    }
}
