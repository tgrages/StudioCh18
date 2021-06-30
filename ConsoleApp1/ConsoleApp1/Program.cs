using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select a category: \nAppetizers\nEntree\nDessert");
            string input = Console.ReadLine().ToLower();

            if (input == "appetizers")
            {
                Menu TimeUpdate = new Menu();
                TimeUpdate.LastUpdated = "June 29, 2021";
                Console.WriteLine("Menu Last Updated on " + TimeUpdate.LastUpdated);
                //may need to make this a method and field in one of classes
                DateTime inputDate = new DateTime(2021, 06, 20);

                //Appetizers
                Menu AppTitle = new Menu("Appetizer");
                MenuItems AppItem1 = new MenuItems("Buffalo Wings", 5.99, 500, inputDate);
                MenuItems AppItem2 = new MenuItems("Blooming Onion", 7.99, 800, inputDate);
                AppTitle.AddMenuItem(AppItem1);
                AppTitle.AddMenuItem(AppItem2);
                AppTitle.RemoveItem(AppItem1);


                Console.WriteLine("\n" + AppTitle.MenuName + "\n");
                AppTitle.PrintMenuItems();
            }
            else if (input == "entree")
            {
                Menu TimeUpdate = new Menu();
                TimeUpdate.LastUpdated = "June 29, 2021";
                Console.WriteLine("Menu Last Updated on " + TimeUpdate.LastUpdated);
                //may need to make this a method and field in one of classes
                DateTime inputDate = new DateTime(2021, 06, 20);

                Menu EntreesTitle = new Menu("Entrees");
                MenuItems EntreesItem1 = new MenuItems("Hamburgers", 12.99, 900, inputDate);
                MenuItems EntreesItem2 = new MenuItems("Tacos", 9.99, 650, inputDate);
                MenuItems EntreesItem3 = new MenuItems("Spaghetti", 15.99, 1000, inputDate);
                EntreesTitle.AddMenuItem(EntreesItem1);
                EntreesTitle.AddMenuItem(EntreesItem2);
                EntreesTitle.AddMenuItem(EntreesItem3);

                Console.WriteLine("\n" + EntreesTitle.MenuName + "\n");
                EntreesTitle.PrintMenuItems();

            }
            else if (input == "dessert")
            {
                Menu TimeUpdate = new Menu();
                TimeUpdate.LastUpdated = "June 29, 2021";
                Console.WriteLine("Menu Last Updated on " + TimeUpdate.LastUpdated);
                //may need to make this a method and field in one of classes
                DateTime inputDate = new DateTime(2021, 06, 20);

                //Dessert
                Menu DessertTitle = new Menu("Dessert");
                MenuItems DessertItem1 = new MenuItems("Key Lime Pie", 7.99, 600, inputDate);
                MenuItems DessertItem2 = new MenuItems("Ice Cream Sundae", 9.99, 700, inputDate);
                MenuItems DessertItem3 = new MenuItems("Red Velvet Cake", 8.99, 500, inputDate);
                DessertTitle.AddMenuItem(DessertItem1);
                DessertTitle.AddMenuItem(DessertItem2);
                DessertTitle.AddMenuItem(DessertItem3);

                Console.WriteLine("\n" + DessertTitle.MenuName + "\n");
                DessertTitle.PrintMenuItems();
            }


            /*

            Menu TimeUpdate = new Menu();
            TimeUpdate.LastUpdated = "June 29, 2021";
            Console.WriteLine("Menu Last Updated on " + TimeUpdate.LastUpdated);
            //may need to make this a method and field in one of classes
            DateTime inputDate = new DateTime(2021, 06, 20);

            //Appetizers
            Menu AppTitle = new Menu("Appetizer");
            MenuItems AppItem1 = new MenuItems("Buffalo Wings", 5.99, 500, inputDate);
            MenuItems AppItem2 = new MenuItems("Blooming Onion", 7.99, 800, inputDate);
            AppTitle.AddMenuItem(AppItem1);
            AppTitle.AddMenuItem(AppItem2);
            AppTitle.RemoveItem(AppItem1);

   
            Console.WriteLine("\n" + AppTitle.MenuName);
            AppTitle.PrintMenuItems();


            //Entrees
            Menu EntreesTitle = new Menu("Entrees");
            MenuItems EntreesItem1 = new MenuItems("Hamburgers", 12.99, 900, inputDate);
            MenuItems EntreesItem2 = new MenuItems("Tacos", 9.99, 650, inputDate);
            MenuItems EntreesItem3 = new MenuItems("Spaghetti", 15.99, 1000, inputDate);
            EntreesTitle.AddMenuItem(EntreesItem1);
            EntreesTitle.AddMenuItem(EntreesItem2);
            EntreesTitle.AddMenuItem(EntreesItem3);

           Console.WriteLine("\n" + EntreesTitle.MenuName);
           EntreesTitle.PrintMenuItems();


            //Dessert
            Menu DessertTitle = new Menu("Dessert");
            MenuItems DessertItem1 = new MenuItems("Key Lime Pie", 7.99, 600, inputDate);
            MenuItems DessertItem2 = new MenuItems("Ice Cream Sundae", 9.99, 700, inputDate);
            MenuItems DessertItem3 = new MenuItems("Red Velvet Cake", 8.99, 500, inputDate);
            DessertTitle.AddMenuItem(DessertItem1);
            DessertTitle.AddMenuItem(DessertItem2);
            DessertTitle.AddMenuItem(DessertItem3);

           Console.WriteLine("\n" + DessertTitle.MenuName);
           DessertTitle.PrintMenuItems();

                */


        }
    }
}
