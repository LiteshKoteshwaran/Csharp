using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Nov_Practice
{
    interface IPerson:IHuman
    {
        void CanDoSomeWork();
        int Age { get; }
    }
}
