using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_UrsulaSchuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Item I = new Item();

            Stack MyStack = new Stack();

            MyStack.Push(new Item("Italy", "Rome"));
            MyStack.Push(new Item("Munich", "Germany"));

            I = MyStack.Peek();

            Console.WriteLine(I.City);

            I = MyStack.Pop();

            Console.WriteLine(I.City);

            Console.ReadLine();


        }
    }
}
