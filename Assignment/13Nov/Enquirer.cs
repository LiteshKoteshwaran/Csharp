using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class Enquirer : Person
    {
        public void EntryEnquirerDetails()
        {
            Console.WriteLine("ENTER ENQUIRER DETAILS");
            EnterPersonDetails();
        }

        public void DisplayEnquirerDetails()
        {
            CreatePersonID();
            Console.WriteLine(PersonName + "\t\t\t" + PersonContactNo +"\t\t\t"+PersonID);
        }
    }
}
