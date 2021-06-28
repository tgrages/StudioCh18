using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItems Hamburger = new MenuItems();
            Hamburger.AddItem(7.50, "Hamburger");
            Hamburger.print();

            Hamburger.AddTopping("lettuce");
        }
    }
}
