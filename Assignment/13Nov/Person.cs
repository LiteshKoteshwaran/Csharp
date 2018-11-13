using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class Person
    {
        public string PersonName, PersonContactNo;
        public int PersonID;

        public void EnterPersonDetails()
        {
            Console.WriteLine("ENTER THE PERSON NAME");
            PersonName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("ENTER THE PERSON CONTACT NUMBER");
            PersonName = Console.ReadLine();
            Console.WriteLine();
        }
        
        public void CreatePersonID()
        {
           PersonID= int.Parse(PersonContactNo.Substring(6,PersonContactNo.Length));
        }
    }
}
