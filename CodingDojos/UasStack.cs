using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojos
{
    class UasStack<T>
    {
        
        StackItem<T> latestItem;

        public void Push(T item)
        {
            if (latestItem != null)
            {
                StackItem< T> transit = new StackItem<T>() { Data = item, Pointer = latestItem };
                latestItem = transit;
            }
        }

        public T Pop()
        {
            if (latestItem != null)
            {
                StackItem<T> toPop = latestItem;
                latestItem = latestItem.Pointer;
            }

        }

        public T Peek()
        {
            if (latestItem != null)
            {
                return latestItem.Data;
            }
            else
            {
                return default(T);
            }
        }
    }


}
