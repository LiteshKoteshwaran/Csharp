using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Nov_Practice
{
    //static class Program : Men//static class Program cant derive from type Men coz static class can derive from obj
    class Program : Men
    {
        static void Main(string[] args)
        {
            Men men = new Men();
            men.CanDoSomeWork();
            men.Dance();
            manin();//no need of obj reference this is a static method in base class(class Men)
        }
    }
}
