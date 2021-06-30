using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MenuItems
    {
        public string _itemName;
        private double _price;
        private int _calories;
        public DateTime InputDate { get; set; }
        public int ItemAge;

        public int age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - InputDate;
                int days = timeSpan.Days;
                return this.ItemAge = days;
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{this._itemName} is ${this._price} and has {this._calories} calories.");

           if (this.ItemAge.Equals(this.InputDate))
           {
                Console.WriteLine($"{this._itemName} is a new item!");
           }
           else
            {
                Console.WriteLine($"{this._itemName} is an old item.");
            }

        }

        
        public MenuItems(string name, double price, int cal, DateTime time)
        {
            this._itemName = name;
            this._price = price;
            this._calories = cal;
            this.InputDate = time;
        }









    }
}
