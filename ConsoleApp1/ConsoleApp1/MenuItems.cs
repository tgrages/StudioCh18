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
        public DateTime InputDate = new DateTime();


        /*
        public void ItemName(string name)
        {
            _itemName.Add(name);
        } 

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Calories
        {
            get { return _calories; }
            set { _calories = value; }
        } */

        public void PrintDetails()
        {
            Console.WriteLine($"{this._itemName} is ${this._price} and has {this._calories} calories.");
            DateTime thisDay = DateTime.Today;

            //new variable representing how many days before and do math
            //create int variable (A) that determines days
            //conditional statement that compares (A) to thisDay.

            TimeSpan timeSpan = thisDay - new DateTime(1995, 12, 20);
            Console.WriteLine(timeSpan);
            //if (this.DateTime <= )
            //{
            //    Console.WriteLine($"{this._itemName} is a new item!");
            //}

        }

        
        public MenuItems(string name, double price, int cal, DateTime date)
        {
            this._itemName = name;
            this._price = price;
            this._calories = cal;
            this.InputDate = date;
        }







    }
}
