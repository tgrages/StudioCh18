using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public List<MenuItems> listOfMenuItems = new List<MenuItems>();
        public string MenuName { get; set; }
        public string LastUpdated { get; set; }

        public Menu(string name)
        {
            this.MenuName = name;
        }
        public void AddMenuItem(MenuItems name)
        {
            this.listOfMenuItems.Add(name);
        }

        public void PrintMenuItems()
        {
            foreach (MenuItems name in this.listOfMenuItems)
            {
                name.PrintDetails();
            }
        }

        public void RemoveItem(MenuItems name)
        {
            this.listOfMenuItems.Remove(name);
        }


        public Menu()
        {
        }
    }
}
