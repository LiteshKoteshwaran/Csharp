using System;
using System.Collections.Generic;
using System.Text;

namespace _15Nov
{
    class Croc : IAnimals, ILivingBeing
    {
        public void Eat()
        {
            Console.WriteLine("I am Crocodile, i hunt and eat my food");
        }

        void IAnimals.HowManyLegsToWalk()
        {
            Console.WriteLine("I am Crocodile, i have four legs ");
        }

        void IAnimals.Hunt()
        {
            Console.WriteLine("I am Crocodile, i hunt");
        }

        void ILivingBeing.Sleep()
        {
            Console.WriteLine("I am Crocodile, i sleep with my eyes open");
        }

        void ILivingBeing.Walk()
        {
            Console.WriteLine("I am Crocodile, I walk with four of my legs");
        }
    }
}
