using System;
using System.Collections.Generic;
using System.Text;

namespace StudioRestaurantMenu
{
    public class MenuItem
    {
        private string Name;
        private double Price;
        private string Description;
        private string Category;
        private DateTime DateAdded = new DateTime();

        public MenuItem (string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            DateAdded = DateTime.Now;
        }
        public string name
        {
            get { return Name; }
        }

        public double price
        {
            get { return Price; }
        }

        public string description
        {
            get { return Description; }
        }

        public string category
        {
            get { return Category; }
        }

        public DateTime dateAdded
        {
            get { return DateAdded; }
        }
    }
}
