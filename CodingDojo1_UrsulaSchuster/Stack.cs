using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_UrsulaSchuster
{
    class Stack
    {
        private Node Top;

        public void Push(Item i)
        {
            Node Temp = new Node();
            Temp.Data = i;

            Temp.Next = Top;

            Top = Temp;
        }

        public Item Pop()
        {
            if (Top == null) return null;
            Node Popped = Top;

            Top = Top.Next;

            Popped.Next = null;

            return Popped.Data;
        }

        public Item Peek()
        {
            return Top.Data;
        }
    }
}
