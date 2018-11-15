using System;
using System.Collections.Generic;
using System.Text;

namespace _15Nov
{
    class Person:IHumans, ILivingBeing
    {
        void IHumans.Love()
        {
            Console.WriteLine("I am human and i love ");
        }
        void IHumans.PlaySport()
        {
            Console.WriteLine("i am human and i play sport");
        }
        void ILivingBeing.Eat()
        {
            Console.WriteLine("I am human, i eat with my hands");
        }
        void ILivingBeing.Sleep()
        {
            Console.WriteLine("I am human, i sleep with my eyes closed");
        }
        void ILivingBeing.Walk()
        {
            Console.WriteLine("I am Human, i have two legs to walk");
        }
        public void PersonPet()
        {
            Croc croc = new Croc();
            croc.Eat();
            

        }
    }
}
