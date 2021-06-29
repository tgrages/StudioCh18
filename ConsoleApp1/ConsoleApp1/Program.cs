using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu TimeUpdate = new Menu();
            TimeUpdate.LastUpdated = "June 29, 2021";
            //Console.WriteLine("Menu Last Updated on " + TimeUpdate.LastUpdated);

            //Appetizers
            Menu AppTitle = new Menu("Appetizer");
            MenuItems AppItem1 = new MenuItems("Buffalo Wings", 5.99, 500, DateTime.Today);
            MenuItems AppItem2 = new MenuItems("Blooming Onion", 7.99, 800, DateTime.Today);
            AppTitle.AddMenuItem(AppItem1);
            AppTitle.AddMenuItem(AppItem2);

            Console.WriteLine("\n" + AppTitle.MenuName);
            AppTitle.PrintMenuItems();


            //Entrees
            Menu EntreesTitle = new Menu("Entrees");
            MenuItems EntreesItem1 = new MenuItems("Hamburgers", 12.99, 900, DateTime.Today);
            MenuItems EntreesItem2 = new MenuItems("Tacos", 9.99, 650, DateTime.Today);
            MenuItems EntreesItem3 = new MenuItems("Spaghetti", 15.99, 1000, DateTime.Today);
            EntreesTitle.AddMenuItem(EntreesItem1);
            EntreesTitle.AddMenuItem(EntreesItem2);
            EntreesTitle.AddMenuItem(EntreesItem3);

            //Console.WriteLine("\n" + EntreesTitle.MenuName);
            //EntreesTitle.PrintMenuItems();


            //Dessert
            Menu DessertTitle = new Menu("Dessert");
            MenuItems DessertItem1 = new MenuItems("Key Lime Pie", 7.99, 600, DateTime.Today);
            MenuItems DessertItem2 = new MenuItems("Ice Cream Sundae", 9.99, 700, DateTime.Today);
            MenuItems DessertItem3 = new MenuItems("Red Velvet Cake", 8.99, 500, DateTime.Today);
            DessertTitle.AddMenuItem(DessertItem1);
            DessertTitle.AddMenuItem(DessertItem2);
            DessertTitle.AddMenuItem(DessertItem3);

            //Console.WriteLine("\n" + DessertTitle.MenuName);
            //DessertTitle.PrintMenuItems();
        }
    }
}
