using System;
using System.Collections.Generic;
using System.Text;

namespace StudioRestaurantMenu
{
    public class Menu
    {
        private Dictionary<string, MenuItem> Appetizers = new Dictionary<string, MenuItem>();
        private Dictionary<string, MenuItem> Entrees = new Dictionary<string, MenuItem>();
        private Dictionary<string, MenuItem> Deserts = new Dictionary<string, MenuItem>();
        private DateTime Updated = new DateTime();

        public Menu()
        {
            Updated = DateTime.Now;
        }

        public Dictionary<string, MenuItem> appetizers
        {
            get { return Appetizers; }
            
        }

        public Dictionary<string, MenuItem> entrees
        {
            get { return Entrees; }
        }

        public Dictionary<string, MenuItem> deserts
        {
            get { return Deserts; }
        }
        public DateTime updated
        {
            get { return Updated; }
        }

        public void AddItem(MenuItem dish)
        {
            if (dish.category == "appetizers")
            {
                Appetizers.Add(dish.name, dish);
            }
            else if (dish.category == "main")
            {
                Entrees.Add(dish.name, dish);
            }
            else
            {
                Deserts.Add(dish.name, dish);
            }
            Updated = DateTime.Now;
        }

        public void RemItem(MenuItem dish)
        {
            if (dish.category == "appetizers")
            {
                Appetizers.Remove(dish.name);
            }
            else if (dish.category == "main")
            {
                Entrees.Remove(dish.name);
            }
            else
            {
                Deserts.Remove(dish.name);
            }
            Updated = DateTime.Now;
        }

    }
}
