using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojos
{
    public class StackItem<T>
    {
        

        //Pointer
        internal object Pointer { get; set; }
        //Data
        internal T Data { get; set; }

        
       
    }
}
