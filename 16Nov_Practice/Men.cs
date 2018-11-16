using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Nov_Practice
{
    class Men : IPerson
    {
        public void CanDoSomeWork()
        {
            Console.WriteLine();
        }

        public void Dance()
        {
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine();
        }

        public void Sleep()
        {
            Console.WriteLine();
        }

        public static void manin()
        {
            Console.WriteLine();
        }

        public int Age { get; }

        public static string Name { get; }//static can't be overridden 

    }
}
