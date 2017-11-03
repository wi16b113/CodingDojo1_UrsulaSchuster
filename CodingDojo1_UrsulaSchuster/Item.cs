using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_UrsulaSchuster
{
    class Item
    {
        public string Country { get; set; }
        public string City { get; set; }

        public Item(string Country, string City)
        {
            this.City = Country;
            this.City = City;
        }

        public Item()
        {
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Country, City);
        }




        //MyStack.Push(new Item("Italy", "Rome"));
        // MyStack.Push(new Item("Munich", "Germany"));
    }
}
