using System;
using System.Globalization;

namespace StudioRestaurantMenu
{
    class Restaurant
    {
        private static void Main()
        {
            
            Menu menu = new Menu();
            menu.AddItem(new MenuItem("Fries", 1.99, "From Idaho", "appetizers"));
            menu.AddItem(new MenuItem("Cheese Curds", 1.89, "From Wisconsin", "appetizers"));
            menu.AddItem(new MenuItem("Fish", 2.99, "Cold Fish", "main"));
            menu.AddItem(new MenuItem("Beef", 3.89, "It's what's for dinner", "main"));
            menu.AddItem(new MenuItem("Ice Cream", 3.99, "It's Cold", "deserts"));
            menu.AddItem(new MenuItem("Pie", 4.89, "It's got fruit in it", "deserts"));
            RestaurantMenu.PrintFullMenu(menu);

            RestaurantMenu.PrintSingleMenu(menu.entrees, "Fish");

            menu.RemItem(new MenuItem("Beef", 3.89, "It's what's for dinner", "main"));

            RestaurantMenu.PrintFullMenu(menu);

        }
    }
}
